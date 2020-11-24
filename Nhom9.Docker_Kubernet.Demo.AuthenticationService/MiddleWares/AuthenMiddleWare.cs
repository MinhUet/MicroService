﻿using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Microsoft.Extensions.Primitives;
using Microsoft.IdentityModel.Tokens;
using Nancy.Json;
using Nhom9.Docker_Kubernet.Demo.AuthenticationService.AuthenticationConfig;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Nhom9.Docker_Kubernet.Demo.AuthenticationService.MiddleWares
{
    public class AuthenMiddleWare
    {
        private readonly RequestDelegate _next;
        private readonly ILogger<AuthenMiddleWare> _logger;
        private readonly Authentication _authenticationConfig;
        public AuthenMiddleWare(Authentication authenticationConfig,
            ILogger<AuthenMiddleWare> logger, RequestDelegate next)
        {
            _authenticationConfig = authenticationConfig;
            _logger = logger;
            _next = next;
        }

        public async Task InvokeAsync(HttpContext context)
        {
            var headers = context.Request.Headers;
            StringValues bearerToken = new StringValues();
            headers.TryGetValue("Authorization", out bearerToken);
            try
            {
                if(bearerToken.Count > 0)
                {
                    var accessToken = bearerToken.ToString().Split(' ').ToList()[1];
                    if (accessToken != null)
                    {
                        var decodedToken = _authenticationConfig.DecodeToken(accessToken);
                        if (decodedToken != null)
                        {
                            var json_serializer = new JavaScriptSerializer();
                            var claims = (IDictionary<string, object>)json_serializer.DeserializeObject(decodedToken);
                            var expiredTimeStamp = Convert.ToInt64(claims["exp"].ToString());
                            var now = ((DateTimeOffset)DateTime.UtcNow).ToUnixTimeSeconds();
                            context.Items.Add("x-full-name", claims["full-name"].ToString());
                            context.Items.Add("x-userID", claims["userID"].ToString());
                        }
                    }
                }
            }
            catch (SecurityTokenException ex)
            {
                _logger.LogError("Localhost exception in AuthenMiddleWare: " + ex.ToString());
            }
            catch (Exception ex)
            {
                _logger.LogError("Localhost exception in AuthenMiddleWare: " + ex.ToString());
            }

            await _next(context);
        }
    }
}

using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Nhom9.Docker_Kubernet.Demo.AuthenticationService.Controllers
{
    [Route("api/[controller]s")]
    [ApiController]
    public class AuthenticationController : ControllerBase
    {

        [HttpGet]
        [Route("healthz")]
        public string Healthz()
        {
            return "Authentication service active";
        }
    }
}

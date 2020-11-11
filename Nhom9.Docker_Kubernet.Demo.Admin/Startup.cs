using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using Nhom9.Docker_Kubernet.Demo.UserService.Utils;
using Nhom9.Docker_Kubernet.Demo.AuthenticationService.AuthenticationConfig;
using Nhom9.Docker_Kubernet.Demo.DL.Database;
using Nhom9.Docker_Kubernet.Demo.DL.Repositories;
using Nhom9.Docker_Kubernet.Demo.Entity.ConfigObjects;
using Nhom9.Docker_Kubernet.Demo.Entity.Interfaces;
using Nhom9.Docker_Kubernet.Demo.AuthenticationService.MiddleWares;

namespace Nhom9.Docker_Kubernet.Demo.UserService
{
    public class Startup
    {
        public Startup(IConfiguration configuration, IWebHostEnvironment env)
        {
            Configuration = Utils.Environment.GetConfiguration(env);
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();

            services.Configure<EmailDataBaseSettings>(
              Configuration.GetSection(nameof(EmailDataBaseSettings)));

            services.AddSingleton<IDatabaseSettings>(sp =>
                sp.GetRequiredService<IOptions<EmailDataBaseSettings>>().Value);

            services.AddTransient<IDatabaseContext, MongoDatabaseContext>();

            services.AddTransient<Authentication>();
            services.AddSingleton<UserRepository>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseStaticFiles();

            app.UseMiddleware<AuthenMiddleWare>();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}

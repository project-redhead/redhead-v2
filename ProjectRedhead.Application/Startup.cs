using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authentication.OpenIdConnect;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using ProjectRedhead.Core.Infrastructure;
using ProjectRedhead.Domain.UserAggregrate;
using ProjectRedhead.Infrastructure;

namespace ProjectRedhead.Application
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);

            // Database provider
            services.AddSingleton<DatabaseProvider>(builder =>
                new DatabaseProvider(Configuration.GetConnectionString("MongoDatabase"),
                    Configuration.GetValue("Database:Name", "redhead")));

            // Authentication
            services.AddAuthentication(options =>
                    {
                        options.DefaultScheme = CookieAuthenticationDefaults.AuthenticationScheme;
                    })
                .AddCookie()
                .AddDiscord("discord", options =>
                {
                    options.SignInScheme = CookieAuthenticationDefaults.AuthenticationScheme;

                    options.ClientId = Configuration.GetValue<string>("Authentication:Discord:Id");
                    options.ClientSecret = Configuration.GetValue<string>("Authentication:Discord:Secret");

                    options.CallbackPath = "/signin-discord";

                    options.SaveTokens = true;

                    options.Scope.Add("identify");
                })
                .AddJwtBearer(JwtBearerDefaults.AuthenticationScheme, options =>
                    {
                        options.RequireHttpsMetadata = false;
                        options.SaveToken = true;

                        // TODO: Read from config
                        options.TokenValidationParameters = new TokenValidationParameters();

                        options.IncludeErrorDetails = true;
                    });

            // Repositories
            services.AddSingleton<IUserRepository, UserRepository>();

            // Third party services
            services.AddMediatR(typeof(Startup).Assembly);
            services.AddOpenApiDocument(config => { config.Title = "redhead API"; });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseOpenApi();
                app.UseSwaggerUi3();
            }
            else
            {
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();

            app.UseAuthentication();
            app.UseMvc();
        }
    }
}

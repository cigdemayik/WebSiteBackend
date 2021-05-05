using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebSiteBackend.WebApi.Middlewares
{
    public static class JwtMiddleware
    {
        public static void AddJwt(this IServiceCollection services)
        {
            var key = Encoding.ASCII.GetBytes("BANAYALANSOYLEDILER!soylediler");

            services.AddAuthentication(x =>
            {
                x.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                x.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
            })
                .AddJwtBearer(x =>
                {
                    x.Audience = "Application";
                    x.RequireHttpsMetadata = false;
                    x.SaveToken = true;
                    x.ClaimsIssuer = "WebSiteDemo";
                    x.TokenValidationParameters = new TokenValidationParameters
                    {
                        IssuerSigningKey = new SymmetricSecurityKey(key),
                        ValidateLifetime = true,
                        ValidateIssuerSigningKey = true,
                        ValidateIssuer = false,
                        ValidateAudience = false
                    };
                    x.Events = new JwtBearerEvents()
                    {
                        OnTokenValidated = (context) =>
                          {
                              var name = context.Principal.Identity.Name;
                              if (string.IsNullOrEmpty(name))
                              {
                                  context.Fail("Yetkisizsiniz, Lütfen Tekrar Giriş Yapınız");
                              }
                              return Task.CompletedTask;
                          }
                    };
                });
                

        }

    }
}

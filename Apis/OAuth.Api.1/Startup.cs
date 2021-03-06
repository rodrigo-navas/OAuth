using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;
using Swashbuckle.AspNetCore.SwaggerUI;

namespace OAuth.Api._1
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
            services.AddControllers();

            // Aqui usando o JWT Token
            services.AddAuthentication(defaultScheme: "Bearer").AddJwtBearer(options =>
            {
                options.Authority = "https://localhost:5001";
                options.Audience = "api_1";
            });

            // Aqui usando o References Token
            //services.AddAuthentication("Bearer")
            //   .AddOAuth2Introspection("Bearer",
            //       options =>
            //       {
            //           options.Authority = "https://localhost:5001";
            //           options.ClientSecret = "335af9f38c484c2aad2aa8d64add12cc";
            //           options.ClientId = "api_1";
            //       });

            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "API 1", Version = "v1" });
                // add JWT Authentication
                var securityScheme = new OpenApiSecurityScheme
                {
                    Name = "JWT Authentication",
                    Description = "Enter JWT Bearer token **_only_**",
                    In = ParameterLocation.Header,
                    Type = SecuritySchemeType.Http,
                    Scheme = "bearer", // must be lower case
                    BearerFormat = "JWT",
                    Reference = new OpenApiReference
                    {
                        Id = "Bearer",
                        Type = ReferenceType.SecurityScheme
                    }
                };
                c.AddSecurityDefinition(securityScheme.Reference.Id, securityScheme);
                c.AddSecurityRequirement(new OpenApiSecurityRequirement
                {
                    {securityScheme, new string[] { }}
                });
            });

            services.AddAuthorization(options =>
            {
                options.AddPolicy("Proprietario", policy =>
                    policy.RequireClaim("cargo", "Proprietario"));

                //options.AddPolicy("B2B", policy =>
                //    policy.RequireAssertion(ctx => ctx.User.Identity.IsAuthenticated || ctx.User.HasClaim("parceiro", "frete")));
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            app.UseSwagger();
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("./v1/swagger.json", "API de Fretes");

                c.DocExpansion(DocExpansion.List);
            });

            app.UseRouting();

            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}

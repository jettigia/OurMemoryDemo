using AutoMapper;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using OurMemoryDb;
using OurMemoryService.Interfaces;
using OurMemoryService.Maps;
using OurMemoryService.Services;
using System;
using System.Threading.Tasks;

namespace OurMemoryCms
{
    public class Startup
    {
        public const string VUE_CORS_POLICY = "VueCorsPolicy";

        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();

            services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
                .AddCookie(options =>
                {
                    options.LoginPath = "/users/authenticate";
                    options.SlidingExpiration = true;
                    options.ExpireTimeSpan = TimeSpan.FromDays(7);
                    options.Events.OnRedirectToLogin = (context) =>
                    {
                        context.Response.StatusCode = 401;
                        return Task.CompletedTask;
                    };
                });

            services.AddDbContext<OurMemoryContext>(options =>
                options.UseMySql(Configuration.GetConnectionString("DefaultConnection"))
            );

            services.AddAutoMapper(typeof(ServiceProfile), typeof(UserProfile));

            // Services
            services.AddScoped<ICommentService, CommentService>();
            services.AddScoped<IMemoryService, MemoryService>();
            services.AddScoped<IUserService, UserService>();

            // Repositories
            services.AddScoped<ICommentRepository, CommentRepository>();
            services.AddScoped<IMemoryRepository, MemoryRepository>();
            services.AddScoped<IUserRepository, UserRepository>();

            services.AddCors(options =>
            {
                options.AddPolicy(VUE_CORS_POLICY, builder =>
                {
                    builder
                      .AllowAnyHeader()
                      .AllowAnyMethod()
                      .AllowCredentials()
                      // Todo Make configurable
                      .WithOrigins("http://ourmemory.com", "http://localhost:8080");
                });
            });

            services.AddRouting(r => r.SuppressCheckForUnhandledSecurityMetadata = true);

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseCors(VUE_CORS_POLICY);

            app.UseHttpsRedirection();

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

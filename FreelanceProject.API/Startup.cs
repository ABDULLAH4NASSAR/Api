using FreelanceProject.Core.Common;
using FreelanceProject.Core.Repository;
using FreelanceProject.Core.Service;
using FreelanceProject.infra.Common;
using FreelanceProject.infra.Repository;
using FreelanceProject.infra.Service;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FreelanceProject.API
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
            services.AddCors(corsOptions =>
            {
                corsOptions.AddPolicy("policy",
                builder =>
                {
                    builder.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader();
                });
            });


           
            services.AddControllers();

            services.AddScoped<IDBContaxt, DBContaxt>();

            services.AddScoped<IAboutusofsRepository, AboutusofsRepository>();
            services.AddScoped<IAboutusofsService, AboutusofsService>();


            services.AddScoped<IBanckofsRepository, BanckofsRepository>();
            services.AddScoped<IBanckofsService, BanckofsService>();


            services.AddScoped<ICategoryofsRepository, CategoryofsRepository>();
            services.AddScoped<ICategoryofsService, CategoryofsService>();


            services.AddScoped<IContactusofsRepository, ContactusofsRepository>();
            services.AddScoped<IContactusofsService, ContactusofsService>();


            services.AddScoped<IEducationfreelanerofsRepository, EducationfreelanerofsRepository>();
            services.AddScoped<IEducationfreelanerofsService, EducationfreelanerofsService>();


            services.AddScoped<IExperiencefreelanerofsRepository, ExperiencefreelanerofsRepository>();
            services.AddScoped<IExperiencefreelanerofsService, ExperiencefreelanerofsService>();


            services.AddScoped<IFreelanceraccountofRepository, FreelanceraccountofRepository>();
            services.AddScoped<IFreelanceraccountofService, FreelanceraccountofService>();


            services.AddScoped<IHomepageofRepository, HomepageofRepository>();
            services.AddScoped<IHomepageofService, HomepageofService>();


            services.AddScoped<ILoginofRepository, LoginofRepository>();
            services.AddScoped<ILoginofService, LoginofService>();



            services.AddScoped<IPaymentmethodofRepository, PaymentmethodofRepository>();
            services.AddScoped<IPaymentmethodofService, PaymentmethodofService>();


            services.AddScoped<IPostprojectofRepository, PostprojectofRepository>();
            services.AddScoped<IPostprojectofService, PostprojectofService>();


            services.AddScoped<IPublicationsfreelanerofRepository, PublicationsfreelanerofRepository>();
            services.AddScoped<IPublicationsfreelanerofService, PublicationsfreelanerofService>();






            services.AddScoped<IQualificationsfreelanerofRepository, QualificationsfreelanerofRepository>();
            services.AddScoped<IQualificationsfreelanerofService, QualificationsfreelanerofService>();


            services.AddScoped<IReviewsofRepository, ReviewsofRepository>();
            services.AddScoped<IReviewsofService, ReviewsofService>();


            services.AddScoped<IRoleofRepository, RoleofRepository>();
            services.AddScoped<IRoleofService, RoleofService>();






            services.AddScoped<ISliderofRepository, SliderofRepository>();
            services.AddScoped<ISliderofService, SliderofService>();


            services.AddScoped<ITestimonialofRepository, TestimonialofRepository>();
            services.AddScoped<ITestimonialofService, TestimonialofService>();


            services.AddScoped<ITestomonialfreelnce, TestomonialfreelanceRepository>();
            services.AddScoped<ITestomonialfreelanceService, TestomonialfreelanceService>();

            services.AddScoped<IUseraccountofRepository, UseraccountofRepository>();
            services.AddScoped<IUseraccountofService, UseraccountofService>();


            services.AddScoped<IWallettofRepository, WallettofRepository>();
            services.AddScoped<IWallettofService, WallettofService>();

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
            app.UseCors("policy");

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}

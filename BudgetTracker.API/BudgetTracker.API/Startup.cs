using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;
using BudgetTracker.Common;
using Microsoft.EntityFrameworkCore;
using BudgetTracker.Common.Entities;
using BudgetTracker.Common.Dtos.FinancialItemDtos;
using BudgetTracker.Common.DI;
using BudgetTracker.DAL.DI;
using BudgetTracker.BL.DI;
using Swashbuckle.AspNetCore.Swagger;
using BudgetTracker.Common.Dtos.FinancialOperationDtos;

namespace BudgetTracker.API
{
    public class Startup
    {
        public static IConfiguration Configuration { get; private set; }
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            var connectionString = Startup.Configuration["connectionStrings:budgetTrackerConnectionString"];
            services.AddMvc();
            services.AddDbContext<BudgetTrackerDbContext>(o => o.UseSqlServer(connectionString));

            services.AddCors();

            services.AddCommonDependencies();
            services.AddDalDependencies();
            services.AddBlDependencies();

            services.AddSwaggerGen(c => c.SwaggerDoc("v1", new Info { Title = "Budget Tracker API", Version = "1.0" }));
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            app.UseCors(builder => builder.AllowAnyOrigin().AllowAnyHeader().AllowAnyMethod().Build());

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseMvc();

            app.UseStatusCodePages();

            AutoMapper.Mapper.Initialize(cfg =>
            {
                cfg.CreateMap<FinancialItem, FinancialItemCreateDto>()
                .ForSourceMember(x => x.Id, opt => opt.Ignore())
                .ForSourceMember(x => x.IsDeleted, opt => opt.Ignore())
                .ReverseMap();

                cfg.CreateMap<FinancialItem, FinancialItemGetDto>()
                .ForSourceMember(x => x.IsDeleted, opt => opt.Ignore())
                .ReverseMap();

                cfg.CreateMap<FinancialOperation, FinancialOperationCreateDto>()
                .ForSourceMember(x => x.Id, opt => opt.Ignore())
                .ForSourceMember(x => x.IsDeleted, opt => opt.Ignore())
                .ReverseMap();

                cfg.CreateMap<FinancialOperation, FinancialOperationGetDto>()
                .ForSourceMember(x => x.IsDeleted, opt => opt.Ignore())
                .ReverseMap();


                //cfg.CreateMap<IList<FinancialItem>, IList<FinancialItemCreateDto>>().ReverseMap();
                //cfg.CreateMap<IList<FinancialItem>, IList<FinancialItemGetDto>>().ReverseMap();
            });

            app.UseSwagger();

            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "My API V1");
            });

            //app.Run(async (context) =>
            //{
            //    await context.Response.WriteAsync("hello");
            //});
        }
    }
}

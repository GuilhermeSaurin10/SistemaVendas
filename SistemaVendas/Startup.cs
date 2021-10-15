using Aplicacao.Servico.Interfaces;
using Dominio.Interfaces;
using Dominio.Repositorio;
using Dominio.Servicos;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Repositorio.Entidades;
using SistemaVendas.DAL;
using System;

namespace SistemaVendas
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
            services.Configure<CookiePolicyOptions>(options =>
            {
                //
                options.CheckConsentNeeded = context => true;
                options.MinimumSameSitePolicy = SameSiteMode.None;
            });

            //Fica por enquanto, pois o projeto ainda n�o foi completamente migrado para o padr�o DDD
            services.AddDbContext<ApplicationDbContext>(options =>
            options.UseSqlServer(Configuration.GetConnectionString("MyStock")));

            //A princ�pio, ser� a definitiva
            services.AddDbContext<Repositorio.Contexto.ApplicationDbContext>(options =>
            options.UseSqlServer(Configuration.GetConnectionString("MyStock")));

            services.AddHttpContextAccessor();

            services.AddDistributedMemoryCache();
            services.AddSession(o =>
            {
                o.IdleTimeout = TimeSpan.FromMinutes(60);
                o.Cookie.HttpOnly = true;
                o.Cookie.IsEssential = true;
            });

            //Servi�o Aplica��o
            services.AddScoped<IServicoAplicacaoCategoria, ServicoAplicacaoCategoria>();

            //Dom�nio
            services.AddScoped<IServicoCategoria, ServicoCategoria>();

            //Reposit�rio
            services.AddScoped<IRepositorioCategoria, RepositorioCategoria>();

            services.AddAntiforgery(o => o.HeaderName = "XSRF-TOKEN");
            services.AddRazorPages();

            services.AddMvc(options => options.EnableEndpointRouting = false);
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_3_0);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseCookiePolicy();
            app.UseSession();

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Login}/{action=Index}/{id?}");
            });
        }
    }
}
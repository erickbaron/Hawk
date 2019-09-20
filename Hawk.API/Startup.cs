using AutoMapper;
using FluentValidation.AspNetCore;
using Hawk.Domain.Entities;
using Hawk.Domain.Identity;
using Hawk.Repository;
using Hawk.Repository.Repositories;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System.Threading.Tasks;
using Microsoft.AspNetCore.HttpsPolicy;
using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;

namespace Hawk.API
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
            services.AddAutoMapper();
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2).AddFluentValidation(fvc =>
                            fvc.RegisterValidatorsFromAssemblyContaining<Startup>()); ;
            services.AddDbContext<HawkContext>(opt => opt.UseSqlServer(Configuration.GetConnectionString("BancoDadosHawk")));

            services.AddCors(options =>
            {
                options.AddPolicy("AllowAllHeaders",
                    x =>
                    {
                        x.AllowAnyOrigin()
                            .AllowAnyHeader()
                            .AllowAnyMethod()
                            .AllowCredentials();
                    });
            });

            IdentityBuilder builder = services.AddIdentityCore<User>(options =>
            {
                options.Password.RequireDigit = false;
                options.Password.RequireNonAlphanumeric = false;
                options.Password.RequireLowercase = false;
                options.Password.RequireUppercase = false;
                options.Password.RequiredLength = 4;
            });

            services.AddScoped(typeof(IHawkRepository<AvaliacaoEmpresa>), typeof(AvaliacaoEmpresaRepository));
            services.AddScoped(typeof(IHawkRepository<AvaliacaoProduto>), typeof(AvaliacaoProdutoRepository));
            services.AddScoped(typeof(IHawkRepository<Carrinho>), typeof(CarrinhoRepository));
            services.AddScoped(typeof(IHawkRepository<Cartao>), typeof(CartaoRepository));
            services.AddScoped(typeof(IHawkRepository<Carrinho>), typeof(CarrinhoRepository));
            services.AddScoped(typeof(IHawkRepository<Categoria>), typeof(CategoriaRepository));
            services.AddScoped(typeof(IHawkRepository<Cliente>), typeof(ClienteRepository));
            services.AddScoped(typeof(IHawkRepository<Compra>), typeof(CompraRepository));
            services.AddScoped(typeof(IHawkRepository<Empresa>), typeof(EmpresaRepository));
            services.AddScoped(typeof(IHawkRepository<EnderecoCliente>), typeof(EnderecoClienteRepository));
            services.AddScoped(typeof(IHawkRepository<EnderecoEmpresa>), typeof(EnderecoEmpresaRepository));
            services.AddScoped(typeof(IHawkRepository<Estoque>), typeof(EstoqueRepository));
            services.AddScoped(typeof(IHawkRepository<Financa>), typeof(FinancaRepository));
            services.AddScoped(typeof(IHawkRepository<ItemCompra>), typeof(ItemCompraRepository));
            services.AddScoped(typeof(IHawkRepository<ProdutoFavorito>), typeof(ProdutoFavoritoRepository));
            services.AddScoped(typeof(IHawkRepository<Produto>), typeof(ProdutoRepository));
            services.AddScoped(typeof(IHawkRepository<Usuario>), typeof(UsuarioRepository));

    
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
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseCors("AllowAllHeaders");
            app.UseStaticFiles();
            app.UseHttpsRedirection();
            app.UseMvc();
        }
    }
}

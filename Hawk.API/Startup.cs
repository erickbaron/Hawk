using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Hawk.Domain.Entities;
using Hawk.Repository;
using Hawk.Repository.Repositories;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Authorization;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;

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
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);
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
            IdentityBuilder builder = services.AddIdentityCore<Usuario>(options =>
            {
                options.Password.RequireDigit = false;
                options.Password.RequireNonAlphanumeric = false;
                options.Password.RequireLowercase = false;
                options.Password.RequireUppercase = false;
                options.Password.RequiredLength = 4;
            });

            builder = new IdentityBuilder(builder.UserType, typeof(Role), builder.Services);
            builder.AddEntityFrameworkStores<HawkContext>();
            builder.AddRoleValidator<RoleValidator<Role>>();
            builder.AddRoleManager<RoleManager<Role>>();
            builder.AddSignInManager<SignInManager<Usuario>>();

            var configurationBuilder = new ConfigurationBuilder()
                .AddConfiguration(Configuration)
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json");

            services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
                  .AddJwtBearer(opt =>
                  {
                      opt.TokenValidationParameters = new TokenValidationParameters
                      {
                          ValidateIssuerSigningKey = true,
                          IssuerSigningKey = new SymmetricSecurityKey(Encoding.ASCII
                          .GetBytes(Configuration.GetSection("Token").Value)),
                          ValidateIssuer = false,
                          ValidateAudience = false,
                          ValidateLifetime = true,
                      };

                  });

            services.AddMvc(options =>
            {
                var policy = new AuthorizationPolicyBuilder()
                    .RequireAuthenticatedUser()
                    .Build();
                options.Filters.Add(new AuthorizeFilter(policy));
            })
                .SetCompatibilityVersion(CompatibilityVersion.Version_2_2)
                .AddJsonOptions(opt => opt.SerializerSettings.ReferenceLoopHandling =
                Newtonsoft.Json.ReferenceLoopHandling.Ignore);


            services.AddCors();

            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);

            services.AddScoped(typeof(IHawkRepository<AvaliacaoEmpresa>), typeof(AvaliacaoEmpresaRepository));
            services.AddScoped(typeof(IHawkRepository<AvaliacaoProduto>), typeof(AvaliacaoProdutoRepository));
            services.AddScoped(typeof(IHawkRepository<Cartao>), typeof(CartaoRepository));
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
            app.UseAuthentication();
            app.UseCors("AllowAllHeaders");
            app.UseHttpsRedirection();
            app.UseMvc();
        }
    }
}

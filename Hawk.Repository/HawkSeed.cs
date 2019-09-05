using Hawk.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Hawk.Repository
{
    public static class HawkSeed
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            #region categorias
            modelBuilder.Entity<Categoria>().HasData(
                new Categoria()
                {
                    Id = 1,
                    Nome = "Eletronicos",
                    RegistroAtivo = true
                },
                new Categoria()
                {
                    Id = 2,
                    Nome = "Calabresa",
                    RegistroAtivo = true
                });
            #endregion


        }
    }
}

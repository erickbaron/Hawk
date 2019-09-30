using Hawk.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hawk.Repository.Repositories
{
    public class ImagemProdutoRepository : IHawkRepository<ImagemProduto>
    {
        private readonly HawkContext context;
        public ImagemProdutoRepository(HawkContext context)
        {
            this.context = context;
        }

        public int Add(ImagemProduto imagemProduto)
        {
            imagemProduto.RegistroAtivo = true;
            this.context.Add(imagemProduto);
            this.context.SaveChanges();
            return imagemProduto.Id;
        }

        public bool Delete(int id)
        {
            var imagemProduto = this.context.ImagensProdutos.FirstOrDefault(x => x.Id == id);
            if (imagemProduto == null)
                return false;

            imagemProduto.RegistroAtivo = false;
            return this.context.SaveChanges() == 1;
        }

        public ImagemProduto ObterPeloId(int id)
        {
            return this.context.ImagensProdutos
                .Include(x => x.Produto)
                .FirstOrDefault(x => x.Id == id && x.RegistroAtivo);
        }

        public ImagemProduto ObterPeloIdProduto(int id)
        {
            return this.context.ImagensProdutos
                .Include(x => x.Produto)
                .FirstOrDefault(x => x.ProdutoId == id && x.RegistroAtivo);
        }

        public ImagemProduto ObterPeloNomeHash(string hash)
        {
            return this.context.ImagensProdutos.FirstOrDefault(x => x.NomeHash == hash);
        }

        public List<ImagemProduto> ObterTodos()
        {
            throw new NotImplementedException();
        }
        
        public bool Update(ImagemProduto imagemProdutp)
        {
            imagemProdutp.RegistroAtivo = true;
            this.context.ImagensProdutos.Update(imagemProdutp);
            return this.context.SaveChanges() == 1;
        }
    }
}

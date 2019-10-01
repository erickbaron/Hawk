using Hawk.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Hawk.Repository
{
    public interface IImagemRepository
    {
        
        int Add(imagem imagem);

        bool Update(imagem imagem);

        bool Delete(int id);

        imagem ObterPeloId(int id);

        imagem ObterPeloIdProduto(int id);

        List<imagem> ObterTodasImagens(int idProduto);
        
    }
}

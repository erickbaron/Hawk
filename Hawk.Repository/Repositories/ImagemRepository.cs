using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Hawk.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Hawk.Repository.Repositories
{
    public class ImagemRepository : IImagemRepository
    {
        private readonly HawkContext _context;
        public ImagemRepository(HawkContext context)
        {
            _context = context;
        }
        public int Add(imagem imagem)
        {
            imagem.DataCriacao = DateTime.Now;
            imagem.RegistroAtivo = true;
            _context.Add(imagem);
            _context.SaveChanges();
            return imagem.Id;
        }

        public bool Delete(int id)
        {
            var imagem = _context.imagens.FirstOrDefault(x => x.Id == id);
            if (imagem == null)
                return false;

            imagem.RegistroAtivo = false;
            return _context.SaveChanges() == 1;
        }

        public imagem ObterPeloId(int id)
        {
            return _context.imagens
                .Include(x => x.produto)
                .FirstOrDefault(x => x.Id == id && x.RegistroAtivo);
        }

        public imagem ObterPeloIdProduto(int id)
        {
            return _context.imagens
                .Include(x => x.produto)
                .FirstOrDefault(x => x.IdProduto == id && x.RegistroAtivo);
        }

        public List<imagem> ObterTodasImagens(int idProduto)
        {
            var query = _context.imagens
           .Include(x => x.produto)
           .Where(x => x.IdProduto == idProduto && x.RegistroAtivo)
           .AsQueryable();

            return query.ToList();
        }

        public bool Update(imagem imagem)
        {
            imagem.RegistroAtivo = true;
            _context.imagens.Update(imagem);
            return _context.SaveChanges() == 1;
        }
    }
}

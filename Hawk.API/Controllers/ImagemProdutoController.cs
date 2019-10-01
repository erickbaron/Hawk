using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using Hawk.Domain.Entities;
using Hawk.Repository;
using Hawk.Repository.Repositories;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers
{
    [Route("imagensProdutos")]
    public class CorretoController : Controller
    {
        private readonly string _nomePasta;
        private readonly string _caminho;
        private readonly ImagemProdutoRepository _repository;

        public CorretoController(ImagemProdutoRepository repository, IHostingEnvironment env)
        {
            _repository = repository;

            string wwwroot = env.WebRootPath;
            _nomePasta = "StaticFiles";
            _caminho = Path.Combine(wwwroot, _nomePasta);

            if (!Directory.Exists(_caminho))
            {
                Directory.CreateDirectory(_caminho);
            }
        }

        [HttpPost, Route("upload")]
        public ActionResult Upload(IFormFile arquivo)
        {

            var nomeArquivo = arquivo.FileName;
            var nomeHash = ObterHashDoNomeDoArquivo(nomeArquivo);

            var caminhoArquivo = Path.Combine(_caminho, nomeHash);
            using (var stream = new FileStream(caminhoArquivo, FileMode.Create))
            {
                arquivo.CopyTo(stream);
                _repository.Add(new ImagemProduto()
                {
                    UrlImagem = nomeArquivo,
                    UrlImagemHash = nomeHash
                });
            }
            return RedirectToAction("Index");
        }

        [HttpGet, Route("obterimagem")]
        public ActionResult ObterImagem(int produtoId)
        {
            var imagemProduto = _repository.ObterPeloIdProduto(produtoId);

            if (imagemProduto == null)
            {
                return NotFound();
            }

            return File(new FileStream(Path.Combine(_caminho, imagemProduto.UrlImagemHash), FileMode.Open), "image/jpeg");
        }
        public static string ObterHashDoNomeDoArquivo(string nome)
        {
            FileInfo info = new FileInfo(nome);

            var crypt = new SHA256Managed();
            var hash = new System.Text.StringBuilder();
            byte[] crypto = crypt.ComputeHash(Encoding.UTF8.GetBytes(info.Name.Replace(info.Extension, "") + DateTime.Now));
            foreach (byte theByte in crypto)
            {
                hash.Append(theByte.ToString("x2"));
            }
            return (hash + info.Extension).ToUpper();
        }
    }
}
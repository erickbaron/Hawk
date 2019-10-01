using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using Hawk.Domain.Entities;
using Hawk.Repository;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using static System.Net.Mime.MediaTypeNames;

namespace Hawk.API.Controllers
{
    [Route("api/imagem")]
    [ApiController]
    [AllowAnonymous]
    public class imagemController : Controller
    {
        private readonly string _nomePasta;
        private readonly string _caminho;
        private IImagemRepository _imagemRepository;
        public imagemController(IImagemRepository imagemRepository, IHostingEnvironment env)
        {
            _imagemRepository = imagemRepository;

            string wwwroot = env.WebRootPath;
            _nomePasta = "arquivos-imagemMontanha";
            _caminho = Path.Combine(wwwroot, _nomePasta);

            if (!Directory.Exists(_caminho))
            {
                Directory.CreateDirectory(_caminho);
            }
        }

        [HttpPost, Route("cadastro")]
        public ActionResult Upload([FromForm] imagemViewModel imagemViewModel)
        {
            IFormFile imagemArquivo = imagemViewModel.Imagem;

            var nomeArquivo = imagemArquivo.FileName;
            var nomeHash = ObterHashDoNomeDoArquivo(nomeArquivo);

            imagem imagem = new imagem
            {
                IdProduto = imagemViewModel.ProdutoID
            };

            var caminhoArquivo = Path.Combine(_caminho, nomeHash);
            using (var stream = new FileStream(caminhoArquivo, FileMode.Create))
            {
                imagemArquivo.CopyTo(stream);

                imagem.UrlImagem = nomeArquivo;
                imagem.UrlImagemHash = nomeHash;

                _imagemRepository.Add(imagem);
            }
            return Json(imagemArquivo);
        }

        [HttpDelete, Route("apagar")]
        public JsonResult Apagar(int id)
        {
            bool apagou = _imagemRepository.Delete(id);
            return Json(new { status = apagou });
        }

        [HttpGet, Route("obterpeloid")]
        public ActionResult ObterPeloId(int id)
        {
            var imagemMontanha = _imagemRepository.ObterPeloId(id);

            if (imagemMontanha == null)
            {
                return NotFound();
            }

            return File(new FileStream(Path.Combine(_caminho, imagemMontanha.UrlImagemHash), FileMode.Open), "image/jpeg");
        }

        [AllowAnonymous]
        [HttpGet, Route("obterimagem")]
        public ActionResult ObterImagem(int produtoId)
        {
            var imagemMontanha = _imagemRepository.ObterPeloIdProduto(produtoId);

            if (imagemMontanha == null)
            {
                return NotFound();
            }

            return File(new FileStream(Path.Combine(_caminho, imagemMontanha.UrlImagemHash), FileMode.Open), "image/jpeg");
        }

        [AllowAnonymous]
        [HttpGet, Route("obtertodasimagens")]
        public JsonResult ObterTodasImagens(int produtoId)
        {
            //var imagemMontanha = _imagemMontanhaRepository.ObterPeloIdMontanha(montanhaId);
            List<imagem> imagemMontanha = _imagemRepository.ObterTodasImagens(produtoId);
            return Json(imagemMontanha);
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
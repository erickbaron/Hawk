using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Hawk.Domain.Entities;
using Hawk.Repository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using Hawk.Validator;
using Microsoft.AspNetCore.Http;
using System.IO;
using System.Net.Http.Headers;
using Microsoft.AspNetCore.Hosting;
using System.Security.Cryptography;
using System.Text;

namespace Hawk.API.Controllers
{
    [Route("api/produtos")]
    [ApiController]
    [AllowAnonymous]

    public class ProdutoController : Controller
    {
        private IHawkRepository<Produto> repository;
        private readonly string nomePasta;
        private readonly string caminho;

        public ProdutoController(IHawkRepository<Produto> repository, IHostingEnvironment env)
        {
            this.repository = repository;

            string wwwroot = env.WebRootPath;
            this.nomePasta = "StaticFiles";
            this.caminho = Path.Combine(wwwroot, this.nomePasta);

            if (!Directory.Exists(this.caminho))
            {
                Directory.CreateDirectory(this.caminho);
            }
        }


        [HttpGet, Route("obtertodos")]
        public JsonResult ObterTodos()
        {
            return Json(repository.ObterTodos());
        }

        [HttpGet, Route("obterpeloid")]
        public JsonResult ObterPeloId(int id)
        {
            return Json(repository.ObterPeloId(id));
        }

        [HttpPost, Route("add")]
        public ActionResult Adicionar(Produto produto, IFormFile arquivo)
        {
            ProdutoValidator validator = new ProdutoValidator();
            var result = validator.Validate(produto);

            if (!result.IsValid)
            {
                var errors = new Dictionary<string, string>();
                foreach (var error in result.Errors)
                {
                    string message = error.ErrorMessage;
                    string property = error.PropertyName;
                    errors.Add(property, message);
                }
                return BadRequest(Json(errors));
            }

            
            return Json(new { id = repository.Add(produto) });
        }
        
        [HttpPut, Route("update")]
        public ActionResult Update(Produto produto)
        {
            ProdutoValidator validator = new ProdutoValidator();
            var result = validator.Validate(produto);

            if (!result.IsValid)
            {
                var errors = new Dictionary<string, string>();
                foreach (var error in result.Errors)
                {
                    string message = error.ErrorMessage;
                    string property = error.PropertyName;
                    errors.Add(property, message);
                }
                return BadRequest(Json(errors));
            }

            return Json(new { id = repository.Update(produto) });
        }

        [HttpDelete, Route("delete")]
        public JsonResult Delete(int id)
        {
            var apagou = repository.Delete(id);
            return Json(new { status = apagou });
        }

        [HttpPost, Route("upload")]
        public ActionResult Upload(IFormFile arquivo)
        {

            var nomeArquivo = arquivo.FileName;
            var nomeHash = ObterHashDoNomeDoArquivo(nomeArquivo);

            var caminhoArquivo = Path.Combine(this.caminho, nomeHash);
            using (var stream = new FileStream(caminhoArquivo, FileMode.Create))
            {
                arquivo.CopyTo(stream);
                this.repository.Add(new Produto()
                {
                    NomeArquivo = nomeArquivo,
                    NomeHash = nomeHash
                });
            }
            return RedirectToAction("Index");
        }

        public static string ObterHashDoNomeDoArquivo(string nome)
        {
            FileInfo info = new FileInfo(nome);

            var crypt = new SHA256Managed();
            var hash = new StringBuilder();
            byte[] crypto = crypt.ComputeHash(Encoding.UTF8.GetBytes(info.Name.Replace(info.Extension, "") + DateTime.Now));
            foreach (byte theByte in crypto)
            {
                hash.Append(theByte.ToString("x2"));
            }
            return (hash + info.Extension).ToUpper();
        }
    }
}
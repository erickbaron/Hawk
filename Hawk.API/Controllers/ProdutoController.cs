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
using Microsoft.AspNetCore.Authorization;


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
        public ActionResult Adicionar(Produto produto)
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


        [HttpPost("upload")]
        public IActionResult Upload()
        {
            try
            {
                Produto produto = new Produto();
                var file = Request.Form.Files[0];
                var folderName = Path.Combine("Resources", "Images");
                var pathToSave = Path.Combine(Directory.GetCurrentDirectory(), folderName);

                if (file.Length > 0)
                {
                    var filename = ContentDispositionHeaderValue.Parse(file.ContentDisposition).FileName;
                    var fullPath = Path.Combine(pathToSave, filename.Replace("\"", " ").Trim());

                    using (var stream = new FileStream(fullPath, FileMode.Create))
                    {
                        produto.NomeArquivo = file.FileName;
                        file.CopyTo(stream);
                    }
                }

                return Ok();    
            }
            catch (System.Exception ex)
            {
                return this.StatusCode(StatusCodes.Status500InternalServerError, $"Falha no upload");
            }
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
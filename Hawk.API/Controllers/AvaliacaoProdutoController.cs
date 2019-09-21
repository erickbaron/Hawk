using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Hawk.Domain.Entities;
using Hawk.Repository;
using Microsoft.AspNetCore.Mvc;
using Hawk.Validator;

namespace Hawk.API.Controllers
{
    [Route("api/avaliacoesprodutos")]
    [ApiController]

    public class AvaliacaoProdutoController : Controller
    {
        private IHawkRepository<AvaliacaoProduto> repository;

        public AvaliacaoProdutoController(IHawkRepository<AvaliacaoProduto> repository)
        {
            this.repository = repository;
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
        public ActionResult Adicionar(AvaliacaoProduto avaliacaoProduto)
        {
            AvaliacaoProdutoValidator validator = new AvaliacaoProdutoValidator();
            var result = validator.Validate(avaliacaoProduto);

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

            return Json(new { id = repository.Add(avaliacaoProduto) });
        }

        [HttpPut, Route("update")]
        public ActionResult Update(AvaliacaoProduto avaliacaoProduto)
        {
            AvaliacaoProdutoValidator validator = new AvaliacaoProdutoValidator();
            var result = validator.Validate(avaliacaoProduto);

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

            return Json(new { id = repository.Update(avaliacaoProduto) });
        }

        [HttpDelete, Route("delete")]
        public JsonResult Delete(int id)
        {
            var apagou = repository.Delete(id);
            return Json(new { status = apagou });
        }
    }
}
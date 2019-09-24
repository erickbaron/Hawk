using Hawk.Domain.Entities;
using Hawk.Repository;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Hawk.Validator;
using Microsoft.AspNetCore.Authorization;

namespace Hawk.API.Controllers
{
    [Route("api/avaliacoesempresas")]
    [ApiController]
    [AllowAnonymous]

    public class AvaliacaoEmpresaController : Controller
    {
        private IHawkRepository<AvaliacaoEmpresa> repository;

        public AvaliacaoEmpresaController(IHawkRepository<AvaliacaoEmpresa> repository)
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
        public ActionResult Adicionar(AvaliacaoEmpresa avaliacaoEmpresa)
        {
            AvaliacaoEmpresaValidator validator = new AvaliacaoEmpresaValidator();
            var result = validator.Validate(avaliacaoEmpresa);

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

            return Json(new { id = repository.Add(avaliacaoEmpresa) });
        }

        [HttpPut, Route("update")]
        public ActionResult Update(AvaliacaoEmpresa avaliacaoEmpresa)
        {

            AvaliacaoEmpresaValidator validator = new AvaliacaoEmpresaValidator();
            var result = validator.Validate(avaliacaoEmpresa);

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

            return Json(new { id = repository.Update(avaliacaoEmpresa) });
        }

        [HttpDelete, Route("delete")]
        public JsonResult Delete(int id)
        {
            var apagou = repository.Delete(id);
            return Json(new { status = apagou });
        }

    }
}

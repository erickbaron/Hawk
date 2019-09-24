using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Hawk.Domain.Entities;
using Hawk.Repository;
using Microsoft.AspNetCore.Mvc;
using Hawk.Validator;
using Microsoft.AspNetCore.Authorization;


namespace Hawk.API.Controllers
{
    [Route("api/enderecosClientes")]
    [ApiController]
    [AllowAnonymous]
    public class EnderecoClienteController : Controller
    {
        private IHawkRepository<EnderecoCliente> repository;

        public EnderecoClienteController(IHawkRepository<EnderecoCliente> repository)
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
        public ActionResult Adicionar(EnderecoCliente enderecoCliente)
        {
            EnderecoClienteValidator validator = new EnderecoClienteValidator();
            var result = validator.Validate(enderecoCliente);

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

            return Json(new { id = repository.Add(enderecoCliente) });
        }

        [HttpPut, Route("update")]
        public ActionResult Update(EnderecoCliente enderecoCliente)
        {
            EnderecoClienteValidator validator = new EnderecoClienteValidator();
            var result = validator.Validate(enderecoCliente);

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

            return Json(new { id = repository.Update(enderecoCliente) });
        }

        [HttpDelete, Route("delete")]
        public JsonResult Delete(int id)
        {
            var apagou = repository.Delete(id);
            return Json(new { status = apagou });
        }

    }
}
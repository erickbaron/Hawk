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
    [Route("api/carrinhos")]
    [ApiController]

    [AllowAnonymous]
    public class CarrinhoController : Controller
    {
        private IHawkRepository<Carrinho> repository;

        public CarrinhoController(IHawkRepository<Carrinho> repository)
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
        public ActionResult Adicionar(Carrinho carrinho)
        {
            CarrinhoValidator validator = new CarrinhoValidator();
            var result = validator.Validate(carrinho);

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

            return Json(new { id = repository.Add(carrinho) });
        }

        [HttpPut, Route("update")]
        public ActionResult Update(Carrinho carrinho)
        {
            CarrinhoValidator validator = new CarrinhoValidator();
            var result = validator.Validate(carrinho);

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


            return Json(new { id = repository.Update(carrinho) });
        }

        [HttpDelete, Route("delete")]
        public JsonResult Delete(int id)
        {
            var apagou = repository.Delete(id);
            return Json(new { status = apagou });
        }
    }
}
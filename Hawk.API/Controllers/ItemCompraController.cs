using Hawk.Domain.Entities;
using Hawk.Repository;
using Microsoft.AspNetCore.Mvc;
using System;
using Microsoft.AspNetCore.Authorization;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Hawk.Validator;

namespace Hawk.API.Controllers
{
    [Route("api/itenscompras")]
    [ApiController]
    [AllowAnonymous]
    public class ItemCompraController : Controller
    {
        private readonly IHawkRepository<ItemCompra> repository;

        public ItemCompraController(IHawkRepository<ItemCompra> repository)
        {
            this.repository = repository;
        }

        [HttpGet, Route("obtertodos")]
        public JsonResult ObterTods()
        {
            return Json(repository.ObterTodos());
        }

        [HttpGet, Route("obterpeloid")]
        public JsonResult ObterPeloId(int id)
        {
            return Json(repository.ObterPeloId(id));
        }

        [HttpPost, Route("add")]
        public ActionResult Adicionar(ItemCompra itemCompra)
        {
            ItemCompraValidator validator = new ItemCompraValidator();
            var result = validator.Validate(itemCompra);

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

            return Json(new { id = repository.Add(itemCompra) });
        }

        [HttpPut, Route("update")]
        public ActionResult Update(ItemCompra itemCompra)
        {
            ItemCompraValidator validator = new ItemCompraValidator();
            var result = validator.Validate(itemCompra);

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

            return Json(new { id = repository.Update(itemCompra) });
        }

        [HttpDelete, Route("delete")]
        public JsonResult Delete(int id)
        {
            var apagou = repository.Delete(id);
            return Json(new { status = apagou });
        }
    }
}

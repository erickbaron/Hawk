using Hawk.Domain.Entities;
using Hawk.Repository;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hawk.API.Controllers
{[Route("api/itenscompras")]
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
        public JsonResult Adicionar(ItemCompra itemCompra)
        {
            var id = repository.Add(itemCompra);
            return Json(new { id });
        }

        [HttpPut, Route("update")]
        public JsonResult Update(ItemCompra itemCompra)
        {
            var alterou = repository.Update(itemCompra);
            return Json(new { status = alterou });
        }

        [HttpDelete, Route("delete")]
        public JsonResult Delete(int id)
        {
            var apagou = repository.Delete(id);
            return Json(new { status = apagou });
        }
    }
}

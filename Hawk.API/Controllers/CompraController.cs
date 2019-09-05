using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Hawk.Domain.Entities;
using Hawk.Repository;
using Microsoft.AspNetCore.Mvc;

namespace Hawk.API.Controllers
{
    [Route("api/compras")]
    [ApiController]
    public class CompraController : Controller
    {
        private readonly IHawkRepository<Compra> repository;

        public CompraController(IHawkRepository<Compra> repository)
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
        public JsonResult Adicionar(Compra compra)
        {
            var id = repository.Add(compra);
            return Json(new { id });
        }

        [HttpPut, Route("update")]
        public JsonResult Update(Compra compra)
        {

            var alterou = repository.Update(compra);
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
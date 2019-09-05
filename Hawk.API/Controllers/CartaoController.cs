using Hawk.Domain.Entities;
using Hawk.Repository;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hawk.API.Controllers
{
    [Route("api/cartoes")]
    [ApiController]
    public class CartaoController : Controller
    {
        private IHawkRepository<Cartao> repository;

        public CartaoController(IHawkRepository<Cartao> repository)
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
        public ActionResult Adicionar(Cartao cartao)
        {
            var id = repository.Add(cartao);
            return Json(new { id });
        }

        [HttpPut, Route("update")]
        public ActionResult Update(Cartao cartao)
        {
            var alterou = repository.Update(cartao);
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

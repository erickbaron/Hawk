using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Hawk.Domain.Entities;
using Hawk.Repository;
using Microsoft.AspNetCore.Mvc;

namespace Hawk.API.Controllers
{
    [Route("api/estoques")]
    [ApiController]
    public class EstoqueController : Controller
    {
        private IHawkRepository<Estoque> repository;

        public EstoqueController(IHawkRepository<Estoque> repository)
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
        public JsonResult Adicionar(Estoque estoque)
        {
            var id = repository.Add(estoque);
            return Json(new { id });
        }

        [HttpPut, Route("update")]
        public JsonResult Update(Estoque estoque)
        {
            var alterou = repository.Update(estoque);
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
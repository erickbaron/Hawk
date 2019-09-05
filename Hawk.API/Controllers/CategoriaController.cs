using Hawk.Domain.Entities;
using Hawk.Repository;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hawk.API.Controllers
{
    [Route("api/categorias")]
    [ApiController]
    public class CategoriaController : Controller
    {
        private IHawkRepository<Categoria> repository;

        public CategoriaController(IHawkRepository<Categoria> repository)
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
        public ActionResult Adicionar(Categoria categoria)
        {
            var id = repository.Add(categoria);
            return Json(new { id });
        }

        [HttpPut, Route("update")]
        public ActionResult Update(Categoria categoria)
        {
            var alterou = repository.Update(categoria);
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

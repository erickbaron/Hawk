using Hawk.Domain.Entities;
using Hawk.Repository;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hawk.API.Controllers
{
    [Route("api/empresas")]
    [ApiController]
    public class EmpresaController : Controller
    {
        private IHawkRepository<Empresa> repository;

        public EmpresaController(IHawkRepository<Empresa> repository)
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
        public ActionResult Adicionar(Empresa empresa)
        {
            var id = repository.Add(empresa);
            return Json(new { id });
        }

        [HttpPut, Route("update")]
        public ActionResult Update(Empresa empresa)
        {
            var alterou = repository.Update(empresa);
            return Json(new { status = alterou });
        }

        [HttpDelete, Route("delete")]
        public JsonResult Delete(int id)
        {
            var apagou = repository.Delete(id);
            return null;
        }
    }
}

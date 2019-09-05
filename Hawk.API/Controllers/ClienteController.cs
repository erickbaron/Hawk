using Hawk.Domain.Entities;
using Hawk.Repository;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hawk.API.Controllers
{
    [Route("api/clientes")]
    [ApiController]
    public class ClienteController : Controller
    {
        private IHawkRepository<Cliente> repository;

        public ClienteController(IHawkRepository<Cliente> repository)
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
        public ActionResult Adicionar(Cliente cliente)
        {
            var id = repository.Add(cliente);
            return Json(new { id });
        }

        [HttpPut, Route("update")]
        public ActionResult Update(Cliente cliente)
        {

            var alterou = repository.Update(cliente);
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

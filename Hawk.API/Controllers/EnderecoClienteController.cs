using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Hawk.Domain.Entities;
using Hawk.Repository;
using Microsoft.AspNetCore.Mvc;

namespace Hawk.API.Controllers
{
    [Route("api/enderecosClientes")]
    [ApiController]
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
        public JsonResult Adicionar(EnderecoCliente enderecoCliente)
        {
            var id = repository.Add(enderecoCliente);
            return Json(new { id });
        }

        [HttpPut, Route("update")]
        public JsonResult Update(EnderecoCliente enderecoCliente)
        {
            var alterou = repository.Update(enderecoCliente);
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
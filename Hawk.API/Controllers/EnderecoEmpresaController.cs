using Hawk.Domain.Entities;
using Hawk.Repository;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hawk.API.Controllers
{
    [Route("api/enderecosempresas")]
    [ApiController]
    public class EnderecoEmpresaController : Controller
    {
        private readonly IHawkRepository<EnderecoEmpresa> repository;

        public EnderecoEmpresaController(IHawkRepository<EnderecoEmpresa> repository)
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
        public JsonResult Adicionar(EnderecoEmpresa enderecoEmpresa)
        {
            var id = repository.Add(enderecoEmpresa);
            return Json(new { id });
        }

        [HttpPut, Route("update")]
        public JsonResult Update(EnderecoEmpresa enderecoEmpresa)
        {
            var alterou = repository.Update(enderecoEmpresa);
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

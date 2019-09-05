using Hawk.Domain.Entities;
using Hawk.Repository;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hawk.API.Controllers
{
    [Route("api/avaliacoesempresas")]
    [ApiController]
    public class AvaliacaoEmpresaController : Controller
    {
        private IHawkRepository<AvaliacaoEmpresa> repository;

        public AvaliacaoEmpresaController(IHawkRepository<AvaliacaoEmpresa> repository)
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
        public JsonResult Adicionar(AvaliacaoEmpresa avaliacaoEmpresa)
        {
            var id = repository.Add(avaliacaoEmpresa);
            return Json(new { id });
        }

        [HttpPut, Route("update")]
        public JsonResult Update(AvaliacaoEmpresa avaliacaoEmpresa)
        {
            var alterou = repository.Update(avaliacaoEmpresa);
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

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Hawk.Domain.Entities;
using Hawk.Repository;
using Microsoft.AspNetCore.Mvc;

namespace Hawk.API.Controllers
{
    [Route("api/avaliacoesprodutos")]
    [ApiController]
    public class AvaliacaoProdutoController : Controller
    {
        private IHawkRepository<AvaliacaoProduto> repository;

        public AvaliacaoProdutoController(IHawkRepository<AvaliacaoProduto> repository)
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
        public JsonResult Adicionar(AvaliacaoProduto avaliacaoProduto)
        {
            var id = repository.Add(avaliacaoProduto);
            return Json(new { id });
        }

        [HttpPut, Route("update")]
        public JsonResult Update(AvaliacaoProduto avaliacaoProduto)
        {
            var alterou = repository.Update(avaliacaoProduto);
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
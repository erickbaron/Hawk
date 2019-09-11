using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Hawk.Domain.Entities;
using Hawk.Repository;
using Microsoft.AspNetCore.Mvc;

namespace Hawk.API.Controllers
{
    [Route("api/produtos")]
    [ApiController]
    public class ProdutoController : Controller
    {
        private IHawkRepository<Produto> repository;

        public ProdutoController(IHawkRepository<Produto> repository)
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
        public JsonResult Adicionar(Produto produto)
        {
            var id = repository.Add(produto);
            return Json(new { id });
        }

        [HttpPut, Route("update")]
        public JsonResult Update(Produto produto)
        {
            var alterou = repository.Update(produto);
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
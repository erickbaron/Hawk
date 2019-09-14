using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Hawk.Domain.Entities;
using Hawk.Repository;
using Microsoft.AspNetCore.Mvc;

namespace Hawk.API.Controllers
{
    public class CarrinhoController : Controller
    {
        private IHawkRepository<Carrinho> repository;

        public CarrinhoController(IHawkRepository<Carrinho> repository)
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
        public JsonResult Adicionar(Carrinho carrinho)
        {
            var id = repository.Add(carrinho);
            return Json(new { id });
        }

        [HttpPut, Route("update")]
        public JsonResult Update(Carrinho carrinho)
        {
            var alterou = repository.Update(carrinho);
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
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Hawk.Domain.Entities;
using Hawk.Repository;
using Microsoft.AspNetCore.Mvc;

namespace Hawk.API.Controllers
{
    [Route("api/produtosfavoritos")]
    [ApiController]

    public class ProdutoFavoritoController : Controller
    {
        private IHawkRepository<ProdutoFavorito> repository;

        public ProdutoFavoritoController(IHawkRepository<ProdutoFavorito> repository)
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
        public JsonResult Adicionar(ProdutoFavorito produtoFavorito)
        {
            var id = repository.Add(produtoFavorito);
            return Json(new { id });
        }

        [HttpPut, Route("update")]
        public JsonResult Update(ProdutoFavorito produtoFavorito)
        {
            var alterou = repository.Update(produtoFavorito);
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
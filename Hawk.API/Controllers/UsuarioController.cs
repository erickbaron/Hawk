using Hawk.Domain.Entities;
using Hawk.Repository;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hawk.API.Controllers
{
    public class UsuarioController : Controller
    {
        private IHawkRepository<Usuario> repository;

        public UsuarioController(IHawkRepository<Usuario> repository)
        {
            this.repository = repository;
        }

        [HttpPost, Route("add")]
        public JsonResult Adicionar(Usuario usuario)
        {
            var id = repository.Add(usuario);
            return Json(new { id });
        }

        [HttpPut, Route("update")]
        public JsonResult Update(Usuario usuario)
        {
            var alterou = repository.Update(usuario);
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

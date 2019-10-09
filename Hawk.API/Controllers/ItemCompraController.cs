using Hawk.Domain.Entities;
using Hawk.Repository;
using Microsoft.AspNetCore.Mvc;
using System;
using Microsoft.AspNetCore.Authorization;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Hawk.Validator;
using Microsoft.AspNetCore.Authorization;


namespace Hawk.API.Controllers
{
    [Route("api/itenscompras")]
    [ApiController]
    [AllowAnonymous]
    public class ItemCompraController : Controller
    {
        private readonly IHawkRepository<ItemCompra> repository;
        private readonly ICarrinhoRepository repositoryCarrinho;

        public ItemCompraController(
            IHawkRepository<ItemCompra> repository,
            ICarrinhoRepository repositoryCarrinho
            )
        {
            this.repository = repository;
            this.repositoryCarrinho = repositoryCarrinho;
        }

        [HttpGet, Route("obtertodos")]
        public JsonResult ObterTods()
        {
            return Json(repository.ObterTodos());
        }

        [HttpGet, Route("obterpeloid")]
        public JsonResult ObterPeloId(int id)
        {
            return Json(repository.ObterPeloId(id));
        }

        [HttpPost, Route("add")]
        public ActionResult Adicionar(ItemCompra itemCompra)
        {
            ItemCompraValidator validator = new ItemCompraValidator();
            var result = validator.Validate(itemCompra);

            if (!result.IsValid)
            {
                var errors = new Dictionary<string, string>();
                foreach (var error in result.Errors)
                {
                    string message = error.ErrorMessage;
                    string property = error.PropertyName;
                    errors.Add(property, message);
                }
                return BadRequest(Json(errors));
            }
            // TODO obter o Id Usuário
            var x = User.Identity.Name;
                int idUsuario = Convert.ToInt32(1);
            var carrinho = repositoryCarrinho.ObterCarrinhoAbertoPeloIdUsuario(idUsuario);

            if(carrinho == null)
            {
                carrinho = new Carrinho()
                {
                    UsuarioId = idUsuario,
                    RegistroAtivo = true,
                    ValorTotal = itemCompra.Valor
                };
                repositoryCarrinho.Add(carrinho);
            }

            itemCompra.CompraId = carrinho.Id;
            var id = repository.Add(itemCompra);

            return Json(new { id = id });
        }

        [HttpPut, Route("update")]
        public ActionResult Update(ItemCompra itemCompra)
        {
            ItemCompraValidator validator = new ItemCompraValidator();
            var result = validator.Validate(itemCompra);

            if (!result.IsValid)
            {
                var errors = new Dictionary<string, string>();
                foreach (var error in result.Errors)
                {
                    string message = error.ErrorMessage;
                    string property = error.PropertyName;
                    errors.Add(property, message);
                }
                return BadRequest(Json(errors));
            }

            return Json(new { id = repository.Update(itemCompra) });
        }

        [HttpDelete, Route("delete")]
        public JsonResult Delete(int id)
        {
            var apagou = repository.Delete(id);
            return Json(new { status = apagou });
        }
    }
}

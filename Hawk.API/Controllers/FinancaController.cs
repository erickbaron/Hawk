﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Hawk.Domain.Entities;
using Hawk.Repository;
using Microsoft.AspNetCore.Mvc;
using Hawk.Validator;

namespace Hawk.API.Controllers
{
    [Route("api/financas")]
    [ApiController]
    public class FinancaController : Controller
    {
        private readonly IHawkRepository<Financa> repository;

        public FinancaController(IHawkRepository<Financa> repository)
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
        public JsonResult Adicionar(Financa financa)
        {
            var id = repository.Add(financa);
            return Json(new { id });
        }

        [HttpPut, Route("update")]
        public JsonResult Update(Financa financa)
        {

            var alterou = repository.Update(financa);
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
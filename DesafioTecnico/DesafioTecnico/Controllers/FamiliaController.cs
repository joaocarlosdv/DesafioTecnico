using DesafioTecnico.Models;
using DesafioTecnico.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesafioTecnico.Controllers
{
    public class FamiliaController : Controller
    {
        private readonly FamiliaService familiaService;
        public FamiliaController(IFamiliaService service)
        {
            familiaService = (FamiliaService)service;
        }

        [HttpPost("ListaOrdenada")]
        public ActionResult ListaOrdenada([FromBody] List<Familia> lista)
        {
            return Ok(familiaService.ListaOrdenada(lista));
        }

        [HttpGet("TesteListaOrdenada")]
        public ActionResult TesteListaOrdenada()
        {
            return Ok(familiaService.ListaOrdenada(familiaService.CarregarListaFamilia()));
        }
    }
}

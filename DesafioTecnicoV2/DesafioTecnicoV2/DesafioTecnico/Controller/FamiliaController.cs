using DesafioTecnicoV2.Domain.Entities;
using DesafioTecnicoV2.Service.Services;
using DesafioTecnicoV2.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace DesafioTecnicoV2.Controller
{
    public class FamiliaController : ControllerBase
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

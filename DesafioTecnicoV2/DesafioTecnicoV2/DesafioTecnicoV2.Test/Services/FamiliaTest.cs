using DesafioTecnicoV2.Service.Services;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesafioTecnicoV2.Test.Services
{
    public class FamiliaTest
    {
        private readonly FamiliaService familiaService = new FamiliaService();

        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TesteOrdenarLista()
        {
            Assert.IsNotNull(familiaService.ListaOrdenada(familiaService.CarregarListaFamilia()));
        }

        [Test]
        public void TesteCarregarLista()
        {
            Assert.IsNotNull(familiaService.CarregarListaFamilia());
        }
    }
}

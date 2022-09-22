using NUnit.Framework;

namespace TestProject1
{
    public class Tests
    {
        private readonly DesafioTecnico.Services.FamiliaService familiaService = new DesafioTecnico.Services.FamiliaService();

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
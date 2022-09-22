using DesafioTecnico.Models;
using System.Collections.Generic;

namespace DesafioTecnico.Services
{
    public interface IFamiliaService
    {
        List<Familia> CarregarListaFamilia();
        List<Familia> ListaOrdenada(List<Familia> lista);
    }
}

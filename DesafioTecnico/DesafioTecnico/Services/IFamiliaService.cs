using DesafioTecnico.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesafioTecnico.Services
{
    public interface IFamiliaService
    {
        List<Familia> CarregarListaFamilia();
        List<Familia> ListaOrdenada(List<Familia> lista);
    }
}

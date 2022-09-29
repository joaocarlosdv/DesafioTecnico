using DesafioTecnicoV2.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesafioTecnicoV2.Services.Interfaces
{
    public interface IFamiliaService
    {
        List<Familia> CarregarListaFamilia();
        List<Familia> ListaOrdenada(List<Familia> lista);
    }
}

using DesafioTecnicoV2.Domain.Entities;
using DesafioTecnicoV2.Services.Libs;
using DesafioTecnicoV2.Services.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace DesafioTecnicoV2.Service.Services
{
    public class FamiliaService : IFamiliaService
    {
        private List<Dependente> CarregarDependentes(int idFamilia)
        {
            List<Dependente> dependentes = new List<Dependente>();

            for (int i = 0; i < Functions.RandomInt(10); i++)
            {
                dependentes.Add(
                    new Dependente
                    {
                        Id = i + 1,
                        Cpf = Functions.RandomCpf(),
                        FamiliaId = idFamilia,
                        Nome = Functions.RandomNames(),
                        Idade = Functions.RandomInt(100)
                    }
                );
            }

            return dependentes;
        }

        public List<Familia> CarregarListaFamilia()
        {
            List<Familia> lista = new List<Familia>();

            for (int i = 0; i < 30; i++)
            {
                lista.Add(
                    new Familia
                    {
                        Id = i + 1,
                        PretendenteCpf = Functions.RandomCpf(),
                        PretendenteNome = Functions.RandomNames(),
                        ConjugeCpf = Functions.RandomCpf(),
                        ConjugeNome = Functions.RandomNames(),
                        RendaFamiliar = Functions.RandomDecimal(100, 3000),
                        Dependentes = CarregarDependentes(i + 1)
                    }
                );
            }

            return lista;
        }

        public List<Familia> ListaOrdenada(List<Familia> lista)
        {
            return lista.OrderByDescending(x => x.PontosFamilia).ThenBy(x => x.PretendenteNome).ToList();
        }
    }
}

using DesafioTecnico.Functions;
using DesafioTecnico.Models;
using System.Collections.Generic;
using System.Linq;

namespace DesafioTecnico.Services
{
    public class FamiliaService : IFamiliaService
    {
        private List<Dependente> CarregarDependentes(int idFamilia)
        {
            List<Dependente> dependentes = new List<Dependente>();

            for (int i=0; i < ClassFuncions.RandomInt(10); i++)
            {
                dependentes.Add(
                    new Dependente
                    {
                        Id = i+1,
                        Cpf = ClassFuncions.RandomCpf(),
                        FamiliaId = idFamilia,
                        Nome = ClassFuncions.RandomNames(),
                        Idade = ClassFuncions.RandomInt(100)
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
                        PretendenteCpf = ClassFuncions.RandomCpf(),
                        PretendenteNome = ClassFuncions.RandomNames(),
                        ConjugeCpf = ClassFuncions.RandomCpf(),
                        ConjugeNome = ClassFuncions.RandomNames(),
                        RendaFamiliar = ClassFuncions.RandomDecimal(100, 3000),
                        Dependentes = CarregarDependentes(i + 1)
                    }
                ); 
            }

            return lista;
        }

        public List<Familia> ListaOrdenada(List<Familia> lista)
        {
            return lista.OrderByDescending(x => x.PontosFamilia).ThenBy(x=>x.PretendenteNome).ToList();
        }
    }
}

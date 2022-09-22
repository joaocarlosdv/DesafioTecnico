using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesafioTecnico.Models
{
    public class Familia
    {
        public Familia()
        {
            Dependentes = new List<Dependente>();
        }

        public int Id { get; set; }
        public string PretendenteCpf { get; set; }
        public string PretendenteNome { get; set; }
        public string ConjugeCpf { get; set; }
        public string ConjugeNome { get; set; }
        public decimal RendaFamiliar { get; set; }
        public List<Dependente> Dependentes { get; set; }

        private int PontosRenda
        {
            get
            {
                int retorno = 0;
                if (RendaFamiliar <= 900)
                {
                    retorno = 5;
                }
                else if (RendaFamiliar >= 901 && RendaFamiliar <= 1500)
                {
                    retorno = 3;
                }

                return retorno;
            }
        }

        private int PontosDependentes
        {            
            get
            {
                int retorno = 0;
                int tot = Dependentes.Where(x => x.Idade < 18).Count();
                if (tot > 0 && tot <= 2)
                {
                    retorno = 2;
                }
                if (tot > 3)
                {
                    retorno = 3;
                }
                return retorno;
            }
        }

        public int PontosFamilia
        {
            get
            {
                return PontosRenda + PontosDependentes;
            }
        }
    }
}

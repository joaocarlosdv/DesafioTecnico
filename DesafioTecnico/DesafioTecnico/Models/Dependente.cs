using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesafioTecnico.Models
{
    public class Dependente
    {
        public int Id { get; set; }
        public int FamiliaId { get; set; }
        public string Cpf { get; set; }
        public string Nome { get; set; }
        public int Idade { get; set; }
    }
}

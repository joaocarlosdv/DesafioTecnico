using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Threading.Tasks;

namespace DesafioTecnico.Functions
{
    public class ClassFuncions
    {
        public static string RandomCpf()
        {
            var random = new Random();

            int soma = 0;
            int resto = 0;
            int[] multiplicadores = new int[10] { 11, 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            string semente;

            do
            {
                semente = random.Next(1, 999999999).ToString().PadLeft(9, '0');
            }
            while (
                semente == "000000000"
                || semente == "111111111"
                || semente == "222222222"
                || semente == "333333333"
                || semente == "444444444"
                || semente == "555555555"
                || semente == "666666666"
                || semente == "777777777"
                || semente == "888888888"
                || semente == "999999999"
            );

            for (int i = 1; i < multiplicadores.Count(); i++)
                soma += int.Parse(semente[i - 1].ToString()) * multiplicadores[i];

            resto = soma % 11;

            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;

            semente += resto;
            soma = 0;

            for (int i = 0; i < multiplicadores.Count(); i++)
                soma += int.Parse(semente[i].ToString()) * multiplicadores[i];

            resto = soma % 11;

            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;

            semente = semente + resto;

            return semente;
        }

        public static string RandomNames()
        {
            var random = new Random();
            var nomes = new[] { 
                "Ana Maria", 
                "Ana Clara", 
                "Ana Gabriela", 
                "Amanda", 
                "Arthur", 
                "Alex", 
                "Bruna", 
                "Bruno", 
                "Bárbara", 
                "Beatriz",
                "Carla",
                "Carlos Alberto",
                "Carlos Eduardo",
                "Cristina",
                "Danilo",
                "Daniela",
                "Daniele",
                "Daniel",
                "Denize",
                "Eduardo",
                "Eduarda",
                "Elizabete",
                "Francisca",
                "Fernando",
                "Gabriel",
                "Gabriela",
                "Giovana",
                "Giovane",
                "Hugo",
                "Hélio",
                "Israel",
                "Israelita",
                "João Carlos",
                "João Marcelo",
                "João Augusto",
                "João Guilherme",
                "Luiz Ricardo",
                "Luiz Roberto",
                "Luiza Maria",
                "Luiza",
                "Letícia",
                "Letícia Maria",
                "Marcelo",
                "Marcel",
                "Marcela",
                "Maria",
                "Maria José",
                "Maria Eduarda",
                "Nilma",
                "Nadir",
                "Noelma",
                "Otávio",
                "Otilia",
                "Osvaldo",
                "Pedro",
                "Paulo",
                "Patrícia",
                "Paloma",
                "Rafeal",
                "Raimundo",
                "Rodrigo",
                "Renata",
                "Renato",
                "Silvia",
                "Silvio",
                "Sandra",
                "Severino",
                "Severino José",
                "Shirley",
                "Sabrina",
                "Tácio",
                "Tiago",
                "Talita",
                "Tereza",
                "Vitória",
                "Vinicios",
                "Valter",
                "Valeria"
            };
            var sobrenomes = new[] { 
                "Alves", 
                "da Silva", 
                "Dantas", 
                "Vieira", 
                "da Luz", 
                "Magalhães", 
                "Lima", 
                "Monteiro", 
                "Rezende", 
                "Brasil",
                "Laranjeira",
                "Brizola",
                "Gomes",
                "Cavalcanti",
                "Pessoa",
                "Silverio",
                "Espirito Santo",
                "Medeiros",
                "Araújo",
                "Albuquerque",
                "Ferreira",
                "Garcia"
            };
            
            return nomes[random.Next(nomes.Length)] + " " + sobrenomes[random.Next(sobrenomes.Length)] + " " + sobrenomes[random.Next(sobrenomes.Length)];
        }

        public static decimal RandomDecimal(decimal min, decimal max)
        {
            // Create a int array to hold the random values.
            Byte[] bytes = new Byte[] { 0, 0, 0, 0 };

            RNGCryptoServiceProvider Gen = new RNGCryptoServiceProvider();

            // Fill the array with a random value.
            Gen.GetBytes(bytes);
            bytes[3] %= 29; // this must be between 0 and 28 (inclusive)
            decimal d = new decimal((int)bytes[0], (int)bytes[1], (int)bytes[2], false, bytes[3]);            

            decimal valor = Math.Round(d % (max + 1), 2);

            if (valor < min)
            {
                valor = min;
            }

            return valor;
        }

        public static int RandomInt(int max)
        {
            Random randNum = new Random();
            return randNum.Next(max);
        }
    }
}

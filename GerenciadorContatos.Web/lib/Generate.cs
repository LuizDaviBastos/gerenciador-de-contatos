using System;

namespace GerenciadorContatos.lib
{
    public class Generate
    {
        public static string GenerateName(int len)
        {
            Random r = new Random();
            string[] consonants = { "b", "c", "d", "f", "g", "h", "j", "k", "l", "m", "l", "n", "p", "q", "r", "s", "sh", "zh", "t", "v", "w", "x" };
            string[] vowels = { "a", "e", "i", "o", "u", "ae", "y" };
            string Name = "";
            Name += consonants[r.Next(consonants.Length)].ToUpper();
            Name += vowels[r.Next(vowels.Length)];
            int b = 2; //b tells how many times a new letter has been added. It's 2 right now because the first two letters are already in the name.
            while (b < len)
            {
                Name += consonants[r.Next(consonants.Length)];
                b++;
                Name += vowels[r.Next(vowels.Length)];
                b++;
            }

            return Name;


        }
        public static string GeneratePhone()
        {
            return $"({new Random().Next(10, 40)}) 9{new Random().Next(1000, 9999)}-{new Random().Next(1000, 9999)}";
        }

        public static string GenerateCity()
        {
            var list = new string[,]
            {
                { "AC", "Acre" },
                { "AL", "Alagoas" },
                { "AP", "Amapá" },
                { "AM", "Amazonas" },
                { "BA", "Bahia" },
                { "CE", "Ceará" },
                { "DF", "Distrito Federal" },
                { "ES", "Espírito Santo" },
                { "GO", "Goiás" },
                { "MA", "Maranhão" },
                { "MT", "Mato Grosso" },
                { "MS", "Mato Grosso do Sul" },
                { "MG", "Minas Gerais" },
                { "PA", "Pará" },
                { "PB", "Paraíba" },
                { "PR", "Paraná" },
                { "PE", "Pernambuco" },
                { "PI", "Piauí" },
                { "RJ", "Rio de Janeiro" },
                { "RN", "Rio Grande do Norte" },
                { "RS", "Rio Grande do Sul" },
                { "RO", "Rondônia" },
                { "RR", "Roraima" },
                { "SC", "Santa Catarina" },
                { "SP", "São Paulo" },
                { "SE", "Sergipe" },
                { "TO", "Tocantins" }
            };

            return list[0, 0];
        }
    }

}

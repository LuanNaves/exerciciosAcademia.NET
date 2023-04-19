using System.Runtime.CompilerServices;

namespace Exercicio10 {
    internal class Program {
        static void Main(string[] args) {
            string nome;
            char sexo;
            int idade, totalMasculino = 0, totalFeminino = 0, somaIdadeFeminino = 0, menosDe30 = 0, maisDe60 = 0;
            double media;
            for (int i = 0; i < 10;  i++) {
                Console.WriteLine($"Dados da {i + 1}ª pessoa");
                Console.Write("Qual é o seu nome?  ");
                nome = Console.ReadLine();
                Console.Write("Qual é o seu sexo (M/F)? ");
                sexo = char.Parse(Console.ReadLine().ToUpper());
                Console.Write("Qual é a sua idade? ");
                idade = int.Parse(Console.ReadLine());

                if (sexo == 'F') {
                    totalFeminino++;
                    somaIdadeFeminino += idade;
                }
                else {
                    totalMasculino++;
                }
                if (idade < 30) {
                    menosDe30++;
                }
                else if (idade > 60) {
                    maisDe60++;
                }
            }
            media = somaIdadeFeminino / totalFeminino;
            Console.WriteLine();
            Console.WriteLine($"Número de pessoas do sexo masculino: {totalMasculino}");
            Console.WriteLine($"Número de pessoas do sexo feminino: {totalFeminino}");
            Console.WriteLine($"Número de pessoas com idade inferior a 30: {menosDe30}");
            Console.WriteLine($"Número de pessoas com idade superior a 60: {maisDe60}");
            Console.WriteLine($"Média de idade das mulheres {media}");

        }
    }
}
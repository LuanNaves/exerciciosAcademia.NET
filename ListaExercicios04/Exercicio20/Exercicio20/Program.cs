namespace Exercicio20 {
    internal class Program {
        static void Main(string[] args) {
            char sexo;
            string corOlhos, corCabelos;
            int idade, maiorIdade = -1, qtdFemOlhVerCabLou18a35 = 0;

            do {
                Console.WriteLine("Informe suas características: ");
                Console.Write("Sexo (M/F): ");
                sexo = char.Parse(Console.ReadLine().ToUpper());
                Console.Write("Cor dos olhos (azuis, verdes, castanhos): ");
                corOlhos = Console.ReadLine().ToLower();
                Console.Write("Cor dos cabelos (louros, castanhos, pretos): ");
                corCabelos = Console.ReadLine().ToLower();
                Console.Write("Idade: ");
                idade = int.Parse(Console.ReadLine());
                if (idade == -1) break;

                if (idade > maiorIdade) {
                    maiorIdade = idade;
                }
                if (corOlhos == "verdes" && corCabelos == "louros" && sexo == 'F' && idade > 18 && idade <= 35) {
                    qtdFemOlhVerCabLou18a35++;
                }

            } while (true);

            Console.WriteLine($"Maior idade dos habitantes: {maiorIdade}");
            Console.WriteLine($"Quantidade de indivíduos do sexo feminino cuja idade está entre 18 e 35 anos inclusive" +
                $"\ne que tenham olhos verdes e cabelos louros: {qtdFemOlhVerCabLou18a35}");
        }
    }
}
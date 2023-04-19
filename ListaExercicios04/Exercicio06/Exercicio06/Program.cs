namespace Exercicio06 {
    internal class Program {
        static void Main(string[] args) {
            int idade;

            do {
                Console.Write("Insira a sua idade: ");
                idade = int.Parse(Console.ReadLine());
            } while (idade <= 0);

            Console.WriteLine($"Idade digitada {idade}");

        }
    }
}
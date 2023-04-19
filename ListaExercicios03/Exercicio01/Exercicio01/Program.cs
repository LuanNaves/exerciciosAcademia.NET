namespace Exercicio01 {
    internal class Program {
        static void Main(string[] args) {

            int n, idade;
            int soma = 0;

            Console.Write("Digite o número de pessoas: ");
            n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++) {
                Console.Write($"Digite a idade da {i + 1}ª pessoa: ");
                idade = int.Parse(Console.ReadLine());

                soma += idade;
            }
            double media = soma / n;
            Console.WriteLine($"A média da idade das pessoas é {media}");
        }
    } 
}
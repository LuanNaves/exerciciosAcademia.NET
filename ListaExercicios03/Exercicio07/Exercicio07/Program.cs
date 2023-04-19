namespace Exercicio07 {
    internal class Program {
        static void Main(string[] args) {
            int num, qtdPar = 0, qtdImpar = 0;

            for (int i = 0; i < 20;  i++) {
                Console.Write("Digite um número: ");
                num = int.Parse(Console.ReadLine());

                if (num % 2 == 0) {
                    qtdPar++;
                }
                else {
                    qtdImpar++;
                }
            }
            Console.WriteLine($"Quantidade de números pares digitados = {qtdPar}");
            Console.WriteLine($"Quantidade de números impares digitados = {qtdImpar}");

        }
    }
}
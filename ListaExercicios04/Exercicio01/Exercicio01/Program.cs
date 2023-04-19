namespace Exercicio01 {
    internal class Program {
        static void Main(string[] args) {
            int num;

            for(; ;) {
                Console.Write("Digite um número inteiro positivo: ");
                num = int.Parse(Console.ReadLine());

                if (num < 1) {
                    Console.WriteLine("Valor inválido.");
                }
                else {
                    break;
                }
            }
            Console.WriteLine($"Números inteiros pares entre 1 e {num}: ");
            for (int i = 0; i < num; i++) {
                if (i % 2 == 0) {
                    Console.Write((i < num - 2) ? i + ", ": i +".");
                }
            }
        }
    }
}
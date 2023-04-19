namespace Exercicio16 {
    internal class Program {
        static void Main(string[] args) {
            int num, produto;

            do {
                Console.Write("Digite um número menor ou igual a 50: ");
                num = int.Parse(Console.ReadLine());
            } while (num < 50);

            for (produto = num; produto < 250; produto *= 3) {
                Console.Write(produto + " ");
            }
        }
    }
}
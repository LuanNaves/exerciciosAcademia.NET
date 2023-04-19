namespace Exercicio13 {
    internal class Program {
        static void Main(string[] args) {
            int soma = 0;
            for (int i = 2; i <= 500; i += 2) {
                soma += i;
            }
            Console.WriteLine(soma);
        }
    }
}
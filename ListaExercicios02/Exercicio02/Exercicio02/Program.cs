namespace Exercicio02 {
    internal class Program {
        static void Main(string[] args) {
            Console.Write("Digite um número: ");
            int num = int.Parse(Console.ReadLine());

            if (num % 2 == 0) {
                Console.WriteLine($"{num} é PAR");
            }
            else {
                Console.WriteLine($"{num} é IMPAR");
            }
        }
    }
}
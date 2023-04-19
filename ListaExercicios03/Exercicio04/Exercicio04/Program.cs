namespace Exercicio04 {
    internal class Program {
        static void Main(string[] args) {

            int x, y, total = 1;

            Console.Write("Digite o valor de x: ");
            x = int.Parse(Console.ReadLine());
            Console.Write("Digite o valor de y: ");
            y = int.Parse(Console.ReadLine());

            for (int i = 0; i < y; i++) {
                total *= x;
            }
            Console.WriteLine($"{x} elevado a {y} é igual a {total}");

        }
    }
}
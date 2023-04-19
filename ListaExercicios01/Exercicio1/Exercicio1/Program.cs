namespace Exercicio1 {
    internal class Program {
        static void Main(string[] args) {

            double num1, num2, media;

            Console.Write("Digite o primeiro número: ");
            num1 = double.Parse(Console.ReadLine());
            Console.Write("Digite o segundo número: ");
            num2 = double.Parse(Console.ReadLine());

            media = (num1 + num2) / 2;

            Console.WriteLine($"A media aritimética entre esses dois valores é {media}");

        }
    }
}
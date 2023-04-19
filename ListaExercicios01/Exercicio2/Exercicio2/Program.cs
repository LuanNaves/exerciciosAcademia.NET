namespace Exercicio2 {
    internal class Program {
        static void Main(string[] args) {

            double num1, num2, num3, num4, media;

            Console.WriteLine("Digite o primeiro número: ");
            num1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo número: ");
            num2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o terceiro número: ");
            num3 = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o quarto número: ");
            num4 = double.Parse(Console.ReadLine());

            media = (num1 + num2 + num3 + num4) / 4;

            Console.WriteLine($"A média aritimética entre esses quatro valores é {media}");
        }
    }
}
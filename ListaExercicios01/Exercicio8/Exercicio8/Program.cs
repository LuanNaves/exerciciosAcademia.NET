namespace Exercicio8 {
    internal class Program {
        static void Main(string[] args) {
            Console.Write("Digite a temperatura em graus C: ");
            double celsius = double.Parse(Console.ReadLine());

            double fahrenheit = 1.8 * celsius + 32;

            Console.WriteLine($"Mesma temperatura em graus F: {fahrenheit}");
        }
    }
}
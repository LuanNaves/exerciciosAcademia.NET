using System.Runtime.Serialization.Formatters;

namespace Exercicio05 {
    internal class Program {
        static void Main(string[] args) {

            int num, resultado = 1;

            Console.Write("Digite um número: ");
            num = int.Parse(Console.ReadLine());

            for (int i = 1; i <= num; i++) {
                resultado *= i;

            }
            Console.WriteLine($"{num}! = {resultado}");
        }
    }
}
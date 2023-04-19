namespace Exercicio18 {
    internal class Program {
        static void Main(string[] args) {
            double a, b, c;

            Console.Write("Digite o primeiro valor: ");
            a = double.Parse(Console.ReadLine());
            Console.Write("Digite o segundo valor: ");
            b = double.Parse(Console.ReadLine());
            Console.Write("Digite o terceiro valor: ");
            c = double.Parse(Console.ReadLine());

            if (a > b && a > c) {
                Console.WriteLine($"O maior número digitado foi o {a}");
            }
            else if (b > a && b > c) {
                Console.WriteLine($"O maior número digitado foi o {b}");
            }
            else if (c > a && c > b) {
                Console.WriteLine($"O maior número digitado foi o {c}");
            }
            else if (a == b && b == c) {
                Console.WriteLine("Os números digitados são iguais");
            }
            else if (a == c && a > b) {
                Console.WriteLine($"O maior número digitado foi o {a}");
            }
            else if (a == b && a > c) {
                Console.WriteLine($"O maior número digitado foi o {a}");
            }
            else {
                Console.WriteLine($"O maior número digitado foi o {b}");
            }
        }
    }
}
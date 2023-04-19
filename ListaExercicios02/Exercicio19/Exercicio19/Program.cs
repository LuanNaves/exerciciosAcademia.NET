namespace Exercicio19 {
    internal class Program {
        static void Main(string[] args) {
            int a, b, c;

            Console.Write("Digite o primeiro valor: ");
            a = int.Parse(Console.ReadLine());
            Console.Write("Digite o segundo valor: ");
            b = int.Parse(Console.ReadLine());
            Console.Write("Digite o terceiro valor: ");
            c = int.Parse(Console.ReadLine());
    
            if (a > b && a > c) {
                if (b > c) {
                    Console.Write($"{c}, ");
                    Console.Write($"{b}, ");
                }
                else if (b < c) {
                    Console.Write($"{b}, ");
                    Console.Write($"{c}, ");
                }
                else {
                    Console.Write($"{b}, ");
                    Console.Write($"{c}, ");
                }
                Console.Write($"{a}");

            }
            else if (b > a && b > c) {
                if (a > c) {
                    Console.Write($"{c}, ");
                    Console.Write($"{a}, ");
                }
                else if (a < c) {
                    Console.Write($"{a}, ");
                    Console.Write($"{c}, ");
                }
                else {
                    Console.Write($"{a}, ");
                    Console.Write($"{c}, ");
                }
                Console.Write($"{b}");

            }
            else if (c > a && c > b) {
                if (a > b) {
                    Console.Write($"{b}, ");
                    Console.Write($"{a}, ");
                }
                else if (a < b) {
                    Console.Write($"{a}, ");
                    Console.Write($"{b}, ");
                }
                else {
                    Console.Write($"{a}, ");
                    Console.Write($"{b}, ");
                }
                Console.Write($"{c}");

            }
            else if (a > b && a == c) {
                Console.Write($"{b}, ");
                Console.Write($"{c}, ");
                Console.Write($"{a}");
            }
            else if (a > c && a == b) {
                Console.Write($"{c}, ");
                Console.Write($"{b}, ");
                Console.Write($"{a}");
            }
            else if (b > a && b == c) {
                Console.Write($"{a}, ");
                Console.Write($"{c}, ");
                Console.Write($"{b}");
            }
            else {
                Console.WriteLine("Todos os números são iguais.");
            }
            
        }
    }
}
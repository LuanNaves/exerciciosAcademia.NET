namespace Exercicio10 {
    internal class Program {
        static void Main(string[] args) {
            Console.Write("Informe a quantia a ser sacada: R$");
            int valor = int.Parse(Console.ReadLine());

            int nota100 = (int) valor / 100;
            valor -= nota100 * 100;

            int nota50 = (int) valor / 50;
            valor -= nota50 * 50;

            int nota20 = (int)valor / 20;
            valor -= nota20 * 20;

            int nota10 = (int)valor / 10;
            valor -= nota10 * 10;

            int nota5 = (int)valor / 5;
            valor -= nota5 * 5;

            int nota2 = (int)valor / 2;
            valor -= nota2 * 2;

            int nota1 = (int)valor / 1;
            valor -= nota1 * 1;

            Console.WriteLine($"{nota100} notas de 100");
            Console.WriteLine($"{nota50} notas de 50");
            Console.WriteLine($"{nota20} notas de 20");
            Console.WriteLine($"{nota10} notas de 10");
            Console.WriteLine($"{nota5} notas de 5");
            Console.WriteLine($"{nota2} notas de 2");
            Console.WriteLine($"{nota1} notas de 1");
        }
    }
}
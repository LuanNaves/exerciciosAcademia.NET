namespace Exercicio3 {
    internal class Program {
        static void Main(string[] args) {

            double x, y, aux;
            x = 10;
            y = 5;

            Console.WriteLine($"Valores:\nX = {x}\nY = {y}");

            aux = x;
            x = y;
            y = aux;

            Console.WriteLine($"Valores invertidos:\nX = {x}\nY = {y}");

        }
    }
}
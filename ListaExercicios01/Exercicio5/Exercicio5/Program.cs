namespace Exercicio5 {
    internal class Program {
        static void Main(string[] args) {

            Console.Write("Distancia total percorrida (em Km): ");
            double distancia = double.Parse(Console.ReadLine());
            Console.Write("Volume de combustivel consumido para percorre-la (em litros): ");
            double litros = double.Parse(Console.ReadLine());

            double consumoMedio = distancia / litros;

            Console.WriteLine($"Consumo medio do automovel: {consumoMedio}");
        }
    }
}
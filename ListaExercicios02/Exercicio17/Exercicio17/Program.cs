namespace Exercicio17 {
    internal class Program {
        static void Main(string[] args) {
            double lado1, lado2, lado3;

            Console.Write("Digite o primeiro número: ");
            lado1 = double.Parse(Console.ReadLine());
            Console.Write("Digite o segundo número: ");
            lado2 = double.Parse(Console.ReadLine());
            Console.Write("Digite o terceiro número: ");
            lado3 = double.Parse(Console.ReadLine());

            string tipoTriangulo;

            if ((lado1 <= lado3 + lado2) && (lado2 <= lado1 + lado3) && (lado3 <= lado1 + lado2)) {
                if (lado1 == lado2 && lado3 == lado1) {
                    tipoTriangulo = "Equilátero";
                }
                else if ((lado1 == lado2) || (lado2 == lado3) || (lado1 == lado3)) {
                    tipoTriangulo = "Isóceles";
                }
                else {
                    tipoTriangulo = "Escaleno";
                }
                Console.WriteLine($"Esses três números formam um triângulo {tipoTriangulo}");
            }
            else {
                Console.WriteLine("Esses três números não formam um triângulo.");
            }
        }
    }
}
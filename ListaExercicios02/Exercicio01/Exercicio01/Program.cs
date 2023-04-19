namespace Exercicio01 {
    internal class Program {
        static void Main(string[] args) {

            double baseTriangulo, alturaTriangulo, areaTriangulo;

            Console.Write("Informe a base do triângulo: ");
            baseTriangulo = double.Parse(Console.ReadLine());
            if (baseTriangulo == 0) {
                Console.WriteLine("Base inválida.");
            }
            else {
                Console.Write("Informe a altura do triângulo: ");
                alturaTriangulo = double.Parse(Console.ReadLine());
                if (alturaTriangulo == 0) {
                    Console.WriteLine("Altura inválida.");
                }
                else {
                    areaTriangulo = (baseTriangulo * alturaTriangulo) / 2;
                    Console.WriteLine($"Área do triângulo: {areaTriangulo}");
                }
            }
        }
    }
}
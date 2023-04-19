namespace Exercicio18 {
    internal class Program {
        static void Main(string[] args) {
            double baseNum, expoenteNum, resultado;

            Console.Write("Digite a base: ");
            baseNum = double.Parse(Console.ReadLine());

            Console.Write("Digite o expoente: ");
            expoenteNum = double.Parse(Console.ReadLine());

            resultado = Math.Pow(baseNum, expoenteNum);

            Console.WriteLine($"Resultado: {resultado}");

        }
    }
}
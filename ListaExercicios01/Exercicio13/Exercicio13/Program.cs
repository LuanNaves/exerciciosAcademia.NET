namespace Exercicio13 {
    internal class Program {
        static void Main(string[] args) {

            Console.Write("Valor do salario mínimo: R$");
            double salarioMínimo = double.Parse(Console.ReadLine());
            Console.Write("Preço de custo de cada bicicleta: R$");
            double precoCustoBicicleta = double.Parse(Console.ReadLine());
            Console.Write("Número de bicicletas vendidas: ");
            int bicicletasVendidas = int.Parse(Console.ReadLine());

            double salarioDoEmpregado = salarioMínimo * 2 + (precoCustoBicicleta * bicicletasVendidas) * 0.15;

            Console.WriteLine($"Sálario total do empregado: R${salarioDoEmpregado:F2}");
        }
    }
}
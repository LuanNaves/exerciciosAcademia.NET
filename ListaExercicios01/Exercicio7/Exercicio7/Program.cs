namespace Exercicio7 {
    internal class Program {
        static void Main(string[] args) {

            Console.WriteLine("Dados do vendedor");
            Console.Write("Numero: ");
            int numero = int.Parse(Console.ReadLine());
            Console.Write("Salario fixo: ");
            int salarioFixo = int.Parse(Console.ReadLine());
            Console.Write("Total de vendas efetuadas: ");
            double totalVendas = double.Parse(Console.ReadLine());
            Console.Write("Percentual sobre o total de vendas (%): ");
            double percentualSobreVendas = double.Parse(Console.ReadLine());

            double salarioTotal = salarioFixo + totalVendas * (percentualSobreVendas / 100);

            Console.WriteLine();
            Console.WriteLine($"Vendedor do numero {numero}\nSalario total: {salarioTotal}");

        }
    }
}
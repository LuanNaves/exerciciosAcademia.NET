namespace Exercicio08 {
    internal class Program {
        static void Main(string[] args) {

            Console.Write("Código do funcionário: ");
            int codigo = int.Parse(Console.ReadLine());
            Console.Write("Nome: ");
            string nome = Console.ReadLine();
            Console.Write("Salário base: R$");
            double salarioBase = double.Parse(Console.ReadLine());
            Console.Write("Total de vendas: R$");
            double totalVendas = double.Parse(Console.ReadLine());

            double comissao, comissaoPorcentagem;

            if (totalVendas > 500 && totalVendas <= 1000) {
                comissaoPorcentagem = 0.05;
            }
            else if (totalVendas > 1000 && totalVendas <= 5000) {
                comissaoPorcentagem = 0.07;
            }
            else if (totalVendas > 5000) {
                comissaoPorcentagem = 0.10;
            }
            else {
                comissaoPorcentagem = 0;
            }
            comissao = totalVendas * comissaoPorcentagem;
            double salarioNovo = salarioBase + comissao;

            Console.WriteLine();
            Console.WriteLine($"Salário base: R${salarioBase:F2}" +
                        $"\nComissão em reais: R${comissao:F2}" +
                        $"\nSalário novo: R${salarioNovo:F2}");

        }
    }
}
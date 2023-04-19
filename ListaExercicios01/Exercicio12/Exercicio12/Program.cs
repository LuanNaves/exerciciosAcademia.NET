namespace Exercicio12 {
    internal class Program {
        static void Main(string[] args) {

            double preçoCombustivel = 6.90;

            Console.Write("Marcação inicial do odômetro: ");
            int odometroInicio = int.Parse(Console.ReadLine());
            Console.Write("Marcação final do odômetro: ");
            int odometroFinal = int.Parse(Console.ReadLine());
            Console.Write("Quantidade de combustível gasto (em litros): ");
            double litrosGastos =  double.Parse(Console.ReadLine());
            Console.Write("Valor total recebido dos passageiros: R$");
            double valorRecebido = double.Parse(Console.ReadLine());

            int totalKm = odometroFinal - odometroInicio;
            double mediaConsumo = totalKm / litrosGastos;
            double lucroDoDia = valorRecebido - (litrosGastos * preçoCombustivel);

            Console.WriteLine();
            Console.WriteLine($"Média de consumo: {mediaConsumo}Km/l");
            Console.WriteLine($"Lucro líquido do dia: R${lucroDoDia:F2}");
        }
    }
}
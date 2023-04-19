namespace Exercicio15 {
    internal class Program {
        static void Main(string[] args) {

            Console.Write("Qual o tamanho da área a ser pintada, em metros quadrados: ");
            double area = double.Parse(Console.ReadLine());

            double litrosTinta = area / 3;
            double latasTinta = Math.Ceiling(litrosTinta / 18);
            double preçoTotal = latasTinta * 80;

            Console.WriteLine($"Será preciso comprar {latasTinta} latas de tintas.");
            Console.WriteLine($"Valor total: R${preçoTotal:F2}");
        }
    }
}
namespace Exercicio9 {
    internal class Program {
        static void Main(string[] args) {

            Console.Write("Valor da mercadoria: R$");
            double valorMercadoria = double.Parse(Console.ReadLine());

            double entrada, prestação, resto;

            resto = valorMercadoria % 3;
            entrada = (valorMercadoria - resto) / 3 + resto;
            prestação = (valorMercadoria - resto) / 3;

            Console.WriteLine($"Valor da entrada: R${entrada:F2}");
            Console.WriteLine($"Valor da prestação: R${prestação:F2}");

        }
    }
}
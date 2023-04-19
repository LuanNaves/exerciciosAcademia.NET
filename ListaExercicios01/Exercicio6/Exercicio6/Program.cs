namespace Exercicio6 {
    internal class Program {
        static void Main(string[] args) {

            Console.WriteLine("Digite os dados do Parafuso A");
            Console.Write("Código: ");
            int codigoA = int.Parse(Console.ReadLine());
            Console.Write("Quantidade de peças: ");
            int quantidadeA = int.Parse(Console.ReadLine());
            Console.Write("Valor unitário: ");
            double precoA = double.Parse(Console.ReadLine());
            Console.Write("Porcentagem de IPI (unica) a ser acrescentada: ");
            double ipiA = double.Parse(Console.ReadLine());


            Console.WriteLine("Digite os dados do Parafuso B");
            Console.Write("Código: ");
            int codigoB = int.Parse(Console.ReadLine());
            Console.Write("Quantidade de peças: ");
            int quantidadeB = int.Parse(Console.ReadLine());
            Console.Write("Valor unitário: ");
            double precoB = double.Parse(Console.ReadLine());
            Console.Write("Porcentagem de IPI (unica) a ser acrescentada: ");
            double ipiB = double.Parse(Console.ReadLine());

        }
    }
}
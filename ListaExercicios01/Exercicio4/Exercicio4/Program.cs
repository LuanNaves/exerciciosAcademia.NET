namespace Exercicio4 {
    internal class Program {
        static void Main(string[] args) {

            int dia, mes, ano;

            Console.Write("Digite a data no formato DDMMAAAA: ");
            string data = Console.ReadLine();

            dia = int.Parse(data.Substring(0, 2));
            mes = int.Parse(data.Substring(2, 2));
            ano = int.Parse(data.Substring(4, 4));

            Console.WriteLine($"Data no formato AAAAMMDD: {ano}{mes.ToString("D2")}{dia}");


            Console.WriteLine($"Data no formato AAMMDD: {ano.ToString().Substring(2)}{mes.ToString("D2")}{dia}");

        }
    }
}
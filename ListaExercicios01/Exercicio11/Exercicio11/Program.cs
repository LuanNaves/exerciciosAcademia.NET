namespace Exercicio11 {
    internal class Program {
        static void Main(string[] args) {
            Console.Write("Número de eleitores do município: ");
            int eleitores = int.Parse(Console.ReadLine());
            Console.Write("Votos nulos: ");
            int nulos = int.Parse(Console.ReadLine());
            Console.Write("Votos brancos: ");
            int brancos = int.Parse(Console.ReadLine());
            Console.Write("Votos válidos: ");
            int validos = int.Parse(Console.ReadLine());

            double porcentagemNulo = (nulos * 100) / eleitores;
            double porcentagemBrancos = (brancos * 100) / eleitores;
            double porcentagemValidos = (validos * 100) / eleitores;

            Console.WriteLine("Com relação ao total de eleitores desse municipio, podemos dizer que: ");
            Console.WriteLine($"{porcentagemNulo}% dos votos foram nulos;");
            Console.WriteLine($"{porcentagemBrancos}% dos votos foram brancos;");
            Console.WriteLine($"{porcentagemValidos}% dos votos foram válidos;");
        }
    }
}
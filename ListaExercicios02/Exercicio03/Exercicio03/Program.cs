namespace Exercicio03 {
    internal class Program {
        static void Main(string[] args) {

            double nota1, nota2, nota3, nota4, media;

            Console.Write("Insira a primeira nota: ");
            nota1 = double.Parse(Console.ReadLine());
            Console.Write("Insira a segunda nota: ");
            nota2 = double.Parse(Console.ReadLine());
            Console.Write("Insira a terceira nota: ");
            nota3 = double.Parse(Console.ReadLine());
            Console.Write("Insira a quarta nota: ");
            nota4 = double.Parse(Console.ReadLine());

            media = (nota1 + nota2 + nota3 + nota4) / 4;
            Console.WriteLine($"Média: {media}");

            Console.WriteLine("Notas maiores que a media: ");
            if (nota1 > media) {
                Console.WriteLine("Primeira");
            }
            if (nota2 > media) {
                Console.WriteLine("Segunda");
            }
            if (nota3 > media) {
                Console.WriteLine("Terceira");
            }
            if (nota4 > media) {
                Console.WriteLine("Quarta");
            }
        }
    }
}
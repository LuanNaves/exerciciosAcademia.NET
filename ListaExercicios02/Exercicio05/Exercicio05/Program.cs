namespace Exercicio05 {
    internal class Program {
        static void Main(string[] args) {

            double primeiraNota, segundaNota, media;

            Console.Write("Primeira nota: ");
            primeiraNota = double.Parse(Console.ReadLine());
            Console.Write("Segunda nota: ");
            segundaNota = double.Parse(Console.ReadLine());

            media = (primeiraNota + segundaNota) / 2;

            if (media < 7) {
                Console.Write("Nota do exame: ");
                double notaExame = double.Parse(Console.ReadLine());

                double mediaFinal = (notaExame + media) / 2;

                if (mediaFinal < 7) {
                    Console.WriteLine("Reprovado!");
                }
                else {
                    Console.WriteLine("Aprovado!");
                }
            }
            else {
                Console.WriteLine("Aprovado!");
            }
        }
    }
}
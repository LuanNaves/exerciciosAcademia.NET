namespace Exercicio07 {
    internal class Program {
        static void Main(string[] args) {

            string frase, palavra;

            Console.WriteLine("Escreva uma frase qualquer: ");
            frase = Console.ReadLine();
            Console.Write("Qual palavra deseja pesquisar na frase: ");
            palavra = Console.ReadLine();

            if (frase.Contains(palavra)) {
                Console.WriteLine($"A palavra {palavra} se encontra na frase.");
            }
            else {
                Console.WriteLine($"A palavra {palavra} não se encontra na frase.");
            }
        }
    }
}
namespace Exercicio20 {
    internal class Program {
        static void Main(string[] args) {

            int jogador, computador;
            Random aleatorio = new Random();
            computador = aleatorio.Next(0, 10);

            Console.WriteLine("Advinhe o número!");
            for (int i = 3; i > 0; i--) {
                Console.WriteLine($"Você tem {i} tentativas");
                Console.Write("Qual o seu palpite? ");
                jogador = int.Parse( Console.ReadLine());
                if (jogador > computador ) {
                    if (i == 1) {
                        Console.WriteLine($"Você perdeu! O número certo era {computador}.");
                    }
                    else {
                        Console.WriteLine("Menos...");
                    }
                }
                else if (jogador < computador) {
                    if (i == 1) {
                        Console.WriteLine($"Você perdeu! O número certo era {computador}.");
                    }
                    else {
                        Console.WriteLine("Mais...");
                    }
                }
                else {
                    Console.WriteLine("Você acertou!");
                    break;
                }

            }
        }
    }
}
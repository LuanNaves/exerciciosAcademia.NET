namespace Exercicio13 {
    internal class Program {
        static void Main(string[] args) {
            int[] vetor = new int[100];
            Random indices = new Random();
            int existe2 = 0, existe4 = 0, existe8 = 0;

            Console.WriteLine("Criando um vetor aleatorio...");
            Console.Write("|");
            for (int i = 0; i < vetor.Length; i++) {
                vetor[i] = indices.Next(-1, 100);
                Console.Write(vetor[i] + "|");
                if (vetor[i] == -1) {
                    break;
                }
            }
            Console.WriteLine();
            for (int i = 0; i < vetor.Length; i++) {
                if (vetor[i] == -1) {
                    break;
                }
                if (vetor[i] == 2) {
                    existe2++;
                }
                else if (vetor[i] == 4) {
                    existe4++;
                }
                else if (vetor[i] == 8) {
                    existe8++;
                }
            }
            if (existe2 == 0) {
                Console.WriteLine("O vetor criado não possui o número dois.");
            }
            else {
                Console.WriteLine($"O vetor criado possui o número dois {existe2} vezes");
            }
            if (existe4 == 0) {
                Console.WriteLine("O vetor criado não possui o número quatro.");
            }
            else {
                Console.WriteLine($"O vetor criado possui o número quatro {existe4} vezes");
            }
            if (existe8 == 0) {
                Console.WriteLine("O vetor criado não possui o número oito.");
            }
            else {
                Console.WriteLine($"O vetor criado possui o número oito {existe8} vezes");
            }
        }
    }
}
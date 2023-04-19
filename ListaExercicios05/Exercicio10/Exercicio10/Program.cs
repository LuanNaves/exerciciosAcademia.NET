namespace Exercicio10 {
    internal class Program {
        static void Main(string[] args) {
            int[] vetor = new int[20];
            int[] vetor2 = new int[20];

            for (int i = 0; i < vetor.Length; i++) {
                Console.Write($"Digite o {i + 1}º elemento do vetor: ");
                vetor[i] = int.Parse(Console.ReadLine());
                if (vetor[i] == 0) {
                    vetor2[i] = 2;
                }
                else {
                    vetor2[i] = vetor[i];
                }
            }
            Console.WriteLine("Vetor lido: ");
            for (int i = 0; i < vetor.Length; i++) {
                Console.Write(vetor[i] + " ");
            }
            Console.WriteLine();
            Console.WriteLine("Vetor resultado: ");
            for (int i = 0; i < vetor2.Length; i++) {
                Console.Write(vetor2[i] + " ");
            }
        }
    }
}
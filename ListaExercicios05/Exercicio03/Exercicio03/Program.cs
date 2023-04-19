namespace Exercicio03 {
    internal class Program {
        static void Main(string[] args) {
            int[] vetor = new int[10];
            bool ePrimo = false;

            for (int i = 0; i < vetor.Length; i++) {
                vetor[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0;i < vetor.Length;i++) {
                if (vetor[i] > 1) {
                    ePrimo = true;

                    for (int j = 2; j <= Math.Sqrt(vetor[i]); j++) {
                        if (vetor[i] % j == 0) {
                            ePrimo = false;
                            break;
                        }
                    }
                }

                if (ePrimo) {
                    Console.Write(vetor[i] + " ");
                }
            }
        }
    }
}
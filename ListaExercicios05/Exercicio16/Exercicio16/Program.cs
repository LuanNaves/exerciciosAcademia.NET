namespace Exercicio16 {
    internal class Program {
        static void Main(string[] args) {
            int[] vetorX = new int[10];
            int[] vetorY = new int[10];
            int[] uniao = new int[10];
            int[] diferenca = new int[10];
            int[] intercecao = new int[10];

            for (int i = 0; i < vetorX.Length; i++) {
                Console.Write($"VetorX {i}º elemento: ");
                vetorX[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < vetorY.Length; i++) {
                Console.Write($"VetorY {i}º elemento: ");
                vetorY[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < vetorX.Length; i++) {
                for (int j = 0; j < vetorY.Length; j++) {
                    if (vetorX[i] == vetorY[j]) { }
                }
            }


        }
    }
}
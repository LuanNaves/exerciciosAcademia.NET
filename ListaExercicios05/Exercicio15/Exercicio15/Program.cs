namespace Exercicio15 {
    internal class Program {
        static void Main(string[] args) {
            int[] numeros = new int[20];
            int[] inversa = new int[20];
            Random random = new Random();
            int aux = numeros.Length - 1;

            for (int i = 0; i < numeros.Length; i++) {
                numeros[i] = random.Next(1, 10);
                inversa[aux] = numeros[i];
                aux--;
            }
            Console.Write("Ordem normal:  | ");
            for (int i = 0; i < numeros.Length; i++) {
                Console.Write(numeros[i] + " | ");
            }
            Console.WriteLine();
            Console.Write("Ordem inversa: | ");
            for (int i = 0; i < inversa.Length; i++) {
                Console.Write(inversa[i] + " | ");
            }
        }
    }
}
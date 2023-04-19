namespace Exercicio06 {
    internal class Program {
        static void Main(string[] args) {
            int[] numeros = new int[10];
            int[] inversa = new int[10];
            int aux = 0;

            for (int i = 0; i < numeros.Length; i++) {
                Console.Write($"Insira o {i + 1}º valor: ");
                numeros[i] = int.Parse(Console.ReadLine());
            }


            Console.Write("Ordem inversa: | ");
            for (int i = numeros.Length - 1; i >= 0; i--) {
                inversa[aux] = numeros[i];
                Console.Write(inversa[aux] + " | ");
                aux++;
            }
        }
    }
}
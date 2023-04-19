namespace Exercicio07 {
    internal class Program {
        static void Main(string[] args) {
            int[] numeros = new int[10];

            for (int i = 0; i < numeros.Length; i++) {
                Console.Write($"Insira o {i + 1}º valor: ");
                numeros[i] = int.Parse(Console.ReadLine());
            }

            Console.Write("|");
            for (int i = 0; i < numeros.Length;i++) {
                if (numeros[i] % 2 == 0) {
                    Console.Write(numeros[i] + "|");
                }
            }
            for (int i = 0; i < numeros.Length; i++) { 
            if (numeros[i] % 2 != 0) {
                    Console.Write(numeros[i] + "|");
                } 
            }
        }
    }
}
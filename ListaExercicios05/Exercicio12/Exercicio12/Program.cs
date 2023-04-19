namespace Exercicio12 {
    internal class Program {
        static void Main(string[] args) {
            int[] vetor = new int[10];
            Random indices = new Random();
            int num;
            bool existe = false;

            Console.WriteLine("Criando um vetor aleatorio...");
            for (int i = 0; i < vetor.Length; i++) {
                vetor[i] = indices.Next(0, 10);
            }
            Console.Write("Digite um número de 0 a 10: ");
            num = int.Parse(Console.ReadLine());
            for (int i = 0; i < vetor.Length; i++ ) {
                if (num == vetor[i]) {
                    existe = true;
                }
            }
            if (existe) {
                Console.Write("O número digitado existe no vetor, na(s) posição(ões): ");
                for (int i = 0; i < vetor.Length; i++) {
                    if (num == vetor[i]) {
                        Console.Write(i + " ");
                    }
                }
            }
            else {
                Console.WriteLine("O número digitado não existe no vetor.");
            }

        }
    }
}
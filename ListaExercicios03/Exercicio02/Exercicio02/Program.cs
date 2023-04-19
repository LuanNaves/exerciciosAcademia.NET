namespace Exercicio02 {
    internal class Program {
        static void Main(string[] args) {

            int num, maior = 0;

            for (int i = 0; i < 10; i++) {
                Console.Write("Digite um número: ");
                num = int.Parse(Console.ReadLine());

                if (i == 0) { 
                    maior = num;
                }
                else if (num > maior) {
                    maior = num;
                }
            }
            Console.WriteLine($"O maior número digitado foi {maior}");

        }
    }
}
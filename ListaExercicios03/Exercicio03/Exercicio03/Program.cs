namespace Exercicio03 {
    internal class Program {
        static void Main(string[] args) {

            int num;

            Console.Write("Digite o número que deseja ver a tabuada: ");
            num = int.Parse(Console.ReadLine());

            Console.WriteLine("---------------");
            Console.WriteLine($" TABUADA DO {num}");
            Console.WriteLine("---------------");
            for (int i = 1; i <= 10; i++) {
                Console.WriteLine($"{i} x {num} = {i * num}");
            }
        }
    }
}
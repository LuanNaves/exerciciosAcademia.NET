namespace Exercicio03 {
    internal class Program {
        static void Main(string[] args) {
            int num;
            bool primo = false;
                                        
            for (; ; ) {
                Console.Write("Digite um número (0 para parar): ");
                num = int.Parse(Console.ReadLine());
                if (num != 0) {
                    if (num % 2 == 0) {
                        Console.Write("O número digitado é par ");
                    }
                    else {
                        Console.Write("O número digitado é impar ");
                    }
                    if (num > 1) {
                        primo = true;
                        for (int i = 2; i <= Math.Sqrt(num); i++) {
                            if (num % i == 0) {
                                primo = false;
                                break;
                            }
                        }
                    }
                    if (primo) {
                        Console.WriteLine("e primo.");
                    }
                    else {
                        Console.WriteLine("e não é primo.");
                    }
                }
                else {
                    break;
                }
            }
        }
    }
}
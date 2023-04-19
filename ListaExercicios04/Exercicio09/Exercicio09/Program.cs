namespace Exercicio09 {
    internal class Program {
        static void Main(string[] args) {
            int filhos, total1a3 = 0, total4a7 = 0, totalMaisDe8 = 0, totalSemFilhos = 0;
            for (int i = 0; i < 30; i++) {
                while (true) {
                    Console.Write("Quantos filhos você tem? ");
                    
                    filhos = int.Parse(Console.ReadLine());
                    if (filhos == 0) {
                        totalSemFilhos++;
                        break;
                    }
                    else if (filhos >= 1 && filhos <= 3) {
                        total1a3++;
                        break;
                    }
                    else if (filhos >= 4 && filhos <= 7) {
                        total4a7++;
                        break;
                    }
                    else if (filhos > 7) {
                        totalMaisDe8++;
                        break;
                    }
                    else {
                        Console.WriteLine("Insira um valor válido");
                    }
                }
            }
            Console.WriteLine($"{total1a3} pessoas tem entre 1 e 3 filhos.");
            Console.WriteLine($"{total4a7} pessoas tem entre 4 e 7 filhos.");
            Console.WriteLine($"{totalMaisDe8} pessoas tem 8 ou mais filhos.");
            Console.WriteLine($"{totalSemFilhos} pessoas não tem filhos.");
        }
    }
}
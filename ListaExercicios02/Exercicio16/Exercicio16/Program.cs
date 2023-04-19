using System.Threading.Channels;

namespace Exercicio16 {
    internal class Program {
        static void Main(string[] args) {
            Console.Write("Informe o placar do jogo: ");
            string placar = Console.ReadLine();

            int timeCasa = int.Parse(placar.Substring(0, 1));
            int timeFora = int.Parse(placar.Substring(4, 1));

            if (timeFora >= timeCasa + 2) {
                Console.WriteLine("O time de fora já se classificou.");
            }
            else {
                Console.WriteLine("Os dois times se enfrentarão em um novo jogo");
                Console.Write("Informe o placar do segundo jogo: ");
                placar = Console.ReadLine();

                timeCasa += int.Parse(placar.Substring(0, 1));
                timeFora += int.Parse(placar.Substring(4, 1));

                if (timeFora > timeCasa) {
                    Console.WriteLine("O time de fora ganhou e se classificou para a próxima fase.");
                }
                else if (timeFora < timeCasa) {
                    Console.WriteLine("O time da casa ganhou e se classificou para a próxima fase.");
                }
                else {
                    Console.WriteLine("Houve um empate.");
                }

            }


        }
    }
}
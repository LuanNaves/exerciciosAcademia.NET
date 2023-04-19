namespace Exercicio05 {
    internal class Program {
        static void Main(string[] args) {
            int somaZeca = 0, somaJoao = 0, somaBranco = 0, somaNulos = 0, totalPessoas = 0;
            string voto, vencedor;

            for (; ; ) {
                Console.WriteLine();
                Console.WriteLine("Informe seu voto ZECA, JOAO ou BRANCO (FIM para encerrar a votação)");
                voto = Console.ReadLine().ToUpper();
                if (voto == "ZECA") {
                    somaZeca++;
                }
                else if (voto == "JOAO") {
                    somaJoao++;
                }
                else if (voto == "BRANCO") {
                    somaBranco++;
                }
                else if (voto == "FIM") {
                    break;
                }
                else {
                    somaNulos++;
                }
                totalPessoas++;
            }
            if (somaZeca > somaJoao) {
                vencedor = "ZECA";
            }
            else if (somaJoao > somaZeca) {
                vencedor = "JOAO";
            }
            else {
                vencedor = "EMPATE";
            }

            Console.WriteLine();
            Console.WriteLine($"{totalPessoas} pessoas votaram, mas {somaNulos} foram nulos");
            Console.WriteLine();
            Console.WriteLine("Apuração dos votos: ");
            Console.WriteLine($"ZECA = {somaZeca}");
            Console.WriteLine($"JOAO = {somaJoao}");
            Console.WriteLine($"BRANCO = {somaBranco}");
            Console.WriteLine();
            Console.WriteLine($"CADIDATO VENCEDOR = {vencedor} ");
        }
    }
}
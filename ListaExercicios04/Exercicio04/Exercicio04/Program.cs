namespace Exercicio04 {
    internal class Program {
        static void Main(string[] args) {
            int somaZeca = 0, somaJoao = 0, somaBranco = 0;
            string voto;

            for(; ; ) {
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
                    Console.WriteLine("Valor inválido.");
                }
                
            }
            Console.WriteLine();
            Console.WriteLine("Apuração dos votos: ");
            Console.WriteLine($"ZECA = {somaZeca}");
            Console.WriteLine($"JOAO = {somaJoao}");
            Console.WriteLine($"BRANCO = {somaBranco}");
        }
    }
}
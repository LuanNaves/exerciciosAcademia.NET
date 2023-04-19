namespace Exercicio14 {
    internal class Program {
        static void Main(string[] args) {
            Console.Write("Tamanho do arquivo para download (em Mb): ");
            double arquivo = double.Parse(Console.ReadLine());
            Console.Write("Velocidade do link de internet (em Mbps): ");
            int internetVel = int.Parse(Console.ReadLine());

            double tempoSeg = (arquivo * 8) / internetVel; // convertendo o arquivo em megabyte para megabit
            double tempoMin = tempoSeg / 60;

            Console.WriteLine($"Tempo aproximado de download: {tempoMin:F2} minutos");
        }
    }
}
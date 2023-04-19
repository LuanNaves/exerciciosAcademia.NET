namespace Exercicio10 {
    internal class Program {
        static void Main(string[] args) {
            Console.WriteLine("Dados do primeiro atleta");
            Console.Write("Nome: ");
            string nome1 = Console.ReadLine();
            Console.Write("Idade: ");
            int idade1 = int.Parse(Console.ReadLine());
            Console.Write("Altura: ");
            double altura1 = double.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("Dados do segundo atleta");
            Console.Write("Nome: ");
            string nome2 = Console.ReadLine();
            Console.Write("Idade: ");
            int idade2 = int.Parse(Console.ReadLine());
            Console.Write("Altura: ");
            double altura2 = double.Parse(Console.ReadLine());
            Console.WriteLine();
            
            if (idade1 < idade2 && altura1 > altura2) {
                Console.WriteLine("Atleta mais novo e mais alto: ");
                Console.WriteLine($"Nome: {nome1}\n" +
                                  $"Idade: {idade1}\n" +
                                  $"Altura: {altura1}");
            }
            else if (idade2 < idade1 && altura2 > altura1) {
                Console.WriteLine("Atleta mais novo e mais alto: ");
                Console.WriteLine($"Nome: {nome2}\n" +
                                  $"Idade: {idade2}\n" +
                                  $"Altura: {altura2}");
            }
            else {
                Console.WriteLine("O aluno mais novo não é o mais alto.");
            }
        }
    }
}
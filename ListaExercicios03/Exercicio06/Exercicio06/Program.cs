namespace Exercicio06 {
    internal class Program {
        static void Main(string[] args) {
            int alunos, avaliacoes;

            Console.Write("Quantidade de alunos na turma: ");
            alunos = int.Parse(Console.ReadLine());
            Console.Write("Quantidade de avaliações aplicadas para esse turma: ");
            avaliacoes = int.Parse(Console.ReadLine());

            double nota, soma = 0, media;
            for (int i = 1; i <= alunos; i++) {
                Console.WriteLine($"Aluno {i}");
                for (int j = 1; j <= avaliacoes; j++) {
                    Console.Write($"Nota da {j}ª avaliação: ");
                    nota = double.Parse(Console.ReadLine());
                    soma += nota;
                }
                media = soma / avaliacoes;
                soma = 0;
                Console.WriteLine($"Nota final: {media:F2}");
            }
        }
    }
}
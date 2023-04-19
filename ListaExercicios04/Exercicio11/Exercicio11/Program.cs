namespace Exercicio11 {
    internal class Program {
        static void Main(string[] args) {
            double nota, somaNotas = 0, media, maiorNota = 0, menorNota = 0;
            int quantidadeAlunos = 0, contador = 1;
            do {
                Console.Write($"Nota do {contador}° aluno: ");
                nota = double.Parse(Console.ReadLine());
                if (nota == -1) {
                    break;
                }
                if (contador == 1) {
                    maiorNota = menorNota = nota;
                }
                else if (nota > maiorNota) {
                    maiorNota = nota;
                }
                else if (nota < menorNota) {
                    menorNota = nota;
                }
                quantidadeAlunos++;
                contador++;
                somaNotas += nota;
            } while (true);
            media = somaNotas / quantidadeAlunos;
            Console.WriteLine($"Menor nota da turma: {menorNota}");
            Console.WriteLine($"Maior nota da turma: {maiorNota}");
            Console.WriteLine($"Quantidade de alunos na turma: {quantidadeAlunos}");
            Console.WriteLine($"Média da turma: {media}");
        }
    }
}
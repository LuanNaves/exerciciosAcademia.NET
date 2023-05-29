namespace ExercicioArquivoPOO {
    internal class Program {
        static void Main(string[] args) {
            List<Pessoa> listaPessoas = new List<Pessoa>();
            string nomeArquivo = "D:\\Codiguinhos - Luan\\Academia.NET\\Exercícios\\ExercicioArquivoPOO\\ExercicioArquivoPOO\\ExercicioArquivoPOO\\dados.dat";
            Persistencia.popularArquivoLista(nomeArquivo, listaPessoas);

            int op;
            Console.WriteLine("1 - Cadastrar pessoa\n" +
                              "2 - Listar pessoas\n" +
                              "3 - Pesquisar pessoa\n" +
                              "4 - Excluir pessoa\n" +
                              "5 - Sair");
            Console.Write("Opção: ");
            op = int.Parse(Console.ReadLine());

            switch (op) {
                case 1:
                    Console.WriteLine("Cadastrando Pessoa");
                    Crud.cadastrar(listaPessoas, nomeArquivo);
                    break;
                case 2:
                    Console.WriteLine("Listando Pessoas");
                    Crud.exibirLista(listaPessoas);
                    break;
                case 3:
                    Console.WriteLine("Pesquisando Pessoa");
                    Crud.pesquisar(listaPessoas);
                    break;
                case 4:
                    break;
                case 5:
                    break;
                default:
                    break;
            }

        }
    }
}
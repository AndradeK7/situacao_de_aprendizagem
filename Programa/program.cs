using System;
using Layout;
using GerenciarTarefa;

class Program
{
    static void Main()
    {
        Gerenciador gerenciador = new Gerenciador();
        int opcao;

        do
        {
            Formatacao.ImprimirCabecalho();
            Console.WriteLine("1 - Adicionar Tarefa");
            Console.WriteLine("2 - Listar Tarefas");
            Console.WriteLine("3 - Concluir Tarefa");
            Console.WriteLine("4 - Remover Tarefa");
            Console.WriteLine("0 - Sair");
            Console.Write("Escolha uma opção: ");
            opcao = int.Parse(Console.ReadLine());

            switch (opcao)
            {
                case 1:
                    Console.Write("Descrição da tarefa: ");
                    string descricao = Console.ReadLine();
                    gerenciador.AdicionarTarefa(descricao);
                    break;
                case 2:
                    gerenciador.ListarTarefas();
                    break;
                case 3:
                    Console.Write("ID da tarefa a concluir: ");
                    int idConcluir = int.Parse(Console.ReadLine());
                    gerenciador.ConcluirTarefa(idConcluir);
                    break;
                case 4:
                    Console.Write("ID da tarefa a remover: ");
                    int idRemover = int.Parse(Console.ReadLine());
                    gerenciador.RemoverTarefa(idRemover);
                    break;
            }
        } while (opcao != 0);
    }
}

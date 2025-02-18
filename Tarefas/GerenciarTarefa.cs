namespace GerenciarTarefa
{
    using Tarefas;
    using System.Collections.Generic;

    public class Gerenciador
    {
        private List<Tarefa> tarefas = new List<Tarefa>();
        private int proximoId = 1;

        public void AdicionarTarefa(string descricao)
        {
            tarefas.Add(new Tarefa(proximoId++, descricao));
        }

        public void ListarTarefas()
        {
            foreach (var tarefa in tarefas)
            {
                tarefa.ExibirTarefa();
            }
        }

        public void ConcluirTarefa(int id)
        {
            var tarefa = tarefas.Find(t => t.Id == id);
            if (tarefa != null)
                tarefa.Concluida = true;
        }

        public void RemoverTarefa(int id)
        {
            tarefas.RemoveAll(t => t.Id == id);
        }
    }
}

// Arquivo principal que executa o programa
using System;
using Layout;
using GerenciarTarefa;

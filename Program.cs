using System;
using System.Collections.Generic;

enum UserChoice
{
    AddTask = 1,
    RemoveTask = 2,
    UpdateTask = 3,
    Exit = 4,
}

class Program
{
    static void Main(string[] args)
    {
        List<string> toDoList = new List<string>();

        while (true)
        {
            Console.WriteLine("1. Adicionar Tarefa");
            Console.WriteLine("2. Remover Tarefa");
            Console.WriteLine("3. Atualizar Tarefa");
            Console.WriteLine("4. Sair");

            int choice = int.Parse(Console.ReadLine());

            switch ((UserChoice)choice)
            {
                case UserChoice.AddTask:
                    Console.WriteLine("Insira a tarefa: ");
                    string task = Console.ReadLine();
                    toDoList.Add(task);
                    Console.Clear();
                    Console.WriteLine("Tarefa adicionada com sucesso!");
                    break;

                case UserChoice.RemoveTask:
                    Console.WriteLine("Digite a tarefa que deseja remover: ");
                    string taskToRemove = Console.ReadLine();
                    toDoList.Remove(taskToRemove);
                    Console.Clear();
                    Console.WriteLine("Tarefa removida com sucesso!");
                    break;

                case UserChoice.UpdateTask:
                    Console.WriteLine("Insira a tarefa que deseja alterar: ");
                    string taskToUpdate = Console.ReadLine();
                    toDoList.Remove(taskToUpdate);
                    Console.WriteLine("Insira a nova tarefa: ");
                    string newTask = Console.ReadLine();
                    toDoList.Add(newTask);
                    Console.Clear();
                    Console.WriteLine($"Tarefa alterada com sucesso, de: {taskToUpdate} para: {newTask}.");
                    break;

                case UserChoice.Exit:
                    Console.WriteLine("Encerrando o sistema...");
                    return;

                default:
                    Console.WriteLine("Opção inválida. Por favor, insira um número correspondente a uma opção válida.");
                    break;
            }

            if (toDoList.Count > 0)
            {
                Console.WriteLine("Tarefas pendentes: ");
                for (int i = 0; i < toDoList.Count; i++)
                {
                    Console.WriteLine($"- {toDoList[i]}");
                }
            }
            else
            {
                Console.WriteLine("A lista de tarefas está vazia!\n");
            }
        }
    }
}

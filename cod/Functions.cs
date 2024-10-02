class Functions
{
     Tarefas[] tarefas = new Tarefas[10];
     int NumeroDeTarefas = 0; 

     public void Iniciar()
     {
         while(true)
         {
            MostrarMenu();
            Console.WriteLine("Escolha uma opção");
            int opcao = Convert.ToInt32(Console.ReadLine());

            switch(opcao)
            {
                case 1:
                    AdicionarTarefa();
                    break;
                case 2:
                    ListarTarefa();
                     break;
                case 3:
                    TarefaConcluida();
                    break;
                case 4:
                    ExcluirTarefa();
                    break;
                case 5:
                    Console.WriteLine("Saindo...");
                    return;
                default:
                    Console.WriteLine("Opção invalida");
                    break;

            }
        
        }
     }

    public void MostrarMenu()
    {
        
           Console.WriteLine(@"[1] Adicionar Tarefa 
[2] Listar tarefas
[3] Tarefa Concluida 
[4] Excluir tarefa
[5] Sair");
           
    }  
    public void AdicionarTarefa()
    {
        if (NumeroDeTarefas >= tarefas.Length )
        {
            Console.WriteLine("Não é possível adicionar mais tarefas");
        }  

        Console.WriteLine("Digite a descrição da tarefa: ");
        string? descricao = Console.ReadLine();

        Console.WriteLine("Digite a data de vencimento dessa tarefa: ");
        DateTime datavencimento = DateTime.Parse(Console.ReadLine());

        tarefas[NumeroDeTarefas] = new Tarefas(descricao, datavencimento);
        NumeroDeTarefas++;
        Console.WriteLine("Tarefa adicionada com sucesso.\n");

    }
    public void ListarTarefa()
    {
     if (NumeroDeTarefas == 0 )
     {
        Console.WriteLine("Nenhuma tarefa cadastrada");
        
     }else{
        for(int i = 0; i < NumeroDeTarefas; i++)
        {
        Console.WriteLine($"{i + 1}. {tarefas[i].Descricao} - Vence em: {tarefas[i].DataVencimento.ToShortDateString()} - {(tarefas[i].Concluida ? "Concluida" : "Pendente")}");
        }
    }
    }
 
    public void TarefaConcluida()
    {
        ListarTarefa();
        if (NumeroDeTarefas == 0)
        {
            return;
        }
        Console.WriteLine("Digite um número de tarefa para marcar com concluída");
        int numero = Convert.ToInt32(Console.ReadLine());

        if (numero < 1 || numero > NumeroDeTarefas)
        {
            Console.WriteLine("NUmero de tarefa invalido");
            return;
        }

        tarefas[numero - 1].Concluida = true;
        Console.WriteLine($"Tarefa {numero} marcada como concluida");
    }

    public void ExcluirTarefa()
    {
        ListarTarefa();
        Console.WriteLine("Digite o número da tarefa que deseja excluir");
        int numero = Convert.ToInt16(Console.ReadLine());

        if (numero != -1)
        {
            for (int i = numero; i < NumeroDeTarefas -1; i++)
            {
                tarefas[i] = tarefas[i + 1];
            }
            tarefas[NumeroDeTarefas - 1] = null;
            NumeroDeTarefas--;

            Console.Write("Peça removida!");
        }else{
            Console.WriteLine("Produto não encontrado");
        }

    }
    
}
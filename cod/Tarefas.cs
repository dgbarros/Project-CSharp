class Tarefas
{
    public string Descricao {get; set;}
    public DateTime DataVencimento {get; set;}
    public bool Concluida {get; set;}
 
    public Tarefas (string descricao, DateTime datavencimento)
    {
        Descricao = descricao;
        DataVencimento = datavencimento;
        Concluida = false;
    }    
}
namespace gerenciaTarefas.models;
//namespace = agrupar classes
public class Tarefa{
    //propiedades automaticas
    
    public int id { get; set; } // int = inteiro
    public string? Cabeçalho { get; set; }

    public string? Titulo { get; set; }
   
    public string? Descricao { get; set; }  //string = texto
  
    public bool TaCompleta { get; set; }  // bool = boleano = verdadeiro ou falso


}
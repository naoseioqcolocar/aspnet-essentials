namespace GerenciaTarefa.Models;
public class Tarefa{
    public int Id { get; set; }

    public String? Cabecalho { get; set; }

    public String? Titulo { get; set; }

    public String? Descricao { get; set; }

    public bool TaCompleta { get; set; }
}
namespace GestorDeTarefas.Models
{
    public class Tarefa
    {
        public int Id { get; set; }
        public string? Titulo { get; set; }
        public string? Descricao { get; set; }
        public DateTime DataDeCriacao { get; set; } = DateTime.UtcNow;
        public DateTime Prazo { get; set; }
    }
}

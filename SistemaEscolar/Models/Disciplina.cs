namespace SistemaEscolar.Models
{
    public class Disciplina
    {
        public int Id { get; set; }
        public string Nome { get; set; } = string.Empty;
        public string Professor { get; set; } = string.Empty;
        public int TurmaId { get; set; }
    }
}
namespace SistemaEscolar.Models
{
    public class Turma // Represents a school class
    {
        public int Id { get; set; }
        public string Nome { get; set; } = string.Empty;
        public string Serie { get; set; } = string.Empty;
        public List<Estudante> Estudantes { get; set; } = new();
        public int QuantidadeEstudantes => Estudantes.Count;
    }
}

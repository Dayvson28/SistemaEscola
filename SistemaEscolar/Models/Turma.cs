namespace SistemaEscolar.Models
{
    public class Turma // Representa uma turma em uma escola
    {
        public int Id { get; set; }
        public string Nome { get; set; } = string.Empty;
        public string Serie { get; set; } = string.Empty;
        public List<Estudante> Estudantes { get; set; } = new();
        public int QuantidadeEstudantes => Estudantes.Count;
    }
}

namespace SistemaEscolar.Models
{
    public class Estudante // Modelo da classe para estudantes
    {
        public int Id { get; set; }
        public string Nome { get; set; } = string.Empty;
        public int Idade { get; set; }
        public string Serie { get; set; } = string.Empty;
        public int TurmaId { get; set; }
    }
}

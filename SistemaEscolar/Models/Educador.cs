namespace SistemaEscolar.Models
{
    public class Educador // Professor
    {
        public int Id { get; set; }
        public string Nome { get; set; } = string.Empty;
        public List<int> TurmasIds { get; set; } = new();
    }
}

namespace SistemaEscolar.Models
{
    public class Horario
    {
        public int Id { get; set; }
        public string DiaSemana { get; set; } = string.Empty;
        public int NumeroAula { get; set; }
        public int DisciplinaId { get; set; }
        public string NomeDisciplina { get; set; } = string.Empty;
        public int TurmaId { get; set; }
    }
}
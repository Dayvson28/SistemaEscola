using SistemaEscolar.Models; 
namespace SistemaEscolar.Services // Serviços para gerenciar turmas e estudantes
{
    public class TurmaService
    {
        private List<Turma> _turmas = new(); // Lista de turmas
        private List<Estudante> _estudantes = new(); // Lista de estudantes
        private List<Disciplina> _disciplinas = new(); // Lista de disciplinas
        private List<Horario> _horarios = new(); // Lista de horários

        public TurmaService() // Construtor que inicializa os dados
        {
            InicializarDados(); // Chama o método para inicializar os dados
        }

        private void InicializarDados() // Método para inicializar dados fictícios
        {
            // Inicializa as turmas (1º ao 3º ano, turmas A a F)
            for (int serie = 1; serie <= 3; serie++) // Para cada série
            {
                for(char turma = 'A'; turma <= 'F'; turma++) // Para cada turma
                {
                    var novaturma = new Turma
                    {
                        Id = (_turmas.Count + 1),
                        Nome = $"{serie}º ano {turma}",
                        Serie = $"{serie}º ano"
                    };
                    _turmas.Add(novaturma); // Adiciona a nova turma à lista de turmas
                }
            }

            var nomes = new[] { "Ana Silva", "João Santos", "Maria Oliveira", "Pedro Costa", "Lucia Ferreira", "Carlos Souza" }; // Nomes fictícios
            int estudanteId = 1; // Contador de IDs para estudantes

            foreach (var turma in _turmas)
            {
                int quantidadeEstudantes = Random.Shared.Next(12, 18); // Número aleatório de estudantes por turma
                for (int i = 0; i < quantidadeEstudantes; i++)
                {
                    var estudante = new Estudante
                    {
                        Id = estudanteId++,
                        Nome = nomes[new Random().Next(nomes.Length)],
                        Idade = new Random().Next(6, 18),
                        Serie = turma.Serie,
                        TurmaId = turma.Id
                    };
                    turma.Estudantes.Add(estudante); // Adiciona o estudante à turma
                    _estudantes.Add(estudante); // Adiciona o estudante à lista de estudantes
                }
            }
        }

        public List<Turma> ObterTodasTurmas() => _turmas; // Retorna todas as turmas

        public Turma? ObterTurmaPorId(int id) => _turmas.FirstOrDefault(t => t.Id == id); // Retorna uma turma por ID

        public List<Turma> ObterTurmasPorSerie(string serie) =>
            _turmas.Where(t => t.Serie.Equals(serie, StringComparison.OrdinalIgnoreCase)).ToList(); // Retorna turmas por série

        public Dictionary<string, int> ObterQuantidadeEstudantesPorSerie() // Retorna a quantidade de estudantes por série
        {
            return _turmas
                .GroupBy(t => t.Serie)
                .ToDictionary(g => g.Key, g => g.Sum(t => t.QuantidadeEstudantes));
        }

        public Dictionary<string, int> ObterEstatisticasPorSerie() // Retorna estatísticas por série
        {
            return ObterQuantidadeEstudantesPorSerie(); // Reutiliza o método anterior
        }

        public void AdicionarTurma(Turma turma) // Adiciona uma nova turma
        {
            turma.Id = _turmas.Count + 1;
            _turmas.Add(turma); // Adiciona a nova turma à lista de turmas
        }

        public void AdicionarEstudante(int turmaId, Estudante estudante) // Adiciona um estudante a uma turma específica
        {
            var turma = ObterTurmaPorId(turmaId);
            if (turma != null)
            {
                estudante.Id = _estudantes.Count + 1;
                estudante.TurmaId = turma.Id;
                estudante.Serie = turma.Serie;
                turma.Estudantes.Add(estudante);
                _estudantes.Add(estudante);
            }
        }

        // Métodos para gerenciar disciplinas
        public List<Disciplina> ObterDisciplinasPorTurma(int turmaId) =>
            _disciplinas.Where(d => d.TurmaId == turmaId).ToList();

        public void AdicionarDisciplina(Disciplina disciplina)
        {
            var turma = ObterTurmaPorId(disciplina.TurmaId);
            if (turma != null)
            {
                disciplina.Id = _disciplinas.Count + 1;
                _disciplinas.Add(disciplina);
            }
        }

        // Métodos para gerenciar horários
        public List<Horario> ObterHorariosPorTurma(int turmaId) =>
            _horarios.Where(h => h.TurmaId == turmaId).ToList();

        public void AdicionarHorario(Horario horario)
        {
            var turma = ObterTurmaPorId(horario.TurmaId);
            if (turma != null)
            {
                horario.Id = _horarios.Count + 1;
                _horarios.Add(horario);
            }
        }
    }
}

using SistemaEscolar.Models;
namespace SistemaEscolar.Services
{
    public class EducadorService // Simula um serviço de dados para educadores
    {
        private List<Educador> _educadores = new(); // Lista interna para armazenar educadores
        public EducadorService() // Construtor que inicializa os dados
        {
            InicializarDados(); // Chama o método para popular a lista de educadores
        }
        private void InicializarDados() // Método para adicionar educadores fictícios
        {
            var nomes = new[] { "Dayanne", "Nathalia", "Fernanda", "Ricardo", "Stephanie" };

            for (int i = 0; i < nomes.Length; i++)
            {
                _educadores.Add(new Educador
                {
                    Id = i + 1,
                    Nome = nomes[i],
                    TurmasIds = new List<int> { i + 1, i + 7, i + 13 } // Cada educador cuida de 3 turmas
                });
            }
        }
        public List<Educador> ObterTodosEducadores() => _educadores; // Retorna todos os educadores
        public Educador? ObterEducadorPorId(int id) => _educadores.FirstOrDefault(e => e.Id == id); // Retorna um educador por ID

        public void AdicionarEducador(string nome, List<int>? turmas = null)
        {
            var novoEducador = new Educador
            { 
            Id = _educadores.Any() ? _educadores.Max(e => e.Id) + 1 : 1,
            Nome = nome,
            TurmasIds = turmas ?? new List<int>()
            };
        _educadores.Add(novoEducador);
        }
    }
}

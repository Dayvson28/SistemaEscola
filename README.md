# 📚 Sistema Escolar

Olá, eu sou Dayvson 👋 Este é o meu projeto de Sistema Escolar que desenvolvi como teste para a vaga de desenvolvedor júnior. É um sistema simples para gerenciamento de escolas feito com Blazor.

## 🚀 Sobre o Projeto

Este sistema foi criado para ajudar na gestão de uma escola, permitindo o controle de turmas, estudantes, disciplinas e educadores. Ele foi desenvolvido usando Blazor, que é uma tecnologia da Microsoft para criar aplicações web interativas com C#.

## 💻 Tecnologias Usadas

- .NET 9.0
- Blazor Server
- C#
- HTML/CSS
- Bootstrap
- MudBlazor (para alguns componentes de UI, mas ao final não usei)

## 🏗️ Estrutura do Projeto

O projeto está organizado da seguinte forma:

- **Models**: Classes que representam as entidades do sistema (Turma, Estudante, Disciplina, etc.)
- **Services**: Serviços que gerenciam a lógica de negócio e os dados
- **Components**: Componentes Blazor que formam a interface do usuário
  - **Pages**: Páginas do sistema
  - **Shared**: Componentes compartilhados
  - **Layout**: Componentes de layout

## ✨ Funcionalidades

### Gerenciamento de Turmas
- Visualização de todas as turmas
- Criação de novas turmas
- Detalhes de cada turma
- Estatísticas de estudantes por série
- Seleção de tipo de visualização do card (Lista ou Cards)

### Gerenciamento de Estudantes
- Adicionar estudantes às turmas
- Visualizar estudantes por turma

### Gerenciamento de Educadores
- Cadastro de educadores
- Exclusão de educadores
- Visualização de educadores

### Diário de Classe
- Registro de aulas por data, que o professor tem aula naquela turma
- Visualização de calendário
- inserção de registros de aula por dia
- lista de estudantes

### Configurações do Sistema
- Estatísticas gerais, quantidade total de turmas e estudantes
- Opção limpar cache de dados
- Opção para resetar dados do sistema
- Opção para gerar dados do sistema (Turmas, Estudantes)

## 🚀 Como Executar o Projeto

1. Clone o repositório
   git clone https://github.com/Dayvson28/SistemaEscola.git
2. Navegue até o diretório do projeto
   cd SistemaEscola
3. Restaure as dependências
   dotnet restore
4. Execute o projeto
   dotnet run

   ## 📝 Observações
- Este é um projeto de demonstração, então os dados são armazenados em memória e não persistem após o encerramento da aplicação.
- Ainda existem muitas melhorias que podem ser implementadas no futuro!

## 👨‍💻 Autor
Desenvolvido por Dayvson Medeiros como parte de um teste para vaga de desenvolvedor júnior.

Feito com ❤️ e muito ☕ (café)!
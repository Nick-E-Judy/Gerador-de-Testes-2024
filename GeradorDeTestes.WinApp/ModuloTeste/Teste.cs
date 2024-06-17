using GeradorDeTestes.WinApp.Compartilhado;
using GeradorDeTestes.WinApp.ModuloDisciplina;
using GeradorDeTestes.WinApp.ModuloMateria;
using GeradorDeTestes.WinApp.ModuloQuestao;


namespace GeradorDeTestes.WinApp.ModuloTeste
{
    public class Teste : EntidadeBase
    {
        public string Titulo { get; set; }
        public Disciplina Disciplina { get; set; }
        public Materia Materia { get; set; }
        public int QuantQuestoes { get; set; }
        public List<Questao> Questoes { get; set; }
        public Questao Questao { get; set; }

        public Teste() { }

        public Teste(string titulo, Disciplina disciplina, Materia materia, int quantQuestoes, List<Questao> questoes)
        {
            Titulo = titulo;
            Disciplina = disciplina;
            Materia = materia;
            QuantQuestoes = quantQuestoes; 
            Questoes = questoes;
        }

        public override List<string> Validar()
        {
            List<string> erros = new List<string>();

            if (string.IsNullOrWhiteSpace(Titulo))
                erros.Add("O campo 'Título' é obrigatório.");

            if (Disciplina == null)
                erros.Add("O campo 'Disciplina' é obrigatório.");

            if (QuantQuestoes <= 0)
                erros.Add("A quantidade de questões deve ser maior que zero.");

            if (Questoes.Count == 0)
                erros.Add("É necessário adicionar questões ao teste.");

            return erros;
        }

        public override void AtualizarRegistro(EntidadeBase novoRegistro)
        {
            Teste atualizado = (Teste)novoRegistro;

            Titulo = atualizado.Titulo;
        }

        public override string ToString()
        {
            return Titulo.ToTitleCase();
        }
    }
}

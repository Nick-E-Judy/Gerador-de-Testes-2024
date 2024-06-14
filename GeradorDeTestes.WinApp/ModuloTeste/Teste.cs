using GeradorDeTestes.WinApp.Compartilhado;
using GeradorDeTestes.WinApp.ModuloDisciplina;
using GeradorDeTestes.WinApp.ModuloMateria;


namespace GeradorDeTestes.WinApp.ModuloTeste
{
    public class Teste : EntidadeBase
    {
        public string Titulo { get; set; }
        public Disciplina Disciplina { get; set; }
        public Materia Materia { get; set; }
        public int QuantQuestoes { get; set; }
        public bool ProvaRecuperacao { get; set; }
        //public Materia Serie { get; set; }

        public Teste() { }

        public Teste(string titulo, Disciplina disciplina, Materia materia, int quantQuestoes)
        {
            Titulo = titulo;
            Disciplina = disciplina;
            Materia = materia;
            QuantQuestoes = quantQuestoes;
        }

        public override List<string> Validar()
        {
            List<string> erros = new List<string>();

            if (string.IsNullOrEmpty(Titulo.Trim()))
                erros.Add("O campo \"nome\" é obrigatório");

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

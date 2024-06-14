using GeradorDeTestes.WinApp.Compartilhado;
using GeradorDeTestes.WinApp.ModuloMateria;

namespace GeradorDeTestes.WinApp.ModuloQuestao
{
    public class Questao : EntidadeBase
    {
        public string Enunciado { get; set; }
        public List<Alternativa> Alternativas { get; set; }
        public Materia Materia { get; set; }

        public Questao() { }

        public Questao(string enunciado, List<Alternativa> alternativas,  Materia materia)
        {
            Enunciado = enunciado;
            Alternativas = alternativas;
            Materia = materia;
        }


        public override List<string> Validar()
        {
            List<string> erros = new List<string>();

            if (string.IsNullOrEmpty(Enunciado.Trim()))
                erros.Add("O campo \"enunciado\" é obrigatório");

            if (Materia == null)
                erros.Add("A matéria deve ser selecionada.");

            if (Alternativas.Count < 2)
                erros.Add("A questão deve ter pelo menos duas alternativas.");

            if (Alternativas.Count > 4)
                erros.Add("A questão não pode ter mais que quatro alternativas.");

            if (!Alternativas.Any(a => a.Correto))
                erros.Add("Uma alternativa deve ser marcada como correta.");

            return erros;
        }

        public override void AtualizarRegistro(EntidadeBase novoRegistro)
        {
            Questao atualizado = (Questao)novoRegistro;

            Enunciado = atualizado.Enunciado;
            Alternativas = atualizado.Alternativas;
            Materia = atualizado.Materia;
        }

        public override string ToString()
        {
            return Enunciado.ToTitleCase();
        }
    }
}

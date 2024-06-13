using GeradorDeTestes.WinApp.Compartilhado;
using GeradorDeTestes.WinApp.ModuloMateria;

namespace GeradorDeTestes.WinApp.ModuloQuestao
{
    public class Questao : EntidadeBase
    {
        public string Enunciado { get; set; }
        public List<string> Alternativas { get; set; }
        public Materia Materia { get; set; }

        public Questao(string enunciado,  Materia materia)
        {
            Enunciado = enunciado;
            //Alternativas = alternativas;
            Materia = materia;
        }


        public override List<string> Validar()
        {
            List<string> erros = new List<string>();

            if (string.IsNullOrEmpty(Enunciado.Trim()))
                erros.Add("O campo \"enunciado\" é obrigatório");

            return erros;
        }

        public override void AtualizarRegistro(EntidadeBase novoRegistro)
        {
            Questao atualizado = (Questao)novoRegistro;

            Enunciado = atualizado.Enunciado;
        }

        public override string ToString()
        {
            return Enunciado.ToTitleCase();
        }
    }
}

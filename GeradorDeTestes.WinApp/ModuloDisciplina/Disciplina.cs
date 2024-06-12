using GeradorDeTestes.WinApp.Compartilhado;

namespace GeradorDeTestes.WinApp.ModuloDisciplina
{
    public class Disciplina : EntidadeBase
    {
        public string Nome { get; set; }

        public Disciplina(string nome)
        {
            Nome = nome;
        }

        public override List<string> Validar()
        {
            List<string> erros = new List<string>();

            if (string.IsNullOrEmpty(Nome.Trim()))
                erros.Add("O campo \"nome\" é obrigatório");

            return erros;
        }

        public override void AtualizarRegistro(EntidadeBase novoRegistro)
        {
            Disciplina atualizado = (Disciplina)novoRegistro;

            Nome = atualizado.Nome;
        }

        public override string ToString()
        {
            return Nome.ToTitleCase();
        }
    }
}

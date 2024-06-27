using GeradorDeTestes.WinApp.Compartilhado;
using GeradorDeTestes.WinApp.ModuloMateria;

namespace GeradorDeTestes.WinApp.ModuloDisciplina
{
    public class Disciplina : EntidadeBase
    {
        public string Nome { get; set; }
        public List<Materia> Materias { get; set; }
        public Disciplina()
        {
            Materias = new List<Materia>();
        }
        public Disciplina(string nome)
        {
            Nome = nome;
            Materias = new List<Materia>();
        }

        public bool AdicionarMateria(Materia materia)
        {
            if (Materias.Exists(i => i.Nome == materia.Nome))
                return false;

            materia.Disciplina = this;
            Materias.Add(materia);

            return true;
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

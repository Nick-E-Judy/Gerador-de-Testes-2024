using GeradorDeTestes.WinApp.Compartilhado;
using GeradorDeTestes.WinApp.ModuloMateria;

namespace GeradorDeTestes.WinApp.ModuloDisciplina
{
    public class RepositorioDisciplinaEmArquivo : RepositorioBaseEmArquivo<Disciplina>, IRepositorioDisciplina
    {
        public RepositorioDisciplinaEmArquivo(ContextoDados contexto) : base(contexto)
        {
            if (contexto.Disciplinas.Any())
                contadorId = contexto.Disciplinas.Max(c => c.Id) + 1;
        }

        protected override List<Disciplina> ObterRegistros()
        {
            return contexto.Disciplinas;
        }

        public override bool Excluir(int id)
        {
            Disciplina disciplina = SelecionarPorId(id);

            List<Materia> materiasRelacionadas = contexto.Materias.FindAll(m => m.Disciplina != null && m.Disciplina.Id == disciplina.Id);

            if (materiasRelacionadas != null || materiasRelacionadas.Count > 0)
            {
                MessageBox.Show("Não é possível excluir a disciplina pois há matérias relacionadas.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return base.Excluir(id);

        }
    }
}

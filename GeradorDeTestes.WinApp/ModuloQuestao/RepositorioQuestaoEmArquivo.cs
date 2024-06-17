using GeradorDeTestes.WinApp.Compartilhado;
using GeradorDeTestes.WinApp.ModuloMateria;

namespace GeradorDeTestes.WinApp.ModuloQuestao
{
    public class RepositorioQuestaoEmArquivo : RepositorioBaseEmArquivo<Questao>, IRepositorioQuestao
    {
        public RepositorioQuestaoEmArquivo(ContextoDados contexto) : base(contexto)
        {
            if (contexto.Questoes.Any())
                contadorId = contexto.Questoes.Max(c => c.Id) + 1;
        }

        protected override List<Questao> ObterRegistros()
        {
            return contexto.Questoes;
        }

        public override bool Excluir(int id)
        {
            //Questao questao = SelecionarPorId(id);

            //List<Materia> materiasRelacionadas = contexto.Materias.FindAll(m => m.Questao != null && m.Questao.Id == questao.Id);

            //if (materiasRelacionadas != null || materiasRelacionadas.Count > 0)
            //{
            //    MessageBox.Show("Não é possível excluir a questao pois há matérias relacionadas.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    return false;
            //}

            return base.Excluir(id);

        }

        public List<Questao> SelecionarPorMateria(int materiaId)
        {
            return contexto.Questoes.Where(q => q.Materia.Id == materiaId).ToList();
        }
    }
}

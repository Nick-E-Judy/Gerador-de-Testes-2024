using GeradorDeTestes.WinApp.Compartilhado;

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
            //Materia materia = SelecionarPorId(id);

            //List<Materia> materiasRelacionadas =
            //   contexto.Materias.FindAll(m => m.Materia.Id == materia.Id);

            //foreach (Materia m in materiasRelacionadas)
            //   m.Materia = null;

            return base.Excluir(id);
        }
    }
}

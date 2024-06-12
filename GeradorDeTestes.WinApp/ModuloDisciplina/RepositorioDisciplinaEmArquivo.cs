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
            Disciplina disciplina = SelecionarPorId(id);

            //List<Disciplina> disciplinasRelacionados =
            //    contexto.Disciplinas.FindAll(c => c.Disciplina.Id == disciplina.Id);

            //foreach (Disciplina c in disciplinasRelacionados)
            //    c.Disciplina = null;

            return base.Excluir(id);
        }
    }
}

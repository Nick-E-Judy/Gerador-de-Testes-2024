using GeradorDeTestes.WinApp.Compartilhado;
using GeradorDeTestes.WinApp.ModuloMateria;

namespace GeradorDeTestes.WinApp.ModuloTeste
{
    public class RepositorioTesteEmArquivo : RepositorioBaseEmArquivo<Teste>, IRepositorioTeste
    {
        public RepositorioTesteEmArquivo(ContextoDados contexto) : base(contexto)
        {
            if (contexto.Testes.Any())
                contadorId = contexto.Testes.Max(c => c.Id) + 1;
        }

        protected override List<Teste> ObterRegistros()
        {
            return contexto.Testes;
        }

        public override bool Excluir(int id)
        {
            Teste teste = SelecionarPorId(id);

            return base.Excluir(id);

        }
    }
}

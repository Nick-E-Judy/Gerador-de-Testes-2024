using GeradorDeTestes.WinApp.Compartilhado;
using GeradorDeTestes.WinApp.ModuloDisciplina;
using GeradorDeTestes.WinApp.ModuloMateria;
using GeradorDeTestes.WinApp.ModuloQuestao;

namespace GeradorDeTestes.WinApp.ModuloTeste
{
    public class ControladorTeste : ControladorBase, IControladorDuplicar
    {
        private IRepositorioTeste repositorioTeste;
        private TabelaTesteControl tabelaTeste;

        private IRepositorioMateria repositorioMateria;
        private IRepositorioDisciplina repositorioDisciplina;
        private IRepositorioQuestao repositorioQuestao;

        public ControladorTeste(IRepositorioTeste repositorioTeste, IRepositorioMateria repositorioMateria, IRepositorioDisciplina repositorioDisciplina, IRepositorioQuestao repositorioQuestao)
        {
            this.repositorioTeste = repositorioTeste;
            this.repositorioMateria = repositorioMateria;
            this.repositorioDisciplina = repositorioDisciplina;
            this.repositorioQuestao = repositorioQuestao;
        }

        public override string TipoCadastro { get { return "Testes"; } }

        public override string ToolTipAdicionar { get { return "Cadastrar um novo teste"; } }

        public override string ToolTipEditar { get { return "Editar um teste existente"; } }

        public override string ToolTipExcluir { get { return "Excluir um teste existente"; } }

        public string ToolTipDuplicar { get { return "Duplicar um teste"; } }

        public string ToolTipVisualizar { get { return "Visualizar um teste"; } }

        public string ToolTipGerarTeste => throw new NotImplementedException();

        public override void Adicionar()
        {
            TelaTesteForm telaTeste = new TelaTesteForm(repositorioMateria, repositorioQuestao);

            List<Disciplina> disciplinasCadastradas = repositorioDisciplina.SelecionarTodos();

            telaTeste.CarregarDisciplinas(disciplinasCadastradas);

            DialogResult resultado = telaTeste.ShowDialog();

            if (resultado != DialogResult.OK)
                return;

            Teste novoTeste = telaTeste.Teste;

            List<Teste> testes = repositorioTeste.SelecionarTodos();

            foreach (var teste in testes)
            {
                if (teste.Titulo.ToLower() == novoTeste.Titulo.ToLower())
                {
                    
                    TelaPrincipalForm
                        .Instancia
                        .AtualizarRodape($"Já existe um teste com este nome.");
                    return;
                }
            }

            repositorioTeste.Cadastrar(novoTeste);

            CarregarTestes();

            TelaPrincipalForm
                .Instancia
                .AtualizarRodape($"O registro \"{novoTeste.Titulo}\" foi criado com sucesso!");
        }

        public override void Editar()
        {
            throw new NotImplementedException();
        }

        public override void Excluir()
        {
            int idSelecionado = tabelaTeste.ObterRegistroSelecionado();

            Teste testeSelecionado = repositorioTeste.SelecionarPorId(idSelecionado);

            if (testeSelecionado == null)
            {
                    TelaPrincipalForm
                        .Instancia
                        .AtualizarRodape($"Não é possível realizar esta ação sem um registro selecionado.");
                return;
            }

            DialogResult resposta = MessageBox.Show(
                $"Você deseja realmente excluir o registro \"{testeSelecionado.Titulo}\"?",
                "Confirmar Exclusão",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (resposta != DialogResult.Yes)
                return;

            repositorioTeste.Excluir(testeSelecionado.Id);

            CarregarTestes();

            TelaPrincipalForm
                .Instancia
                .AtualizarRodape($"O registro \"{testeSelecionado.Titulo}\" foi excluído com sucesso!");
        }

        public void Duplicar()
        {
            int idSelecionado = tabelaTeste.ObterRegistroSelecionado();

            Teste testeSelecionado = repositorioTeste.SelecionarPorId(idSelecionado);

            if (testeSelecionado == null)
            {
                TelaPrincipalForm
                    .Instancia
                    .AtualizarRodape($"Não é possível realizar esta ação sem um registro selecionado.");
                return;
            }

            TelaTesteForm telaTeste = new TelaTesteForm(repositorioMateria, repositorioQuestao);
            telaTeste.Teste = testeSelecionado;
            telaTeste.Text = "Duplicar Teste";

            DialogResult resultado = telaTeste.ShowDialog();

            if (resultado != DialogResult.OK)
                return;

            Teste testeEditado = telaTeste.Teste;

            List<Teste> testes = repositorioTeste.SelecionarTodos();

            foreach (var teste in testes)
            {
                if (teste.Titulo.ToLower() == testeEditado.Titulo.ToLower())
                {
                    TelaPrincipalForm
                        .Instancia
                        .AtualizarRodape($"Já existe um teste com este nome");
                    return;
                }
            }

            repositorioTeste.Cadastrar(testeEditado);

            CarregarTestes();

            TelaPrincipalForm
                .Instancia
                .AtualizarRodape($"O registro \"{testeEditado.Titulo}\" foi editado com sucesso!");
        }

        public void Visualizar()
        {
            int idSelecionado = tabelaTeste.ObterRegistroSelecionado();

            Teste testeSelecionado =
                repositorioTeste.SelecionarPorId(idSelecionado);

            if (testeSelecionado == null)
            {
                TelaPrincipalForm
                    .Instancia
                    .AtualizarRodape($"Não é possível realizar esta ação sem um registro selecionado.");
                return;
            }

            TelaVisualizarTesteForm tela = new TelaVisualizarTesteForm(testeSelecionado);

            tela.ShowDialog();
        }
        public void GerarTeste()
        {
            int idSelecionado = tabelaTeste.ObterRegistroSelecionado();

            Teste testeSelecionado = repositorioTeste.SelecionarPorId(idSelecionado);

            if (testeSelecionado == null)
            {

                TelaPrincipalForm
                    .Instancia
                    .AtualizarRodape($"Não é possível realizar esta ação sem um registro selecionado.");
                return;
            }

            TelaGerarPDFForm telaGerarPDF = new TelaGerarPDFForm(testeSelecionado, repositorioDisciplina.SelecionarTodos(), repositorioMateria.SelecionarTodos(), repositorioQuestao.SelecionarTodos());

            DialogResult resultado = telaGerarPDF.ShowDialog();

            if (resultado != DialogResult.OK)
                return;

            string caminho = telaGerarPDF.Caminho;

            TelaPrincipalForm.Instancia.AtualizarRodape($"O arquivo foi gerado com sucesso em: {caminho}");
        }

        private void CarregarTestes()
        {
            List<Teste> testes = repositorioTeste.SelecionarTodos();

            tabelaTeste.AtualizarRegistros(testes);
        }

        public override UserControl ObterListagem()
        {
            if (tabelaTeste == null)
                tabelaTeste = new TabelaTesteControl();

            CarregarTestes();

            return tabelaTeste;
        }
    }
}

using GeradorDeTestes.WinApp.ModuloQuestao;


namespace GeradorDeTestes.WinApp.ModuloTeste
{
    public partial class TelaVisualizarTesteForm : Form
    {
        public TelaVisualizarTesteForm(Teste testeSelecionado)
        {
            InitializeComponent();
            lblTituloTeste.Text = testeSelecionado.Titulo;
            lblNomeDisciplina.Text = testeSelecionado.Disciplina.Nome;
            lblNomeMateria.Text = testeSelecionado.Materia.ToString();

            CarregarQuestoes(testeSelecionado);
        }

        private void CarregarQuestoes(Teste testeSelecionado)
        {
            foreach (Questao questao in testeSelecionado.Questoes)
                listQuestoes.Items.Add(questao);
        }
    }
}

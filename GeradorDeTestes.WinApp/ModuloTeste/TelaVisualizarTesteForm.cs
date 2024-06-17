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
            if (testeSelecionado.Materia != null)
                lblNomeMateria.Text = testeSelecionado.Materia.ToString();
            else
                lblNomeMateria.Text = "Recuperação";

            CarregarQuestoes(testeSelecionado);
        }

        private void CarregarQuestoes(Teste testeSelecionado)
        {
            foreach (Questao questao in testeSelecionado.Questoes)
                listQuestoes.Items.Add(questao);
        }
    }
}

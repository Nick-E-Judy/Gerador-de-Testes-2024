namespace GeradorDeTestes.WinApp.ModuloQuestao
{
    public partial class ListagemQuestaoControl : UserControl
    {
        public ListagemQuestaoControl()
        {
            InitializeComponent();
        }

        public void AtualizarRegistros(List<Questao> questoes)
        {
            listQuestoes.Items.Clear();

            foreach (Questao questao in questoes)
                listQuestoes.Items.Add(questao);
        }

        public Questao ObterRegistroSelecionado()
        {
            if (listQuestoes.SelectedItem == null)
                return null;

            return (Questao)listQuestoes.SelectedItem;
        }
    }
}

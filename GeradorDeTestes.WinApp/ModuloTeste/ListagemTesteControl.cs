
namespace GeradorDeTestes.WinApp.ModuloTeste
{
    public partial class ListagemTesteControl : UserControl
    {
        public ListagemTesteControl()
        {
            InitializeComponent();
        }

        public void AtualizarRegistros(List<Teste> testes)
        {
            listTestes.Items.Clear();

            foreach (Teste teste in testes)
                listTestes.Items.Add(teste);
        }

        public Teste ObterRegistroSelecionado()
        {
            if (listTestes.SelectedItem == null)
                return null;

            return (Teste)listTestes.SelectedItem;
        }
    }
}

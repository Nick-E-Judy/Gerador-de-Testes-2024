namespace GeradorDeTestes.WinApp.ModuloDisciplina
{
    public partial class ListagemDisciplinaControl : UserControl
    {
        public ListagemDisciplinaControl()
        {
            InitializeComponent();
        }
        public void AtualizarRegistros(List<Disciplina> disciplinas)
        {
            listDisciplinas.Items.Clear();

            foreach (Disciplina disciplina in disciplinas)
                listDisciplinas.Items.Add(disciplina);
        }

        public Disciplina ObterRegistroSelecionado()
        {
            if (listDisciplinas.SelectedItem == null)
                return null;

            return (Disciplina)listDisciplinas.SelectedItem;
        }
    }
}

namespace GeradorDeTestes.WinApp.ModuloMateria
{
    public partial class ListagemMateriaControl : UserControl
    {
        public ListagemMateriaControl()
        {
            InitializeComponent();
        }
        public void AtualizarRegistros(List<Materia> materias)
        {
            listMaterias.Items.Clear();

            foreach (Materia materia in materias)
                listMaterias.Items.Add(materia);
        }

        public Materia ObterRegistroSelecionado()
        {
            if (listMaterias.SelectedItem == null)
                return null;

            return (Materia)listMaterias.SelectedItem;
        }
    }
}

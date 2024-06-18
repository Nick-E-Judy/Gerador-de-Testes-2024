using GeradorDeTestes.WinApp.ModuloDisciplina;
using GeradorDeTestes.WinApp.ModuloMateria;
using GeradorDeTestes.WinApp.ModuloQuestao;

namespace GeradorDeTestes.WinApp.ModuloTeste
{
    public partial class TelaTesteForm : Form
    {
        private IRepositorioMateria repositorioMateria;
        private IRepositorioQuestao repositorioQuestao;
        private Teste teste;
        public Teste Teste
        {
            set
            {
                txtId.Text = value.Id.ToString();
                txtTitulo.Text = value.Titulo;
                cmbDisciplina.Items.Add(value.Disciplina);
                cmbDisciplina.SelectedItem = value.Disciplina;
                numQtdQuestoes.Text = value.QuantQuestoes.ToString();
                if (value.Materia == null)
                    checkBoxRecuperacao.Checked = true;
                else 
                { 
                    checkBoxRecuperacao.Checked = false;
                    cmbMateria.Items.Add(value.Materia);
                    cmbMateria.SelectedItem = value.Materia;
                }
                cmbMateria.Enabled = false;
                cmbDisciplina.Enabled = false;
            }
            get
            {
                return teste;
            }
        }
        public TelaTesteForm(IRepositorioMateria repositorioMateria, IRepositorioQuestao repositorioQuestao)
        {
            InitializeComponent();
            this.repositorioMateria = repositorioMateria;
            this.repositorioQuestao = repositorioQuestao;
        }

        public void CarregarMaterias(List<Materia> materias)
        {
            cmbMateria.Items.Clear();
            foreach (Materia m in materias)
                cmbMateria.Items.Add(m);
        }

        public void CarregarDisciplinas(List<Disciplina> disciplinas)
        {
            cmbDisciplina.Items.Clear();

            foreach (Disciplina d in disciplinas)
                cmbDisciplina.Items.Add(d);
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            string titulo = txtTitulo.Text.Trim();
            Disciplina disciplina = (Disciplina)cmbDisciplina.SelectedItem;
            Materia materia = (Materia)cmbMateria.SelectedItem;
            int qtdQuestoes = Convert.ToInt32(numQtdQuestoes.Text);
            List<Questao> questoes = new List<Questao>();
            foreach (Questao questao in listQuestoes.Items)
            {
                questoes.Add(questao);
            }

            teste = new Teste(titulo, disciplina, materia, qtdQuestoes, questoes);

            List<string> erros = teste.Validar();
            
            if (erros.Count > 0)
            {
                TelaPrincipalForm.Instancia.AtualizarRodape(erros[0]);

                DialogResult = DialogResult.None;
            }
        }

        private void btnSortear_Click(object sender, EventArgs e)
        {
            Disciplina disciplinaSelecionada = (Disciplina)cmbDisciplina.SelectedItem;
            int quantidadeQuestoes = (int)numQtdQuestoes.Value;
            bool provaRecuperacao = checkBoxRecuperacao.Checked;

            List<Questao> questoesDisponiveis = new List<Questao>();

            if (provaRecuperacao)
            {
                var materiasDaDisciplina = repositorioMateria.SelecionarPorDisciplina(disciplinaSelecionada.Id);

                foreach (var materia in materiasDaDisciplina)
                {
                    var questoesMateria = repositorioQuestao.SelecionarPorMateria(materia.Id);
                    questoesDisponiveis.AddRange(questoesMateria);
                }
            }
            else
            {
                Materia materiaSelecionada = (Materia)cmbMateria.SelectedItem;
                questoesDisponiveis = repositorioQuestao.SelecionarPorMateria(materiaSelecionada.Id);
            }

            if (quantidadeQuestoes > questoesDisponiveis.Count)
            {
                MessageBox.Show("A quantidade de questões informada é maior que a quantidade de questões disponíveis.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            List<Questao> questoesSorteadas = SortearQuestoes(questoesDisponiveis, quantidadeQuestoes);

            listQuestoes.Items.Clear();

            foreach (Questao questao in questoesSorteadas)
            {
                listQuestoes.Items.Add(questao);
            }

        }

        private void cmbDisciplina_SelectedIndexChanged(object sender, EventArgs e)
        {
            Disciplina disciplinaSelecionada = (Disciplina)cmbDisciplina.SelectedItem;
            if (disciplinaSelecionada != null)
            {
                List<Materia> materiasFiltradas = repositorioMateria.SelecionarPorDisciplina(disciplinaSelecionada.Id);
                CarregarMaterias(materiasFiltradas);
            }
        }

        private List<Questao> SortearQuestoes(List<Questao> questoesDisponiveis, int quantidade)
        {
            Random random = new Random();
            return questoesDisponiveis.OrderBy(q => random.Next()).Take(quantidade).ToList();
        }

        private void checkBoxRecuperacao_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxRecuperacao.Checked) 
            { 
                cmbMateria.Enabled = false;
                cmbMateria.SelectedIndex = -1;
            }
            else
                cmbMateria.Enabled = true;
        }
    }
}
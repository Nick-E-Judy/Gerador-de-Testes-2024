namespace GeradorDeTestes.WinApp.ModuloTeste
{
    partial class TelaTesteForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtId = new TextBox();
            label4 = new Label();
            btnGravar = new Button();
            btnCancelar = new Button();
            cmbMateria = new ComboBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            txtTitulo = new TextBox();
            cmbDisciplina = new ComboBox();
            label5 = new Label();
            checkBoxRecuperacao = new CheckBox();
            groupBox1 = new GroupBox();
            btnSortear = new Button();
            listQuestoes = new ListBox();
            numQtdQuestoes = new NumericUpDown();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numQtdQuestoes).BeginInit();
            SuspendLayout();
            // 
            // txtId
            // 
            txtId.Enabled = false;
            txtId.Location = new Point(110, 46);
            txtId.Margin = new Padding(3, 2, 3, 2);
            txtId.Name = "txtId";
            txtId.Size = new Size(97, 23);
            txtId.TabIndex = 24;
            txtId.Text = "0";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11.25F);
            label4.Location = new Point(77, 46);
            label4.Name = "label4";
            label4.Size = new Size(25, 20);
            label4.TabIndex = 23;
            label4.Text = "Id:";
            // 
            // btnGravar
            // 
            btnGravar.DialogResult = DialogResult.OK;
            btnGravar.Font = new Font("Segoe UI", 11.25F);
            btnGravar.Location = new Point(284, 479);
            btnGravar.Name = "btnGravar";
            btnGravar.Size = new Size(100, 26);
            btnGravar.TabIndex = 6;
            btnGravar.Text = "Gravar";
            btnGravar.UseVisualStyleBackColor = true;
            btnGravar.Click += btnGravar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.DialogResult = DialogResult.Cancel;
            btnCancelar.Font = new Font("Segoe UI", 11.25F);
            btnCancelar.Location = new Point(390, 479);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(100, 26);
            btnCancelar.TabIndex = 7;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // cmbMateria
            // 
            cmbMateria.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbMateria.FormattingEnabled = true;
            cmbMateria.Location = new Point(110, 162);
            cmbMateria.Margin = new Padding(3, 2, 3, 2);
            cmbMateria.Name = "cmbMateria";
            cmbMateria.Size = new Size(181, 23);
            cmbMateria.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11.25F);
            label3.Location = new Point(21, 120);
            label3.Name = "label3";
            label3.Size = new Size(81, 20);
            label3.TabIndex = 15;
            label3.Text = "Disciplina: ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.25F);
            label2.Location = new Point(45, 82);
            label2.Name = "label2";
            label2.Size = new Size(54, 20);
            label2.TabIndex = 14;
            label2.Text = "Titulo: ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11.25F);
            label1.Location = new Point(30, 161);
            label1.Name = "label1";
            label1.Size = new Size(67, 20);
            label1.TabIndex = 13;
            label1.Text = "Matéria: ";
            // 
            // txtTitulo
            // 
            txtTitulo.Location = new Point(110, 83);
            txtTitulo.Margin = new Padding(3, 2, 3, 2);
            txtTitulo.Name = "txtTitulo";
            txtTitulo.Size = new Size(380, 23);
            txtTitulo.TabIndex = 0;
            // 
            // cmbDisciplina
            // 
            cmbDisciplina.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbDisciplina.FormattingEnabled = true;
            cmbDisciplina.Location = new Point(110, 121);
            cmbDisciplina.Margin = new Padding(3, 2, 3, 2);
            cmbDisciplina.Name = "cmbDisciplina";
            cmbDisciplina.Size = new Size(181, 23);
            cmbDisciplina.TabIndex = 1;
            cmbDisciplina.SelectedIndexChanged += cmbDisciplina_SelectedIndexChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11.25F);
            label5.Location = new Point(299, 120);
            label5.Name = "label5";
            label5.Size = new Size(109, 20);
            label5.TabIndex = 28;
            label5.Text = "Qtd. Questões: ";
            // 
            // checkBoxRecuperacao
            // 
            checkBoxRecuperacao.AutoSize = true;
            checkBoxRecuperacao.Font = new Font("Segoe UI", 11.25F);
            checkBoxRecuperacao.Location = new Point(302, 160);
            checkBoxRecuperacao.Margin = new Padding(3, 2, 3, 2);
            checkBoxRecuperacao.Name = "checkBoxRecuperacao";
            checkBoxRecuperacao.Size = new Size(176, 24);
            checkBoxRecuperacao.TabIndex = 4;
            checkBoxRecuperacao.Text = "Prova de Recuperação";
            checkBoxRecuperacao.UseVisualStyleBackColor = true;
            checkBoxRecuperacao.CheckedChanged += checkBoxRecuperacao_CheckedChanged;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnSortear);
            groupBox1.Controls.Add(listQuestoes);
            groupBox1.Font = new Font("Segoe UI", 11.25F);
            groupBox1.Location = new Point(45, 202);
            groupBox1.Margin = new Padding(3, 2, 3, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 2, 3, 2);
            groupBox1.Size = new Size(445, 261);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Text = "Questões Selecionadas";
            // 
            // btnSortear
            // 
            btnSortear.Font = new Font("Segoe UI", 11.25F);
            btnSortear.Location = new Point(17, 24);
            btnSortear.Name = "btnSortear";
            btnSortear.Size = new Size(145, 26);
            btnSortear.TabIndex = 5;
            btnSortear.Text = "Sortear Questões";
            btnSortear.UseVisualStyleBackColor = true;
            btnSortear.Click += btnSortear_Click;
            // 
            // listQuestoes
            // 
            listQuestoes.FormattingEnabled = true;
            listQuestoes.ItemHeight = 20;
            listQuestoes.Location = new Point(5, 66);
            listQuestoes.Margin = new Padding(3, 2, 3, 2);
            listQuestoes.Name = "listQuestoes";
            listQuestoes.Size = new Size(435, 184);
            listQuestoes.TabIndex = 89;
            // 
            // numQtdQuestoes
            // 
            numQtdQuestoes.Location = new Point(418, 122);
            numQtdQuestoes.Margin = new Padding(3, 2, 3, 2);
            numQtdQuestoes.Name = "numQtdQuestoes";
            numQtdQuestoes.Size = new Size(72, 23);
            numQtdQuestoes.TabIndex = 2;
            // 
            // TelaTesteForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(533, 515);
            Controls.Add(numQtdQuestoes);
            Controls.Add(groupBox1);
            Controls.Add(checkBoxRecuperacao);
            Controls.Add(label5);
            Controls.Add(cmbDisciplina);
            Controls.Add(txtTitulo);
            Controls.Add(txtId);
            Controls.Add(label4);
            Controls.Add(btnGravar);
            Controls.Add(btnCancelar);
            Controls.Add(cmbMateria);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(3, 2, 3, 2);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "TelaTesteForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Formulário de Testes";
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)numQtdQuestoes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtId;
        private Label label4;
        private Button btnGravar;
        private Button btnCancelar;
        private ComboBox cmbMateria;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox txtTitulo;
        private ComboBox cmbDisciplina;
        private DomainUpDown domainUpD;
        private Label label5;
        private CheckBox checkBoxRecuperacao;
        private GroupBox groupBox1;
        private Button btnSortear;
        private ListBox listQuestoes;
        private NumericUpDown numQtdQuestoes;
    }
}
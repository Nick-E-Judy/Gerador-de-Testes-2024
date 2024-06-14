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
            txtId.Location = new Point(126, 61);
            txtId.Name = "txtId";
            txtId.Size = new Size(110, 27);
            txtId.TabIndex = 24;
            txtId.Text = "0";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11.25F);
            label4.Location = new Point(88, 61);
            label4.Name = "label4";
            label4.Size = new Size(32, 25);
            label4.TabIndex = 23;
            label4.Text = "Id:";
            // 
            // btnGravar
            // 
            btnGravar.DialogResult = DialogResult.OK;
            btnGravar.Font = new Font("Segoe UI", 11.25F);
            btnGravar.Location = new Point(325, 639);
            btnGravar.Margin = new Padding(3, 4, 3, 4);
            btnGravar.Name = "btnGravar";
            btnGravar.Size = new Size(114, 35);
            btnGravar.TabIndex = 22;
            btnGravar.Text = "Gravar";
            btnGravar.UseVisualStyleBackColor = true;
            btnGravar.Click += btnGravar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.DialogResult = DialogResult.Cancel;
            btnCancelar.Font = new Font("Segoe UI", 11.25F);
            btnCancelar.Location = new Point(446, 639);
            btnCancelar.Margin = new Padding(3, 4, 3, 4);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(114, 35);
            btnCancelar.TabIndex = 21;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // cmbMateria
            // 
            cmbMateria.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbMateria.FormattingEnabled = true;
            cmbMateria.Location = new Point(126, 216);
            cmbMateria.Name = "cmbMateria";
            cmbMateria.Size = new Size(206, 28);
            cmbMateria.TabIndex = 16;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11.25F);
            label3.Location = new Point(24, 160);
            label3.Name = "label3";
            label3.Size = new Size(103, 25);
            label3.TabIndex = 15;
            label3.Text = "Disciplina: ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.25F);
            label2.Location = new Point(51, 110);
            label2.Name = "label2";
            label2.Size = new Size(69, 25);
            label2.TabIndex = 14;
            label2.Text = "Titulo: ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11.25F);
            label1.Location = new Point(34, 215);
            label1.Name = "label1";
            label1.Size = new Size(86, 25);
            label1.TabIndex = 13;
            label1.Text = "Matéria: ";
            // 
            // txtTitulo
            // 
            txtTitulo.Location = new Point(126, 111);
            txtTitulo.Name = "txtTitulo";
            txtTitulo.Size = new Size(434, 27);
            txtTitulo.TabIndex = 25;
            // 
            // cmbDisciplina
            // 
            cmbDisciplina.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbDisciplina.FormattingEnabled = true;
            cmbDisciplina.Location = new Point(126, 161);
            cmbDisciplina.Name = "cmbDisciplina";
            cmbDisciplina.Size = new Size(206, 28);
            cmbDisciplina.TabIndex = 26;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11.25F);
            label5.Location = new Point(342, 160);
            label5.Name = "label5";
            label5.Size = new Size(139, 25);
            label5.TabIndex = 28;
            label5.Text = "Qtd. Questões: ";
            // 
            // checkBoxRecuperacao
            // 
            checkBoxRecuperacao.AutoSize = true;
            checkBoxRecuperacao.Font = new Font("Segoe UI", 11.25F);
            checkBoxRecuperacao.Location = new Point(345, 214);
            checkBoxRecuperacao.Name = "checkBoxRecuperacao";
            checkBoxRecuperacao.Size = new Size(221, 29);
            checkBoxRecuperacao.TabIndex = 29;
            checkBoxRecuperacao.Text = "Prova de Recuperação";
            checkBoxRecuperacao.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnSortear);
            groupBox1.Controls.Add(listQuestoes);
            groupBox1.Font = new Font("Segoe UI", 11.25F);
            groupBox1.Location = new Point(51, 270);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(509, 348);
            groupBox1.TabIndex = 30;
            groupBox1.TabStop = false;
            groupBox1.Text = "Questões Selecionadas";
            // 
            // btnSortear
            // 
            btnSortear.DialogResult = DialogResult.OK;
            btnSortear.Font = new Font("Segoe UI", 11.25F);
            btnSortear.Location = new Point(19, 32);
            btnSortear.Margin = new Padding(3, 4, 3, 4);
            btnSortear.Name = "btnSortear";
            btnSortear.Size = new Size(166, 35);
            btnSortear.TabIndex = 31;
            btnSortear.Text = "Sortear Questões";
            btnSortear.UseVisualStyleBackColor = true;
            // 
            // listQuestoes
            // 
            listQuestoes.FormattingEnabled = true;
            listQuestoes.ItemHeight = 25;
            listQuestoes.Location = new Point(6, 88);
            listQuestoes.Name = "listQuestoes";
            listQuestoes.Size = new Size(497, 254);
            listQuestoes.TabIndex = 0;
            // 
            // numQtdQuestoes
            // 
            numQtdQuestoes.Location = new Point(478, 162);
            numQtdQuestoes.Name = "numQtdQuestoes";
            numQtdQuestoes.Size = new Size(82, 27);
            numQtdQuestoes.TabIndex = 31;
            // 
            // TelaTesteForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(609, 687);
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
            Name = "TelaTesteForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Cadastro de Teste";
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
namespace GeradorDeTestes.WinApp.ModuloTeste
{
    partial class TelaVisualizarTesteForm
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
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox1 = new GroupBox();
            listQuestoes = new ListBox();
            btnFechar = new Button();
            lblTituloTeste = new Label();
            lblNomeDisciplina = new Label();
            lblNomeMateria = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11.25F);
            label3.Location = new Point(38, 84);
            label3.Name = "label3";
            label3.Size = new Size(81, 20);
            label3.TabIndex = 18;
            label3.Text = "Disciplina: ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.25F);
            label2.Location = new Point(62, 46);
            label2.Name = "label2";
            label2.Size = new Size(54, 20);
            label2.TabIndex = 17;
            label2.Text = "Titulo: ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11.25F);
            label1.Location = new Point(47, 125);
            label1.Name = "label1";
            label1.Size = new Size(67, 20);
            label1.TabIndex = 16;
            label1.Text = "Matéria: ";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(listQuestoes);
            groupBox1.Font = new Font("Segoe UI", 11.25F);
            groupBox1.Location = new Point(38, 177);
            groupBox1.Margin = new Padding(3, 2, 3, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 2, 3, 2);
            groupBox1.Size = new Size(454, 272);
            groupBox1.TabIndex = 31;
            groupBox1.TabStop = false;
            groupBox1.Text = "Questões Selecionadas";
            // 
            // listQuestoes
            // 
            listQuestoes.FormattingEnabled = true;
            listQuestoes.ItemHeight = 20;
            listQuestoes.Location = new Point(9, 32);
            listQuestoes.Margin = new Padding(3, 2, 3, 2);
            listQuestoes.Name = "listQuestoes";
            listQuestoes.Size = new Size(435, 224);
            listQuestoes.TabIndex = 36;
            // 
            // btnFechar
            // 
            btnFechar.DialogResult = DialogResult.Cancel;
            btnFechar.Font = new Font("Segoe UI", 11.25F);
            btnFechar.Location = new Point(393, 454);
            btnFechar.Name = "btnFechar";
            btnFechar.Size = new Size(100, 26);
            btnFechar.TabIndex = 0;
            btnFechar.Text = "Fechar";
            btnFechar.UseVisualStyleBackColor = true;
            // 
            // lblTituloTeste
            // 
            lblTituloTeste.AutoSize = true;
            lblTituloTeste.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTituloTeste.Location = new Point(128, 46);
            lblTituloTeste.Name = "lblTituloTeste";
            lblTituloTeste.Size = new Size(103, 20);
            lblTituloTeste.TabIndex = 33;
            lblTituloTeste.Text = "[Titulo Teste]";
            // 
            // lblNomeDisciplina
            // 
            lblNomeDisciplina.AutoSize = true;
            lblNomeDisciplina.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNomeDisciplina.Location = new Point(128, 84);
            lblNomeDisciplina.Name = "lblNomeDisciplina";
            lblNomeDisciplina.Size = new Size(135, 20);
            lblNomeDisciplina.TabIndex = 34;
            lblNomeDisciplina.Text = "[Nome Disciplina]";
            // 
            // lblNomeMateria
            // 
            lblNomeMateria.AutoSize = true;
            lblNomeMateria.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNomeMateria.Location = new Point(128, 125);
            lblNomeMateria.Name = "lblNomeMateria";
            lblNomeMateria.Size = new Size(122, 20);
            lblNomeMateria.TabIndex = 35;
            lblNomeMateria.Text = "[Nome Matéria]";
            // 
            // TelaVisualizarTesteForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(530, 490);
            Controls.Add(lblNomeMateria);
            Controls.Add(lblNomeDisciplina);
            Controls.Add(lblTituloTeste);
            Controls.Add(btnFechar);
            Controls.Add(groupBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(3, 2, 3, 2);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "TelaVisualizarTesteForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Visualizar Testes";
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label3;
        private Label label2;
        private Label label1;
        private GroupBox groupBox1;
        private ListBox listQuestoes;
        private Button btnFechar;
        private Label lblTituloTeste;
        private Label lblNomeDisciplina;
        private Label lblNomeMateria;
    }
}
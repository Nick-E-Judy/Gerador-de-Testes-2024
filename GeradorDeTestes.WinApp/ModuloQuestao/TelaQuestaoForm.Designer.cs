namespace GeradorDeTestes.WinApp.ModuloQuestao
{
    partial class TelaQuestaoForm
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            cmbMateria = new ComboBox();
            txtResposta = new TextBox();
            txtEnunciado = new RichTextBox();
            groupBox1 = new GroupBox();
            btnRemover = new Button();
            listAlternativas = new CheckedListBox();
            btnAdicionar = new Button();
            btnGravar = new Button();
            btnCancelar = new Button();
            txtId = new TextBox();
            label4 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11.25F);
            label1.Location = new Point(62, 97);
            label1.Name = "label1";
            label1.Size = new Size(86, 25);
            label1.TabIndex = 0;
            label1.Text = "Matéria: ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.25F);
            label2.Location = new Point(43, 179);
            label2.Name = "label2";
            label2.Size = new Size(105, 25);
            label2.TabIndex = 1;
            label2.Text = "Enunciado:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11.25F);
            label3.Location = new Point(53, 263);
            label3.Name = "label3";
            label3.Size = new Size(95, 25);
            label3.TabIndex = 2;
            label3.Text = "Resposta: ";
            // 
            // cmbMateria
            // 
            cmbMateria.FormattingEnabled = true;
            cmbMateria.Location = new Point(153, 94);
            cmbMateria.Name = "cmbMateria";
            cmbMateria.Size = new Size(221, 28);
            cmbMateria.TabIndex = 3;
            // 
            // txtResposta
            // 
            txtResposta.Location = new Point(153, 258);
            txtResposta.Name = "txtResposta";
            txtResposta.Size = new Size(221, 27);
            txtResposta.TabIndex = 4;
            // 
            // txtEnunciado
            // 
            txtEnunciado.Location = new Point(153, 147);
            txtEnunciado.Name = "txtEnunciado";
            txtEnunciado.Size = new Size(360, 85);
            txtEnunciado.TabIndex = 5;
            txtEnunciado.Text = "";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnRemover);
            groupBox1.Controls.Add(listAlternativas);
            groupBox1.Font = new Font("Segoe UI", 11.25F);
            groupBox1.Location = new Point(43, 311);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(470, 243);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "Alternativas";
            // 
            // btnRemover
            // 
            btnRemover.Location = new Point(19, 35);
            btnRemover.Name = "btnRemover";
            btnRemover.Size = new Size(106, 32);
            btnRemover.TabIndex = 1;
            btnRemover.Text = "Remover";
            btnRemover.UseVisualStyleBackColor = true;
            // 
            // listAlternativas
            // 
            listAlternativas.FormattingEnabled = true;
            listAlternativas.Location = new Point(19, 89);
            listAlternativas.Name = "listAlternativas";
            listAlternativas.Size = new Size(403, 112);
            listAlternativas.TabIndex = 0;
            // 
            // btnAdicionar
            // 
            btnAdicionar.Font = new Font("Segoe UI", 11.25F);
            btnAdicionar.Location = new Point(387, 257);
            btnAdicionar.Name = "btnAdicionar";
            btnAdicionar.Size = new Size(126, 31);
            btnAdicionar.TabIndex = 7;
            btnAdicionar.Text = "Adicionar";
            btnAdicionar.UseVisualStyleBackColor = true;
            // 
            // btnGravar
            // 
            btnGravar.DialogResult = DialogResult.OK;
            btnGravar.Font = new Font("Segoe UI", 11.25F);
            btnGravar.Location = new Point(278, 570);
            btnGravar.Margin = new Padding(3, 4, 3, 4);
            btnGravar.Name = "btnGravar";
            btnGravar.Size = new Size(114, 35);
            btnGravar.TabIndex = 10;
            btnGravar.Text = "Gravar";
            btnGravar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            btnCancelar.DialogResult = DialogResult.Cancel;
            btnCancelar.Font = new Font("Segoe UI", 11.25F);
            btnCancelar.Location = new Point(399, 570);
            btnCancelar.Margin = new Padding(3, 4, 3, 4);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(114, 35);
            btnCancelar.TabIndex = 9;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // txtId
            // 
            txtId.Enabled = false;
            txtId.Location = new Point(153, 46);
            txtId.Name = "txtId";
            txtId.Size = new Size(110, 27);
            txtId.TabIndex = 12;
            txtId.Text = "0";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11.25F);
            label4.Location = new Point(115, 45);
            label4.Name = "label4";
            label4.Size = new Size(32, 25);
            label4.TabIndex = 11;
            label4.Text = "Id:";
            // 
            // TelaQuestaoForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(559, 636);
            Controls.Add(txtId);
            Controls.Add(label4);
            Controls.Add(btnGravar);
            Controls.Add(btnCancelar);
            Controls.Add(btnAdicionar);
            Controls.Add(groupBox1);
            Controls.Add(txtEnunciado);
            Controls.Add(txtResposta);
            Controls.Add(cmbMateria);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "TelaQuestaoForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Cadastros de Questões";
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private ComboBox cmbMateria;
        private TextBox txtResposta;
        private RichTextBox txtEnunciado;
        private GroupBox groupBox1;
        private Button btnAdicionar;
        private Button btnRemover;
        private CheckedListBox listAlternativas;
        private Button btnGravar;
        private Button btnCancelar;
        private TextBox txtId;
        private Label label4;
    }
}
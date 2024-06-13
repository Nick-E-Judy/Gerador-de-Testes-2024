namespace GeradorDeTestes.WinApp.ModuloMateria
{
    partial class TelaMateriaForm
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
            btnGravar = new Button();
            btnCancelar = new Button();
            txtNome = new TextBox();
            txtId = new TextBox();
            label2 = new Label();
            label1 = new Label();
            label3 = new Label();
            label4 = new Label();
            rb1Serie = new RadioButton();
            rb2Serie = new RadioButton();
            cbDisciplina = new ComboBox();
            SuspendLayout();
            // 
            // btnGravar
            // 
            btnGravar.DialogResult = DialogResult.OK;
            btnGravar.Font = new Font("Segoe UI", 11.25F);
            btnGravar.Location = new Point(167, 177);
            btnGravar.Name = "btnGravar";
            btnGravar.Size = new Size(100, 26);
            btnGravar.TabIndex = 14;
            btnGravar.Text = "Gravar";
            btnGravar.UseVisualStyleBackColor = true;
            btnGravar.Click += btnGravar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.DialogResult = DialogResult.Cancel;
            btnCancelar.Font = new Font("Segoe UI", 11.25F);
            btnCancelar.Location = new Point(273, 177);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(100, 26);
            btnCancelar.TabIndex = 13;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // txtNome
            // 
            txtNome.Location = new Point(111, 56);
            txtNome.Margin = new Padding(3, 2, 3, 2);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(262, 23);
            txtNome.TabIndex = 12;
            // 
            // txtId
            // 
            txtId.Enabled = false;
            txtId.Location = new Point(111, 17);
            txtId.Margin = new Padding(3, 2, 3, 2);
            txtId.Name = "txtId";
            txtId.Size = new Size(92, 23);
            txtId.TabIndex = 11;
            txtId.Text = "0";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.25F);
            label2.Location = new Point(46, 59);
            label2.Name = "label2";
            label2.Size = new Size(57, 20);
            label2.TabIndex = 10;
            label2.Text = "Nome: ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11.25F);
            label1.Location = new Point(78, 20);
            label1.Name = "label1";
            label1.Size = new Size(25, 20);
            label1.TabIndex = 9;
            label1.Text = "Id:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11.25F);
            label3.Location = new Point(26, 100);
            label3.Name = "label3";
            label3.Size = new Size(77, 20);
            label3.TabIndex = 15;
            label3.Text = "Disciplina:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11.25F);
            label4.Location = new Point(58, 134);
            label4.Name = "label4";
            label4.Size = new Size(45, 20);
            label4.TabIndex = 17;
            label4.Text = "Série:";
            // 
            // rb1Serie
            // 
            rb1Serie.AutoSize = true;
            rb1Serie.Location = new Point(111, 136);
            rb1Serie.Name = "rb1Serie";
            rb1Serie.Size = new Size(36, 19);
            rb1Serie.TabIndex = 18;
            rb1Serie.TabStop = true;
            rb1Serie.Text = "1ª";
            rb1Serie.UseVisualStyleBackColor = true;
            // 
            // rb2Serie
            // 
            rb2Serie.AutoSize = true;
            rb2Serie.Location = new Point(180, 136);
            rb2Serie.Name = "rb2Serie";
            rb2Serie.Size = new Size(36, 19);
            rb2Serie.TabIndex = 19;
            rb2Serie.TabStop = true;
            rb2Serie.Text = "2ª";
            rb2Serie.UseVisualStyleBackColor = true;
            // 
            // cbDisciplina
            // 
            cbDisciplina.DropDownStyle = ComboBoxStyle.DropDownList;
            cbDisciplina.FormattingEnabled = true;
            cbDisciplina.Location = new Point(111, 101);
            cbDisciplina.Name = "cbDisciplina";
            cbDisciplina.Size = new Size(105, 23);
            cbDisciplina.TabIndex = 20;
            // 
            // TelaMateriaForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(412, 241);
            Controls.Add(cbDisciplina);
            Controls.Add(rb2Serie);
            Controls.Add(rb1Serie);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(btnGravar);
            Controls.Add(btnCancelar);
            Controls.Add(txtNome);
            Controls.Add(txtId);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "TelaMateriaForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "TelaMateriaForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnGravar;
        private Button btnCancelar;
        private TextBox txtNome;
        private TextBox txtId;
        private Label label2;
        private Label label1;
        private TextBox textBox1;
        private Label label3;
        private Label label4;
        private RadioButton rb1Serie;
        private RadioButton rb2Serie;
        private ComboBox cbDisciplina;
    }
}
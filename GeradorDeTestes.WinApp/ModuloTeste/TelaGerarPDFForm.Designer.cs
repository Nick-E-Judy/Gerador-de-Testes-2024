namespace GeradorDeTestes.WinApp.ModuloTeste
{
    partial class TelaGerarPDFForm
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
            btnGerar = new Button();
            btnCancelar = new Button();
            checkBoxGabarito = new CheckBox();
            SuspendLayout();
            // 
            // btnGerar
            // 
            btnGerar.DialogResult = DialogResult.OK;
            btnGerar.Font = new Font("Segoe UI", 11.25F);
            btnGerar.Location = new Point(204, 113);
            btnGerar.Name = "btnGerar";
            btnGerar.Size = new Size(100, 26);
            btnGerar.TabIndex = 1;
            btnGerar.Text = "Gerar";
            btnGerar.UseVisualStyleBackColor = true;
            btnGerar.Click += btnGerar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.DialogResult = DialogResult.Cancel;
            btnCancelar.Font = new Font("Segoe UI", 11.25F);
            btnCancelar.Location = new Point(310, 113);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(100, 26);
            btnCancelar.TabIndex = 2;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // checkBoxGabarito
            // 
            checkBoxGabarito.AutoSize = true;
            checkBoxGabarito.Font = new Font("Segoe UI", 11.25F);
            checkBoxGabarito.Location = new Point(62, 41);
            checkBoxGabarito.Margin = new Padding(3, 2, 3, 2);
            checkBoxGabarito.Name = "checkBoxGabarito";
            checkBoxGabarito.Size = new Size(278, 24);
            checkBoxGabarito.TabIndex = 0;
            checkBoxGabarito.Text = "Gerar PDF com gabarito das questões";
            checkBoxGabarito.UseVisualStyleBackColor = true;
            // 
            // TelaGerarPDFForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(422, 162);
            Controls.Add(checkBoxGabarito);
            Controls.Add(btnGerar);
            Controls.Add(btnCancelar);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "TelaGerarPDFForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Gerar PDFs";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckBox cbGabarito;
        private Button btnGerar;
        private Button btnCancelar;
        private CheckBox checkBoxGabarito;
    }
}
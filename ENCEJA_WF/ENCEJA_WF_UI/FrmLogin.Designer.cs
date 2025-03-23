namespace ENCEJA_WF_UI
{
    partial class FrmLogin
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
            inputEmail = new TextBox();
            inputSenha = new TextBox();
            labelSenha = new Label();
            labelEmail = new Label();
            btnSalvar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(253, 45);
            label1.Name = "label1";
            label1.Size = new Size(265, 50);
            label1.TabIndex = 0;
            label1.Text = "Faça Seu Login";
            label1.Click += label1_Click;
            // 
            // inputEmail
            // 
            inputEmail.Location = new Point(288, 156);
            inputEmail.Multiline = true;
            inputEmail.Name = "inputEmail";
            inputEmail.Size = new Size(184, 28);
            inputEmail.TabIndex = 1;
            // 
            // inputSenha
            // 
            inputSenha.Location = new Point(288, 216);
            inputSenha.Multiline = true;
            inputSenha.Name = "inputSenha";
            inputSenha.Size = new Size(184, 28);
            inputSenha.TabIndex = 2;
            // 
            // labelSenha
            // 
            labelSenha.AutoSize = true;
            labelSenha.Location = new Point(289, 198);
            labelSenha.Name = "labelSenha";
            labelSenha.Size = new Size(39, 15);
            labelSenha.TabIndex = 7;
            labelSenha.Text = "Senha";
            // 
            // labelEmail
            // 
            labelEmail.AutoSize = true;
            labelEmail.Location = new Point(292, 138);
            labelEmail.Name = "labelEmail";
            labelEmail.Size = new Size(36, 15);
            labelEmail.TabIndex = 8;
            labelEmail.Text = "Email";
            // 
            // btnSalvar
            // 
            btnSalvar.Location = new Point(335, 266);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(81, 43);
            btnSalvar.TabIndex = 9;
            btnSalvar.Text = "Entrar";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // FrmLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnSalvar);
            Controls.Add(labelEmail);
            Controls.Add(labelSenha);
            Controls.Add(inputSenha);
            Controls.Add(inputEmail);
            Controls.Add(label1);
            Name = "FrmLogin";
            Text = "FrmLogin";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox inputEmail;
        private TextBox inputSenha;
        private Label labelSenha;
        private Label labelEmail;
        private Button btnSalvar;
    }
}
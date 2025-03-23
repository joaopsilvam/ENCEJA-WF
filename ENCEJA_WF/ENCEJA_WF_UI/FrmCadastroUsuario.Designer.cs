namespace ENCEJA_WF_UI
{
    partial class FrmCadastroUsuario
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
            inputNome = new TextBox();
            btnSalvar = new Button();
            labelSenha = new Label();
            labelNome = new Label();
            labelEmail = new Label();
            inputEmail = new TextBox();
            inputSenha = new TextBox();
            SuspendLayout();
            // 
            // inputNome
            // 
            inputNome.Location = new Point(271, 122);
            inputNome.Multiline = true;
            inputNome.Name = "inputNome";
            inputNome.Size = new Size(184, 28);
            inputNome.TabIndex = 0;
            // 
            // btnSalvar
            // 
            btnSalvar.Location = new Point(323, 294);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(81, 43);
            btnSalvar.TabIndex = 1;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // labelSenha
            // 
            labelSenha.AutoSize = true;
            labelSenha.Location = new Point(272, 226);
            labelSenha.Name = "labelSenha";
            labelSenha.Size = new Size(39, 15);
            labelSenha.TabIndex = 4;
            labelSenha.Text = "Senha";
            // 
            // labelNome
            // 
            labelNome.AutoSize = true;
            labelNome.Location = new Point(271, 104);
            labelNome.Name = "labelNome";
            labelNome.Size = new Size(40, 15);
            labelNome.TabIndex = 5;
            labelNome.Text = "Nome";
            // 
            // labelEmail
            // 
            labelEmail.AutoSize = true;
            labelEmail.Location = new Point(271, 164);
            labelEmail.Name = "labelEmail";
            labelEmail.Size = new Size(36, 15);
            labelEmail.TabIndex = 6;
            labelEmail.Text = "Email";
            // 
            // inputEmail
            // 
            inputEmail.Location = new Point(271, 182);
            inputEmail.Multiline = true;
            inputEmail.Name = "inputEmail";
            inputEmail.Size = new Size(184, 28);
            inputEmail.TabIndex = 7;
            // 
            // inputSenha
            // 
            inputSenha.Location = new Point(272, 244);
            inputSenha.Multiline = true;
            inputSenha.Name = "inputSenha";
            inputSenha.Size = new Size(184, 28);
            inputSenha.TabIndex = 8;
            // 
            // FrmCadastroUsuario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(inputSenha);
            Controls.Add(inputEmail);
            Controls.Add(labelEmail);
            Controls.Add(labelNome);
            Controls.Add(labelSenha);
            Controls.Add(btnSalvar);
            Controls.Add(inputNome);
            Name = "FrmCadastroUsuario";
            Text = "FrmCadastroUsuario";
            Load += FrmCadastroUsuario_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox inputNome;
        private Button btnSalvar;
        private Label labelSenha;
        private Label labelNome;
        private Label labelEmail;
        private TextBox inputEmail;
        private TextBox inputSenha;
    }
}
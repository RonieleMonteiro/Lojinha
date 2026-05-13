namespace Lojinha.Formularios
{
    partial class ClientesForm
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
            this.codigoLabel = new System.Windows.Forms.Label();
            this.nomeLabel = new System.Windows.Forms.Label();
            this.emailLabel = new System.Windows.Forms.Label();
            this.telefoneLabel = new System.Windows.Forms.Label();
            this.codigoTextbox = new System.Windows.Forms.TextBox();
            this.nomeTextbox = new System.Windows.Forms.TextBox();
            this.emailTextbox = new System.Windows.Forms.TextBox();
            this.telefoneTextbox = new System.Windows.Forms.TextBox();
            this.incluirButton = new System.Windows.Forms.Button();
            this.alterarButton = new System.Windows.Forms.Button();
            this.excluirButton = new System.Windows.Forms.Button();
            this.listagemButton = new System.Windows.Forms.Button();
            this.LimparButton = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // codigoLabel
            // 
            this.codigoLabel.AutoSize = true;
            this.codigoLabel.Location = new System.Drawing.Point(59, 37);
            this.codigoLabel.Name = "codigoLabel";
            this.codigoLabel.Size = new System.Drawing.Size(43, 13);
            this.codigoLabel.TabIndex = 0;
            this.codigoLabel.Text = "Código:";
            // 
            // nomeLabel
            // 
            this.nomeLabel.AutoSize = true;
            this.nomeLabel.Location = new System.Drawing.Point(59, 69);
            this.nomeLabel.Name = "nomeLabel";
            this.nomeLabel.Size = new System.Drawing.Size(38, 13);
            this.nomeLabel.TabIndex = 1;
            this.nomeLabel.Text = "Nome:";
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Location = new System.Drawing.Point(59, 104);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(38, 13);
            this.emailLabel.TabIndex = 2;
            this.emailLabel.Text = "E-mail:";
            // 
            // telefoneLabel
            // 
            this.telefoneLabel.AutoSize = true;
            this.telefoneLabel.Location = new System.Drawing.Point(59, 135);
            this.telefoneLabel.Name = "telefoneLabel";
            this.telefoneLabel.Size = new System.Drawing.Size(52, 13);
            this.telefoneLabel.TabIndex = 3;
            this.telefoneLabel.Text = "Telefone:";
            // 
            // codigoTextbox
            // 
            this.codigoTextbox.Enabled = false;
            this.codigoTextbox.Location = new System.Drawing.Point(121, 29);
            this.codigoTextbox.Name = "codigoTextbox";
            this.codigoTextbox.Size = new System.Drawing.Size(100, 20);
            this.codigoTextbox.TabIndex = 4;
            // 
            // nomeTextbox
            // 
            this.nomeTextbox.Location = new System.Drawing.Point(121, 61);
            this.nomeTextbox.Name = "nomeTextbox";
            this.nomeTextbox.Size = new System.Drawing.Size(325, 20);
            this.nomeTextbox.TabIndex = 5;
            // 
            // emailTextbox
            // 
            this.emailTextbox.Location = new System.Drawing.Point(121, 96);
            this.emailTextbox.Name = "emailTextbox";
            this.emailTextbox.Size = new System.Drawing.Size(261, 20);
            this.emailTextbox.TabIndex = 6;
            this.emailTextbox.TextChanged += new System.EventHandler(this.emailtextbox_TextChanged);
            // 
            // telefoneTextbox
            // 
            this.telefoneTextbox.Location = new System.Drawing.Point(121, 127);
            this.telefoneTextbox.Name = "telefoneTextbox";
            this.telefoneTextbox.Size = new System.Drawing.Size(171, 20);
            this.telefoneTextbox.TabIndex = 7;
            // 
            // incluirButton
            // 
            this.incluirButton.Location = new System.Drawing.Point(121, 176);
            this.incluirButton.Name = "incluirButton";
            this.incluirButton.Size = new System.Drawing.Size(75, 23);
            this.incluirButton.TabIndex = 8;
            this.incluirButton.Text = "Incluir";
            this.incluirButton.UseVisualStyleBackColor = true;
            this.incluirButton.Click += new System.EventHandler(this.incluirButton_Click);
            // 
            // alterarButton
            // 
            this.alterarButton.Location = new System.Drawing.Point(242, 176);
            this.alterarButton.Name = "alterarButton";
            this.alterarButton.Size = new System.Drawing.Size(75, 23);
            this.alterarButton.TabIndex = 9;
            this.alterarButton.Text = "Alterar";
            this.alterarButton.UseVisualStyleBackColor = true;
            // 
            // excluirButton
            // 
            this.excluirButton.Location = new System.Drawing.Point(345, 176);
            this.excluirButton.Name = "excluirButton";
            this.excluirButton.Size = new System.Drawing.Size(75, 23);
            this.excluirButton.TabIndex = 10;
            this.excluirButton.Text = "Excluir";
            this.excluirButton.UseVisualStyleBackColor = true;
            // 
            // listagemButton
            // 
            this.listagemButton.Location = new System.Drawing.Point(467, 176);
            this.listagemButton.Name = "listagemButton";
            this.listagemButton.Size = new System.Drawing.Size(75, 23);
            this.listagemButton.TabIndex = 11;
            this.listagemButton.Text = "Listagem";
            this.listagemButton.UseVisualStyleBackColor = true;
            // 
            // LimparButton
            // 
            this.LimparButton.Location = new System.Drawing.Point(592, 178);
            this.LimparButton.Name = "LimparButton";
            this.LimparButton.Size = new System.Drawing.Size(64, 20);
            this.LimparButton.TabIndex = 12;
            this.LimparButton.Text = "Limpar";
            this.LimparButton.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ClientesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LimparButton);
            this.Controls.Add(this.listagemButton);
            this.Controls.Add(this.excluirButton);
            this.Controls.Add(this.alterarButton);
            this.Controls.Add(this.incluirButton);
            this.Controls.Add(this.telefoneTextbox);
            this.Controls.Add(this.emailTextbox);
            this.Controls.Add(this.nomeTextbox);
            this.Controls.Add(this.codigoTextbox);
            this.Controls.Add(this.telefoneLabel);
            this.Controls.Add(this.emailLabel);
            this.Controls.Add(this.nomeLabel);
            this.Controls.Add(this.codigoLabel);
            this.Name = "ClientesForm";
            this.Text = "ClientesForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label codigoLabel;
        private System.Windows.Forms.Label nomeLabel;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.Label telefoneLabel;
        private System.Windows.Forms.TextBox codigoTextbox;
        private System.Windows.Forms.TextBox nomeTextbox;
        private System.Windows.Forms.TextBox emailTextbox;
        private System.Windows.Forms.TextBox telefoneTextbox;
        private System.Windows.Forms.Button incluirButton;
        private System.Windows.Forms.Button alterarButton;
        private System.Windows.Forms.Button excluirButton;
        private System.Windows.Forms.Button listagemButton;
        private System.Windows.Forms.TextBox LimparButton;
    }
}
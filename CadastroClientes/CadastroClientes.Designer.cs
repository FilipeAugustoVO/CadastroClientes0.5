namespace CadastroClientes
{
    partial class CadastroClientes
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
            this.btnPessoaFisica = new System.Windows.Forms.Button();
            this.lblNome = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtCadastroPessoaFisica = new System.Windows.Forms.TextBox();
            this.btnPessoaJuridica = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.lblEndereco = new System.Windows.Forms.Label();
            this.txtEndereco = new System.Windows.Forms.TextBox();
            this.lblDocumento1 = new System.Windows.Forms.Label();
            this.txtDocumento1 = new System.Windows.Forms.TextBox();
            this.lblDocumento2 = new System.Windows.Forms.Label();
            this.txtDocumento2 = new System.Windows.Forms.TextBox();
            this.txtCadastroPessoaJuridica = new System.Windows.Forms.TextBox();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnPessoaFisica
            // 
            this.btnPessoaFisica.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPessoaFisica.Location = new System.Drawing.Point(29, 12);
            this.btnPessoaFisica.Name = "btnPessoaFisica";
            this.btnPessoaFisica.Size = new System.Drawing.Size(75, 41);
            this.btnPessoaFisica.TabIndex = 0;
            this.btnPessoaFisica.Text = "Pessoa Física";
            this.btnPessoaFisica.UseVisualStyleBackColor = true;
            this.btnPessoaFisica.Click += new System.EventHandler(this.btnPessoaFisica_Click);
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.Location = new System.Drawing.Point(9, 76);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(49, 15);
            this.lblNome.TabIndex = 1;
            this.lblNome.Text = "Nome:";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(80, 72);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(400, 20);
            this.txtNome.TabIndex = 4;
            // 
            // txtCadastroPessoaFisica
            // 
            this.txtCadastroPessoaFisica.Location = new System.Drawing.Point(12, 166);
            this.txtCadastroPessoaFisica.Multiline = true;
            this.txtCadastroPessoaFisica.Name = "txtCadastroPessoaFisica";
            this.txtCadastroPessoaFisica.ReadOnly = true;
            this.txtCadastroPessoaFisica.Size = new System.Drawing.Size(468, 179);
            this.txtCadastroPessoaFisica.TabIndex = 8;
            this.txtCadastroPessoaFisica.TabStop = false;
            // 
            // btnPessoaJuridica
            // 
            this.btnPessoaJuridica.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPessoaJuridica.Location = new System.Drawing.Point(147, 12);
            this.btnPessoaJuridica.Name = "btnPessoaJuridica";
            this.btnPessoaJuridica.Size = new System.Drawing.Size(75, 41);
            this.btnPessoaJuridica.TabIndex = 1;
            this.btnPessoaJuridica.Text = "Pessoa Jurídica";
            this.btnPessoaJuridica.UseVisualStyleBackColor = true;
            this.btnPessoaJuridica.Click += new System.EventHandler(this.btnPessoaJuridica_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.Location = new System.Drawing.Point(265, 12);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 41);
            this.btnSalvar.TabIndex = 2;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // lblEndereco
            // 
            this.lblEndereco.AutoSize = true;
            this.lblEndereco.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEndereco.Location = new System.Drawing.Point(9, 103);
            this.lblEndereco.Name = "lblEndereco";
            this.lblEndereco.Size = new System.Drawing.Size(72, 15);
            this.lblEndereco.TabIndex = 1;
            this.lblEndereco.Text = "Endereço:";
            // 
            // txtEndereco
            // 
            this.txtEndereco.Location = new System.Drawing.Point(80, 98);
            this.txtEndereco.Name = "txtEndereco";
            this.txtEndereco.Size = new System.Drawing.Size(400, 20);
            this.txtEndereco.TabIndex = 5;
            // 
            // lblDocumento1
            // 
            this.lblDocumento1.AutoSize = true;
            this.lblDocumento1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDocumento1.Location = new System.Drawing.Point(9, 128);
            this.lblDocumento1.Name = "lblDocumento1";
            this.lblDocumento1.Size = new System.Drawing.Size(31, 15);
            this.lblDocumento1.TabIndex = 1;
            this.lblDocumento1.Text = "RG:";
            // 
            // txtDocumento1
            // 
            this.txtDocumento1.Location = new System.Drawing.Point(80, 124);
            this.txtDocumento1.Name = "txtDocumento1";
            this.txtDocumento1.Size = new System.Drawing.Size(131, 20);
            this.txtDocumento1.TabIndex = 6;
            // 
            // lblDocumento2
            // 
            this.lblDocumento2.AutoSize = true;
            this.lblDocumento2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDocumento2.Location = new System.Drawing.Point(276, 128);
            this.lblDocumento2.Name = "lblDocumento2";
            this.lblDocumento2.Size = new System.Drawing.Size(37, 15);
            this.lblDocumento2.TabIndex = 1;
            this.lblDocumento2.Text = "CPF:";
            // 
            // txtDocumento2
            // 
            this.txtDocumento2.Location = new System.Drawing.Point(325, 124);
            this.txtDocumento2.Name = "txtDocumento2";
            this.txtDocumento2.Size = new System.Drawing.Size(155, 20);
            this.txtDocumento2.TabIndex = 7;
            // 
            // txtCadastroPessoaJuridica
            // 
            this.txtCadastroPessoaJuridica.Location = new System.Drawing.Point(12, 166);
            this.txtCadastroPessoaJuridica.Multiline = true;
            this.txtCadastroPessoaJuridica.Name = "txtCadastroPessoaJuridica";
            this.txtCadastroPessoaJuridica.ReadOnly = true;
            this.txtCadastroPessoaJuridica.Size = new System.Drawing.Size(468, 179);
            this.txtCadastroPessoaJuridica.TabIndex = 9;
            this.txtCadastroPessoaJuridica.TabStop = false;
            // 
            // btnLimpar
            // 
            this.btnLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.Location = new System.Drawing.Point(383, 12);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(75, 41);
            this.btnLimpar.TabIndex = 3;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // CadastroClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(492, 353);
            this.Controls.Add(this.txtCadastroPessoaJuridica);
            this.Controls.Add(this.txtCadastroPessoaFisica);
            this.Controls.Add(this.txtDocumento2);
            this.Controls.Add(this.lblDocumento2);
            this.Controls.Add(this.txtDocumento1);
            this.Controls.Add(this.lblDocumento1);
            this.Controls.Add(this.txtEndereco);
            this.Controls.Add(this.lblEndereco);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.btnPessoaJuridica);
            this.Controls.Add(this.btnPessoaFisica);
            this.Name = "CadastroClientes";
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.CadastroClientes_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPessoaFisica;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtCadastroPessoaFisica;
        private System.Windows.Forms.Button btnPessoaJuridica;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Label lblEndereco;
        private System.Windows.Forms.TextBox txtEndereco;
        private System.Windows.Forms.Label lblDocumento1;
        private System.Windows.Forms.TextBox txtDocumento1;
        private System.Windows.Forms.Label lblDocumento2;
        private System.Windows.Forms.TextBox txtDocumento2;
        private System.Windows.Forms.TextBox txtCadastroPessoaJuridica;
        private System.Windows.Forms.Button btnLimpar;
    }
}


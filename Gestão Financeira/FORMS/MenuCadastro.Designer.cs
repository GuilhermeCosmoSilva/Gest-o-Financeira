
namespace Gestão_Financeira
{
    partial class MenuCadastro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuCadastro));
            this.btnCadVoltar = new System.Windows.Forms.Button();
            this.btnCadCadastrar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCadNome = new System.Windows.Forms.TextBox();
            this.txtCadConfirmSenha = new System.Windows.Forms.TextBox();
            this.txtCadSenha = new System.Windows.Forms.TextBox();
            this.txtCadLogin = new System.Windows.Forms.TextBox();
            this.txtCadSalario = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCadVoltar
            // 
            this.btnCadVoltar.BackColor = System.Drawing.SystemColors.Control;
            this.btnCadVoltar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCadVoltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadVoltar.Location = new System.Drawing.Point(62, 392);
            this.btnCadVoltar.Name = "btnCadVoltar";
            this.btnCadVoltar.Size = new System.Drawing.Size(169, 28);
            this.btnCadVoltar.TabIndex = 20;
            this.btnCadVoltar.Text = "Sair";
            this.btnCadVoltar.UseVisualStyleBackColor = false;
            this.btnCadVoltar.Click += new System.EventHandler(this.btnCadVoltar_Click);
            // 
            // btnCadCadastrar
            // 
            this.btnCadCadastrar.BackColor = System.Drawing.SystemColors.Control;
            this.btnCadCadastrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCadCadastrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadCadastrar.Location = new System.Drawing.Point(271, 392);
            this.btnCadCadastrar.Name = "btnCadCadastrar";
            this.btnCadCadastrar.Size = new System.Drawing.Size(169, 28);
            this.btnCadCadastrar.TabIndex = 19;
            this.btnCadCadastrar.Text = "Cadastrar";
            this.btnCadCadastrar.UseVisualStyleBackColor = false;
            this.btnCadCadastrar.Click += new System.EventHandler(this.btnCadCadastrar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(59, 247);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "CONFIRMAR SENHA";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(59, 273);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "NOME";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(59, 221);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "SENHA";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(59, 195);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "E-MAIL";
            // 
            // txtCadNome
            // 
            this.txtCadNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCadNome.Location = new System.Drawing.Point(195, 266);
            this.txtCadNome.Name = "txtCadNome";
            this.txtCadNome.Size = new System.Drawing.Size(245, 20);
            this.txtCadNome.TabIndex = 14;
            this.txtCadNome.TextChanged += new System.EventHandler(this.txtCadNome_TextChanged);
            // 
            // txtCadConfirmSenha
            // 
            this.txtCadConfirmSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCadConfirmSenha.Location = new System.Drawing.Point(195, 240);
            this.txtCadConfirmSenha.Name = "txtCadConfirmSenha";
            this.txtCadConfirmSenha.PasswordChar = '*';
            this.txtCadConfirmSenha.Size = new System.Drawing.Size(245, 20);
            this.txtCadConfirmSenha.TabIndex = 13;
            this.txtCadConfirmSenha.TextChanged += new System.EventHandler(this.txtCadConfirmSenha_TextChanged);
            // 
            // txtCadSenha
            // 
            this.txtCadSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCadSenha.Location = new System.Drawing.Point(195, 214);
            this.txtCadSenha.Name = "txtCadSenha";
            this.txtCadSenha.PasswordChar = '*';
            this.txtCadSenha.Size = new System.Drawing.Size(245, 20);
            this.txtCadSenha.TabIndex = 12;
            this.txtCadSenha.TextChanged += new System.EventHandler(this.txtCadSenha_TextChanged);
            // 
            // txtCadLogin
            // 
            this.txtCadLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCadLogin.Location = new System.Drawing.Point(195, 188);
            this.txtCadLogin.Name = "txtCadLogin";
            this.txtCadLogin.Size = new System.Drawing.Size(245, 20);
            this.txtCadLogin.TabIndex = 11;
            this.txtCadLogin.TextChanged += new System.EventHandler(this.txtCadLogin_TextChanged);
            // 
            // txtCadSalario
            // 
            this.txtCadSalario.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCadSalario.Location = new System.Drawing.Point(195, 292);
            this.txtCadSalario.Name = "txtCadSalario";
            this.txtCadSalario.Size = new System.Drawing.Size(245, 20);
            this.txtCadSalario.TabIndex = 21;
            this.txtCadSalario.TextChanged += new System.EventHandler(this.txtCadSalario_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(59, 299);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 22;
            this.label5.Text = "SALARIO";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Location = new System.Drawing.Point(177, 8);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(151, 138);
            this.pictureBox1.TabIndex = 23;
            this.pictureBox1.TabStop = false;
            // 
            // MenuCadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(500, 500);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtCadSalario);
            this.Controls.Add(this.btnCadVoltar);
            this.Controls.Add(this.btnCadCadastrar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCadNome);
            this.Controls.Add(this.txtCadConfirmSenha);
            this.Controls.Add(this.txtCadSenha);
            this.Controls.Add(this.txtCadLogin);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MenuCadastro";
            this.Text = "MenuCadastro";
            this.Load += new System.EventHandler(this.MenuCadastro_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCadVoltar;
        private System.Windows.Forms.Button btnCadCadastrar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCadNome;
        private System.Windows.Forms.TextBox txtCadConfirmSenha;
        private System.Windows.Forms.TextBox txtCadSenha;
        private System.Windows.Forms.TextBox txtCadLogin;
        private System.Windows.Forms.TextBox txtCadSalario;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
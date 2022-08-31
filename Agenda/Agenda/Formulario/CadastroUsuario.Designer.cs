namespace Agenda.Formulario
{
    partial class CadastroUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadastroUsuario));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Botao_Voltar = new System.Windows.Forms.Button();
            this.Botao_cadastrar = new System.Windows.Forms.Button();
            this.Txt_senha = new System.Windows.Forms.TextBox();
            this.Txt_nome_usuario = new System.Windows.Forms.TextBox();
            this.Txt_email = new System.Windows.Forms.TextBox();
            this.Txt_nome = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.Botao_Voltar);
            this.groupBox1.Controls.Add(this.Botao_cadastrar);
            this.groupBox1.Controls.Add(this.Txt_senha);
            this.groupBox1.Controls.Add(this.Txt_nome_usuario);
            this.groupBox1.Controls.Add(this.Txt_email);
            this.groupBox1.Controls.Add(this.Txt_nome);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(501, 415);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(262, 97);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(207, 213);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Botao_Voltar
            // 
            this.Botao_Voltar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Botao_Voltar.BackgroundImage")));
            this.Botao_Voltar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Botao_Voltar.Location = new System.Drawing.Point(417, 22);
            this.Botao_Voltar.Name = "Botao_Voltar";
            this.Botao_Voltar.Size = new System.Drawing.Size(63, 35);
            this.Botao_Voltar.TabIndex = 17;
            this.Botao_Voltar.UseVisualStyleBackColor = true;
            this.Botao_Voltar.Click += new System.EventHandler(this.Botao_Voltar_Click);
            // 
            // Botao_cadastrar
            // 
            this.Botao_cadastrar.Font = new System.Drawing.Font("Arial Black", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Botao_cadastrar.Location = new System.Drawing.Point(18, 343);
            this.Botao_cadastrar.Name = "Botao_cadastrar";
            this.Botao_cadastrar.Size = new System.Drawing.Size(101, 30);
            this.Botao_cadastrar.TabIndex = 16;
            this.Botao_cadastrar.Text = "Cadastrar";
            this.Botao_cadastrar.UseVisualStyleBackColor = true;
            this.Botao_cadastrar.Click += new System.EventHandler(this.Botao_cadastrar_Click);
            // 
            // Txt_senha
            // 
            this.Txt_senha.Location = new System.Drawing.Point(18, 287);
            this.Txt_senha.Name = "Txt_senha";
            this.Txt_senha.PasswordChar = '*';
            this.Txt_senha.Size = new System.Drawing.Size(206, 23);
            this.Txt_senha.TabIndex = 15;
            // 
            // Txt_nome_usuario
            // 
            this.Txt_nome_usuario.Location = new System.Drawing.Point(18, 229);
            this.Txt_nome_usuario.Name = "Txt_nome_usuario";
            this.Txt_nome_usuario.Size = new System.Drawing.Size(206, 23);
            this.Txt_nome_usuario.TabIndex = 14;
            // 
            // Txt_email
            // 
            this.Txt_email.Location = new System.Drawing.Point(18, 162);
            this.Txt_email.Name = "Txt_email";
            this.Txt_email.Size = new System.Drawing.Size(206, 23);
            this.Txt_email.TabIndex = 13;
            // 
            // Txt_nome
            // 
            this.Txt_nome.Location = new System.Drawing.Point(18, 97);
            this.Txt_nome.Name = "Txt_nome";
            this.Txt_nome.Size = new System.Drawing.Size(206, 23);
            this.Txt_nome.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Black", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(18, 265);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 19);
            this.label4.TabIndex = 11;
            this.label4.Text = "Senha:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Black", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(18, 207);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(166, 19);
            this.label3.TabIndex = 10;
            this.label3.Text = "Nome Para Usuário: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Black", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(18, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 19);
            this.label2.TabIndex = 9;
            this.label2.Text = "Email:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Black", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(18, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 19);
            this.label1.TabIndex = 8;
            this.label1.Text = "Nome:";
            // 
            // CadastroUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RosyBrown;
            this.ClientSize = new System.Drawing.Size(516, 439);
            this.Controls.Add(this.groupBox1);
            this.Name = "CadastroUsuario";
            this.Text = "CadastroUsuario";
            this.Load += new System.EventHandler(this.CadastroUsuario_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBox1;
        private TextBox Txt_senha;
        private TextBox Txt_nome_usuario;
        private TextBox Txt_email;
        private TextBox Txt_nome;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private PictureBox pictureBox1;
        private Button Botao_Voltar;
        private Button Botao_cadastrar;
    }
}
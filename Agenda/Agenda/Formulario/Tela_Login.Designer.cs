namespace Agenda
{
    partial class Tela_Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Tela_Login));
            this.Txt_nome_login = new System.Windows.Forms.TextBox();
            this.Txt_senha_login = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Button_Login = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Botao_Criar_Cadastro = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Txt_nome_login
            // 
            this.Txt_nome_login.Font = new System.Drawing.Font("Arial Black", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Txt_nome_login.Location = new System.Drawing.Point(185, 65);
            this.Txt_nome_login.Name = "Txt_nome_login";
            this.Txt_nome_login.Size = new System.Drawing.Size(263, 26);
            this.Txt_nome_login.TabIndex = 0;
            // 
            // Txt_senha_login
            // 
            this.Txt_senha_login.Font = new System.Drawing.Font("Arial Black", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Txt_senha_login.Location = new System.Drawing.Point(185, 156);
            this.Txt_senha_login.Name = "Txt_senha_login";
            this.Txt_senha_login.PasswordChar = '*';
            this.Txt_senha_login.Size = new System.Drawing.Size(263, 26);
            this.Txt_senha_login.TabIndex = 1;
            this.Txt_senha_login.TextChanged += new System.EventHandler(this.Txt_senha_login_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Black", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(185, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "Usuario:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Black", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(185, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "Senha:";
            // 
            // Button_Login
            // 
            this.Button_Login.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Button_Login.BackgroundImage")));
            this.Button_Login.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Button_Login.Font = new System.Drawing.Font("Arial Black", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Document);
            this.Button_Login.Location = new System.Drawing.Point(205, 216);
            this.Button_Login.Name = "Button_Login";
            this.Button_Login.Size = new System.Drawing.Size(80, 61);
            this.Button_Login.TabIndex = 4;
            this.Button_Login.Text = "Login";
            this.Button_Login.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Button_Login.UseVisualStyleBackColor = true;
            this.Button_Login.Click += new System.EventHandler(this.Button_Login_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(7, 31);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(145, 139);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.RosyBrown;
            this.groupBox1.Controls.Add(this.Botao_Criar_Cadastro);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.Button_Login);
            this.groupBox1.Controls.Add(this.Txt_senha_login);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.Txt_nome_login);
            this.groupBox1.Location = new System.Drawing.Point(5, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(487, 346);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            // 
            // Botao_Criar_Cadastro
            // 
            this.Botao_Criar_Cadastro.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Botao_Criar_Cadastro.Font = new System.Drawing.Font("Arial Black", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Document);
            this.Botao_Criar_Cadastro.Image = ((System.Drawing.Image)(resources.GetObject("Botao_Criar_Cadastro.Image")));
            this.Botao_Criar_Cadastro.Location = new System.Drawing.Point(354, 216);
            this.Botao_Criar_Cadastro.Name = "Botao_Criar_Cadastro";
            this.Botao_Criar_Cadastro.Size = new System.Drawing.Size(80, 61);
            this.Botao_Criar_Cadastro.TabIndex = 10;
            this.Botao_Criar_Cadastro.Text = "Cadastrar";
            this.Botao_Criar_Cadastro.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Botao_Criar_Cadastro.UseVisualStyleBackColor = true;
            this.Botao_Criar_Cadastro.Click += new System.EventHandler(this.Botao_Criar_Cadastro_Click);
            // 
            // Tela_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(497, 358);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.Name = "Tela_Login";
            this.Text = "Agenda";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TextBox Txt_nome_login;
        private TextBox Txt_senha_login;
        private Label label1;
        private Label label2;
        private Button Button_Login;
        private PictureBox pictureBox1;
        private GroupBox groupBox1;
        private Button Botao_Criar_Cadastro;
    }
}
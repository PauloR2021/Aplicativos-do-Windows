namespace Agenda
{
    partial class Tela_Principal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Tela_Principal));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Tela_Buscar = new System.Windows.Forms.ListView();
            this.Buscar = new System.Windows.Forms.Button();
            this.TXT_Busca = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.Telefone = new System.Windows.Forms.MaskedTextBox();
            this.Telefone_II = new System.Windows.Forms.MaskedTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.TXT_Email_II = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.TXT_Email = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.TXT_Telefone_II = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TXT_Telefone = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TXT_Apelido = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TXT_Segundo_Nome = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TXT_Nome = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Botao_Voltar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.RosyBrown;
            this.groupBox1.Controls.Add(this.Botao_Voltar);
            this.groupBox1.Controls.Add(this.Tela_Buscar);
            this.groupBox1.Controls.Add(this.Buscar);
            this.groupBox1.Controls.Add(this.TXT_Busca);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.Telefone);
            this.groupBox1.Controls.Add(this.Telefone_II);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.TXT_Email_II);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.TXT_Email);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.TXT_Telefone_II);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.TXT_Telefone);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.TXT_Apelido);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.TXT_Segundo_Nome);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.TXT_Nome);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(1, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(822, 497);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // Tela_Buscar
            // 
            this.Tela_Buscar.Location = new System.Drawing.Point(311, 120);
            this.Tela_Buscar.Name = "Tela_Buscar";
            this.Tela_Buscar.Size = new System.Drawing.Size(505, 281);
            this.Tela_Buscar.TabIndex = 21;
            this.Tela_Buscar.UseCompatibleStateImageBehavior = false;
            // 
            // Buscar
            // 
            this.Buscar.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Buscar.Location = new System.Drawing.Point(709, 61);
            this.Buscar.Name = "Buscar";
            this.Buscar.Size = new System.Drawing.Size(102, 24);
            this.Buscar.TabIndex = 20;
            this.Buscar.Text = "Buscar";
            this.Buscar.UseVisualStyleBackColor = true;
            this.Buscar.Click += new System.EventHandler(this.Buscar_Click);
            // 
            // TXT_Busca
            // 
            this.TXT_Busca.Location = new System.Drawing.Point(311, 61);
            this.TXT_Busca.Name = "TXT_Busca";
            this.TXT_Busca.Size = new System.Drawing.Size(392, 23);
            this.TXT_Busca.TabIndex = 19;
            this.TXT_Busca.TextChanged += new System.EventHandler(this.TXT_Busca_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.RosyBrown;
            this.label8.Font = new System.Drawing.Font("Arial Black", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(328, 38);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(140, 19);
            this.label8.TabIndex = 18;
            this.label8.Text = "Buscar Contatos:";
            // 
            // Telefone
            // 
            this.Telefone.Location = new System.Drawing.Point(6, 225);
            this.Telefone.Mask = "(99) 0 0000-0000";
            this.Telefone.Name = "Telefone";
            this.Telefone.Size = new System.Drawing.Size(299, 23);
            this.Telefone.TabIndex = 16;
            this.Telefone.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBox2_MaskInputRejected);
            // 
            // Telefone_II
            // 
            this.Telefone_II.Location = new System.Drawing.Point(6, 282);
            this.Telefone_II.Mask = "(99) 0 0000-0000";
            this.Telefone_II.Name = "Telefone_II";
            this.Telefone_II.Size = new System.Drawing.Size(299, 23);
            this.Telefone_II.TabIndex = 15;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(91, 425);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 27);
            this.button1.TabIndex = 14;
            this.button1.Text = "Salvar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // TXT_Email_II
            // 
            this.TXT_Email_II.Location = new System.Drawing.Point(6, 378);
            this.TXT_Email_II.Name = "TXT_Email_II";
            this.TXT_Email_II.Size = new System.Drawing.Size(299, 23);
            this.TXT_Email_II.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial Black", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(6, 356);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 19);
            this.label7.TabIndex = 12;
            this.label7.Text = "Email II :";
            // 
            // TXT_Email
            // 
            this.TXT_Email.Location = new System.Drawing.Point(6, 330);
            this.TXT_Email.Name = "TXT_Email";
            this.TXT_Email.Size = new System.Drawing.Size(299, 23);
            this.TXT_Email.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Black", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(6, 308);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 19);
            this.label6.TabIndex = 10;
            this.label6.Text = "Email :";
            // 
            // TXT_Telefone_II
            // 
            this.TXT_Telefone_II.Location = new System.Drawing.Point(6, 282);
            this.TXT_Telefone_II.Name = "TXT_Telefone_II";
            this.TXT_Telefone_II.Size = new System.Drawing.Size(299, 23);
            this.TXT_Telefone_II.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Black", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(6, 260);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 19);
            this.label5.TabIndex = 8;
            this.label5.Text = "Telefone II :";
            // 
            // TXT_Telefone
            // 
            this.TXT_Telefone.Location = new System.Drawing.Point(6, 225);
            this.TXT_Telefone.Name = "TXT_Telefone";
            this.TXT_Telefone.Size = new System.Drawing.Size(299, 23);
            this.TXT_Telefone.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Black", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(6, 203);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 19);
            this.label4.TabIndex = 6;
            this.label4.Text = "Telefone:";
            // 
            // TXT_Apelido
            // 
            this.TXT_Apelido.Location = new System.Drawing.Point(6, 168);
            this.TXT_Apelido.Name = "TXT_Apelido";
            this.TXT_Apelido.Size = new System.Drawing.Size(299, 23);
            this.TXT_Apelido.TabIndex = 5;
            this.TXT_Apelido.TextChanged += new System.EventHandler(this.TXT_Apelido_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Black", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(6, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 19);
            this.label3.TabIndex = 4;
            this.label3.Text = "Apelido:";
            // 
            // TXT_Segundo_Nome
            // 
            this.TXT_Segundo_Nome.Location = new System.Drawing.Point(6, 120);
            this.TXT_Segundo_Nome.Name = "TXT_Segundo_Nome";
            this.TXT_Segundo_Nome.Size = new System.Drawing.Size(299, 23);
            this.TXT_Segundo_Nome.TabIndex = 3;
            this.TXT_Segundo_Nome.TextChanged += new System.EventHandler(this.TXT_Segundo_Nome_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Black", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(6, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Segundo Nome:";
            // 
            // TXT_Nome
            // 
            this.TXT_Nome.Location = new System.Drawing.Point(6, 60);
            this.TXT_Nome.Name = "TXT_Nome";
            this.TXT_Nome.Size = new System.Drawing.Size(299, 23);
            this.TXT_Nome.TabIndex = 1;
            this.TXT_Nome.TextChanged += new System.EventHandler(this.TXT_Nome_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Black", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(6, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome:";
            // 
            // Botao_Voltar
            // 
            this.Botao_Voltar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Botao_Voltar.BackgroundImage")));
            this.Botao_Voltar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Botao_Voltar.Location = new System.Drawing.Point(748, 425);
            this.Botao_Voltar.Name = "Botao_Voltar";
            this.Botao_Voltar.Size = new System.Drawing.Size(63, 35);
            this.Botao_Voltar.TabIndex = 22;
            this.Botao_Voltar.UseVisualStyleBackColor = true;
            this.Botao_Voltar.Click += new System.EventHandler(this.Botao_Voltar_Click);
            // 
            // Tela_Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(824, 502);
            this.Controls.Add(this.groupBox1);
            this.Name = "Tela_Principal";
            this.Text = "AGENDA";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBox1;
        private Button button1;
        private TextBox TXT_Email_II;
        private Label label7;
        private TextBox TXT_Email;
        private Label label6;
        private TextBox TXT_Telefone_II;
        private Label label5;
        private TextBox TXT_Telefone;
        private Label label4;
        private TextBox TXT_Apelido;
        private Label label3;
        private TextBox TXT_Segundo_Nome;
        private Label label2;
        private TextBox TXT_Nome;
        private Label label1;
        private MaskedTextBox Telefone_II;
        private Button Buscar;
        private TextBox TXT_Busca;
        private Label label8;
        private MaskedTextBox Telefone;
        private ListView Tela_Buscar;
        private Button Botao_Voltar;
    }
}
namespace PI_01
{
    partial class Clientes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Clientes));
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tb_Nome = new System.Windows.Forms.TextBox();
            this.Tb_Telefone = new System.Windows.Forms.TextBox();
            this.tb_CPF = new System.Windows.Forms.TextBox();
            this.tb_Pagamento = new System.Windows.Forms.TextBox();
            this.gb_Estufa = new System.Windows.Forms.GroupBox();
            this.rb_Aqua = new System.Windows.Forms.RadioButton();
            this.rb_Fechado = new System.Windows.Forms.RadioButton();
            this.rb_Semi = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_Garantia = new System.Windows.Forms.TextBox();
            this.bt_Limpar = new System.Windows.Forms.Button();
            this.bt_Excluir = new System.Windows.Forms.Button();
            this.bt_Consultar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bt_Cadastrar = new System.Windows.Forms.Button();
            this.tb_ID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gb_Estufa.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(33, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nome";
            this.label2.Click += new System.EventHandler(this.Label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(33, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Telefone";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(271, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "CPF";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(271, 66);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(110, 15);
            this.label6.TabIndex = 5;
            this.label6.Text = "Data de pagamento";
            // 
            // tb_Nome
            // 
            this.tb_Nome.Location = new System.Drawing.Point(36, 82);
            this.tb_Nome.Name = "tb_Nome";
            this.tb_Nome.Size = new System.Drawing.Size(129, 20);
            this.tb_Nome.TabIndex = 7;
            // 
            // Tb_Telefone
            // 
            this.Tb_Telefone.Location = new System.Drawing.Point(36, 132);
            this.Tb_Telefone.Name = "Tb_Telefone";
            this.Tb_Telefone.Size = new System.Drawing.Size(129, 20);
            this.Tb_Telefone.TabIndex = 8;
            // 
            // tb_CPF
            // 
            this.tb_CPF.Location = new System.Drawing.Point(274, 34);
            this.tb_CPF.Name = "tb_CPF";
            this.tb_CPF.Size = new System.Drawing.Size(132, 20);
            this.tb_CPF.TabIndex = 10;
            // 
            // tb_Pagamento
            // 
            this.tb_Pagamento.Location = new System.Drawing.Point(274, 84);
            this.tb_Pagamento.Name = "tb_Pagamento";
            this.tb_Pagamento.Size = new System.Drawing.Size(132, 20);
            this.tb_Pagamento.TabIndex = 11;
            // 
            // gb_Estufa
            // 
            this.gb_Estufa.Controls.Add(this.rb_Aqua);
            this.gb_Estufa.Controls.Add(this.rb_Fechado);
            this.gb_Estufa.Controls.Add(this.rb_Semi);
            this.gb_Estufa.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_Estufa.Location = new System.Drawing.Point(283, 171);
            this.gb_Estufa.Name = "gb_Estufa";
            this.gb_Estufa.Size = new System.Drawing.Size(200, 87);
            this.gb_Estufa.TabIndex = 13;
            this.gb_Estufa.TabStop = false;
            this.gb_Estufa.Text = "Modelo de estufa";
            // 
            // rb_Aqua
            // 
            this.rb_Aqua.AutoSize = true;
            this.rb_Aqua.Location = new System.Drawing.Point(6, 66);
            this.rb_Aqua.Name = "rb_Aqua";
            this.rb_Aqua.Size = new System.Drawing.Size(69, 19);
            this.rb_Aqua.TabIndex = 2;
            this.rb_Aqua.TabStop = true;
            this.rb_Aqua.Text = "Aquário";
            this.rb_Aqua.UseVisualStyleBackColor = true;
            // 
            // rb_Fechado
            // 
            this.rb_Fechado.AutoSize = true;
            this.rb_Fechado.Location = new System.Drawing.Point(6, 43);
            this.rb_Fechado.Name = "rb_Fechado";
            this.rb_Fechado.Size = new System.Drawing.Size(71, 19);
            this.rb_Fechado.TabIndex = 1;
            this.rb_Fechado.TabStop = true;
            this.rb_Fechado.Text = "Fechado";
            this.rb_Fechado.UseVisualStyleBackColor = true;
            // 
            // rb_Semi
            // 
            this.rb_Semi.AutoSize = true;
            this.rb_Semi.Location = new System.Drawing.Point(6, 20);
            this.rb_Semi.Name = "rb_Semi";
            this.rb_Semi.Size = new System.Drawing.Size(88, 19);
            this.rb_Semi.TabIndex = 0;
            this.rb_Semi.TabStop = true;
            this.rb_Semi.Text = "Semi-aberto";
            this.rb_Semi.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(271, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 15);
            this.label4.TabIndex = 15;
            this.label4.Text = "Data - Garantia";
            // 
            // tb_Garantia
            // 
            this.tb_Garantia.Location = new System.Drawing.Point(274, 132);
            this.tb_Garantia.Name = "tb_Garantia";
            this.tb_Garantia.Size = new System.Drawing.Size(132, 20);
            this.tb_Garantia.TabIndex = 16;
            // 
            // bt_Limpar
            // 
            this.bt_Limpar.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Limpar.Image = global::PI_01.Properties.Resources.Limpar;
            this.bt_Limpar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_Limpar.Location = new System.Drawing.Point(146, 224);
            this.bt_Limpar.Name = "bt_Limpar";
            this.bt_Limpar.Size = new System.Drawing.Size(122, 35);
            this.bt_Limpar.TabIndex = 19;
            this.bt_Limpar.Text = "Limpar";
            this.bt_Limpar.UseVisualStyleBackColor = true;
            this.bt_Limpar.Click += new System.EventHandler(this.Bt_Limpar_Click);
            // 
            // bt_Excluir
            // 
            this.bt_Excluir.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Excluir.Image = global::PI_01.Properties.Resources.Excluir;
            this.bt_Excluir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_Excluir.Location = new System.Drawing.Point(12, 224);
            this.bt_Excluir.Name = "bt_Excluir";
            this.bt_Excluir.Size = new System.Drawing.Size(128, 35);
            this.bt_Excluir.TabIndex = 18;
            this.bt_Excluir.Text = "Excluir";
            this.bt_Excluir.UseVisualStyleBackColor = true;
            this.bt_Excluir.Click += new System.EventHandler(this.Bt_Excluir_Click);
            // 
            // bt_Consultar
            // 
            this.bt_Consultar.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Consultar.Image = global::PI_01.Properties.Resources.Consultar;
            this.bt_Consultar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_Consultar.Location = new System.Drawing.Point(146, 171);
            this.bt_Consultar.Name = "bt_Consultar";
            this.bt_Consultar.Size = new System.Drawing.Size(122, 35);
            this.bt_Consultar.TabIndex = 17;
            this.bt_Consultar.Text = "Consultar";
            this.bt_Consultar.UseVisualStyleBackColor = true;
            this.bt_Consultar.Click += new System.EventHandler(this.Bt_Consultar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PI_01.Properties.Resources.User_Img;
            this.pictureBox1.Location = new System.Drawing.Point(431, 34);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(129, 120);
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // bt_Cadastrar
            // 
            this.bt_Cadastrar.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Cadastrar.Image = global::PI_01.Properties.Resources.SignIn;
            this.bt_Cadastrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_Cadastrar.Location = new System.Drawing.Point(12, 171);
            this.bt_Cadastrar.Name = "bt_Cadastrar";
            this.bt_Cadastrar.Size = new System.Drawing.Size(128, 35);
            this.bt_Cadastrar.TabIndex = 12;
            this.bt_Cadastrar.Text = "Cadastrar";
            this.bt_Cadastrar.UseVisualStyleBackColor = true;
            this.bt_Cadastrar.Click += new System.EventHandler(this.Bt_Cadastrar_Click);
            // 
            // tb_ID
            // 
            this.tb_ID.Location = new System.Drawing.Point(36, 32);
            this.tb_ID.Name = "tb_ID";
            this.tb_ID.Size = new System.Drawing.Size(129, 20);
            this.tb_ID.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(33, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 15);
            this.label1.TabIndex = 20;
            this.label1.Text = "ID";
            // 
            // Clientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(572, 271);
            this.Controls.Add(this.tb_ID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bt_Limpar);
            this.Controls.Add(this.bt_Excluir);
            this.Controls.Add(this.bt_Consultar);
            this.Controls.Add(this.tb_Garantia);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.gb_Estufa);
            this.Controls.Add(this.bt_Cadastrar);
            this.Controls.Add(this.tb_Pagamento);
            this.Controls.Add(this.tb_CPF);
            this.Controls.Add(this.Tb_Telefone);
            this.Controls.Add(this.tb_Nome);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Clientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Clientes";
            this.gb_Estufa.ResumeLayout(false);
            this.gb_Estufa.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tb_Nome;
        private System.Windows.Forms.TextBox Tb_Telefone;
        private System.Windows.Forms.TextBox tb_CPF;
        private System.Windows.Forms.TextBox tb_Pagamento;
        private System.Windows.Forms.Button bt_Cadastrar;
        private System.Windows.Forms.GroupBox gb_Estufa;
        private System.Windows.Forms.RadioButton rb_Aqua;
        private System.Windows.Forms.RadioButton rb_Fechado;
        private System.Windows.Forms.RadioButton rb_Semi;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_Garantia;
        private System.Windows.Forms.Button bt_Consultar;
        private System.Windows.Forms.Button bt_Excluir;
        private System.Windows.Forms.Button bt_Limpar;
        private System.Windows.Forms.TextBox tb_ID;
        private System.Windows.Forms.Label label1;
    }
}
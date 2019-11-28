namespace PI_01
{
    partial class Estoque
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Estoque));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_Peca = new System.Windows.Forms.TextBox();
            this.tb_Quant = new System.Windows.Forms.TextBox();
            this.tb_Data = new System.Windows.Forms.TextBox();
            this.bt_Consultar = new System.Windows.Forms.Button();
            this.bt_Excluir = new System.Windows.Forms.Button();
            this.bt_Limpar = new System.Windows.Forms.Button();
            this.bt_Cadastrar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_ID = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Peça";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(217, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Quantidade";
            this.label2.Click += new System.EventHandler(this.Label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(217, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Data";
            // 
            // tb_Peca
            // 
            this.tb_Peca.Location = new System.Drawing.Point(26, 91);
            this.tb_Peca.Name = "tb_Peca";
            this.tb_Peca.Size = new System.Drawing.Size(117, 20);
            this.tb_Peca.TabIndex = 3;
            // 
            // tb_Quant
            // 
            this.tb_Quant.Location = new System.Drawing.Point(222, 35);
            this.tb_Quant.Name = "tb_Quant";
            this.tb_Quant.Size = new System.Drawing.Size(117, 20);
            this.tb_Quant.TabIndex = 4;
            // 
            // tb_Data
            // 
            this.tb_Data.Location = new System.Drawing.Point(220, 91);
            this.tb_Data.Name = "tb_Data";
            this.tb_Data.Size = new System.Drawing.Size(119, 20);
            this.tb_Data.TabIndex = 5;
            // 
            // bt_Consultar
            // 
            this.bt_Consultar.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Consultar.Image = global::PI_01.Properties.Resources.Consultar;
            this.bt_Consultar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_Consultar.Location = new System.Drawing.Point(157, 135);
            this.bt_Consultar.Name = "bt_Consultar";
            this.bt_Consultar.Size = new System.Drawing.Size(129, 44);
            this.bt_Consultar.TabIndex = 7;
            this.bt_Consultar.Text = "Consultar";
            this.bt_Consultar.UseVisualStyleBackColor = true;
            this.bt_Consultar.Click += new System.EventHandler(this.Bt_Consultar_Click);
            // 
            // bt_Excluir
            // 
            this.bt_Excluir.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Excluir.Image = global::PI_01.Properties.Resources.Excluir;
            this.bt_Excluir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_Excluir.Location = new System.Drawing.Point(9, 195);
            this.bt_Excluir.Name = "bt_Excluir";
            this.bt_Excluir.Size = new System.Drawing.Size(129, 44);
            this.bt_Excluir.TabIndex = 8;
            this.bt_Excluir.Text = "Excluir";
            this.bt_Excluir.UseVisualStyleBackColor = true;
            this.bt_Excluir.Click += new System.EventHandler(this.Bt_Excluir_Click);
            // 
            // bt_Limpar
            // 
            this.bt_Limpar.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Limpar.Image = global::PI_01.Properties.Resources.Limpar;
            this.bt_Limpar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_Limpar.Location = new System.Drawing.Point(157, 195);
            this.bt_Limpar.Name = "bt_Limpar";
            this.bt_Limpar.Size = new System.Drawing.Size(129, 44);
            this.bt_Limpar.TabIndex = 9;
            this.bt_Limpar.Text = "Limpar";
            this.bt_Limpar.UseVisualStyleBackColor = true;
            this.bt_Limpar.Click += new System.EventHandler(this.Bt_Limpar_Click);
            // 
            // bt_Cadastrar
            // 
            this.bt_Cadastrar.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Cadastrar.Image = global::PI_01.Properties.Resources.SignIn;
            this.bt_Cadastrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_Cadastrar.Location = new System.Drawing.Point(9, 135);
            this.bt_Cadastrar.Name = "bt_Cadastrar";
            this.bt_Cadastrar.Size = new System.Drawing.Size(129, 44);
            this.bt_Cadastrar.TabIndex = 11;
            this.bt_Cadastrar.Text = "Cadastrar";
            this.bt_Cadastrar.UseVisualStyleBackColor = true;
            this.bt_Cadastrar.Click += new System.EventHandler(this.Bt_Cadastrar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(23, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(20, 15);
            this.label4.TabIndex = 12;
            this.label4.Text = "ID";
            // 
            // tb_ID
            // 
            this.tb_ID.Location = new System.Drawing.Point(24, 35);
            this.tb_ID.Name = "tb_ID";
            this.tb_ID.Size = new System.Drawing.Size(119, 20);
            this.tb_ID.TabIndex = 13;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PI_01.Properties.Resources.Hard2;
            this.pictureBox1.Location = new System.Drawing.Point(293, 123);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(117, 116);
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // Estoque
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(422, 251);
            this.Controls.Add(this.tb_ID);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.bt_Cadastrar);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.bt_Limpar);
            this.Controls.Add(this.bt_Excluir);
            this.Controls.Add(this.bt_Consultar);
            this.Controls.Add(this.tb_Data);
            this.Controls.Add(this.tb_Quant);
            this.Controls.Add(this.tb_Peca);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Estoque";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Estoque";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_Peca;
        private System.Windows.Forms.TextBox tb_Quant;
        private System.Windows.Forms.TextBox tb_Data;
        private System.Windows.Forms.Button bt_Consultar;
        private System.Windows.Forms.Button bt_Excluir;
        private System.Windows.Forms.Button bt_Limpar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button bt_Cadastrar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_ID;
    }
}
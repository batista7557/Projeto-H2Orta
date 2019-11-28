namespace PI_01
{
    partial class Cadastro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cadastro));
            this.tb_Senha = new System.Windows.Forms.TextBox();
            this.tb_Email = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.bt_Sair = new System.Windows.Forms.Button();
            this.bt_Logar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tb_Senha
            // 
            this.tb_Senha.Location = new System.Drawing.Point(115, 63);
            this.tb_Senha.Name = "tb_Senha";
            this.tb_Senha.PasswordChar = '*';
            this.tb_Senha.Size = new System.Drawing.Size(139, 20);
            this.tb_Senha.TabIndex = 11;
            // 
            // tb_Email
            // 
            this.tb_Email.Location = new System.Drawing.Point(115, 22);
            this.tb_Email.Name = "tb_Email";
            this.tb_Email.Size = new System.Drawing.Size(139, 20);
            this.tb_Email.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(49, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 19);
            this.label2.TabIndex = 9;
            this.label2.Text = "Senha";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(49, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 19);
            this.label1.TabIndex = 8;
            this.label1.Text = "E-mail";
            // 
            // bt_Sair
            // 
            this.bt_Sair.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Sair.Image = global::PI_01.Properties.Resources.Sair_Icon;
            this.bt_Sair.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_Sair.Location = new System.Drawing.Point(179, 111);
            this.bt_Sair.Name = "bt_Sair";
            this.bt_Sair.Size = new System.Drawing.Size(144, 44);
            this.bt_Sair.TabIndex = 13;
            this.bt_Sair.Text = "Sair";
            this.bt_Sair.UseVisualStyleBackColor = true;
            this.bt_Sair.Click += new System.EventHandler(this.Bt_Sair_Click);
            // 
            // bt_Logar
            // 
            this.bt_Logar.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Logar.Image = global::PI_01.Properties.Resources.Tatice_Cristal_Intense_Ok;
            this.bt_Logar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_Logar.Location = new System.Drawing.Point(12, 111);
            this.bt_Logar.Name = "bt_Logar";
            this.bt_Logar.Size = new System.Drawing.Size(144, 44);
            this.bt_Logar.TabIndex = 12;
            this.bt_Logar.Text = "Cadastrar";
            this.bt_Logar.UseVisualStyleBackColor = true;
            this.bt_Logar.Click += new System.EventHandler(this.Bt_Logar_Click);
            // 
            // Cadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(335, 187);
            this.Controls.Add(this.bt_Sair);
            this.Controls.Add(this.bt_Logar);
            this.Controls.Add(this.tb_Senha);
            this.Controls.Add(this.tb_Email);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Cadastro";
            this.Text = "Cadastro";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button bt_Sair;
        private System.Windows.Forms.Button bt_Logar;
        private System.Windows.Forms.TextBox tb_Senha;
        private System.Windows.Forms.TextBox tb_Email;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}
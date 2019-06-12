namespace LojadeJogo.Forms.Jogo
{
    partial class UpdateJogo
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
            this.comboBox_plataforma = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_preco = new System.Windows.Forms.MaskedTextBox();
            this.txt_nome = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox_jogo = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_escolher = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboBox_plataforma
            // 
            this.comboBox_plataforma.FormattingEnabled = true;
            this.comboBox_plataforma.Location = new System.Drawing.Point(128, 206);
            this.comboBox_plataforma.Name = "comboBox_plataforma";
            this.comboBox_plataforma.Size = new System.Drawing.Size(441, 21);
            this.comboBox_plataforma.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 209);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Plataforma";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 163);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Preco";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 121);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Jogo";
            // 
            // txt_preco
            // 
            this.txt_preco.Location = new System.Drawing.Point(128, 160);
            this.txt_preco.Name = "txt_preco";
            this.txt_preco.Size = new System.Drawing.Size(441, 20);
            this.txt_preco.TabIndex = 7;
            // 
            // txt_nome
            // 
            this.txt_nome.Location = new System.Drawing.Point(128, 118);
            this.txt_nome.Name = "txt_nome";
            this.txt_nome.Size = new System.Drawing.Size(441, 20);
            this.txt_nome.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(34, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(18, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "ID";
            // 
            // txt_id
            // 
            this.txt_id.Location = new System.Drawing.Point(128, 75);
            this.txt_id.Name = "txt_id";
            this.txt_id.ReadOnly = true;
            this.txt_id.Size = new System.Drawing.Size(441, 20);
            this.txt_id.TabIndex = 12;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(636, 95);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(117, 65);
            this.button1.TabIndex = 14;
            this.button1.Text = "Editar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBox_jogo
            // 
            this.comboBox_jogo.FormattingEnabled = true;
            this.comboBox_jogo.Location = new System.Drawing.Point(217, 34);
            this.comboBox_jogo.Name = "comboBox_jogo";
            this.comboBox_jogo.Size = new System.Drawing.Size(352, 21);
            this.comboBox_jogo.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(34, 37);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(177, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Escolha o jogo que deseja modificar";
            // 
            // btn_escolher
            // 
            this.btn_escolher.Location = new System.Drawing.Point(575, 32);
            this.btn_escolher.Name = "btn_escolher";
            this.btn_escolher.Size = new System.Drawing.Size(60, 23);
            this.btn_escolher.TabIndex = 17;
            this.btn_escolher.Text = "Escolher";
            this.btn_escolher.UseVisualStyleBackColor = true;
            this.btn_escolher.Click += new System.EventHandler(this.btn_escolher_Click);
            // 
            // UpdateJogo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_escolher);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboBox_jogo);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_id);
            this.Controls.Add(this.comboBox_plataforma);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_preco);
            this.Controls.Add(this.txt_nome);
            this.Name = "UpdateJogo";
            this.Text = "UpdateJogo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox_plataforma;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox txt_preco;
        private System.Windows.Forms.TextBox txt_nome;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBox_jogo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_escolher;
    }
}
namespace LojadeJogo.Forms.Jogo
{
    partial class CadJogo
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
            this.txt_nome = new System.Windows.Forms.TextBox();
            this.txt_preco = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox_plataforma = new System.Windows.Forms.ComboBox();
            this.btn_adicionar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_nome
            // 
            this.txt_nome.Location = new System.Drawing.Point(117, 32);
            this.txt_nome.Name = "txt_nome";
            this.txt_nome.Size = new System.Drawing.Size(441, 20);
            this.txt_nome.TabIndex = 0;
            this.txt_nome.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txt_preco
            // 
            this.txt_preco.Location = new System.Drawing.Point(117, 74);
            this.txt_preco.Name = "txt_preco";
            this.txt_preco.Size = new System.Drawing.Size(441, 20);
            this.txt_preco.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Jogo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Preco";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Plataforma";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // comboBox_plataforma
            // 
            this.comboBox_plataforma.FormattingEnabled = true;
            this.comboBox_plataforma.Location = new System.Drawing.Point(117, 120);
            this.comboBox_plataforma.Name = "comboBox_plataforma";
            this.comboBox_plataforma.Size = new System.Drawing.Size(441, 21);
            this.comboBox_plataforma.TabIndex = 5;
            // 
            // btn_adicionar
            // 
            this.btn_adicionar.Location = new System.Drawing.Point(615, 59);
            this.btn_adicionar.Name = "btn_adicionar";
            this.btn_adicionar.Size = new System.Drawing.Size(134, 48);
            this.btn_adicionar.TabIndex = 6;
            this.btn_adicionar.Text = "Adicionar";
            this.btn_adicionar.UseVisualStyleBackColor = true;
            this.btn_adicionar.Click += new System.EventHandler(this.btn_adicionar_Click);
            // 
            // CadJogo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 170);
            this.Controls.Add(this.btn_adicionar);
            this.Controls.Add(this.comboBox_plataforma);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_preco);
            this.Controls.Add(this.txt_nome);
            this.Name = "CadJogo";
            this.Text = "CadJogo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_nome;
        private System.Windows.Forms.MaskedTextBox txt_preco;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox_plataforma;
        private System.Windows.Forms.Button btn_adicionar;
    }
}
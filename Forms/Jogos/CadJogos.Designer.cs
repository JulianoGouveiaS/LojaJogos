namespace LojadeJogo.Forms.Jogos
{
    partial class CadJogos
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
            this.label_jogo = new System.Windows.Forms.Label();
            this.txt_nome = new System.Windows.Forms.TextBox();
            this.btn_adicionar = new System.Windows.Forms.Button();
            this.txt_preco = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox_Plataforma = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label_jogo
            // 
            this.label_jogo.AutoSize = true;
            this.label_jogo.Location = new System.Drawing.Point(26, 36);
            this.label_jogo.Name = "label_jogo";
            this.label_jogo.Size = new System.Drawing.Size(30, 13);
            this.label_jogo.TabIndex = 0;
            this.label_jogo.Text = "Jogo";
            // 
            // txt_nome
            // 
            this.txt_nome.Location = new System.Drawing.Point(65, 36);
            this.txt_nome.Name = "txt_nome";
            this.txt_nome.Size = new System.Drawing.Size(455, 20);
            this.txt_nome.TabIndex = 1;
            // 
            // btn_adicionar
            // 
            this.btn_adicionar.Location = new System.Drawing.Point(601, 67);
            this.btn_adicionar.Name = "btn_adicionar";
            this.btn_adicionar.Size = new System.Drawing.Size(127, 50);
            this.btn_adicionar.TabIndex = 2;
            this.btn_adicionar.Text = "Adicionar";
            this.btn_adicionar.UseVisualStyleBackColor = true;
            this.btn_adicionar.Click += new System.EventHandler(this.btn_adicionar_Click);
            // 
            // txt_preco
            // 
            this.txt_preco.Location = new System.Drawing.Point(65, 83);
            this.txt_preco.Name = "txt_preco";
            this.txt_preco.Size = new System.Drawing.Size(455, 20);
            this.txt_preco.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Preco";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // comboBox_Plataforma
            // 
            this.comboBox_Plataforma.FormattingEnabled = true;
            this.comboBox_Plataforma.Location = new System.Drawing.Point(103, 134);
            this.comboBox_Plataforma.Name = "comboBox_Plataforma";
            this.comboBox_Plataforma.Size = new System.Drawing.Size(417, 21);
            this.comboBox_Plataforma.TabIndex = 5;
            this.comboBox_Plataforma.SelectedIndexChanged += new System.EventHandler(this.comboBox_Plataforma_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Plataforma";
            // 
            // CadJogos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBox_Plataforma);
            this.Controls.Add(this.txt_preco);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_adicionar);
            this.Controls.Add(this.txt_nome);
            this.Controls.Add(this.label_jogo);
            this.Name = "CadJogos";
            this.Text = "CadJogos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_jogo;
        private System.Windows.Forms.TextBox txt_nome;
        private System.Windows.Forms.Button btn_adicionar;
        private System.Windows.Forms.TextBox txt_preco;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox_Plataforma;
        private System.Windows.Forms.Label label2;
    }
}
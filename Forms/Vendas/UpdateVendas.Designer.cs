namespace LojadeJogo.Forms.Vendas
{
    partial class UpdateVendas
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
            this.label4 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbVendas = new System.Windows.Forms.ComboBox();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cb_clientes = new System.Windows.Forms.ComboBox();
            this.cb_funcionarios = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cb_jogo = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Lucida Sans", 9F);
            this.label4.Location = new System.Drawing.Point(13, 158);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 15);
            this.label4.TabIndex = 26;
            this.label4.Text = "Valor:";
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Lucida Sans", 9.25F);
            this.button2.Location = new System.Drawing.Point(12, 287);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(572, 22);
            this.button2.TabIndex = 25;
            this.button2.Text = "Atualizar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Sans", 9F);
            this.label2.Location = new System.Drawing.Point(296, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 15);
            this.label2.TabIndex = 21;
            this.label2.Text = "Descricao:";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Lucida Sans", 9.25F);
            this.button1.Location = new System.Drawing.Point(448, 52);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(136, 21);
            this.button1.TabIndex = 20;
            this.button1.Text = "Escolher";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Sans", 10F);
            this.label1.Location = new System.Drawing.Point(13, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(275, 16);
            this.label1.TabIndex = 19;
            this.label1.Text = "Selecione a venda que deseja modificar:";
            // 
            // cmbVendas
            // 
            this.cmbVendas.FormattingEnabled = true;
            this.cmbVendas.Location = new System.Drawing.Point(12, 52);
            this.cmbVendas.Name = "cmbVendas";
            this.cmbVendas.Size = new System.Drawing.Size(430, 21);
            this.cmbVendas.TabIndex = 18;
            // 
            // txtDescricao
            // 
            this.txtDescricao.Location = new System.Drawing.Point(382, 102);
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(202, 20);
            this.txtDescricao.TabIndex = 27;
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(84, 158);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(184, 20);
            this.txtValor.TabIndex = 28;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lucida Sans", 9F);
            this.label3.Location = new System.Drawing.Point(314, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 15);
            this.label3.TabIndex = 29;
            this.label3.Text = "Cliente:";
            // 
            // cb_clientes
            // 
            this.cb_clientes.FormattingEnabled = true;
            this.cb_clientes.Location = new System.Drawing.Point(382, 156);
            this.cb_clientes.Name = "cb_clientes";
            this.cb_clientes.Size = new System.Drawing.Size(202, 21);
            this.cb_clientes.TabIndex = 30;
            // 
            // cb_funcionarios
            // 
            this.cb_funcionarios.FormattingEnabled = true;
            this.cb_funcionarios.Location = new System.Drawing.Point(84, 210);
            this.cb_funcionarios.Name = "cb_funcionarios";
            this.cb_funcionarios.Size = new System.Drawing.Size(184, 21);
            this.cb_funcionarios.TabIndex = 32;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Lucida Sans", 9F);
            this.label5.Location = new System.Drawing.Point(-1, 212);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 15);
            this.label5.TabIndex = 31;
            this.label5.Text = "Funcionario:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // cb_jogo
            // 
            this.cb_jogo.FormattingEnabled = true;
            this.cb_jogo.Location = new System.Drawing.Point(382, 212);
            this.cb_jogo.Name = "cb_jogo";
            this.cb_jogo.Size = new System.Drawing.Size(202, 21);
            this.cb_jogo.TabIndex = 34;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Lucida Sans", 9F);
            this.label6.Location = new System.Drawing.Point(314, 214);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 15);
            this.label6.TabIndex = 33;
            this.label6.Text = "Jogo:";
            // 
            // txtId
            // 
            this.txtId.Enabled = false;
            this.txtId.Location = new System.Drawing.Point(84, 97);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(180, 20);
            this.txtId.TabIndex = 36;
            this.txtId.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Lucida Sans", 9F);
            this.label7.Location = new System.Drawing.Point(33, 102);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(22, 15);
            this.label7.TabIndex = 35;
            this.label7.Text = "Id:";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // UpdateVendas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(607, 328);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cb_jogo);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cb_funcionarios);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cb_clientes);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.txtDescricao);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbVendas);
            this.Name = "UpdateVendas";
            this.Text = "UpdateVendas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbVendas;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cb_clientes;
        private System.Windows.Forms.ComboBox cb_funcionarios;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cb_jogo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label label7;
    }
}
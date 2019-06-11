namespace LojadeJogo
{
    partial class UpdateFuncionarios
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
            this.label1 = new System.Windows.Forms.Label();
            this.cmb_Funcionarios = new System.Windows.Forms.ComboBox();
            this.bttn_Buscar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_salario = new System.Windows.Forms.TextBox();
            this.bttn_Atualizar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_nome = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(386, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Selecione o funcionário a ser atualizado:";
            // 
            // cmb_Funcionarios
            // 
            this.cmb_Funcionarios.FormattingEnabled = true;
            this.cmb_Funcionarios.Location = new System.Drawing.Point(16, 51);
            this.cmb_Funcionarios.Name = "cmb_Funcionarios";
            this.cmb_Funcionarios.Size = new System.Drawing.Size(382, 21);
            this.cmb_Funcionarios.TabIndex = 1;
            // 
            // bttn_Buscar
            // 
            this.bttn_Buscar.Location = new System.Drawing.Point(423, 49);
            this.bttn_Buscar.Name = "bttn_Buscar";
            this.bttn_Buscar.Size = new System.Drawing.Size(75, 23);
            this.bttn_Buscar.TabIndex = 2;
            this.bttn_Buscar.Text = "Escolher";
            this.bttn_Buscar.UseVisualStyleBackColor = true;
            this.bttn_Buscar.Click += new System.EventHandler(this.bttn_Buscar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "id: ";
            // 
            // txt_id
            // 
            this.txt_id.Location = new System.Drawing.Point(39, 106);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(100, 20);
            this.txt_id.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(149, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Salário: ";
            // 
            // txt_salario
            // 
            this.txt_salario.Location = new System.Drawing.Point(200, 106);
            this.txt_salario.Name = "txt_salario";
            this.txt_salario.Size = new System.Drawing.Size(198, 20);
            this.txt_salario.TabIndex = 6;
            // 
            // bttn_Atualizar
            // 
            this.bttn_Atualizar.Location = new System.Drawing.Point(423, 143);
            this.bttn_Atualizar.Name = "bttn_Atualizar";
            this.bttn_Atualizar.Size = new System.Drawing.Size(75, 23);
            this.bttn_Atualizar.TabIndex = 7;
            this.bttn_Atualizar.Text = "Atualizar";
            this.bttn_Atualizar.UseVisualStyleBackColor = true;
            this.bttn_Atualizar.Click += new System.EventHandler(this.bttn_Atualizar_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 153);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Nome: ";
            // 
            // txt_nome
            // 
            this.txt_nome.Location = new System.Drawing.Point(60, 150);
            this.txt_nome.Name = "txt_nome";
            this.txt_nome.Size = new System.Drawing.Size(338, 20);
            this.txt_nome.TabIndex = 10;
            // 
            // UpdateFuncionarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(506, 175);
            this.Controls.Add(this.txt_nome);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.bttn_Atualizar);
            this.Controls.Add(this.txt_salario);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_id);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.bttn_Buscar);
            this.Controls.Add(this.cmb_Funcionarios);
            this.Controls.Add(this.label1);
            this.Name = "UpdateFuncionarios";
            this.Text = "UpdateFuncionarios";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmb_Funcionarios;
        private System.Windows.Forms.Button bttn_Buscar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_salario;
        private System.Windows.Forms.Button bttn_Atualizar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_nome;
    }
}
namespace LojadeJogo.Forms.Jogo
{
    partial class ExcJogo
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
            this.comboBox_Jogos = new System.Windows.Forms.ComboBox();
            this.btn_excluir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboBox_Jogos
            // 
            this.comboBox_Jogos.FormattingEnabled = true;
            this.comboBox_Jogos.Location = new System.Drawing.Point(54, 61);
            this.comboBox_Jogos.Name = "comboBox_Jogos";
            this.comboBox_Jogos.Size = new System.Drawing.Size(452, 21);
            this.comboBox_Jogos.TabIndex = 0;
            // 
            // btn_excluir
            // 
            this.btn_excluir.Location = new System.Drawing.Point(530, 50);
            this.btn_excluir.Name = "btn_excluir";
            this.btn_excluir.Size = new System.Drawing.Size(109, 41);
            this.btn_excluir.TabIndex = 1;
            this.btn_excluir.Text = "Excluir";
            this.btn_excluir.UseVisualStyleBackColor = true;
            this.btn_excluir.Click += new System.EventHandler(this.btn_excluir_Click);
            // 
            // ExcJogo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(692, 221);
            this.Controls.Add(this.btn_excluir);
            this.Controls.Add(this.comboBox_Jogos);
            this.Name = "ExcJogo";
            this.Text = "ExcJogo";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox_Jogos;
        private System.Windows.Forms.Button btn_excluir;
    }
}
namespace LojadeJogo
{
    partial class ExcFuncionario
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
            this.cmb_Funcionarios = new System.Windows.Forms.ComboBox();
            this.bttn_Excluir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmb_Funcionarios
            // 
            this.cmb_Funcionarios.FormattingEnabled = true;
            this.cmb_Funcionarios.Location = new System.Drawing.Point(24, 21);
            this.cmb_Funcionarios.Name = "cmb_Funcionarios";
            this.cmb_Funcionarios.Size = new System.Drawing.Size(313, 21);
            this.cmb_Funcionarios.TabIndex = 0;
            // 
            // bttn_Excluir
            // 
            this.bttn_Excluir.Location = new System.Drawing.Point(369, 19);
            this.bttn_Excluir.Name = "bttn_Excluir";
            this.bttn_Excluir.Size = new System.Drawing.Size(75, 23);
            this.bttn_Excluir.TabIndex = 1;
            this.bttn_Excluir.Text = "Excluir";
            this.bttn_Excluir.UseVisualStyleBackColor = true;
            this.bttn_Excluir.Click += new System.EventHandler(this.bttn_Excluir_Click);
            // 
            // ExcFuncionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(460, 52);
            this.Controls.Add(this.bttn_Excluir);
            this.Controls.Add(this.cmb_Funcionarios);
            this.Name = "ExcFuncionario";
            this.Text = "ExcFuncionario";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cmb_Funcionarios;
        private System.Windows.Forms.Button bttn_Excluir;
    }
}
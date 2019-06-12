namespace LojadeJogo.Forms.Vendas
{
    partial class ExcVenda
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
            this.bttn_Excluir = new System.Windows.Forms.Button();
            this.cmb_Vendas = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // bttn_Excluir
            // 
            this.bttn_Excluir.Location = new System.Drawing.Point(357, 10);
            this.bttn_Excluir.Name = "bttn_Excluir";
            this.bttn_Excluir.Size = new System.Drawing.Size(75, 23);
            this.bttn_Excluir.TabIndex = 3;
            this.bttn_Excluir.Text = "Excluir";
            this.bttn_Excluir.UseVisualStyleBackColor = true;
            this.bttn_Excluir.Click += new System.EventHandler(this.bttn_Excluir_Click);
            // 
            // cmb_Vendas
            // 
            this.cmb_Vendas.FormattingEnabled = true;
            this.cmb_Vendas.Location = new System.Drawing.Point(12, 12);
            this.cmb_Vendas.Name = "cmb_Vendas";
            this.cmb_Vendas.Size = new System.Drawing.Size(313, 21);
            this.cmb_Vendas.TabIndex = 2;
            // 
            // ExcVenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 45);
            this.Controls.Add(this.bttn_Excluir);
            this.Controls.Add(this.cmb_Vendas);
            this.Name = "ExcVenda";
            this.Text = "ExcVenda";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bttn_Excluir;
        private System.Windows.Forms.ComboBox cmb_Vendas;
    }
}
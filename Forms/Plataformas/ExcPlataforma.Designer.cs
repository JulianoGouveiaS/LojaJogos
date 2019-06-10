namespace LojadeJogo.Forms.Plataformas
{
    partial class ExcPlataforma
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
            this.cmbPlat = new System.Windows.Forms.ComboBox();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmbPlat
            // 
            this.cmbPlat.FormattingEnabled = true;
            this.cmbPlat.Location = new System.Drawing.Point(12, 12);
            this.cmbPlat.Name = "cmbPlat";
            this.cmbPlat.Size = new System.Drawing.Size(184, 21);
            this.cmbPlat.TabIndex = 0;
            this.cmbPlat.SelectedIndexChanged += new System.EventHandler(this.cmbPlat_SelectedIndexChanged);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(216, 12);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(75, 23);
            this.btnExcluir.TabIndex = 1;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // ExcPlataforma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(305, 54);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.cmbPlat);
            this.Name = "ExcPlataforma";
            this.Text = "ExcPlataforma";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbPlat;
        private System.Windows.Forms.Button btnExcluir;
    }
}
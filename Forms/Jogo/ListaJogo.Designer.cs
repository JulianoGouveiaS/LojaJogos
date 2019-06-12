namespace LojadeJogo.Forms.Jogo
{
    partial class ListaJogo
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
            this.dataGridView_jogos = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_jogos)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_jogos
            // 
            this.dataGridView_jogos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_jogos.Location = new System.Drawing.Point(0, 0);
            this.dataGridView_jogos.Name = "dataGridView_jogos";
            this.dataGridView_jogos.Size = new System.Drawing.Size(695, 228);
            this.dataGridView_jogos.TabIndex = 0;
            this.dataGridView_jogos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_jogos_CellContentClick);
            // 
            // ListaJogo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(695, 228);
            this.Controls.Add(this.dataGridView_jogos);
            this.Name = "ListaJogo";
            this.Text = "ListaJogo";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_jogos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_jogos;
    }
}
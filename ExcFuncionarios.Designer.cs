namespace LojadeJogo
{
    partial class ExcFuncionarios
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
            this.cmb_Func = new System.Windows.Forms.ComboBox();
            this.bttn_Excluir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmb_Func
            // 
            this.cmb_Func.FormattingEnabled = true;
            this.cmb_Func.Location = new System.Drawing.Point(32, 24);
            this.cmb_Func.Name = "cmb_Func";
            this.cmb_Func.Size = new System.Drawing.Size(229, 21);
            this.cmb_Func.TabIndex = 0;
            // 
            // bttn_Excluir
            // 
            this.bttn_Excluir.Location = new System.Drawing.Point(291, 22);
            this.bttn_Excluir.Name = "bttn_Excluir";
            this.bttn_Excluir.Size = new System.Drawing.Size(75, 23);
            this.bttn_Excluir.TabIndex = 1;
            this.bttn_Excluir.Text = "Excluir";
            this.bttn_Excluir.UseVisualStyleBackColor = true;
            // 
            // ExcFuncionarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(370, 58);
            this.Controls.Add(this.bttn_Excluir);
            this.Controls.Add(this.cmb_Func);
            this.Name = "ExcFuncionarios";
            this.Text = "ExcFuncionarios";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cmb_Func;
        private System.Windows.Forms.Button bttn_Excluir;
    }
}
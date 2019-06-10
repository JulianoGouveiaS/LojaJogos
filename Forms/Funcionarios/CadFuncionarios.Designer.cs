namespace LojadeJogo
{
    partial class CadFuncionarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadFuncionarios));
            this.label1 = new System.Windows.Forms.Label();
            this.txt_Nome = new System.Windows.Forms.TextBox();
            this.txt_Salario = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.bttn_Adicionar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txt_Nome
            // 
            resources.ApplyResources(this.txt_Nome, "txt_Nome");
            this.txt_Nome.Name = "txt_Nome";
            // 
            // txt_Salario
            // 
            resources.ApplyResources(this.txt_Salario, "txt_Salario");
            this.txt_Salario.Name = "txt_Salario";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // bttn_Adicionar
            // 
            resources.ApplyResources(this.bttn_Adicionar, "bttn_Adicionar");
            this.bttn_Adicionar.Name = "bttn_Adicionar";
            this.bttn_Adicionar.UseVisualStyleBackColor = true;
            this.bttn_Adicionar.Click += new System.EventHandler(this.bttn_Adicionar_Click);
            // 
            // CadFuncionarios
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.bttn_Adicionar);
            this.Controls.Add(this.txt_Salario);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_Nome);
            this.Controls.Add(this.label1);
            this.Name = "CadFuncionarios";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_Nome;
        private System.Windows.Forms.TextBox txt_Salario;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button bttn_Adicionar;
    }
}
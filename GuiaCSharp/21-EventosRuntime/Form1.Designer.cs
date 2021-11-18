
namespace EventosRuntime
{
    partial class Form1
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
            this.btnCriarOutroBotao = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCriarOutroBotao
            // 
            this.btnCriarOutroBotao.Location = new System.Drawing.Point(259, 136);
            this.btnCriarOutroBotao.Name = "btnCriarOutroBotao";
            this.btnCriarOutroBotao.Size = new System.Drawing.Size(201, 30);
            this.btnCriarOutroBotao.TabIndex = 0;
            this.btnCriarOutroBotao.Text = "Criar outro botao";
            this.btnCriarOutroBotao.UseVisualStyleBackColor = true;
            this.btnCriarOutroBotao.Click += new System.EventHandler(this.btnCriarOutroBotao_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCriarOutroBotao);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCriarOutroBotao;
    }
}


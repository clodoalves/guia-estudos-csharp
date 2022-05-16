
namespace _30_InstanciasDeExcecao
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
            this.lblPeso = new System.Windows.Forms.Label();
            this.lblAltura = new System.Windows.Forms.Label();
            this.lblImc = new System.Windows.Forms.Label();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.txtPeso = new System.Windows.Forms.TextBox();
            this.txtAltura = new System.Windows.Forms.TextBox();
            this.txtImc = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtErro = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblPeso
            // 
            this.lblPeso.AutoSize = true;
            this.lblPeso.Location = new System.Drawing.Point(128, 86);
            this.lblPeso.Name = "lblPeso";
            this.lblPeso.Size = new System.Drawing.Size(40, 17);
            this.lblPeso.TabIndex = 0;
            this.lblPeso.Text = "Peso";
            // 
            // lblAltura
            // 
            this.lblAltura.AutoSize = true;
            this.lblAltura.Location = new System.Drawing.Point(131, 139);
            this.lblAltura.Name = "lblAltura";
            this.lblAltura.Size = new System.Drawing.Size(45, 17);
            this.lblAltura.TabIndex = 1;
            this.lblAltura.Text = "Altura";
            // 
            // lblImc
            // 
            this.lblImc.AutoSize = true;
            this.lblImc.Location = new System.Drawing.Point(131, 245);
            this.lblImc.Name = "lblImc";
            this.lblImc.Size = new System.Drawing.Size(31, 17);
            this.lblImc.TabIndex = 2;
            this.lblImc.Text = "IMC";
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(134, 182);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(75, 23);
            this.btnCalcular.TabIndex = 3;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // txtPeso
            // 
            this.txtPeso.Location = new System.Drawing.Point(191, 86);
            this.txtPeso.Name = "txtPeso";
            this.txtPeso.Size = new System.Drawing.Size(100, 22);
            this.txtPeso.TabIndex = 4;
            // 
            // txtAltura
            // 
            this.txtAltura.Location = new System.Drawing.Point(191, 136);
            this.txtAltura.Name = "txtAltura";
            this.txtAltura.Size = new System.Drawing.Size(100, 22);
            this.txtAltura.TabIndex = 5;
            // 
            // txtImc
            // 
            this.txtImc.Location = new System.Drawing.Point(182, 242);
            this.txtImc.Name = "txtImc";
            this.txtImc.Size = new System.Drawing.Size(100, 22);
            this.txtImc.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(131, 305);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "Erro";
            // 
            // txtErro
            // 
            this.txtErro.Location = new System.Drawing.Point(182, 305);
            this.txtErro.Multiline = true;
            this.txtErro.Name = "txtErro";
            this.txtErro.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtErro.Size = new System.Drawing.Size(455, 257);
            this.txtErro.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 629);
            this.Controls.Add(this.txtErro);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtImc);
            this.Controls.Add(this.txtAltura);
            this.Controls.Add(this.txtPeso);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.lblImc);
            this.Controls.Add(this.lblAltura);
            this.Controls.Add(this.lblPeso);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPeso;
        private System.Windows.Forms.Label lblAltura;
        private System.Windows.Forms.Label lblImc;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.TextBox txtPeso;
        private System.Windows.Forms.TextBox txtAltura;
        private System.Windows.Forms.TextBox txtImc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtErro;
    }
}


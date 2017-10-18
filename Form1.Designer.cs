namespace Exercicio_1110
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
            this.lblNumero = new System.Windows.Forms.Label();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.btnConverter = new System.Windows.Forms.Button();
            this.lblParse = new System.Windows.Forms.Label();
            this.lblTryParse = new System.Windows.Forms.Label();
            this.txtLimpar = new System.Windows.Forms.Button();
            this.lblNumero2 = new System.Windows.Forms.Label();
            this.txtNumero2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.Location = new System.Drawing.Point(45, 39);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(90, 13);
            this.lblNumero.TabIndex = 0;
            this.lblNumero.Text = "Insira um número:";
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(153, 39);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(145, 20);
            this.txtNumero.TabIndex = 1;
            this.txtNumero.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtNumero_keydown);
            // 
            // btnConverter
            // 
            this.btnConverter.Location = new System.Drawing.Point(175, 150);
            this.btnConverter.Name = "btnConverter";
            this.btnConverter.Size = new System.Drawing.Size(79, 31);
            this.btnConverter.TabIndex = 2;
            this.btnConverter.Text = "Clique Aqui!";
            this.btnConverter.UseVisualStyleBackColor = true;
            this.btnConverter.Click += new System.EventHandler(this.btnConverter_Click);
            // 
            // lblParse
            // 
            this.lblParse.AutoSize = true;
            this.lblParse.Location = new System.Drawing.Point(91, 216);
            this.lblParse.Name = "lblParse";
            this.lblParse.Size = new System.Drawing.Size(44, 13);
            this.lblParse.TabIndex = 3;
            this.lblParse.Text = "\"Parse\"";
            // 
            // lblTryParse
            // 
            this.lblTryParse.AutoSize = true;
            this.lblTryParse.Location = new System.Drawing.Point(272, 216);
            this.lblTryParse.Name = "lblTryParse";
            this.lblTryParse.Size = new System.Drawing.Size(59, 13);
            this.lblTryParse.TabIndex = 4;
            this.lblTryParse.Text = "\"TryParse\"";
            // 
            // txtLimpar
            // 
            this.txtLimpar.Location = new System.Drawing.Point(330, 39);
            this.txtLimpar.Name = "txtLimpar";
            this.txtLimpar.Size = new System.Drawing.Size(75, 20);
            this.txtLimpar.TabIndex = 5;
            this.txtLimpar.Text = "Limpar";
            this.txtLimpar.UseVisualStyleBackColor = true;
            this.txtLimpar.Click += new System.EventHandler(this.txtLimpar_Click);
            // 
            // lblNumero2
            // 
            this.lblNumero2.AutoSize = true;
            this.lblNumero2.Location = new System.Drawing.Point(48, 79);
            this.lblNumero2.Name = "lblNumero2";
            this.lblNumero2.Size = new System.Drawing.Size(90, 13);
            this.lblNumero2.TabIndex = 6;
            this.lblNumero2.Text = "Insira um número:";
            // 
            // txtNumero2
            // 
            this.txtNumero2.Location = new System.Drawing.Point(153, 79);
            this.txtNumero2.Name = "txtNumero2";
            this.txtNumero2.Size = new System.Drawing.Size(145, 20);
            this.txtNumero2.TabIndex = 7;
            this.txtNumero2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtNumero2_KeyDown);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 276);
            this.Controls.Add(this.txtNumero2);
            this.Controls.Add(this.lblNumero2);
            this.Controls.Add(this.txtLimpar);
            this.Controls.Add(this.lblTryParse);
            this.Controls.Add(this.lblParse);
            this.Controls.Add(this.btnConverter);
            this.Controls.Add(this.txtNumero);
            this.Controls.Add(this.lblNumero);
            this.Name = "Form1";
            this.Text = "Converter String";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNumero;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.Button btnConverter;
        private System.Windows.Forms.Label lblParse;
        private System.Windows.Forms.Label lblTryParse;
        private System.Windows.Forms.Button txtLimpar;
        private System.Windows.Forms.Label lblNumero2;
        private System.Windows.Forms.TextBox txtNumero2;
    }
}


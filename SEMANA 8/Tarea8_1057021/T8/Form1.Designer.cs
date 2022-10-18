namespace T8
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.calcularHexa = new System.Windows.Forms.Button();
            this.calcularBi = new System.Windows.Forms.Button();
            this.hexadecimal = new System.Windows.Forms.TextBox();
            this.decimalHexa = new System.Windows.Forms.TextBox();
            this.binario = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.decimalBi = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.calcularHexa);
            this.groupBox1.Controls.Add(this.calcularBi);
            this.groupBox1.Controls.Add(this.hexadecimal);
            this.groupBox1.Controls.Add(this.decimalHexa);
            this.groupBox1.Controls.Add(this.binario);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.decimalBi);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(407, 296);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // calcularHexa
            // 
            this.calcularHexa.Location = new System.Drawing.Point(328, 90);
            this.calcularHexa.Name = "calcularHexa";
            this.calcularHexa.Size = new System.Drawing.Size(73, 23);
            this.calcularHexa.TabIndex = 9;
            this.calcularHexa.Text = "CALCULAR";
            this.calcularHexa.UseVisualStyleBackColor = true;
            this.calcularHexa.MouseClick += new System.Windows.Forms.MouseEventHandler(this.calcularHexadecimal);
            // 
            // calcularBi
            // 
            this.calcularBi.Location = new System.Drawing.Point(328, 34);
            this.calcularBi.Name = "calcularBi";
            this.calcularBi.Size = new System.Drawing.Size(73, 23);
            this.calcularBi.TabIndex = 8;
            this.calcularBi.Text = "CALCULAR";
            this.calcularBi.UseVisualStyleBackColor = true;
            this.calcularBi.MouseClick += new System.Windows.Forms.MouseEventHandler(this.calcularBinario);
            // 
            // hexadecimal
            // 
            this.hexadecimal.Location = new System.Drawing.Point(195, 93);
            this.hexadecimal.Name = "hexadecimal";
            this.hexadecimal.Size = new System.Drawing.Size(127, 20);
            this.hexadecimal.TabIndex = 7;
            // 
            // decimalHexa
            // 
            this.decimalHexa.Location = new System.Drawing.Point(10, 94);
            this.decimalHexa.Name = "decimalHexa";
            this.decimalHexa.Size = new System.Drawing.Size(171, 20);
            this.decimalHexa.TabIndex = 6;
            // 
            // binario
            // 
            this.binario.Location = new System.Drawing.Point(192, 37);
            this.binario.Name = "binario";
            this.binario.Size = new System.Drawing.Size(130, 20);
            this.binario.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(192, 76);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "RESULTADO";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(143, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "DECIMAL A HEXADECIMAL";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(189, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "RESULTADO";
            // 
            // decimalBi
            // 
            this.decimalBi.Location = new System.Drawing.Point(10, 37);
            this.decimalBi.Name = "decimalBi";
            this.decimalBi.Size = new System.Drawing.Size(171, 20);
            this.decimalBi.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "DECIMAL A BINARIO";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(431, 320);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "T8";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox decimalBi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button calcularHexa;
        private System.Windows.Forms.Button calcularBi;
        private System.Windows.Forms.TextBox hexadecimal;
        private System.Windows.Forms.TextBox decimalHexa;
        private System.Windows.Forms.TextBox binario;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}


namespace Lab8_1057021
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.operacion = new System.Windows.Forms.Button();
            this.contenedor = new System.Windows.Forms.TabControl();
            this.sumatoria = new System.Windows.Forms.TabPage();
            this.tablas = new System.Windows.Forms.TabPage();
            this.perfecto = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.resultadoSumatoria = new System.Windows.Forms.Label();
            this.inNumeroSumatoria = new System.Windows.Forms.TextBox();
            this.datosTabla = new System.Windows.Forms.RichTextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.contenedor.SuspendLayout();
            this.sumatoria.SuspendLayout();
            this.tablas.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.operacion);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 319);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.contenedor);
            this.groupBox2.Location = new System.Drawing.Point(220, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(655, 319);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Sumatoria",
            "Tablas de Multiplicar",
            "Número Perfecto"});
            this.comboBox1.Location = new System.Drawing.Point(7, 20);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(187, 21);
            this.comboBox1.TabIndex = 0;
            // 
            // operacion
            // 
            this.operacion.Location = new System.Drawing.Point(7, 290);
            this.operacion.Name = "operacion";
            this.operacion.Size = new System.Drawing.Size(187, 23);
            this.operacion.TabIndex = 1;
            this.operacion.Text = "Seleccionar";
            this.operacion.UseVisualStyleBackColor = true;
            this.operacion.Click += new System.EventHandler(this.seleccionarOpcion);
            // 
            // contenedor
            // 
            this.contenedor.AccessibleName = "";
            this.contenedor.Controls.Add(this.sumatoria);
            this.contenedor.Controls.Add(this.tablas);
            this.contenedor.Controls.Add(this.perfecto);
            this.contenedor.Location = new System.Drawing.Point(7, 20);
            this.contenedor.Name = "contenedor";
            this.contenedor.SelectedIndex = 0;
            this.contenedor.Size = new System.Drawing.Size(642, 293);
            this.contenedor.TabIndex = 0;
            // 
            // sumatoria
            // 
            this.sumatoria.Controls.Add(this.inNumeroSumatoria);
            this.sumatoria.Controls.Add(this.resultadoSumatoria);
            this.sumatoria.Controls.Add(this.label2);
            this.sumatoria.Controls.Add(this.label1);
            this.sumatoria.Location = new System.Drawing.Point(4, 22);
            this.sumatoria.Name = "sumatoria";
            this.sumatoria.Padding = new System.Windows.Forms.Padding(3);
            this.sumatoria.Size = new System.Drawing.Size(364, 267);
            this.sumatoria.TabIndex = 0;
            this.sumatoria.Text = "Sumatoria";
            this.sumatoria.UseVisualStyleBackColor = true;
            // 
            // tablas
            // 
            this.tablas.Controls.Add(this.datosTabla);
            this.tablas.Location = new System.Drawing.Point(4, 22);
            this.tablas.Name = "tablas";
            this.tablas.Padding = new System.Windows.Forms.Padding(3);
            this.tablas.Size = new System.Drawing.Size(634, 267);
            this.tablas.TabIndex = 1;
            this.tablas.Text = "Tablas de Multiplicar";
            this.tablas.UseVisualStyleBackColor = true;
            // 
            // perfecto
            // 
            this.perfecto.Location = new System.Drawing.Point(4, 22);
            this.perfecto.Name = "perfecto";
            this.perfecto.Padding = new System.Windows.Forms.Padding(3);
            this.perfecto.Size = new System.Drawing.Size(364, 267);
            this.perfecto.TabIndex = 2;
            this.perfecto.Text = "Número Perfecto";
            this.perfecto.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "INGRESE NUMERO N";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "RESULTADO";
            // 
            // resultadoSumatoria
            // 
            this.resultadoSumatoria.AutoSize = true;
            this.resultadoSumatoria.Location = new System.Drawing.Point(90, 42);
            this.resultadoSumatoria.Name = "resultadoSumatoria";
            this.resultadoSumatoria.Size = new System.Drawing.Size(13, 13);
            this.resultadoSumatoria.TabIndex = 2;
            this.resultadoSumatoria.Text = "0";
            // 
            // inNumeroSumatoria
            // 
            this.inNumeroSumatoria.Location = new System.Drawing.Point(131, 7);
            this.inNumeroSumatoria.Name = "inNumeroSumatoria";
            this.inNumeroSumatoria.Size = new System.Drawing.Size(227, 20);
            this.inNumeroSumatoria.TabIndex = 3;
            this.inNumeroSumatoria.KeyUp += new System.Windows.Forms.KeyEventHandler(this.calcularSumatoria);
            // 
            // datosTabla
            // 
            this.datosTabla.Location = new System.Drawing.Point(6, 6);
            this.datosTabla.Name = "datosTabla";
            this.datosTabla.Size = new System.Drawing.Size(622, 255);
            this.datosTabla.TabIndex = 2;
            this.datosTabla.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(887, 344);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.contenedor.ResumeLayout(false);
            this.sumatoria.ResumeLayout(false);
            this.sumatoria.PerformLayout();
            this.tablas.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button operacion;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TabControl contenedor;
        private System.Windows.Forms.TabPage sumatoria;
        private System.Windows.Forms.TabPage tablas;
        private System.Windows.Forms.TabPage perfecto;
        private System.Windows.Forms.TextBox inNumeroSumatoria;
        private System.Windows.Forms.Label resultadoSumatoria;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox datosTabla;
    }
}


namespace Lab9_1057021
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.ingresar = new System.Windows.Forms.TabPage();
            this.mostrar = new System.Windows.Forms.TabPage();
            this.ssss = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.inModelo = new System.Windows.Forms.TextBox();
            this.inPrecio = new System.Windows.Forms.TextBox();
            this.inMarca = new System.Windows.Forms.TextBox();
            this.inCambio = new System.Windows.Forms.TextBox();
            this.btnGuardarInformacion = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.inDescuento = new System.Windows.Forms.TextBox();
            this.btnAplicarDescuento = new System.Windows.Forms.Button();
            this.txtMostrarInformacion = new System.Windows.Forms.RichTextBox();
            this.btnCambiarDisponibilidad = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.ingresar.SuspendLayout();
            this.mostrar.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.ingresar);
            this.tabControl1.Controls.Add(this.mostrar);
            this.tabControl1.Location = new System.Drawing.Point(13, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(451, 426);
            this.tabControl1.TabIndex = 0;
            // 
            // ingresar
            // 
            this.ingresar.Controls.Add(this.btnGuardarInformacion);
            this.ingresar.Controls.Add(this.inCambio);
            this.ingresar.Controls.Add(this.inMarca);
            this.ingresar.Controls.Add(this.inPrecio);
            this.ingresar.Controls.Add(this.inModelo);
            this.ingresar.Controls.Add(this.label4);
            this.ingresar.Controls.Add(this.label3);
            this.ingresar.Controls.Add(this.label2);
            this.ingresar.Controls.Add(this.ssss);
            this.ingresar.Location = new System.Drawing.Point(4, 22);
            this.ingresar.Name = "ingresar";
            this.ingresar.Padding = new System.Windows.Forms.Padding(3);
            this.ingresar.Size = new System.Drawing.Size(443, 400);
            this.ingresar.TabIndex = 0;
            this.ingresar.Text = "Ingreso de Datos";
            this.ingresar.UseVisualStyleBackColor = true;
            // 
            // mostrar
            // 
            this.mostrar.Controls.Add(this.btnCambiarDisponibilidad);
            this.mostrar.Controls.Add(this.txtMostrarInformacion);
            this.mostrar.Controls.Add(this.btnAplicarDescuento);
            this.mostrar.Controls.Add(this.inDescuento);
            this.mostrar.Controls.Add(this.label1);
            this.mostrar.Location = new System.Drawing.Point(4, 22);
            this.mostrar.Name = "mostrar";
            this.mostrar.Padding = new System.Windows.Forms.Padding(3);
            this.mostrar.Size = new System.Drawing.Size(443, 400);
            this.mostrar.TabIndex = 1;
            this.mostrar.Text = "Datos Automóvil";
            this.mostrar.UseVisualStyleBackColor = true;
            // 
            // ssss
            // 
            this.ssss.AutoSize = true;
            this.ssss.Location = new System.Drawing.Point(192, 93);
            this.ssss.Name = "ssss";
            this.ssss.Size = new System.Drawing.Size(42, 13);
            this.ssss.TabIndex = 0;
            this.ssss.Text = "Modelo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(191, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Precio";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(191, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Marca";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(145, 171);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Tipo de Cambio";
            // 
            // inModelo
            // 
            this.inModelo.Location = new System.Drawing.Point(233, 90);
            this.inModelo.Name = "inModelo";
            this.inModelo.Size = new System.Drawing.Size(100, 20);
            this.inModelo.TabIndex = 4;
            // 
            // inPrecio
            // 
            this.inPrecio.Location = new System.Drawing.Point(232, 116);
            this.inPrecio.Name = "inPrecio";
            this.inPrecio.Size = new System.Drawing.Size(100, 20);
            this.inPrecio.TabIndex = 5;
            // 
            // inMarca
            // 
            this.inMarca.Location = new System.Drawing.Point(233, 142);
            this.inMarca.Name = "inMarca";
            this.inMarca.Size = new System.Drawing.Size(100, 20);
            this.inMarca.TabIndex = 6;
            // 
            // inCambio
            // 
            this.inCambio.Location = new System.Drawing.Point(232, 168);
            this.inCambio.Name = "inCambio";
            this.inCambio.Size = new System.Drawing.Size(100, 20);
            this.inCambio.TabIndex = 7;
            // 
            // btnGuardarInformacion
            // 
            this.btnGuardarInformacion.Location = new System.Drawing.Point(74, 194);
            this.btnGuardarInformacion.Name = "btnGuardarInformacion";
            this.btnGuardarInformacion.Size = new System.Drawing.Size(258, 23);
            this.btnGuardarInformacion.TabIndex = 8;
            this.btnGuardarInformacion.Text = "Guardar Información";
            this.btnGuardarInformacion.UseVisualStyleBackColor = true;
            this.btnGuardarInformacion.Click += new System.EventHandler(this.guardarInformacion);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Descuento";
            // 
            // inDescuento
            // 
            this.inDescuento.Location = new System.Drawing.Point(88, 43);
            this.inDescuento.Name = "inDescuento";
            this.inDescuento.Size = new System.Drawing.Size(221, 20);
            this.inDescuento.TabIndex = 1;
            // 
            // btnAplicarDescuento
            // 
            this.btnAplicarDescuento.Location = new System.Drawing.Point(315, 43);
            this.btnAplicarDescuento.Name = "btnAplicarDescuento";
            this.btnAplicarDescuento.Size = new System.Drawing.Size(75, 23);
            this.btnAplicarDescuento.TabIndex = 2;
            this.btnAplicarDescuento.Text = "Aplicar";
            this.btnAplicarDescuento.UseVisualStyleBackColor = true;
            this.btnAplicarDescuento.Click += new System.EventHandler(this.AplicarDescuento);
            // 
            // txtMostrarInformacion
            // 
            this.txtMostrarInformacion.Location = new System.Drawing.Point(26, 72);
            this.txtMostrarInformacion.Name = "txtMostrarInformacion";
            this.txtMostrarInformacion.Size = new System.Drawing.Size(364, 277);
            this.txtMostrarInformacion.TabIndex = 3;
            this.txtMostrarInformacion.Text = "";
            // 
            // btnCambiarDisponibilidad
            // 
            this.btnCambiarDisponibilidad.Location = new System.Drawing.Point(26, 356);
            this.btnCambiarDisponibilidad.Name = "btnCambiarDisponibilidad";
            this.btnCambiarDisponibilidad.Size = new System.Drawing.Size(364, 23);
            this.btnCambiarDisponibilidad.TabIndex = 4;
            this.btnCambiarDisponibilidad.Text = "Cambiar Disponibilidad";
            this.btnCambiarDisponibilidad.UseVisualStyleBackColor = true;
            this.btnCambiarDisponibilidad.Click += new System.EventHandler(this.CambiarDisponibilidad);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(476, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.ingresar.ResumeLayout(false);
            this.ingresar.PerformLayout();
            this.mostrar.ResumeLayout(false);
            this.mostrar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage ingresar;
        private System.Windows.Forms.TabPage mostrar;
        private System.Windows.Forms.Button btnGuardarInformacion;
        private System.Windows.Forms.TextBox inCambio;
        private System.Windows.Forms.TextBox inMarca;
        private System.Windows.Forms.TextBox inPrecio;
        private System.Windows.Forms.TextBox inModelo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label ssss;
        private System.Windows.Forms.RichTextBox txtMostrarInformacion;
        private System.Windows.Forms.Button btnAplicarDescuento;
        private System.Windows.Forms.TextBox inDescuento;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCambiarDisponibilidad;
    }
}


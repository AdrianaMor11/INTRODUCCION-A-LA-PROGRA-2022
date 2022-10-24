namespace tarea9
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
            this.detalles = new System.Windows.Forms.TabPage();
            this.mostrarInformacion = new System.Windows.Forms.RichTextBox();
            this.ingresarInformacion = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.iva = new System.Windows.Forms.TextBox();
            this.marca = new System.Windows.Forms.TextBox();
            this.precio = new System.Windows.Forms.TextBox();
            this.modelo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.precioSinIva = new System.Windows.Forms.Label();
            this.montoIva = new System.Windows.Forms.Label();
            this.precioConIva = new System.Windows.Forms.Label();
            this.detalles.SuspendLayout();
            this.ingresarInformacion.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // detalles
            // 
            this.detalles.Controls.Add(this.precioConIva);
            this.detalles.Controls.Add(this.montoIva);
            this.detalles.Controls.Add(this.precioSinIva);
            this.detalles.Controls.Add(this.label8);
            this.detalles.Controls.Add(this.label7);
            this.detalles.Controls.Add(this.label6);
            this.detalles.Controls.Add(this.mostrarInformacion);
            this.detalles.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.detalles.Location = new System.Drawing.Point(4, 22);
            this.detalles.Name = "detalles";
            this.detalles.Padding = new System.Windows.Forms.Padding(3);
            this.detalles.Size = new System.Drawing.Size(768, 311);
            this.detalles.TabIndex = 1;
            this.detalles.Text = "Ver Detalles";
            this.detalles.UseVisualStyleBackColor = true;
            // 
            // mostrarInformacion
            // 
            this.mostrarInformacion.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mostrarInformacion.Location = new System.Drawing.Point(7, 7);
            this.mostrarInformacion.Name = "mostrarInformacion";
            this.mostrarInformacion.Size = new System.Drawing.Size(375, 298);
            this.mostrarInformacion.TabIndex = 0;
            this.mostrarInformacion.Text = "";
            // 
            // ingresarInformacion
            // 
            this.ingresarInformacion.Controls.Add(this.button1);
            this.ingresarInformacion.Controls.Add(this.label5);
            this.ingresarInformacion.Controls.Add(this.iva);
            this.ingresarInformacion.Controls.Add(this.marca);
            this.ingresarInformacion.Controls.Add(this.precio);
            this.ingresarInformacion.Controls.Add(this.modelo);
            this.ingresarInformacion.Controls.Add(this.label4);
            this.ingresarInformacion.Controls.Add(this.label3);
            this.ingresarInformacion.Controls.Add(this.label2);
            this.ingresarInformacion.Controls.Add(this.label1);
            this.ingresarInformacion.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ingresarInformacion.Location = new System.Drawing.Point(4, 22);
            this.ingresarInformacion.Name = "ingresarInformacion";
            this.ingresarInformacion.Padding = new System.Windows.Forms.Padding(3);
            this.ingresarInformacion.Size = new System.Drawing.Size(768, 311);
            this.ingresarInformacion.TabIndex = 0;
            this.ingresarInformacion.Text = "Ingresar Información";
            this.ingresarInformacion.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(14, 183);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(327, 38);
            this.button1.TabIndex = 9;
            this.button1.Text = "Guardar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.GuardarInformacion);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 156);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "IVA";
            // 
            // iva
            // 
            this.iva.Location = new System.Drawing.Point(69, 150);
            this.iva.Name = "iva";
            this.iva.Size = new System.Drawing.Size(273, 26);
            this.iva.TabIndex = 7;
            // 
            // marca
            // 
            this.marca.Location = new System.Drawing.Point(69, 117);
            this.marca.Name = "marca";
            this.marca.Size = new System.Drawing.Size(273, 26);
            this.marca.TabIndex = 6;
            // 
            // precio
            // 
            this.precio.Location = new System.Drawing.Point(69, 84);
            this.precio.Name = "precio";
            this.precio.Size = new System.Drawing.Size(273, 26);
            this.precio.TabIndex = 5;
            // 
            // modelo
            // 
            this.modelo.Location = new System.Drawing.Point(69, 51);
            this.modelo.Name = "modelo";
            this.modelo.Size = new System.Drawing.Size(273, 26);
            this.modelo.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Marca";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Precio";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Modelo";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(214, 41);
            this.label1.TabIndex = 0;
            this.label1.Text = "Motocicletas";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.ingresarInformacion);
            this.tabControl1.Controls.Add(this.detalles);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(776, 337);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.Click += new System.EventHandler(this.mostrarDatos);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(391, 7);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 20);
            this.label6.TabIndex = 1;
            this.label6.Text = "Precio Sin IVA";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(388, 66);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(99, 20);
            this.label7.TabIndex = 2;
            this.label7.Text = "Precio con IVA";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(416, 35);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 20);
            this.label8.TabIndex = 3;
            this.label8.Text = "Monto IVA";
            // 
            // precioSinIva
            // 
            this.precioSinIva.AutoSize = true;
            this.precioSinIva.Location = new System.Drawing.Point(493, 7);
            this.precioSinIva.Name = "precioSinIva";
            this.precioSinIva.Size = new System.Drawing.Size(16, 20);
            this.precioSinIva.TabIndex = 4;
            this.precioSinIva.Text = "0";
            // 
            // montoIva
            // 
            this.montoIva.AutoSize = true;
            this.montoIva.Location = new System.Drawing.Point(493, 35);
            this.montoIva.Name = "montoIva";
            this.montoIva.Size = new System.Drawing.Size(16, 20);
            this.montoIva.TabIndex = 5;
            this.montoIva.Text = "0";
            // 
            // precioConIva
            // 
            this.precioConIva.AutoSize = true;
            this.precioConIva.Location = new System.Drawing.Point(494, 66);
            this.precioConIva.Name = "precioConIva";
            this.precioConIva.Size = new System.Drawing.Size(16, 20);
            this.precioConIva.TabIndex = 6;
            this.precioConIva.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(793, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.detalles.ResumeLayout(false);
            this.detalles.PerformLayout();
            this.ingresarInformacion.ResumeLayout(false);
            this.ingresarInformacion.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage detalles;
        private System.Windows.Forms.RichTextBox mostrarInformacion;
        private System.Windows.Forms.TabPage ingresarInformacion;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox iva;
        private System.Windows.Forms.TextBox marca;
        private System.Windows.Forms.TextBox precio;
        private System.Windows.Forms.TextBox modelo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label precioConIva;
        private System.Windows.Forms.Label montoIva;
        private System.Windows.Forms.Label precioSinIva;
        private System.Windows.Forms.Label label8;
    }
}


﻿namespace Matrices
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tB_Element = new System.Windows.Forms.TextBox();
            this.tB_n = new System.Windows.Forms.TextBox();
            this.tB_m = new System.Windows.Forms.TextBox();
            this.btn_Tamanio = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_Operacion = new System.Windows.Forms.Button();
            this.rB_Suma = new System.Windows.Forms.RadioButton();
            this.rB_Poner = new System.Windows.Forms.RadioButton();
            this.rB_leer = new System.Windows.Forms.RadioButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lB_result = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.informaciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.firmaDelDesarrolladorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.firmaDelDesarrolladorWPFToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(117, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Entrada";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(377, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Operaciones";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(651, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Salida";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tB_Element);
            this.panel1.Controls.Add(this.tB_n);
            this.panel1.Controls.Add(this.tB_m);
            this.panel1.Controls.Add(this.btn_Tamanio);
            this.panel1.Location = new System.Drawing.Point(23, 78);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(248, 360);
            this.panel1.TabIndex = 3;
            // 
            // tB_Element
            // 
            this.tB_Element.Location = new System.Drawing.Point(18, 16);
            this.tB_Element.Multiline = true;
            this.tB_Element.Name = "tB_Element";
            this.tB_Element.Size = new System.Drawing.Size(200, 179);
            this.tB_Element.TabIndex = 7;
            this.toolTip1.SetToolTip(this.tB_Element, "Ingrese los Valores de la Matriz");
            // 
            // tB_n
            // 
            this.tB_n.Location = new System.Drawing.Point(146, 214);
            this.tB_n.Name = "tB_n";
            this.tB_n.Size = new System.Drawing.Size(72, 20);
            this.tB_n.TabIndex = 6;
            this.tB_n.Text = "N";
            this.tB_n.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.toolTip1.SetToolTip(this.tB_n, "Valor de las Columnas");
            // 
            // tB_m
            // 
            this.tB_m.Location = new System.Drawing.Point(18, 214);
            this.tB_m.Name = "tB_m";
            this.tB_m.Size = new System.Drawing.Size(72, 20);
            this.tB_m.TabIndex = 5;
            this.tB_m.Text = "M";
            this.tB_m.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.toolTip1.SetToolTip(this.tB_m, "Valor de las Filas");
            // 
            // btn_Tamanio
            // 
            this.btn_Tamanio.Location = new System.Drawing.Point(81, 253);
            this.btn_Tamanio.Name = "btn_Tamanio";
            this.btn_Tamanio.Size = new System.Drawing.Size(75, 23);
            this.btn_Tamanio.TabIndex = 0;
            this.btn_Tamanio.Text = "Tamaño";
            this.toolTip1.SetToolTip(this.btn_Tamanio, "Valor de las Filas");
            this.btn_Tamanio.UseVisualStyleBackColor = true;
            this.btn_Tamanio.Click += new System.EventHandler(this.btn_Tamanio_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btn_Operacion);
            this.panel2.Controls.Add(this.rB_Suma);
            this.panel2.Controls.Add(this.rB_Poner);
            this.panel2.Controls.Add(this.rB_leer);
            this.panel2.Location = new System.Drawing.Point(277, 78);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(248, 360);
            this.panel2.TabIndex = 4;
            // 
            // btn_Operacion
            // 
            this.btn_Operacion.Location = new System.Drawing.Point(92, 253);
            this.btn_Operacion.Name = "btn_Operacion";
            this.btn_Operacion.Size = new System.Drawing.Size(75, 23);
            this.btn_Operacion.TabIndex = 3;
            this.btn_Operacion.Text = "Operación";
            this.toolTip1.SetToolTip(this.btn_Operacion, "Realiza la operación");
            this.btn_Operacion.UseVisualStyleBackColor = true;
            this.btn_Operacion.Click += new System.EventHandler(this.btn_Operacion_Click);
            // 
            // rB_Suma
            // 
            this.rB_Suma.AutoSize = true;
            this.rB_Suma.Location = new System.Drawing.Point(44, 104);
            this.rB_Suma.Name = "rB_Suma";
            this.rB_Suma.Size = new System.Drawing.Size(177, 17);
            this.rB_Suma.TabIndex = 2;
            this.rB_Suma.TabStop = true;
            this.rB_Suma.Text = "Suma los Elementos de la Matriz";
            this.toolTip1.SetToolTip(this.rB_Suma, "Suma de elementos");
            this.rB_Suma.UseVisualStyleBackColor = true;
            // 
            // rB_Poner
            // 
            this.rB_Poner.AutoSize = true;
            this.rB_Poner.Location = new System.Drawing.Point(44, 67);
            this.rB_Poner.Name = "rB_Poner";
            this.rB_Poner.Size = new System.Drawing.Size(53, 17);
            this.rB_Poner.TabIndex = 1;
            this.rB_Poner.TabStop = true;
            this.rB_Poner.Text = "Poner";
            this.toolTip1.SetToolTip(this.rB_Poner, "Poner los Elementos de la Matriz");
            this.rB_Poner.UseVisualStyleBackColor = true;
            // 
            // rB_leer
            // 
            this.rB_leer.AutoSize = true;
            this.rB_leer.Location = new System.Drawing.Point(44, 35);
            this.rB_leer.Name = "rB_leer";
            this.rB_leer.Size = new System.Drawing.Size(46, 17);
            this.rB_leer.TabIndex = 0;
            this.rB_leer.TabStop = true;
            this.rB_leer.Text = "Leer";
            this.toolTip1.SetToolTip(this.rB_leer, "Leer la matriz");
            this.rB_leer.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.lB_result);
            this.panel3.Location = new System.Drawing.Point(540, 78);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(248, 360);
            this.panel3.TabIndex = 4;
            // 
            // lB_result
            // 
            this.lB_result.FormattingEnabled = true;
            this.lB_result.Location = new System.Drawing.Point(3, 16);
            this.lB_result.Name = "lB_result";
            this.lB_result.Size = new System.Drawing.Size(242, 342);
            this.lB_result.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(318, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(161, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "TRATAMIENTO DE MATRICES";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(30, 30);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.informaciónToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 38);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salirToolStripMenuItem});
            this.archivoToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("archivoToolStripMenuItem.Image")));
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(90, 34);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("salirToolStripMenuItem.Image")));
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(96, 22);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // informaciónToolStripMenuItem
            // 
            this.informaciónToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.firmaDelDesarrolladorToolStripMenuItem,
            this.firmaDelDesarrolladorWPFToolStripMenuItem});
            this.informaciónToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("informaciónToolStripMenuItem.Image")));
            this.informaciónToolStripMenuItem.Name = "informaciónToolStripMenuItem";
            this.informaciónToolStripMenuItem.Size = new System.Drawing.Size(114, 34);
            this.informaciónToolStripMenuItem.Text = "Información";
            // 
            // firmaDelDesarrolladorToolStripMenuItem
            // 
            this.firmaDelDesarrolladorToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("firmaDelDesarrolladorToolStripMenuItem.Image")));
            this.firmaDelDesarrolladorToolStripMenuItem.Name = "firmaDelDesarrolladorToolStripMenuItem";
            this.firmaDelDesarrolladorToolStripMenuItem.Size = new System.Drawing.Size(223, 22);
            this.firmaDelDesarrolladorToolStripMenuItem.Text = "Firma del Desarrollador";
            this.firmaDelDesarrolladorToolStripMenuItem.Click += new System.EventHandler(this.firmaDelDesarrolladorToolStripMenuItem_Click);
            // 
            // firmaDelDesarrolladorWPFToolStripMenuItem
            // 
            this.firmaDelDesarrolladorWPFToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("firmaDelDesarrolladorWPFToolStripMenuItem.Image")));
            this.firmaDelDesarrolladorWPFToolStripMenuItem.Name = "firmaDelDesarrolladorWPFToolStripMenuItem";
            this.firmaDelDesarrolladorWPFToolStripMenuItem.Size = new System.Drawing.Size(223, 22);
            this.firmaDelDesarrolladorWPFToolStripMenuItem.Text = "Firma del Desarrollador WPF";
            this.firmaDelDesarrolladorWPFToolStripMenuItem.Click += new System.EventHandler(this.firmaDelDesarrolladorWPFToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Tratamiento de Matrices";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem informaciónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem firmaDelDesarrolladorToolStripMenuItem;
        private System.Windows.Forms.TextBox tB_Element;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.TextBox tB_n;
        private System.Windows.Forms.TextBox tB_m;
        private System.Windows.Forms.Button btn_Tamanio;
        private System.Windows.Forms.RadioButton rB_Suma;
        private System.Windows.Forms.RadioButton rB_Poner;
        private System.Windows.Forms.RadioButton rB_leer;
        private System.Windows.Forms.Button btn_Operacion;
        private System.Windows.Forms.ListBox lB_result;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem firmaDelDesarrolladorWPFToolStripMenuItem;
    }
}


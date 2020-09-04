namespace Proyecto_MatricesRealesComplejas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.firmaDelDesarrolladorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.rbClean = new System.Windows.Forms.RadioButton();
            this.rBSuma = new System.Windows.Forms.RadioButton();
            this.rBPoner = new System.Windows.Forms.RadioButton();
            this.rBleer = new System.Windows.Forms.RadioButton();
            this.btn_Operacion = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lB1 = new System.Windows.Forms.ListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tBm = new System.Windows.Forms.TextBox();
            this.tBn = new System.Windows.Forms.TextBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btn_tam = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1355, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.firmaDelDesarrolladorToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.archivoToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("archivoToolStripMenuItem.Image")));
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(76, 20);
            this.archivoToolStripMenuItem.Text = "&Archivo";
            // 
            // firmaDelDesarrolladorToolStripMenuItem
            // 
            this.firmaDelDesarrolladorToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("firmaDelDesarrolladorToolStripMenuItem.Image")));
            this.firmaDelDesarrolladorToolStripMenuItem.Name = "firmaDelDesarrolladorToolStripMenuItem";
            this.firmaDelDesarrolladorToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.firmaDelDesarrolladorToolStripMenuItem.Text = "&Firma del desarrollador";
            this.firmaDelDesarrolladorToolStripMenuItem.Click += new System.EventHandler(this.firmaDelDesarrolladorToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("salirToolStripMenuItem.Image")));
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.salirToolStripMenuItem.Text = "&Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Location = new System.Drawing.Point(15, 176);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(341, 318);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Console", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 140);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Matriz real ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Console", 12.25F);
            this.label2.Location = new System.Drawing.Point(391, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(278, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Matriz de números complejos";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Location = new System.Drawing.Point(394, 176);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(341, 318);
            this.panel2.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Clarendon BT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(362, 274);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 22);
            this.label3.TabIndex = 4;
            this.label3.Text = "+";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Lucida Console", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(785, 196);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(130, 19);
            this.label4.TabIndex = 5;
            this.label4.Text = "Operaciones";
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.rbClean);
            this.panel3.Controls.Add(this.rBSuma);
            this.panel3.Controls.Add(this.rBPoner);
            this.panel3.Controls.Add(this.rBleer);
            this.panel3.Controls.Add(this.btn_Operacion);
            this.panel3.Location = new System.Drawing.Point(768, 202);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(227, 248);
            this.panel3.TabIndex = 6;
            // 
            // rbClean
            // 
            this.rbClean.AutoSize = true;
            this.rbClean.Location = new System.Drawing.Point(15, 180);
            this.rbClean.Name = "rbClean";
            this.rbClean.Size = new System.Drawing.Size(160, 17);
            this.rbClean.TabIndex = 4;
            this.rbClean.TabStop = true;
            this.rbClean.Text = "Limpiar cuadro de resultados";
            this.rbClean.UseVisualStyleBackColor = true;
            // 
            // rBSuma
            // 
            this.rBSuma.AutoSize = true;
            this.rBSuma.Location = new System.Drawing.Point(15, 138);
            this.rBSuma.Name = "rBSuma";
            this.rBSuma.Size = new System.Drawing.Size(52, 17);
            this.rBSuma.TabIndex = 3;
            this.rBSuma.TabStop = true;
            this.rBSuma.Text = "Suma";
            this.rBSuma.UseVisualStyleBackColor = true;
            // 
            // rBPoner
            // 
            this.rBPoner.AutoSize = true;
            this.rBPoner.Location = new System.Drawing.Point(15, 92);
            this.rBPoner.Name = "rBPoner";
            this.rBPoner.Size = new System.Drawing.Size(53, 17);
            this.rBPoner.TabIndex = 2;
            this.rBPoner.TabStop = true;
            this.rBPoner.Text = "Poner";
            this.rBPoner.UseVisualStyleBackColor = true;
            // 
            // rBleer
            // 
            this.rBleer.AutoSize = true;
            this.rBleer.Location = new System.Drawing.Point(15, 51);
            this.rBleer.Name = "rBleer";
            this.rBleer.Size = new System.Drawing.Size(46, 17);
            this.rBleer.TabIndex = 1;
            this.rBleer.TabStop = true;
            this.rBleer.Text = "Leer";
            this.rBleer.UseVisualStyleBackColor = true;
            // 
            // btn_Operacion
            // 
            this.btn_Operacion.Location = new System.Drawing.Point(70, 218);
            this.btn_Operacion.Name = "btn_Operacion";
            this.btn_Operacion.Size = new System.Drawing.Size(75, 23);
            this.btn_Operacion.TabIndex = 0;
            this.btn_Operacion.Text = "Operación";
            this.btn_Operacion.UseVisualStyleBackColor = true;
            this.btn_Operacion.Click += new System.EventHandler(this.btn_Operacion_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Lucida Console", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(1041, 81);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 19);
            this.label5.TabIndex = 7;
            this.label5.Text = "Resultado";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel4.Controls.Add(this.lB1);
            this.panel4.Location = new System.Drawing.Point(1024, 88);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(319, 406);
            this.panel4.TabIndex = 8;
            // 
            // lB1
            // 
            this.lB1.FormattingEnabled = true;
            this.lB1.Location = new System.Drawing.Point(3, 13);
            this.lB1.Name = "lB1";
            this.lB1.Size = new System.Drawing.Size(309, 381);
            this.lB1.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(11, 11);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(295, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Ingrese el tamaño de las matrices en los siguientes recuadros";
            // 
            // tBm
            // 
            this.tBm.Location = new System.Drawing.Point(14, 54);
            this.tBm.Name = "tBm";
            this.tBm.Size = new System.Drawing.Size(66, 20);
            this.tBm.TabIndex = 10;
            this.tBm.Text = "M";
            // 
            // tBn
            // 
            this.tBn.Location = new System.Drawing.Point(106, 54);
            this.tBn.Name = "tBn";
            this.tBn.Size = new System.Drawing.Size(66, 20);
            this.tBn.TabIndex = 11;
            this.tBn.Text = "N";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.btn_tam);
            this.panel5.Controls.Add(this.label6);
            this.panel5.Controls.Add(this.tBn);
            this.panel5.Controls.Add(this.tBm);
            this.panel5.Location = new System.Drawing.Point(15, 27);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(341, 87);
            this.panel5.TabIndex = 12;
            // 
            // btn_tam
            // 
            this.btn_tam.Location = new System.Drawing.Point(196, 51);
            this.btn_tam.Name = "btn_tam";
            this.btn_tam.Size = new System.Drawing.Size(132, 23);
            this.btn_tam.TabIndex = 12;
            this.btn_tam.Text = "Tamaño de matrices";
            this.btn_tam.UseVisualStyleBackColor = true;
            this.btn_tam.Click += new System.EventHandler(this.btn_tam_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1355, 506);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Matrices Reales y Complejas";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem firmaDelDesarrolladorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox tBn;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tBm;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button btn_tam;
        private System.Windows.Forms.RadioButton rBSuma;
        private System.Windows.Forms.RadioButton rBPoner;
        private System.Windows.Forms.RadioButton rBleer;
        private System.Windows.Forms.Button btn_Operacion;
        private System.Windows.Forms.RadioButton rbClean;
        private System.Windows.Forms.ListBox lB1;
    }
}


namespace DesplegarArreglo
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.tB_m = new System.Windows.Forms.TextBox();
            this.tam_btn = new System.Windows.Forms.Button();
            this.leer_btn = new System.Windows.Forms.Button();
            this.poner_btn = new System.Windows.Forms.Button();
            this.lBarr = new System.Windows.Forms.ListBox();
            this.tB_Elements = new System.Windows.Forms.TextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirDeLaAplicaciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.informaciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.firmaDelDesarrolladorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.tB_Elements);
            this.panel1.Controls.Add(this.tam_btn);
            this.panel1.Controls.Add(this.tB_m);
            this.panel1.Location = new System.Drawing.Point(13, 53);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(268, 386);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.poner_btn);
            this.panel2.Controls.Add(this.leer_btn);
            this.panel2.Location = new System.Drawing.Point(287, 53);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(268, 386);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.lBarr);
            this.panel3.Location = new System.Drawing.Point(561, 53);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(258, 386);
            this.panel3.TabIndex = 2;
            // 
            // tB_m
            // 
            this.tB_m.Location = new System.Drawing.Point(86, 253);
            this.tB_m.Name = "tB_m";
            this.tB_m.Size = new System.Drawing.Size(100, 20);
            this.tB_m.TabIndex = 0;
            this.toolTip1.SetToolTip(this.tB_m, "Tamaño del Arreglo");
            // 
            // tam_btn
            // 
            this.tam_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.tam_btn.Location = new System.Drawing.Point(86, 304);
            this.tam_btn.Name = "tam_btn";
            this.tam_btn.Size = new System.Drawing.Size(100, 25);
            this.tam_btn.TabIndex = 2;
            this.tam_btn.Text = "Tamaño";
            this.toolTip1.SetToolTip(this.tam_btn, "Desarrolla el número de elementos");
            this.tam_btn.UseVisualStyleBackColor = true;
            this.tam_btn.Click += new System.EventHandler(this.tam_btn_Click);
            // 
            // leer_btn
            // 
            this.leer_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.leer_btn.Location = new System.Drawing.Point(78, 89);
            this.leer_btn.Name = "leer_btn";
            this.leer_btn.Size = new System.Drawing.Size(123, 23);
            this.leer_btn.TabIndex = 0;
            this.leer_btn.Text = "Leer";
            this.toolTip1.SetToolTip(this.leer_btn, "Leer datos");
            this.leer_btn.UseVisualStyleBackColor = true;
            this.leer_btn.Click += new System.EventHandler(this.leer_btn_Click);
            // 
            // poner_btn
            // 
            this.poner_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.poner_btn.Location = new System.Drawing.Point(78, 140);
            this.poner_btn.Name = "poner_btn";
            this.poner_btn.Size = new System.Drawing.Size(123, 23);
            this.poner_btn.TabIndex = 1;
            this.poner_btn.Text = "Insertar";
            this.poner_btn.UseVisualStyleBackColor = true;
            this.poner_btn.Click += new System.EventHandler(this.poner_btn_Click);
            // 
            // lBarr
            // 
            this.lBarr.FormattingEnabled = true;
            this.lBarr.Location = new System.Drawing.Point(3, 15);
            this.lBarr.Name = "lBarr";
            this.lBarr.Size = new System.Drawing.Size(252, 342);
            this.lBarr.TabIndex = 0;
            // 
            // tB_Elements
            // 
            this.tB_Elements.Location = new System.Drawing.Point(56, 22);
            this.tB_Elements.Multiline = true;
            this.tB_Elements.Name = "tB_Elements";
            this.tB_Elements.Size = new System.Drawing.Size(164, 208);
            this.tB_Elements.TabIndex = 3;
            this.toolTip1.SetToolTip(this.tB_Elements, "Ingresa los datos");
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.informaciónToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(830, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salirDeLaAplicaciónToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // salirDeLaAplicaciónToolStripMenuItem
            // 
            this.salirDeLaAplicaciónToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("salirDeLaAplicaciónToolStripMenuItem.Image")));
            this.salirDeLaAplicaciónToolStripMenuItem.Name = "salirDeLaAplicaciónToolStripMenuItem";
            this.salirDeLaAplicaciónToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.salirDeLaAplicaciónToolStripMenuItem.Text = "Salir de la Aplicación";
            this.salirDeLaAplicaciónToolStripMenuItem.Click += new System.EventHandler(this.salirDeLaAplicaciónToolStripMenuItem_Click);
            // 
            // informaciónToolStripMenuItem
            // 
            this.informaciónToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.firmaDelDesarrolladorToolStripMenuItem});
            this.informaciónToolStripMenuItem.Name = "informaciónToolStripMenuItem";
            this.informaciónToolStripMenuItem.Size = new System.Drawing.Size(84, 20);
            this.informaciónToolStripMenuItem.Text = "Información";
            // 
            // firmaDelDesarrolladorToolStripMenuItem
            // 
            this.firmaDelDesarrolladorToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("firmaDelDesarrolladorToolStripMenuItem.Image")));
            this.firmaDelDesarrolladorToolStripMenuItem.Name = "firmaDelDesarrolladorToolStripMenuItem";
            this.firmaDelDesarrolladorToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.firmaDelDesarrolladorToolStripMenuItem.Text = "Firma del Desarrollador";
            this.firmaDelDesarrolladorToolStripMenuItem.Click += new System.EventHandler(this.firmaDelDesarrolladorToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(830, 450);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Arreglos de 1D";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button tam_btn;
        private System.Windows.Forms.TextBox tB_m;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button poner_btn;
        private System.Windows.Forms.Button leer_btn;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ListBox lBarr;
        private System.Windows.Forms.TextBox tB_Elements;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirDeLaAplicaciónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem informaciónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem firmaDelDesarrolladorToolStripMenuItem;
    }
}


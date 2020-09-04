namespace Graficador_Funciones_WPF
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.lB_tab = new System.Windows.Forms.ListBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pic1 = new System.Windows.Forms.PictureBox();
            this.Borrar = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.oper_btn = new System.Windows.Forms.Button();
            this.rB_tab = new System.Windows.Forms.RadioButton();
            this.rB_graf = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tB_xf = new System.Windows.Forms.TextBox();
            this.tB_xi = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.informaciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.firmaDelDesarrolladorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Humnst777 BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(32, 468);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 20);
            this.label2.TabIndex = 40;
            this.label2.Text = "Ingreso de los Datos";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Humnst777 BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(273, 468);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 20);
            this.label1.TabIndex = 41;
            this.label1.Text = "Operaciones";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Humnst777 BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(511, 60);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(195, 20);
            this.label5.TabIndex = 42;
            this.label5.Text = "Visualización de la Gráfica";
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.button1);
            this.panel4.Controls.Add(this.lB_tab);
            this.panel4.Location = new System.Drawing.Point(948, 71);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(394, 538);
            this.panel4.TabIndex = 39;
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(250, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(128, 23);
            this.button1.TabIndex = 36;
            this.button1.Text = "Limpiar Tabulador";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // lB_tab
            // 
            this.lB_tab.FormattingEnabled = true;
            this.lB_tab.Location = new System.Drawing.Point(3, 50);
            this.lB_tab.Name = "lB_tab";
            this.lB_tab.Size = new System.Drawing.Size(388, 485);
            this.lB_tab.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.pic1);
            this.panel3.Controls.Add(this.Borrar);
            this.panel3.Location = new System.Drawing.Point(508, 71);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(434, 538);
            this.panel3.TabIndex = 38;
            // 
            // pic1
            // 
            this.pic1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pic1.Location = new System.Drawing.Point(3, 50);
            this.pic1.Name = "pic1";
            this.pic1.Size = new System.Drawing.Size(422, 485);
            this.pic1.TabIndex = 36;
            this.pic1.TabStop = false;
            this.pic1.Click += new System.EventHandler(this.pic1_Click_1);
            this.pic1.Paint += new System.Windows.Forms.PaintEventHandler(this.pic1_Paint);
            // 
            // Borrar
            // 
            this.Borrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Borrar.Location = new System.Drawing.Point(297, 12);
            this.Borrar.Name = "Borrar";
            this.Borrar.Size = new System.Drawing.Size(128, 23);
            this.Borrar.TabIndex = 35;
            this.Borrar.Text = "Limpiar Visualizador";
            this.Borrar.UseVisualStyleBackColor = true;
            this.Borrar.Click += new System.EventHandler(this.Borrar_Click);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.oper_btn);
            this.panel2.Controls.Add(this.rB_tab);
            this.panel2.Controls.Add(this.rB_graf);
            this.panel2.Location = new System.Drawing.Point(270, 181);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(179, 297);
            this.panel2.TabIndex = 37;
            // 
            // oper_btn
            // 
            this.oper_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.oper_btn.Location = new System.Drawing.Point(15, 246);
            this.oper_btn.Name = "oper_btn";
            this.oper_btn.Size = new System.Drawing.Size(131, 23);
            this.oper_btn.TabIndex = 28;
            this.oper_btn.Text = "Operación";
            this.oper_btn.UseVisualStyleBackColor = true;
            this.oper_btn.Click += new System.EventHandler(this.oper_btn_Click);
            // 
            // rB_tab
            // 
            this.rB_tab.AutoSize = true;
            this.rB_tab.Location = new System.Drawing.Point(15, 159);
            this.rB_tab.Name = "rB_tab";
            this.rB_tab.Size = new System.Drawing.Size(90, 17);
            this.rB_tab.TabIndex = 1;
            this.rB_tab.TabStop = true;
            this.rB_tab.Text = "Tabular datos";
            this.rB_tab.UseVisualStyleBackColor = true;
            // 
            // rB_graf
            // 
            this.rB_graf.AutoSize = true;
            this.rB_graf.Location = new System.Drawing.Point(15, 111);
            this.rB_graf.Name = "rB_graf";
            this.rB_graf.Size = new System.Drawing.Size(62, 17);
            this.rB_graf.TabIndex = 0;
            this.rB_graf.TabStop = true;
            this.rB_graf.Text = "Graficar";
            this.rB_graf.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.tB_xf);
            this.panel1.Controls.Add(this.tB_xi);
            this.panel1.Location = new System.Drawing.Point(28, 181);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(218, 297);
            this.panel1.TabIndex = 36;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 13);
            this.label3.TabIndex = 29;
            this.label3.Text = "Xf";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(16, 13);
            this.label4.TabIndex = 28;
            this.label4.Text = "Xi";
            // 
            // tB_xf
            // 
            this.tB_xf.Location = new System.Drawing.Point(51, 156);
            this.tB_xf.Name = "tB_xf";
            this.tB_xf.Size = new System.Drawing.Size(126, 20);
            this.tB_xf.TabIndex = 27;
            this.tB_xf.Text = "10";
            // 
            // tB_xi
            // 
            this.tB_xi.Location = new System.Drawing.Point(51, 108);
            this.tB_xi.Name = "tB_xi";
            this.tB_xi.Size = new System.Drawing.Size(126, 20);
            this.tB_xi.TabIndex = 26;
            this.tB_xi.Text = "-10";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Humnst777 BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(1030, 48);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(165, 20);
            this.label6.TabIndex = 43;
            this.label6.Text = "Tabulación de Valores";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(30, 30);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.informaciónToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1367, 38);
            this.menuStrip1.TabIndex = 44;
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
            this.firmaDelDesarrolladorToolStripMenuItem});
            this.informaciónToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("informaciónToolStripMenuItem.Image")));
            this.informaciónToolStripMenuItem.Name = "informaciónToolStripMenuItem";
            this.informaciónToolStripMenuItem.Size = new System.Drawing.Size(114, 34);
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
            this.ClientSize = new System.Drawing.Size(1367, 623);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Graficador de funciones y=f(x)";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel4.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pic1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox lB_tab;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button Borrar;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button oper_btn;
        private System.Windows.Forms.RadioButton rB_tab;
        private System.Windows.Forms.RadioButton rB_graf;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tB_xf;
        private System.Windows.Forms.TextBox tB_xi;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pic1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem informaciónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem firmaDelDesarrolladorToolStripMenuItem;
    }
}
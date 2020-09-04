namespace Graficador_Completo
{
    partial class GraficadorCompleto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GraficadorCompleto));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.firmaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.pB1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btn_graphFunc = new System.Windows.Forms.Button();
            this.limpiar = new System.Windows.Forms.Button();
            this.rBParametricas = new System.Windows.Forms.RadioButton();
            this.rBPolares = new System.Windows.Forms.RadioButton();
            this.rBFx = new System.Windows.Forms.RadioButton();
            this.rbLissajous = new System.Windows.Forms.RadioButton();
            this.btn_OptGraph = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pB1)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1026, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.firmaToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.archivoToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("archivoToolStripMenuItem.Image")));
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(76, 20);
            this.archivoToolStripMenuItem.Text = "&Archivo";
            // 
            // firmaToolStripMenuItem
            // 
            this.firmaToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("firmaToolStripMenuItem.Image")));
            this.firmaToolStripMenuItem.Name = "firmaToolStripMenuItem";
            this.firmaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.firmaToolStripMenuItem.Text = "&Firma";
            this.firmaToolStripMenuItem.Click += new System.EventHandler(this.firmaToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("salirToolStripMenuItem.Image")));
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.salirToolStripMenuItem.Text = "&Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.btn_graphFunc);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(12, 185);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(285, 165);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Humnst777 BT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 176);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Menú de opciones";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.pB1);
            this.panel2.Location = new System.Drawing.Point(334, 81);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(680, 570);
            this.panel2.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Humnst777 BT", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(351, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Visualizador";
            // 
            // pB1
            // 
            this.pB1.BackColor = System.Drawing.Color.White;
            this.pB1.Location = new System.Drawing.Point(3, 15);
            this.pB1.Name = "pB1";
            this.pB1.Size = new System.Drawing.Size(670, 548);
            this.pB1.TabIndex = 0;
            this.pB1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Inserta una función:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(115, 72);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(143, 20);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = "sin(2x)";
            // 
            // btn_graphFunc
            // 
            this.btn_graphFunc.Location = new System.Drawing.Point(148, 108);
            this.btn_graphFunc.Name = "btn_graphFunc";
            this.btn_graphFunc.Size = new System.Drawing.Size(110, 23);
            this.btn_graphFunc.TabIndex = 2;
            this.btn_graphFunc.Text = "Graficar función";
            this.btn_graphFunc.UseVisualStyleBackColor = true;
            this.btn_graphFunc.Click += new System.EventHandler(this.btn_graphFunc_Click);
            // 
            // limpiar
            // 
            this.limpiar.Location = new System.Drawing.Point(882, 52);
            this.limpiar.Name = "limpiar";
            this.limpiar.Size = new System.Drawing.Size(132, 23);
            this.limpiar.TabIndex = 4;
            this.limpiar.Text = "Limpiar Visualizador";
            this.limpiar.UseVisualStyleBackColor = true;
            this.limpiar.Click += new System.EventHandler(this.limpiar_Click);
            // 
            // rBParametricas
            // 
            this.rBParametricas.AutoSize = true;
            this.rBParametricas.Location = new System.Drawing.Point(11, 37);
            this.rBParametricas.Name = "rBParametricas";
            this.rBParametricas.Size = new System.Drawing.Size(118, 17);
            this.rBParametricas.TabIndex = 3;
            this.rBParametricas.TabStop = true;
            this.rBParametricas.Text = "Gráfica Parámetrica";
            this.rBParametricas.UseVisualStyleBackColor = true;
            // 
            // rBPolares
            // 
            this.rBPolares.AutoSize = true;
            this.rBPolares.Location = new System.Drawing.Point(11, 75);
            this.rBPolares.Name = "rBPolares";
            this.rBPolares.Size = new System.Drawing.Size(86, 17);
            this.rBPolares.TabIndex = 4;
            this.rBPolares.TabStop = true;
            this.rBPolares.Text = "Gráfica Polar";
            this.rBPolares.UseVisualStyleBackColor = true;
            // 
            // rBFx
            // 
            this.rBFx.AutoSize = true;
            this.rBFx.Location = new System.Drawing.Point(148, 39);
            this.rBFx.Name = "rBFx";
            this.rBFx.Size = new System.Drawing.Size(76, 17);
            this.rBFx.TabIndex = 5;
            this.rBFx.TabStop = true;
            this.rBFx.Text = "Gráfica f(x)";
            this.rBFx.UseVisualStyleBackColor = true;
            // 
            // rbLissajous
            // 
            this.rbLissajous.AutoSize = true;
            this.rbLissajous.Location = new System.Drawing.Point(148, 75);
            this.rbLissajous.Name = "rbLissajous";
            this.rbLissajous.Size = new System.Drawing.Size(120, 17);
            this.rbLissajous.TabIndex = 6;
            this.rbLissajous.TabStop = true;
            this.rbLissajous.Text = "Figuras de Lissajous";
            this.rbLissajous.UseVisualStyleBackColor = true;
            // 
            // btn_OptGraph
            // 
            this.btn_OptGraph.Location = new System.Drawing.Point(84, 112);
            this.btn_OptGraph.Name = "btn_OptGraph";
            this.btn_OptGraph.Size = new System.Drawing.Size(110, 23);
            this.btn_OptGraph.TabIndex = 7;
            this.btn_OptGraph.Text = "Gráficar opción";
            this.btn_OptGraph.UseVisualStyleBackColor = true;
            this.btn_OptGraph.Click += new System.EventHandler(this.btn_OptGraph_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Humnst777 BT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(21, 376);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(187, 22);
            this.label4.TabIndex = 8;
            this.label4.Text = "Opciones de gráficas";
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.btn_OptGraph);
            this.panel3.Controls.Add(this.rBParametricas);
            this.panel3.Controls.Add(this.rBPolares);
            this.panel3.Controls.Add(this.rBFx);
            this.panel3.Controls.Add(this.rbLissajous);
            this.panel3.Location = new System.Drawing.Point(12, 385);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(285, 165);
            this.panel3.TabIndex = 9;
            // 
            // GraficadorCompleto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1026, 663);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.limpiar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "GraficadorCompleto";
            this.Text = "GraficadorCompleto";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pB1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem firmaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pB1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_graphFunc;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button limpiar;
        private System.Windows.Forms.RadioButton rBParametricas;
        private System.Windows.Forms.RadioButton rBPolares;
        private System.Windows.Forms.RadioButton rBFx;
        private System.Windows.Forms.RadioButton rbLissajous;
        private System.Windows.Forms.Button btn_OptGraph;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel3;
    }
}
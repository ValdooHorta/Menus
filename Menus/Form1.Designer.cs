﻿namespace Menus
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.acercaDeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.formatoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rojoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.azulToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.negroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fuenteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timesNewRomanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.comicSansToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.formatoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.acercaDeToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.archivoToolStripMenuItem.Text = "&Archivo";
            // 
            // acercaDeToolStripMenuItem
            // 
            this.acercaDeToolStripMenuItem.Name = "acercaDeToolStripMenuItem";
            this.acercaDeToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.acercaDeToolStripMenuItem.Text = "Acerca de...";
            this.acercaDeToolStripMenuItem.Click += new System.EventHandler(this.acercaDeToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.salirToolStripMenuItem.Text = "&Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // formatoToolStripMenuItem
            // 
            this.formatoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.colorToolStripMenuItem,
            this.fuenteToolStripMenuItem});
            this.formatoToolStripMenuItem.Name = "formatoToolStripMenuItem";
            this.formatoToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.formatoToolStripMenuItem.Text = "Formato";
            this.formatoToolStripMenuItem.Click += new System.EventHandler(this.formatoToolStripMenuItem_Click);
            // 
            // colorToolStripMenuItem
            // 
            this.colorToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rojoToolStripMenuItem,
            this.azulToolStripMenuItem,
            this.negroToolStripMenuItem});
            this.colorToolStripMenuItem.Name = "colorToolStripMenuItem";
            this.colorToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.colorToolStripMenuItem.Text = "Color";
            this.colorToolStripMenuItem.Click += new System.EventHandler(this.colorToolStripMenuItem_Click);
            // 
            // rojoToolStripMenuItem
            // 
            this.rojoToolStripMenuItem.Name = "rojoToolStripMenuItem";
            this.rojoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.rojoToolStripMenuItem.Text = "Rojo";
            this.rojoToolStripMenuItem.Click += new System.EventHandler(this.rojoToolStripMenuItem_Click);
            // 
            // azulToolStripMenuItem
            // 
            this.azulToolStripMenuItem.Name = "azulToolStripMenuItem";
            this.azulToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.azulToolStripMenuItem.Text = "Azul";
            this.azulToolStripMenuItem.Click += new System.EventHandler(this.azulToolStripMenuItem_Click);
            // 
            // negroToolStripMenuItem
            // 
            this.negroToolStripMenuItem.Name = "negroToolStripMenuItem";
            this.negroToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.negroToolStripMenuItem.Text = "Negro";
            this.negroToolStripMenuItem.Click += new System.EventHandler(this.negroToolStripMenuItem_Click);
            // 
            // fuenteToolStripMenuItem
            // 
            this.fuenteToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.timesNewRomanToolStripMenuItem,
            this.comicSansToolStripMenuItem});
            this.fuenteToolStripMenuItem.Name = "fuenteToolStripMenuItem";
            this.fuenteToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.fuenteToolStripMenuItem.Text = "&Fuente";
            this.fuenteToolStripMenuItem.Click += new System.EventHandler(this.fuenteToolStripMenuItem_Click);
            // 
            // timesNewRomanToolStripMenuItem
            // 
            this.timesNewRomanToolStripMenuItem.Name = "timesNewRomanToolStripMenuItem";
            this.timesNewRomanToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.timesNewRomanToolStripMenuItem.Text = "Times New Roman";
            this.timesNewRomanToolStripMenuItem.Click += new System.EventHandler(this.timesNewRomanToolStripMenuItem_Click);
            // 
            // comicSansToolStripMenuItem
            // 
            this.comicSansToolStripMenuItem.Name = "comicSansToolStripMenuItem";
            this.comicSansToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.comicSansToolStripMenuItem.Text = "Comic Sans";
            this.comicSansToolStripMenuItem.Click += new System.EventHandler(this.comicSansToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(116, 131);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(263, 42);
            this.label1.TabIndex = 1;
            this.label1.Text = "Un texto de prueba";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Menús";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem archivoToolStripMenuItem;
        private ToolStripMenuItem acercaDeToolStripMenuItem;
        private ToolStripMenuItem salirToolStripMenuItem;
        private ToolStripMenuItem formatoToolStripMenuItem;
        private ToolStripMenuItem colorToolStripMenuItem;
        private ToolStripMenuItem rojoToolStripMenuItem;
        private ToolStripMenuItem azulToolStripMenuItem;
        private ToolStripMenuItem fuenteToolStripMenuItem;
        private ToolStripMenuItem timesNewRomanToolStripMenuItem;
        private ToolStripMenuItem comicSansToolStripMenuItem;
        private Label label1;
        private ToolStripMenuItem negroToolStripMenuItem;
    }
}
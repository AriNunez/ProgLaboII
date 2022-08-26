namespace UI
{
    partial class MenuPrincipal
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.agregarJugadorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rtb_informacion = new System.Windows.Forms.RichTextBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarJugadorToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // agregarJugadorToolStripMenuItem
            // 
            this.agregarJugadorToolStripMenuItem.Name = "agregarJugadorToolStripMenuItem";
            this.agregarJugadorToolStripMenuItem.Size = new System.Drawing.Size(106, 20);
            this.agregarJugadorToolStripMenuItem.Text = "Agregar Jugador";
            this.agregarJugadorToolStripMenuItem.Click += new System.EventHandler(this.agregarJugadorToolStripMenuItem_Click);
            // 
            // rtb_informacion
            // 
            this.rtb_informacion.Location = new System.Drawing.Point(23, 37);
            this.rtb_informacion.Name = "rtb_informacion";
            this.rtb_informacion.Size = new System.Drawing.Size(755, 401);
            this.rtb_informacion.TabIndex = 1;
            this.rtb_informacion.Text = "";
            // 
            // MenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rtb_informacion);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MenuPrincipal";
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MenuPrincipal_FormClosed);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem agregarJugadorToolStripMenuItem;
        private System.Windows.Forms.RichTextBox rtb_informacion;
    }
}

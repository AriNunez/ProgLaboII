namespace EjercicioWindowsForm
{
    partial class Login
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
            this.btn_loguear = new System.Windows.Forms.Button();
            this.txb_ingresoUsuario = new System.Windows.Forms.TextBox();
            this.txb_ingresoPassword = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_loguear
            // 
            this.btn_loguear.Location = new System.Drawing.Point(319, 188);
            this.btn_loguear.Name = "btn_loguear";
            this.btn_loguear.Size = new System.Drawing.Size(150, 23);
            this.btn_loguear.TabIndex = 1;
            this.btn_loguear.Text = "Loguear";
            this.btn_loguear.UseVisualStyleBackColor = true;
            this.btn_loguear.Click += new System.EventHandler(this.btn_loguear_Click);
            // 
            // txb_ingresoUsuario
            // 
            this.txb_ingresoUsuario.Location = new System.Drawing.Point(319, 88);
            this.txb_ingresoUsuario.Name = "txb_ingresoUsuario";
            this.txb_ingresoUsuario.PlaceholderText = "Usuario";
            this.txb_ingresoUsuario.Size = new System.Drawing.Size(150, 23);
            this.txb_ingresoUsuario.TabIndex = 3;
            // 
            // txb_ingresoPassword
            // 
            this.txb_ingresoPassword.Location = new System.Drawing.Point(319, 139);
            this.txb_ingresoPassword.Name = "txb_ingresoPassword";
            this.txb_ingresoPassword.PasswordChar = '*';
            this.txb_ingresoPassword.PlaceholderText = "Password";
            this.txb_ingresoPassword.Size = new System.Drawing.Size(150, 23);
            this.txb_ingresoPassword.TabIndex = 4;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txb_ingresoPassword);
            this.Controls.Add(this.txb_ingresoUsuario);
            this.Controls.Add(this.btn_loguear);
            this.Name = "Login";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_loguear;
        private System.Windows.Forms.TextBox txb_ingresoUsuario;
        private System.Windows.Forms.TextBox txb_ingresoPassword;
    }
}

namespace EjercicioWinForm
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
            this.txb_ingresoUsuario = new System.Windows.Forms.TextBox();
            this.txb_ingresoPassword = new System.Windows.Forms.TextBox();
            this.btn_login = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txb_ingresoUsuario
            // 
            this.txb_ingresoUsuario.Location = new System.Drawing.Point(294, 52);
            this.txb_ingresoUsuario.Name = "txb_ingresoUsuario";
            this.txb_ingresoUsuario.PlaceholderText = "Usuario";
            this.txb_ingresoUsuario.Size = new System.Drawing.Size(100, 23);
            this.txb_ingresoUsuario.TabIndex = 0;
            // 
            // txb_ingresoPassword
            // 
            this.txb_ingresoPassword.Location = new System.Drawing.Point(294, 127);
            this.txb_ingresoPassword.Name = "txb_ingresoPassword";
            this.txb_ingresoPassword.PasswordChar = '*';
            this.txb_ingresoPassword.PlaceholderText = "Password";
            this.txb_ingresoPassword.Size = new System.Drawing.Size(100, 23);
            this.txb_ingresoPassword.TabIndex = 1;
            // 
            // btn_login
            // 
            this.btn_login.Location = new System.Drawing.Point(307, 183);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(75, 23);
            this.btn_login.TabIndex = 2;
            this.btn_login.Text = "Login";
            this.btn_login.UseVisualStyleBackColor = true;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_login);
            this.Controls.Add(this.txb_ingresoPassword);
            this.Controls.Add(this.txb_ingresoUsuario);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txb_ingresoUsuario;
        private System.Windows.Forms.TextBox txb_ingresoPassword;
        private System.Windows.Forms.Button btn_login;
    }
}

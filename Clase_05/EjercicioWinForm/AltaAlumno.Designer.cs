namespace EjercicioWinForm
{
    partial class AltaAlumno
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
            this.txb_nombre = new System.Windows.Forms.TextBox();
            this.txb_apellido = new System.Windows.Forms.TextBox();
            this.txb_dni = new System.Windows.Forms.TextBox();
            this.txb_telefono = new System.Windows.Forms.TextBox();
            this.txb_direccion = new System.Windows.Forms.TextBox();
            this.btn_aceptar = new System.Windows.Forms.Button();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txb_nombre
            // 
            this.txb_nombre.Location = new System.Drawing.Point(207, 48);
            this.txb_nombre.Name = "txb_nombre";
            this.txb_nombre.PlaceholderText = "Nombre";
            this.txb_nombre.Size = new System.Drawing.Size(348, 23);
            this.txb_nombre.TabIndex = 0;
            // 
            // txb_apellido
            // 
            this.txb_apellido.Location = new System.Drawing.Point(207, 94);
            this.txb_apellido.Name = "txb_apellido";
            this.txb_apellido.PlaceholderText = "Apellido";
            this.txb_apellido.Size = new System.Drawing.Size(348, 23);
            this.txb_apellido.TabIndex = 1;
            // 
            // txb_dni
            // 
            this.txb_dni.Location = new System.Drawing.Point(207, 139);
            this.txb_dni.Name = "txb_dni";
            this.txb_dni.PlaceholderText = "DNI";
            this.txb_dni.Size = new System.Drawing.Size(348, 23);
            this.txb_dni.TabIndex = 2;
            // 
            // txb_telefono
            // 
            this.txb_telefono.Location = new System.Drawing.Point(207, 180);
            this.txb_telefono.Name = "txb_telefono";
            this.txb_telefono.PlaceholderText = "Telefono";
            this.txb_telefono.Size = new System.Drawing.Size(348, 23);
            this.txb_telefono.TabIndex = 3;
            // 
            // txb_direccion
            // 
            this.txb_direccion.Location = new System.Drawing.Point(207, 224);
            this.txb_direccion.Name = "txb_direccion";
            this.txb_direccion.PlaceholderText = "Direccion";
            this.txb_direccion.Size = new System.Drawing.Size(348, 23);
            this.txb_direccion.TabIndex = 4;
            // 
            // btn_aceptar
            // 
            this.btn_aceptar.Location = new System.Drawing.Point(207, 290);
            this.btn_aceptar.Name = "btn_aceptar";
            this.btn_aceptar.Size = new System.Drawing.Size(75, 23);
            this.btn_aceptar.TabIndex = 5;
            this.btn_aceptar.Text = "Aceptar";
            this.btn_aceptar.UseVisualStyleBackColor = true;
            this.btn_aceptar.Click += new System.EventHandler(this.btn_aceptar_Click);
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.Location = new System.Drawing.Point(480, 290);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(75, 23);
            this.btn_cancelar.TabIndex = 6;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.UseVisualStyleBackColor = true;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // AltaAlumno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.btn_aceptar);
            this.Controls.Add(this.txb_direccion);
            this.Controls.Add(this.txb_telefono);
            this.Controls.Add(this.txb_dni);
            this.Controls.Add(this.txb_apellido);
            this.Controls.Add(this.txb_nombre);
            this.Name = "AltaAlumno";
            this.Text = "AltaAlumno";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txb_nombre;
        private System.Windows.Forms.TextBox txb_apellido;
        private System.Windows.Forms.TextBox txb_dni;
        private System.Windows.Forms.TextBox txb_telefono;
        private System.Windows.Forms.TextBox txb_direccion;
        private System.Windows.Forms.Button btn_aceptar;
        private System.Windows.Forms.Button btn_cancelar;
    }
}
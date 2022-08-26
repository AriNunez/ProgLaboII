namespace UI
{
    partial class AltaJugador
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
            this.btn_aceptar = new System.Windows.Forms.Button();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.txt_numeroCamiseta = new System.Windows.Forms.TextBox();
            this.txt_posicion = new System.Windows.Forms.TextBox();
            this.txt_partidosJugados = new System.Windows.Forms.TextBox();
            this.cmb_posicion = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btn_aceptar
            // 
            this.btn_aceptar.Location = new System.Drawing.Point(162, 311);
            this.btn_aceptar.Name = "btn_aceptar";
            this.btn_aceptar.Size = new System.Drawing.Size(132, 57);
            this.btn_aceptar.TabIndex = 3;
            this.btn_aceptar.Text = "Aceptar";
            this.btn_aceptar.UseVisualStyleBackColor = true;
            this.btn_aceptar.Click += new System.EventHandler(this.btn_aceptar_Click);
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.Location = new System.Drawing.Point(502, 311);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(132, 57);
            this.btn_cancelar.TabIndex = 4;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.UseVisualStyleBackColor = true;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // txt_nombre
            // 
            this.txt_nombre.Location = new System.Drawing.Point(285, 61);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.PlaceholderText = "Nombre";
            this.txt_nombre.Size = new System.Drawing.Size(211, 23);
            this.txt_nombre.TabIndex = 0;
            // 
            // txt_numeroCamiseta
            // 
            this.txt_numeroCamiseta.Location = new System.Drawing.Point(285, 101);
            this.txt_numeroCamiseta.Name = "txt_numeroCamiseta";
            this.txt_numeroCamiseta.PlaceholderText = "Número de Camiseta";
            this.txt_numeroCamiseta.Size = new System.Drawing.Size(210, 23);
            this.txt_numeroCamiseta.TabIndex = 1;
            // 
            // txt_posicion
            // 
            this.txt_posicion.Location = new System.Drawing.Point(285, 144);
            this.txt_posicion.Name = "txt_posicion";
            this.txt_posicion.PlaceholderText = "Posición";
            this.txt_posicion.Size = new System.Drawing.Size(211, 23);
            this.txt_posicion.TabIndex = 2;
            // 
            // txt_partidosJugados
            // 
            this.txt_partidosJugados.Location = new System.Drawing.Point(285, 186);
            this.txt_partidosJugados.Name = "txt_partidosJugados";
            this.txt_partidosJugados.PlaceholderText = "Partidos Jugados";
            this.txt_partidosJugados.Size = new System.Drawing.Size(210, 23);
            this.txt_partidosJugados.TabIndex = 5;
            // 
            // cmb_posicion
            // 
            this.cmb_posicion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_posicion.FormattingEnabled = true;
            this.cmb_posicion.Location = new System.Drawing.Point(539, 147);
            this.cmb_posicion.Name = "cmb_posicion";
            this.cmb_posicion.Size = new System.Drawing.Size(180, 23);
            this.cmb_posicion.TabIndex = 6;
            // 
            // AltaJugador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cmb_posicion);
            this.Controls.Add(this.txt_partidosJugados);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.btn_aceptar);
            this.Controls.Add(this.txt_posicion);
            this.Controls.Add(this.txt_numeroCamiseta);
            this.Controls.Add(this.txt_nombre);
            this.Name = "AltaJugador";
            this.Text = "Alta de Jugador";
            this.Load += new System.EventHandler(this.AltaJugador_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_aceptar;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.TextBox txt_nombre;
        private System.Windows.Forms.TextBox txt_numeroCamiseta;
        private System.Windows.Forms.TextBox txt_posicion;
        private System.Windows.Forms.TextBox txt_partidosJugados;
        private System.Windows.Forms.ComboBox cmb_posicion;
    }
}
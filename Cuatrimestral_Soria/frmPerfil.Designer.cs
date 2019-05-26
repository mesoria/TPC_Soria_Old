namespace Cuatrimestral_Soria
{
    partial class FrmPerfil
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
            this.lblNombreCompleto = new System.Windows.Forms.Label();
            this.DNI = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.lblDni = new System.Windows.Forms.Label();
            this.lblPerfil = new System.Windows.Forms.Label();
            this.cbxPerfil = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbxContraseña = new System.Windows.Forms.TextBox();
            this.tbxContraseña2 = new System.Windows.Forms.TextBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNombreCompleto
            // 
            this.lblNombreCompleto.AutoSize = true;
            this.lblNombreCompleto.Location = new System.Drawing.Point(260, 70);
            this.lblNombreCompleto.Name = "lblNombreCompleto";
            this.lblNombreCompleto.Size = new System.Drawing.Size(123, 17);
            this.lblNombreCompleto.TabIndex = 0;
            this.lblNombreCompleto.Text = "Nombre y Apellido";
            // 
            // DNI
            // 
            this.DNI.AutoSize = true;
            this.DNI.Location = new System.Drawing.Point(260, 107);
            this.DNI.Name = "DNI";
            this.DNI.Size = new System.Drawing.Size(72, 17);
            this.DNI.TabIndex = 1;
            this.DNI.Text = "12345678";
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Location = new System.Drawing.Point(125, 70);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(61, 17);
            this.lblUsuario.TabIndex = 2;
            this.lblUsuario.Text = "Usuario:";
            // 
            // lblDni
            // 
            this.lblDni.AutoSize = true;
            this.lblDni.Location = new System.Drawing.Point(139, 107);
            this.lblDni.Name = "lblDni";
            this.lblDni.Size = new System.Drawing.Size(47, 17);
            this.lblDni.TabIndex = 3;
            this.lblDni.Text = "D.N.I.:";
            // 
            // lblPerfil
            // 
            this.lblPerfil.AutoSize = true;
            this.lblPerfil.Location = new System.Drawing.Point(196, 238);
            this.lblPerfil.Name = "lblPerfil";
            this.lblPerfil.Size = new System.Drawing.Size(44, 17);
            this.lblPerfil.TabIndex = 4;
            this.lblPerfil.Text = "Perfil:";
            // 
            // cbxPerfil
            // 
            this.cbxPerfil.FormattingEnabled = true;
            this.cbxPerfil.Location = new System.Drawing.Point(128, 258);
            this.cbxPerfil.Name = "cbxPerfil";
            this.cbxPerfil.Size = new System.Drawing.Size(182, 24);
            this.cbxPerfil.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(101, 146);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Contraseña:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 185);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Confirmar Contraseña:";
            // 
            // tbxContraseña
            // 
            this.tbxContraseña.Location = new System.Drawing.Point(263, 143);
            this.tbxContraseña.Name = "tbxContraseña";
            this.tbxContraseña.PasswordChar = '*';
            this.tbxContraseña.Size = new System.Drawing.Size(120, 22);
            this.tbxContraseña.TabIndex = 8;
            this.tbxContraseña.TextChanged += new System.EventHandler(this.tbxContraseña_TextChanged);
            // 
            // tbxContraseña2
            // 
            this.tbxContraseña2.Location = new System.Drawing.Point(263, 180);
            this.tbxContraseña2.Name = "tbxContraseña2";
            this.tbxContraseña2.PasswordChar = '*';
            this.tbxContraseña2.Size = new System.Drawing.Size(120, 22);
            this.tbxContraseña2.TabIndex = 9;
            this.tbxContraseña2.TextChanged += new System.EventHandler(this.tbxContraseña2_TextChanged);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(326, 258);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(147, 23);
            this.btnAceptar.TabIndex = 10;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // FrmPerfil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(513, 338);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.tbxContraseña2);
            this.Controls.Add(this.tbxContraseña);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbxPerfil);
            this.Controls.Add(this.lblPerfil);
            this.Controls.Add(this.lblDni);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.DNI);
            this.Controls.Add(this.lblNombreCompleto);
            this.Name = "FrmPerfil";
            this.Text = "frmPerfil";
            this.Load += new System.EventHandler(this.FrmPerfil_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNombreCompleto;
        private System.Windows.Forms.Label DNI;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label lblDni;
        private System.Windows.Forms.Label lblPerfil;
        private System.Windows.Forms.ComboBox cbxPerfil;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbxContraseña;
        private System.Windows.Forms.TextBox tbxContraseña2;
        private System.Windows.Forms.Button btnAceptar;
    }
}
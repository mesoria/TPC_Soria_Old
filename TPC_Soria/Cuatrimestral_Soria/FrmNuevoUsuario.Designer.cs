namespace Cuatrimestral_Soria
{
    partial class FrmAgragarUsuario
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
            this.lblName = new System.Windows.Forms.Label();
            this.lblSurname = new System.Windows.Forms.Label();
            this.lblDNI = new System.Windows.Forms.Label();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.tbxName = new System.Windows.Forms.TextBox();
            this.tbxSurname = new System.Windows.Forms.TextBox();
            this.tbxDNI = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dateNac = new System.Windows.Forms.DateTimePicker();
            this.tbxDirec = new System.Windows.Forms.TextBox();
            this.tbxNumber = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbxTelefono = new System.Windows.Forms.TextBox();
            this.tbxEmail = new System.Windows.Forms.TextBox();
            this.lblPerfil = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(39, 38);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(62, 17);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Nombre:";
            // 
            // lblSurname
            // 
            this.lblSurname.AutoSize = true;
            this.lblSurname.Location = new System.Drawing.Point(39, 75);
            this.lblSurname.Name = "lblSurname";
            this.lblSurname.Size = new System.Drawing.Size(62, 17);
            this.lblSurname.TabIndex = 1;
            this.lblSurname.Text = "Apellido:";
            // 
            // lblDNI
            // 
            this.lblDNI.AutoSize = true;
            this.lblDNI.Location = new System.Drawing.Point(39, 112);
            this.lblDNI.Name = "lblDNI";
            this.lblDNI.Size = new System.Drawing.Size(35, 17);
            this.lblDNI.TabIndex = 2;
            this.lblDNI.Text = "DNI:";
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Location = new System.Drawing.Point(39, 186);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(71, 17);
            this.lblDireccion.TabIndex = 3;
            this.lblDireccion.Text = "Dirección:";
            // 
            // tbxName
            // 
            this.tbxName.Location = new System.Drawing.Point(127, 33);
            this.tbxName.Name = "tbxName";
            this.tbxName.Size = new System.Drawing.Size(200, 22);
            this.tbxName.TabIndex = 4;
            // 
            // tbxSurname
            // 
            this.tbxSurname.Location = new System.Drawing.Point(127, 70);
            this.tbxSurname.Name = "tbxSurname";
            this.tbxSurname.Size = new System.Drawing.Size(200, 22);
            this.tbxSurname.TabIndex = 5;
            // 
            // tbxDNI
            // 
            this.tbxDNI.Location = new System.Drawing.Point(127, 107);
            this.tbxDNI.Name = "tbxDNI";
            this.tbxDNI.Size = new System.Drawing.Size(200, 22);
            this.tbxDNI.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 149);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "Nacimiento:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 223);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "Número";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 260);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "Teléfono";
            // 
            // dateNac
            // 
            this.dateNac.Location = new System.Drawing.Point(127, 144);
            this.dateNac.Name = "dateNac";
            this.dateNac.Size = new System.Drawing.Size(200, 22);
            this.dateNac.TabIndex = 10;
            // 
            // tbxDirec
            // 
            this.tbxDirec.Location = new System.Drawing.Point(127, 181);
            this.tbxDirec.Name = "tbxDirec";
            this.tbxDirec.Size = new System.Drawing.Size(200, 22);
            this.tbxDirec.TabIndex = 11;
            // 
            // tbxNumber
            // 
            this.tbxNumber.Location = new System.Drawing.Point(127, 217);
            this.tbxNumber.Name = "tbxNumber";
            this.tbxNumber.Size = new System.Drawing.Size(100, 22);
            this.tbxNumber.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(42, 295);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 17);
            this.label4.TabIndex = 13;
            this.label4.Text = "Email:";
            // 
            // tbxTelefono
            // 
            this.tbxTelefono.Location = new System.Drawing.Point(127, 254);
            this.tbxTelefono.Name = "tbxTelefono";
            this.tbxTelefono.Size = new System.Drawing.Size(200, 22);
            this.tbxTelefono.TabIndex = 14;
            // 
            // tbxEmail
            // 
            this.tbxEmail.Location = new System.Drawing.Point(127, 292);
            this.tbxEmail.Name = "tbxEmail";
            this.tbxEmail.Size = new System.Drawing.Size(200, 22);
            this.tbxEmail.TabIndex = 15;
            // 
            // lblPerfil
            // 
            this.lblPerfil.AutoSize = true;
            this.lblPerfil.Location = new System.Drawing.Point(395, 38);
            this.lblPerfil.Name = "lblPerfil";
            this.lblPerfil.Size = new System.Drawing.Size(44, 17);
            this.lblPerfil.TabIndex = 16;
            this.lblPerfil.Text = "Perfil:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Administrador",
            "Usuario"});
            this.comboBox1.Location = new System.Drawing.Point(493, 29);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 24);
            this.comboBox1.TabIndex = 17;
            // 
            // btnAgregar
            // 
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnAgregar.Location = new System.Drawing.Point(327, 356);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(112, 30);
            this.btnAgregar.TabIndex = 18;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            // 
            // FrmAgragarUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(651, 416);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.lblPerfil);
            this.Controls.Add(this.tbxEmail);
            this.Controls.Add(this.tbxTelefono);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbxNumber);
            this.Controls.Add(this.tbxDirec);
            this.Controls.Add(this.dateNac);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbxDNI);
            this.Controls.Add(this.tbxSurname);
            this.Controls.Add(this.tbxName);
            this.Controls.Add(this.lblDireccion);
            this.Controls.Add(this.lblDNI);
            this.Controls.Add(this.lblSurname);
            this.Controls.Add(this.lblName);
            this.Name = "FrmAgragarUsuario";
            this.Text = "Nuevo Usuario";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblSurname;
        private System.Windows.Forms.Label lblDNI;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.TextBox tbxName;
        private System.Windows.Forms.TextBox tbxSurname;
        private System.Windows.Forms.TextBox tbxDNI;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateNac;
        private System.Windows.Forms.TextBox tbxDirec;
        private System.Windows.Forms.TextBox tbxNumber;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbxTelefono;
        private System.Windows.Forms.TextBox tbxEmail;
        private System.Windows.Forms.Label lblPerfil;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btnAgregar;
    }
}
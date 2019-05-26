namespace Cuatrimestral_Soria
{
    partial class FrmListar
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
            this.lblBuscar = new System.Windows.Forms.Label();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.lblCondicion = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.dgvPersonas = new System.Windows.Forms.DataGridView();
            this.btnEditarPersona = new System.Windows.Forms.Button();
            this.btnEditPerfil = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnNuevoUsuario = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersonas)).BeginInit();
            this.SuspendLayout();
            // 
            // lblBuscar
            // 
            this.lblBuscar.AutoSize = true;
            this.lblBuscar.Location = new System.Drawing.Point(12, 13);
            this.lblBuscar.Name = "lblBuscar";
            this.lblBuscar.Size = new System.Drawing.Size(56, 17);
            this.lblBuscar.TabIndex = 0;
            this.lblBuscar.Text = "Buscar:";
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(87, 10);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(219, 22);
            this.txtBuscar.TabIndex = 1;
            // 
            // lblCondicion
            // 
            this.lblCondicion.AutoSize = true;
            this.lblCondicion.Location = new System.Drawing.Point(331, 13);
            this.lblCondicion.Name = "lblCondicion";
            this.lblCondicion.Size = new System.Drawing.Size(46, 17);
            this.lblCondicion.TabIndex = 2;
            this.lblCondicion.Text = "label1";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(497, 10);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 24);
            this.comboBox1.TabIndex = 3;
            // 
            // dgvPersonas
            // 
            this.dgvPersonas.AllowUserToOrderColumns = true;
            this.dgvPersonas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPersonas.Location = new System.Drawing.Point(12, 65);
            this.dgvPersonas.Name = "dgvPersonas";
            this.dgvPersonas.RowTemplate.Height = 24;
            this.dgvPersonas.Size = new System.Drawing.Size(776, 273);
            this.dgvPersonas.TabIndex = 4;
            // 
            // btnEditarPersona
            // 
            this.btnEditarPersona.Location = new System.Drawing.Point(223, 382);
            this.btnEditarPersona.Name = "btnEditarPersona";
            this.btnEditarPersona.Size = new System.Drawing.Size(119, 23);
            this.btnEditarPersona.TabIndex = 5;
            this.btnEditarPersona.Text = "Editar Usuario";
            this.btnEditarPersona.UseVisualStyleBackColor = true;
            this.btnEditarPersona.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnEditPerfil
            // 
            this.btnEditPerfil.Location = new System.Drawing.Point(431, 382);
            this.btnEditPerfil.Name = "btnEditPerfil";
            this.btnEditPerfil.Size = new System.Drawing.Size(119, 23);
            this.btnEditPerfil.TabIndex = 6;
            this.btnEditPerfil.Text = "Editar Perfil";
            this.btnEditPerfil.UseVisualStyleBackColor = true;
            this.btnEditPerfil.Click += new System.EventHandler(this.btnEditPerfil_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(639, 382);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(119, 23);
            this.btnEliminar.TabIndex = 7;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnNuevoUsuario
            // 
            this.btnNuevoUsuario.Location = new System.Drawing.Point(15, 382);
            this.btnNuevoUsuario.Name = "btnNuevoUsuario";
            this.btnNuevoUsuario.Size = new System.Drawing.Size(119, 23);
            this.btnNuevoUsuario.TabIndex = 8;
            this.btnNuevoUsuario.Text = "Nuevo Usuario";
            this.btnNuevoUsuario.UseVisualStyleBackColor = true;
            this.btnNuevoUsuario.Click += new System.EventHandler(this.btnNuevoUsuario_Click);
            // 
            // FrmListar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnNuevoUsuario);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnEditPerfil);
            this.Controls.Add(this.btnEditarPersona);
            this.Controls.Add(this.dgvPersonas);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.lblCondicion);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.lblBuscar);
            this.Name = "FrmListar";
            this.Text = "FrmListar";
            this.Load += new System.EventHandler(this.FrmListar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersonas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBuscar;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Label lblCondicion;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DataGridView dgvPersonas;
        private System.Windows.Forms.Button btnEditarPersona;
        private System.Windows.Forms.Button btnEditPerfil;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnNuevoUsuario;
    }
}
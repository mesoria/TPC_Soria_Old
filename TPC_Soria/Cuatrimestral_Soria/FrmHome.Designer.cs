namespace Cuatrimestral_Soria
{
    partial class FrmHome
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.MenuAchivo = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuSalir = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuProductos = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuListarProductos = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuAgregarProducto = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuModificarProducto = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuAdministrador = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuListarUsuario = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuNewUser = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuModificarUsuario = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuSesion = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuCerrarSesion = new System.Windows.Forms.ToolStripMenuItem();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.lblPerf = new System.Windows.Forms.Label();
            this.lblNomyApe = new System.Windows.Forms.Label();
            this.lblPerfil = new System.Windows.Forms.Label();
            this.btnNewInvoice = new System.Windows.Forms.Button();
            this.btnCatalogo = new System.Windows.Forms.Button();
            this.btnProveedor = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuAchivo,
            this.MenuProductos,
            this.MenuAdministrador,
            this.MenuSesion});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // MenuAchivo
            // 
            this.MenuAchivo.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuSalir});
            this.MenuAchivo.Name = "MenuAchivo";
            this.MenuAchivo.Size = new System.Drawing.Size(71, 24);
            this.MenuAchivo.Text = "Archivo";
            // 
            // MenuSalir
            // 
            this.MenuSalir.Name = "MenuSalir";
            this.MenuSalir.Size = new System.Drawing.Size(113, 26);
            this.MenuSalir.Text = "Salir";
            this.MenuSalir.Click += new System.EventHandler(this.MenuSalir_Click);
            // 
            // MenuProductos
            // 
            this.MenuProductos.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuListarProductos,
            this.MenuAgregarProducto,
            this.MenuModificarProducto});
            this.MenuProductos.Name = "MenuProductos";
            this.MenuProductos.Size = new System.Drawing.Size(87, 24);
            this.MenuProductos.Text = "Productos";
            // 
            // MenuListarProductos
            // 
            this.MenuListarProductos.Name = "MenuListarProductos";
            this.MenuListarProductos.Size = new System.Drawing.Size(212, 26);
            this.MenuListarProductos.Text = "Listar Productos";
            this.MenuListarProductos.Click += new System.EventHandler(this.MenuListarProductos_Click);
            // 
            // MenuAgregarProducto
            // 
            this.MenuAgregarProducto.Name = "MenuAgregarProducto";
            this.MenuAgregarProducto.Size = new System.Drawing.Size(212, 26);
            this.MenuAgregarProducto.Text = "Agregar Producto";
            // 
            // MenuModificarProducto
            // 
            this.MenuModificarProducto.Name = "MenuModificarProducto";
            this.MenuModificarProducto.Size = new System.Drawing.Size(212, 26);
            this.MenuModificarProducto.Text = "Modificar Producto";
            // 
            // MenuAdministrador
            // 
            this.MenuAdministrador.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuListarUsuario,
            this.MenuNewUser,
            this.MenuModificarUsuario});
            this.MenuAdministrador.Name = "MenuAdministrador";
            this.MenuAdministrador.Size = new System.Drawing.Size(116, 24);
            this.MenuAdministrador.Text = "Administrador";
            this.MenuAdministrador.Click += new System.EventHandler(this.btnAdmin_Click);
            // 
            // MenuListarUsuario
            // 
            this.MenuListarUsuario.Name = "MenuListarUsuario";
            this.MenuListarUsuario.Size = new System.Drawing.Size(202, 26);
            this.MenuListarUsuario.Text = "Listar Usuarios";
            this.MenuListarUsuario.Click += new System.EventHandler(this.MenuListarUsuario_Click);
            // 
            // MenuNewUser
            // 
            this.MenuNewUser.Name = "MenuNewUser";
            this.MenuNewUser.Size = new System.Drawing.Size(202, 26);
            this.MenuNewUser.Text = "Agregar Usuario";
            this.MenuNewUser.Click += new System.EventHandler(this.btnNewUser_Click);
            // 
            // MenuModificarUsuario
            // 
            this.MenuModificarUsuario.Name = "MenuModificarUsuario";
            this.MenuModificarUsuario.Size = new System.Drawing.Size(202, 26);
            this.MenuModificarUsuario.Text = "Modificar Usuario";
            // 
            // MenuSesion
            // 
            this.MenuSesion.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuCerrarSesion});
            this.MenuSesion.Name = "MenuSesion";
            this.MenuSesion.Size = new System.Drawing.Size(64, 24);
            this.MenuSesion.Text = "Sesión";
            // 
            // MenuCerrarSesion
            // 
            this.MenuCerrarSesion.Name = "MenuCerrarSesion";
            this.MenuCerrarSesion.Size = new System.Drawing.Size(216, 26);
            this.MenuCerrarSesion.Text = "Cerrar sesión";
            this.MenuCerrarSesion.Click += new System.EventHandler(this.MenuCerrarSesion_Click);
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.Location = new System.Drawing.Point(402, 42);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(64, 18);
            this.lblUsuario.TabIndex = 1;
            this.lblUsuario.Text = "Usuario:";
            // 
            // lblPerf
            // 
            this.lblPerf.AutoSize = true;
            this.lblPerf.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPerf.Location = new System.Drawing.Point(402, 78);
            this.lblPerf.Name = "lblPerf";
            this.lblPerf.Size = new System.Drawing.Size(45, 18);
            this.lblPerf.TabIndex = 2;
            this.lblPerf.Text = "Perfil:";
            // 
            // lblNomyApe
            // 
            this.lblNomyApe.AutoSize = true;
            this.lblNomyApe.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomyApe.Location = new System.Drawing.Point(500, 44);
            this.lblNomyApe.Name = "lblNomyApe";
            this.lblNomyApe.Size = new System.Drawing.Size(46, 17);
            this.lblNomyApe.TabIndex = 3;
            this.lblNomyApe.Text = "label1";
            // 
            // lblPerfil
            // 
            this.lblPerfil.AutoSize = true;
            this.lblPerfil.Location = new System.Drawing.Point(500, 80);
            this.lblPerfil.Name = "lblPerfil";
            this.lblPerfil.Size = new System.Drawing.Size(46, 17);
            this.lblPerfil.TabIndex = 4;
            this.lblPerfil.Text = "label1";
            // 
            // btnNewInvoice
            // 
            this.btnNewInvoice.Location = new System.Drawing.Point(82, 153);
            this.btnNewInvoice.Name = "btnNewInvoice";
            this.btnNewInvoice.Size = new System.Drawing.Size(174, 59);
            this.btnNewInvoice.TabIndex = 5;
            this.btnNewInvoice.Text = "Nueva Factura";
            this.btnNewInvoice.UseVisualStyleBackColor = true;
            // 
            // btnCatalogo
            // 
            this.btnCatalogo.Location = new System.Drawing.Point(282, 153);
            this.btnCatalogo.Name = "btnCatalogo";
            this.btnCatalogo.Size = new System.Drawing.Size(174, 59);
            this.btnCatalogo.TabIndex = 6;
            this.btnCatalogo.Text = "Catálogo";
            this.btnCatalogo.UseVisualStyleBackColor = true;
            // 
            // btnProveedor
            // 
            this.btnProveedor.Location = new System.Drawing.Point(477, 153);
            this.btnProveedor.Name = "btnProveedor";
            this.btnProveedor.Size = new System.Drawing.Size(174, 59);
            this.btnProveedor.TabIndex = 7;
            this.btnProveedor.Text = "Proveedor";
            this.btnProveedor.UseVisualStyleBackColor = true;
            // 
            // FrmHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnProveedor);
            this.Controls.Add(this.btnCatalogo);
            this.Controls.Add(this.btnNewInvoice);
            this.Controls.Add(this.lblPerfil);
            this.Controls.Add(this.lblNomyApe);
            this.Controls.Add(this.lblPerf);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmHome";
            this.Text = "FrmHome";
            this.Load += new System.EventHandler(this.FrmHome_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem MenuAchivo;
        private System.Windows.Forms.ToolStripMenuItem MenuProductos;
        private System.Windows.Forms.ToolStripMenuItem MenuAdministrador;
        private System.Windows.Forms.ToolStripMenuItem MenuNewUser;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label lblPerf;
        private System.Windows.Forms.Label lblNomyApe;
        private System.Windows.Forms.Label lblPerfil;
        private System.Windows.Forms.ToolStripMenuItem MenuSalir;
        private System.Windows.Forms.ToolStripMenuItem MenuListarProductos;
        private System.Windows.Forms.ToolStripMenuItem MenuListarUsuario;
        private System.Windows.Forms.Button btnNewInvoice;
        private System.Windows.Forms.Button btnCatalogo;
        private System.Windows.Forms.Button btnProveedor;
        private System.Windows.Forms.ToolStripMenuItem MenuAgregarProducto;
        private System.Windows.Forms.ToolStripMenuItem MenuModificarProducto;
        private System.Windows.Forms.ToolStripMenuItem MenuModificarUsuario;
        private System.Windows.Forms.ToolStripMenuItem MenuSesion;
        private System.Windows.Forms.ToolStripMenuItem MenuCerrarSesion;
    }
}
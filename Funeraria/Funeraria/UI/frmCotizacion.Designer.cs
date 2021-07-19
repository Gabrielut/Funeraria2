
namespace UTN.Winform.Funeraria.UI
{
    partial class frmCotizacion
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btnEditarCotizacion = new FontAwesome.Sharp.IconButton();
            this.btnSalir = new FontAwesome.Sharp.IconButton();
            this.btnNuevo = new FontAwesome.Sharp.IconButton();
            this.btnSalvarCotizacion = new FontAwesome.Sharp.IconButton();
            this.pnlContenido = new System.Windows.Forms.Panel();
            this.label29 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.lblListado = new System.Windows.Forms.Label();
            this.pnlLinea = new System.Windows.Forms.Panel();
            this.dgrvConvenio = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NomEmpresa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ubicacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TelCelular = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TelEmpresa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TelFax = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descuento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Comentarios = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Servicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnBuscarConvenio = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.iconButton3 = new FontAwesome.Sharp.IconButton();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label18 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgrvPaquete = new System.Windows.Forms.DataGridView();
            this.IdPaquete = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TipoServicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnBuscarPaquete = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.iconButton4 = new FontAwesome.Sharp.IconButton();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.label7 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnBuscarProoveedor = new System.Windows.Forms.Button();
            this.label17 = new System.Windows.Forms.Label();
            this.iconButton7 = new FontAwesome.Sharp.IconButton();
            this.dgrvProveedor = new System.Windows.Forms.DataGridView();
            this.IdProveedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NomProveedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Propietario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Celular = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TelProveedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fax = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Correo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Monto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CantidadUni = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdTipoServicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.label14 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.dgrvCliente = new System.Windows.Forms.DataGridView();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnBuscarCliente = new System.Windows.Forms.Button();
            this.label23 = new System.Windows.Forms.Label();
            this.iconButton8 = new FontAwesome.Sharp.IconButton();
            this.btnGuardar2 = new FontAwesome.Sharp.IconButton();
            this.toolTNombreConvenio = new System.Windows.Forms.ToolTip(this.components);
            this.panel1.SuspendLayout();
            this.pnlContenido.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgrvConvenio)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgrvPaquete)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgrvProveedor)).BeginInit();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgrvCliente)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(63)))), ((int)(((byte)(81)))));
            this.panel1.Controls.Add(this.lblTitulo);
            this.panel1.Controls.Add(this.btnEditarCotizacion);
            this.panel1.Controls.Add(this.btnSalir);
            this.panel1.Controls.Add(this.btnNuevo);
            this.panel1.Controls.Add(this.btnSalvarCotizacion);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(2, 0, 0, 0);
            this.panel1.Size = new System.Drawing.Size(1028, 51);
            this.panel1.TabIndex = 1;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.Goldenrod;
            this.lblTitulo.Location = new System.Drawing.Point(592, 16);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(182, 21);
            this.lblTitulo.TabIndex = 24;
            this.lblTitulo.Text = "Ventana de Cotización";
            // 
            // btnEditarCotizacion
            // 
            this.btnEditarCotizacion.FlatAppearance.BorderSize = 0;
            this.btnEditarCotizacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditarCotizacion.IconChar = FontAwesome.Sharp.IconChar.Edit;
            this.btnEditarCotizacion.IconColor = System.Drawing.Color.Goldenrod;
            this.btnEditarCotizacion.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnEditarCotizacion.IconSize = 36;
            this.btnEditarCotizacion.Location = new System.Drawing.Point(77, 0);
            this.btnEditarCotizacion.Name = "btnEditarCotizacion";
            this.btnEditarCotizacion.Size = new System.Drawing.Size(60, 55);
            this.btnEditarCotizacion.TabIndex = 3;
            this.btnEditarCotizacion.UseVisualStyleBackColor = true;
            // 
            // btnSalir
            // 
            this.btnSalir.FlatAppearance.BorderSize = 0;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.IconChar = FontAwesome.Sharp.IconChar.ExternalLinkAlt;
            this.btnSalir.IconColor = System.Drawing.Color.Goldenrod;
            this.btnSalir.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSalir.IconSize = 36;
            this.btnSalir.Location = new System.Drawing.Point(1283, 3);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(50, 45);
            this.btnSalir.TabIndex = 2;
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.FlatAppearance.BorderSize = 0;
            this.btnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevo.IconChar = FontAwesome.Sharp.IconChar.ListAlt;
            this.btnNuevo.IconColor = System.Drawing.Color.Goldenrod;
            this.btnNuevo.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnNuevo.IconSize = 36;
            this.btnNuevo.Location = new System.Drawing.Point(143, 6);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(50, 45);
            this.btnNuevo.TabIndex = 1;
            this.btnNuevo.UseVisualStyleBackColor = true;
            // 
            // btnSalvarCotizacion
            // 
            this.btnSalvarCotizacion.FlatAppearance.BorderSize = 0;
            this.btnSalvarCotizacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalvarCotizacion.IconChar = FontAwesome.Sharp.IconChar.Save;
            this.btnSalvarCotizacion.IconColor = System.Drawing.Color.Goldenrod;
            this.btnSalvarCotizacion.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSalvarCotizacion.IconSize = 36;
            this.btnSalvarCotizacion.Location = new System.Drawing.Point(23, 6);
            this.btnSalvarCotizacion.Name = "btnSalvarCotizacion";
            this.btnSalvarCotizacion.Size = new System.Drawing.Size(48, 45);
            this.btnSalvarCotizacion.TabIndex = 0;
            this.btnSalvarCotizacion.UseVisualStyleBackColor = true;
            this.btnSalvarCotizacion.Click += new System.EventHandler(this.btnSalvarCotizacion_Click);
            // 
            // pnlContenido
            // 
            this.pnlContenido.BackColor = System.Drawing.Color.White;
            this.pnlContenido.Controls.Add(this.label29);
            this.pnlContenido.Controls.Add(this.tabControl1);
            this.pnlContenido.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContenido.Location = new System.Drawing.Point(0, 51);
            this.pnlContenido.Name = "pnlContenido";
            this.pnlContenido.Size = new System.Drawing.Size(1028, 749);
            this.pnlContenido.TabIndex = 2;
            this.pnlContenido.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlContenido_Paint);
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label29.ForeColor = System.Drawing.Color.Red;
            this.label29.Location = new System.Drawing.Point(882, 642);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(124, 14);
            this.label29.TabIndex = 53;
            this.label29.Text = "** Campos Requeridos";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(36, 37);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1277, 601);
            this.tabControl1.TabIndex = 49;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.White;
            this.tabPage1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.tabPage1.Controls.Add(this.lblListado);
            this.tabPage1.Controls.Add(this.pnlLinea);
            this.tabPage1.Controls.Add(this.dgrvConvenio);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1269, 572);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Convenios";
            // 
            // lblListado
            // 
            this.lblListado.AutoSize = true;
            this.lblListado.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblListado.ForeColor = System.Drawing.Color.Goldenrod;
            this.lblListado.Location = new System.Drawing.Point(540, 305);
            this.lblListado.Name = "lblListado";
            this.lblListado.Size = new System.Drawing.Size(168, 19);
            this.lblListado.TabIndex = 51;
            this.lblListado.Text = "Convenio Seleccionado";
            // 
            // pnlLinea
            // 
            this.pnlLinea.BackColor = System.Drawing.Color.Black;
            this.pnlLinea.Location = new System.Drawing.Point(510, 327);
            this.pnlLinea.Name = "pnlLinea";
            this.pnlLinea.Size = new System.Drawing.Size(223, 1);
            this.pnlLinea.TabIndex = 52;
            // 
            // dgrvConvenio
            // 
            this.dgrvConvenio.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrvConvenio.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.NomEmpresa,
            this.Ubicacion,
            this.TelCelular,
            this.TelEmpresa,
            this.TelFax,
            this.Descuento,
            this.Estado,
            this.Comentarios,
            this.Servicio});
            this.dgrvConvenio.Location = new System.Drawing.Point(37, 343);
            this.dgrvConvenio.Name = "dgrvConvenio";
            this.dgrvConvenio.Size = new System.Drawing.Size(912, 193);
            this.dgrvConvenio.TabIndex = 50;
            // 
            // ID
            // 
            this.ID.DataPropertyName = "IdConvenio";
            this.ID.HeaderText = "IdConvenio";
            this.ID.Name = "ID";
            // 
            // NomEmpresa
            // 
            this.NomEmpresa.DataPropertyName = "NomEmpresa";
            this.NomEmpresa.HeaderText = "Nombre Empresa";
            this.NomEmpresa.Name = "NomEmpresa";
            // 
            // Ubicacion
            // 
            this.Ubicacion.DataPropertyName = "Ubicacion";
            this.Ubicacion.HeaderText = "Ubicacion";
            this.Ubicacion.Name = "Ubicacion";
            // 
            // TelCelular
            // 
            this.TelCelular.DataPropertyName = "TelCelular";
            this.TelCelular.HeaderText = "TelCelular";
            this.TelCelular.Name = "TelCelular";
            // 
            // TelEmpresa
            // 
            this.TelEmpresa.DataPropertyName = "TelEmpresa";
            this.TelEmpresa.HeaderText = "TelEmpresa";
            this.TelEmpresa.Name = "TelEmpresa";
            // 
            // TelFax
            // 
            this.TelFax.DataPropertyName = "TelFax";
            this.TelFax.HeaderText = "TelFax";
            this.TelFax.Name = "TelFax";
            // 
            // Descuento
            // 
            this.Descuento.DataPropertyName = "Descuento";
            this.Descuento.HeaderText = "Descuento";
            this.Descuento.Name = "Descuento";
            // 
            // Estado
            // 
            this.Estado.DataPropertyName = "Estado";
            this.Estado.HeaderText = "Estado";
            this.Estado.Name = "Estado";
            // 
            // Comentarios
            // 
            this.Comentarios.DataPropertyName = "Comentarios";
            this.Comentarios.HeaderText = "Comentarios";
            this.Comentarios.Name = "Comentarios";
            // 
            // Servicio
            // 
            this.Servicio.DataPropertyName = "TipoServicio";
            this.Servicio.HeaderText = "Servicio";
            this.Servicio.Name = "Servicio";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnBuscarConvenio);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.iconButton3);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold);
            this.groupBox1.Location = new System.Drawing.Point(269, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(612, 206);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            // 
            // btnBuscarConvenio
            // 
            this.btnBuscarConvenio.Location = new System.Drawing.Point(250, 29);
            this.btnBuscarConvenio.Name = "btnBuscarConvenio";
            this.btnBuscarConvenio.Size = new System.Drawing.Size(89, 33);
            this.btnBuscarConvenio.TabIndex = 53;
            this.btnBuscarConvenio.Text = "Buscar";
            this.btnBuscarConvenio.UseVisualStyleBackColor = true;
            this.btnBuscarConvenio.Click += new System.EventHandler(this.btnBuscarConvenio_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Goldenrod;
            this.label12.Location = new System.Drawing.Point(105, 29);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(103, 23);
            this.label12.TabIndex = 51;
            this.label12.Text = "Convenios";
            // 
            // iconButton3
            // 
            this.iconButton3.BackColor = System.Drawing.Color.White;
            this.iconButton3.FlatAppearance.BorderSize = 0;
            this.iconButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton3.IconChar = FontAwesome.Sharp.IconChar.Handshake;
            this.iconButton3.IconColor = System.Drawing.Color.Goldenrod;
            this.iconButton3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton3.IconSize = 65;
            this.iconButton3.Location = new System.Drawing.Point(10, 11);
            this.iconButton3.Name = "iconButton3";
            this.iconButton3.Size = new System.Drawing.Size(88, 68);
            this.iconButton3.TabIndex = 50;
            this.iconButton3.UseVisualStyleBackColor = false;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.White;
            this.tabPage2.Controls.Add(this.label18);
            this.tabPage2.Controls.Add(this.panel2);
            this.tabPage2.Controls.Add(this.dgrvPaquete);
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1269, 572);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Paquetes";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.Color.Goldenrod;
            this.label18.Location = new System.Drawing.Point(416, 286);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(160, 19);
            this.label18.TabIndex = 53;
            this.label18.Text = "Paquete Seleccionado";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Location = new System.Drawing.Point(386, 308);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(223, 1);
            this.panel2.TabIndex = 54;
            // 
            // dgrvPaquete
            // 
            this.dgrvPaquete.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrvPaquete.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdPaquete,
            this.Nombre,
            this.Descripcion,
            this.Precio,
            this.Cantidad,
            this.TipoServicio});
            this.dgrvPaquete.Location = new System.Drawing.Point(27, 315);
            this.dgrvPaquete.Name = "dgrvPaquete";
            this.dgrvPaquete.Size = new System.Drawing.Size(892, 199);
            this.dgrvPaquete.TabIndex = 51;
            // 
            // IdPaquete
            // 
            this.IdPaquete.DataPropertyName = "IdPaquete";
            this.IdPaquete.HeaderText = "IdPaquete";
            this.IdPaquete.Name = "IdPaquete";
            // 
            // Nombre
            // 
            this.Nombre.DataPropertyName = "Nombre";
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            // 
            // Descripcion
            // 
            this.Descripcion.DataPropertyName = "Descripcion";
            this.Descripcion.HeaderText = "Descripcion";
            this.Descripcion.Name = "Descripcion";
            // 
            // Precio
            // 
            this.Precio.DataPropertyName = "Precio";
            this.Precio.HeaderText = "Precio";
            this.Precio.Name = "Precio";
            // 
            // Cantidad
            // 
            this.Cantidad.DataPropertyName = "Cantidad";
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.Name = "Cantidad";
            // 
            // TipoServicio
            // 
            this.TipoServicio.DataPropertyName = "TipoServicio";
            this.TipoServicio.HeaderText = "Tipo Servicio";
            this.TipoServicio.Name = "TipoServicio";
            this.TipoServicio.ReadOnly = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnBuscarPaquete);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.iconButton4);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold);
            this.groupBox2.Location = new System.Drawing.Point(294, 32);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(416, 241);
            this.groupBox2.TabIndex = 46;
            this.groupBox2.TabStop = false;
            // 
            // btnBuscarPaquete
            // 
            this.btnBuscarPaquete.Location = new System.Drawing.Point(245, 34);
            this.btnBuscarPaquete.Name = "btnBuscarPaquete";
            this.btnBuscarPaquete.Size = new System.Drawing.Size(138, 70);
            this.btnBuscarPaquete.TabIndex = 60;
            this.btnBuscarPaquete.Text = "Buscar";
            this.btnBuscarPaquete.UseVisualStyleBackColor = true;
            this.btnBuscarPaquete.Click += new System.EventHandler(this.btnBuscarPaquete_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Goldenrod;
            this.label6.Location = new System.Drawing.Point(105, 34);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 23);
            this.label6.TabIndex = 53;
            this.label6.Text = "Paquetes";
            // 
            // iconButton4
            // 
            this.iconButton4.BackColor = System.Drawing.Color.White;
            this.iconButton4.FlatAppearance.BorderSize = 0;
            this.iconButton4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton4.IconChar = FontAwesome.Sharp.IconChar.BoxOpen;
            this.iconButton4.IconColor = System.Drawing.Color.Goldenrod;
            this.iconButton4.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton4.IconSize = 65;
            this.iconButton4.Location = new System.Drawing.Point(10, 16);
            this.iconButton4.Name = "iconButton4";
            this.iconButton4.Size = new System.Drawing.Size(88, 68);
            this.iconButton4.TabIndex = 52;
            this.iconButton4.UseVisualStyleBackColor = false;
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.White;
            this.tabPage3.Controls.Add(this.label7);
            this.tabPage3.Controls.Add(this.panel3);
            this.tabPage3.Controls.Add(this.groupBox3);
            this.tabPage3.Controls.Add(this.dgrvProveedor);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1269, 572);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Servicios Adicionales";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Goldenrod;
            this.label7.Location = new System.Drawing.Point(552, 291);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(143, 19);
            this.label7.TabIndex = 56;
            this.label7.Text = "Detalle de servicios";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Black;
            this.panel3.Location = new System.Drawing.Point(522, 313);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(223, 1);
            this.panel3.TabIndex = 57;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnBuscarProoveedor);
            this.groupBox3.Controls.Add(this.label17);
            this.groupBox3.Controls.Add(this.iconButton7);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold);
            this.groupBox3.Location = new System.Drawing.Point(219, 35);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(676, 211);
            this.groupBox3.TabIndex = 47;
            this.groupBox3.TabStop = false;
            // 
            // btnBuscarProoveedor
            // 
            this.btnBuscarProoveedor.Location = new System.Drawing.Point(366, 41);
            this.btnBuscarProoveedor.Name = "btnBuscarProoveedor";
            this.btnBuscarProoveedor.Size = new System.Drawing.Size(81, 50);
            this.btnBuscarProoveedor.TabIndex = 58;
            this.btnBuscarProoveedor.Text = "Buscar";
            this.btnBuscarProoveedor.UseVisualStyleBackColor = true;
            this.btnBuscarProoveedor.Click += new System.EventHandler(this.btnBuscarProoveedor_Click);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.Goldenrod;
            this.label17.Location = new System.Drawing.Point(110, 41);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(194, 23);
            this.label17.TabIndex = 57;
            this.label17.Text = "Servicios Adicionales";
            // 
            // iconButton7
            // 
            this.iconButton7.BackColor = System.Drawing.Color.White;
            this.iconButton7.FlatAppearance.BorderSize = 0;
            this.iconButton7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton7.IconChar = FontAwesome.Sharp.IconChar.Buromobelexperte;
            this.iconButton7.IconColor = System.Drawing.Color.Goldenrod;
            this.iconButton7.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton7.IconSize = 65;
            this.iconButton7.Location = new System.Drawing.Point(15, 23);
            this.iconButton7.Name = "iconButton7";
            this.iconButton7.Size = new System.Drawing.Size(88, 68);
            this.iconButton7.TabIndex = 56;
            this.iconButton7.UseVisualStyleBackColor = false;
            // 
            // dgrvProveedor
            // 
            this.dgrvProveedor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrvProveedor.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdProveedor,
            this.NomProveedor,
            this.Propietario,
            this.Celular,
            this.TelProveedor,
            this.Fax,
            this.Correo,
            this.Monto,
            this.CantidadUni,
            this.IdTipoServicio});
            this.dgrvProveedor.Location = new System.Drawing.Point(103, 341);
            this.dgrvProveedor.Name = "dgrvProveedor";
            this.dgrvProveedor.Size = new System.Drawing.Size(789, 193);
            this.dgrvProveedor.TabIndex = 55;
            // 
            // IdProveedor
            // 
            this.IdProveedor.DataPropertyName = "IdProveedor";
            this.IdProveedor.HeaderText = "IdProveedor";
            this.IdProveedor.Name = "IdProveedor";
            // 
            // NomProveedor
            // 
            this.NomProveedor.DataPropertyName = "NomProveedor";
            this.NomProveedor.HeaderText = "NomProveedor";
            this.NomProveedor.Name = "NomProveedor";
            // 
            // Propietario
            // 
            this.Propietario.DataPropertyName = "Propietario";
            this.Propietario.HeaderText = "Propietario";
            this.Propietario.Name = "Propietario";
            // 
            // Celular
            // 
            this.Celular.DataPropertyName = "TelCelular";
            this.Celular.HeaderText = "Celular";
            this.Celular.Name = "Celular";
            // 
            // TelProveedor
            // 
            this.TelProveedor.DataPropertyName = "TelProveedor";
            this.TelProveedor.HeaderText = "TelProveedor";
            this.TelProveedor.Name = "TelProveedor";
            // 
            // Fax
            // 
            this.Fax.DataPropertyName = "TelFax";
            this.Fax.HeaderText = "Fax";
            this.Fax.Name = "Fax";
            // 
            // Correo
            // 
            this.Correo.DataPropertyName = "Correo";
            this.Correo.HeaderText = "Correo";
            this.Correo.Name = "Correo";
            // 
            // Monto
            // 
            this.Monto.DataPropertyName = "Precio";
            this.Monto.HeaderText = "Monto";
            this.Monto.Name = "Monto";
            // 
            // CantidadUni
            // 
            this.CantidadUni.DataPropertyName = "CantUni";
            this.CantidadUni.HeaderText = "CantidadUni";
            this.CantidadUni.Name = "CantidadUni";
            // 
            // IdTipoServicio
            // 
            this.IdTipoServicio.DataPropertyName = "IdTipoServicio";
            this.IdTipoServicio.HeaderText = "Tipo Servicio";
            this.IdTipoServicio.Name = "IdTipoServicio";
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.label14);
            this.tabPage4.Controls.Add(this.panel4);
            this.tabPage4.Controls.Add(this.dgrvCliente);
            this.tabPage4.Controls.Add(this.groupBox4);
            this.tabPage4.Controls.Add(this.btnGuardar2);
            this.tabPage4.Location = new System.Drawing.Point(4, 25);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(1269, 572);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Información de Clientes";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.Goldenrod;
            this.label14.Location = new System.Drawing.Point(383, 332);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(133, 19);
            this.label14.TabIndex = 59;
            this.label14.Text = "Detalle del cliente";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Black;
            this.panel4.Location = new System.Drawing.Point(341, 360);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(223, 1);
            this.panel4.TabIndex = 60;
            // 
            // dgrvCliente
            // 
            this.dgrvCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrvCliente.Location = new System.Drawing.Point(20, 373);
            this.dgrvCliente.Name = "dgrvCliente";
            this.dgrvCliente.Size = new System.Drawing.Size(948, 183);
            this.dgrvCliente.TabIndex = 58;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnBuscarCliente);
            this.groupBox4.Controls.Add(this.label23);
            this.groupBox4.Controls.Add(this.iconButton8);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold);
            this.groupBox4.Location = new System.Drawing.Point(220, 32);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(388, 127);
            this.groupBox4.TabIndex = 48;
            this.groupBox4.TabStop = false;
            // 
            // btnBuscarCliente
            // 
            this.btnBuscarCliente.Location = new System.Drawing.Point(231, 34);
            this.btnBuscarCliente.Name = "btnBuscarCliente";
            this.btnBuscarCliente.Size = new System.Drawing.Size(95, 36);
            this.btnBuscarCliente.TabIndex = 76;
            this.btnBuscarCliente.Text = "Buscar";
            this.btnBuscarCliente.UseVisualStyleBackColor = true;
            this.btnBuscarCliente.Click += new System.EventHandler(this.btnBuscarCliente_Click);
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.ForeColor = System.Drawing.Color.Goldenrod;
            this.label23.Location = new System.Drawing.Point(105, 34);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(79, 23);
            this.label23.TabIndex = 74;
            this.label23.Text = "Clientes";
            // 
            // iconButton8
            // 
            this.iconButton8.BackColor = System.Drawing.Color.White;
            this.iconButton8.FlatAppearance.BorderSize = 0;
            this.iconButton8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton8.IconChar = FontAwesome.Sharp.IconChar.IdCard;
            this.iconButton8.IconColor = System.Drawing.Color.Goldenrod;
            this.iconButton8.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton8.IconSize = 65;
            this.iconButton8.Location = new System.Drawing.Point(11, 13);
            this.iconButton8.Name = "iconButton8";
            this.iconButton8.Size = new System.Drawing.Size(88, 68);
            this.iconButton8.TabIndex = 73;
            this.iconButton8.UseVisualStyleBackColor = false;
            // 
            // btnGuardar2
            // 
            this.btnGuardar2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGuardar2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(63)))), ((int)(((byte)(81)))));
            this.btnGuardar2.FlatAppearance.BorderColor = System.Drawing.Color.DarkGoldenrod;
            this.btnGuardar2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(63)))), ((int)(((byte)(81)))));
            this.btnGuardar2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Goldenrod;
            this.btnGuardar2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGuardar2.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar2.ForeColor = System.Drawing.Color.White;
            this.btnGuardar2.IconChar = FontAwesome.Sharp.IconChar.Fax;
            this.btnGuardar2.IconColor = System.Drawing.Color.Goldenrod;
            this.btnGuardar2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnGuardar2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGuardar2.Location = new System.Drawing.Point(1034, 497);
            this.btnGuardar2.Name = "btnGuardar2";
            this.btnGuardar2.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnGuardar2.Size = new System.Drawing.Size(200, 46);
            this.btnGuardar2.TabIndex = 49;
            this.btnGuardar2.Text = "Generar Cotización";
            this.btnGuardar2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuardar2.UseVisualStyleBackColor = false;
            // 
            // toolTNombreConvenio
            // 
            this.toolTNombreConvenio.IsBalloon = true;
            // 
            // frmCotizacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1028, 800);
            this.Controls.Add(this.pnlContenido);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmCotizacion";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnlContenido.ResumeLayout(false);
            this.pnlContenido.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgrvConvenio)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgrvPaquete)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgrvProveedor)).EndInit();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgrvCliente)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton btnEditarCotizacion;
        private FontAwesome.Sharp.IconButton btnSalir;
        private FontAwesome.Sharp.IconButton btnNuevo;
        private FontAwesome.Sharp.IconButton btnSalvarCotizacion;
        private System.Windows.Forms.Panel pnlContenido;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataGridView dgrvConvenio;
        private System.Windows.Forms.Label label12;
        private FontAwesome.Sharp.IconButton iconButton3;
        private System.Windows.Forms.DataGridView dgrvPaquete;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Label lblListado;
        private System.Windows.Forms.Panel pnlLinea;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label6;
        private FontAwesome.Sharp.IconButton iconButton4;
        private System.Windows.Forms.Label label17;
        private FontAwesome.Sharp.IconButton iconButton7;
        private FontAwesome.Sharp.IconButton btnGuardar2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dgrvProveedor;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DataGridView dgrvCliente;
        private System.Windows.Forms.Label label23;
        private FontAwesome.Sharp.IconButton iconButton8;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.ToolTip toolTNombreConvenio;
        private System.Windows.Forms.Button btnBuscarCliente;
        private System.Windows.Forms.Button btnBuscarConvenio;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomEmpresa;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ubicacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn TelCelular;
        private System.Windows.Forms.DataGridViewTextBoxColumn TelEmpresa;
        private System.Windows.Forms.DataGridViewTextBoxColumn TelFax;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descuento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estado;
        private System.Windows.Forms.DataGridViewTextBoxColumn Comentarios;
        private System.Windows.Forms.DataGridViewTextBoxColumn Servicio;
        private System.Windows.Forms.Button btnBuscarPaquete;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdPaquete;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipoServicio;
        private System.Windows.Forms.Button btnBuscarProoveedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdProveedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomProveedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Propietario;
        private System.Windows.Forms.DataGridViewTextBoxColumn Celular;
        private System.Windows.Forms.DataGridViewTextBoxColumn TelProveedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fax;
        private System.Windows.Forms.DataGridViewTextBoxColumn Correo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Monto;
        private System.Windows.Forms.DataGridViewTextBoxColumn CantidadUni;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdTipoServicio;
    }
}
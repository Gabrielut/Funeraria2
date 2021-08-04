
namespace UTN.Winform.Funeraria.UI
{
    partial class frmFacturacion
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCerrar = new FontAwesome.Sharp.IconButton();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btnSalir = new FontAwesome.Sharp.IconButton();
            this.dgrFactura = new System.Windows.Forms.DataGridView();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Paquete = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Servicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Comentarios = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnFacturar = new FontAwesome.Sharp.IconButton();
            this.btnGuardar2 = new FontAwesome.Sharp.IconButton();
            this.txtIdCotizacion = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblCosto = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.iconButton2 = new FontAwesome.Sharp.IconButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtTotal = new System.Windows.Forms.MaskedTextBox();
            this.txtDescuento = new System.Windows.Forms.MaskedTextBox();
            this.txtIVA = new System.Windows.Forms.MaskedTextBox();
            this.txtSubTotal = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.toolTNumCotiz = new System.Windows.Forms.ToolTip(this.components);
            this.toolTBuscar = new System.Windows.Forms.ToolTip(this.components);
            this.toolTFacturar = new System.Windows.Forms.ToolTip(this.components);
            this.toolTLista = new System.Windows.Forms.ToolTip(this.components);
            this.toolTSubtotal = new System.Windows.Forms.ToolTip(this.components);
            this.toolTIVA = new System.Windows.Forms.ToolTip(this.components);
            this.toolTDesc = new System.Windows.Forms.ToolTip(this.components);
            this.toolTTotal = new System.Windows.Forms.ToolTip(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgrFactura)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(63)))), ((int)(((byte)(81)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnCerrar);
            this.panel1.Controls.Add(this.lblTitulo);
            this.panel1.Controls.Add(this.btnSalir);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(2, 0, 0, 0);
            this.panel1.Size = new System.Drawing.Size(1012, 51);
            this.panel1.TabIndex = 2;
            // 
            // btnCerrar
            // 
            this.btnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(63)))), ((int)(((byte)(81)))));
            this.btnCerrar.FlatAppearance.BorderSize = 0;
            this.btnCerrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(135)))), ((int)(((byte)(18)))));
            this.btnCerrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(63)))), ((int)(((byte)(81)))));
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrar.ForeColor = System.Drawing.Color.Transparent;
            this.btnCerrar.IconChar = FontAwesome.Sharp.IconChar.Times;
            this.btnCerrar.IconColor = System.Drawing.Color.White;
            this.btnCerrar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCerrar.IconSize = 25;
            this.btnCerrar.Location = new System.Drawing.Point(975, 8);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(32, 31);
            this.btnCerrar.TabIndex = 25;
            this.btnCerrar.UseVisualStyleBackColor = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.Goldenrod;
            this.lblTitulo.Location = new System.Drawing.Point(447, 13);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(99, 21);
            this.lblTitulo.TabIndex = 24;
            this.lblTitulo.Text = "Facturación";
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
            // 
            // dgrFactura
            // 
            this.dgrFactura.BackgroundColor = System.Drawing.Color.White;
            this.dgrFactura.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgrFactura.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgrFactura.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(63)))), ((int)(((byte)(81)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(82)))), ((int)(((byte)(89)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgrFactura.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgrFactura.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrFactura.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo,
            this.Cliente,
            this.Paquete,
            this.Servicio,
            this.Comentarios});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(82)))), ((int)(((byte)(89)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgrFactura.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgrFactura.EnableHeadersVisualStyles = false;
            this.dgrFactura.Location = new System.Drawing.Point(84, 198);
            this.dgrFactura.Name = "dgrFactura";
            this.dgrFactura.ReadOnly = true;
            this.dgrFactura.RowHeadersVisible = false;
            this.dgrFactura.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgrFactura.Size = new System.Drawing.Size(864, 209);
            this.dgrFactura.TabIndex = 3;
            // 
            // Codigo
            // 
            this.Codigo.DataPropertyName = "IdCotizacion";
            this.Codigo.HeaderText = "Codigo";
            this.Codigo.Name = "Codigo";
            this.Codigo.ReadOnly = true;
            this.Codigo.Width = 150;
            // 
            // Cliente
            // 
            this.Cliente.DataPropertyName = "cliente";
            this.Cliente.HeaderText = "Cliente";
            this.Cliente.Name = "Cliente";
            this.Cliente.ReadOnly = true;
            this.Cliente.Width = 150;
            // 
            // Paquete
            // 
            this.Paquete.DataPropertyName = "paquete";
            this.Paquete.HeaderText = "Paquete";
            this.Paquete.Name = "Paquete";
            this.Paquete.ReadOnly = true;
            this.Paquete.Width = 170;
            // 
            // Servicio
            // 
            this.Servicio.DataPropertyName = "proveedores";
            this.Servicio.HeaderText = "Servicio";
            this.Servicio.Name = "Servicio";
            this.Servicio.ReadOnly = true;
            this.Servicio.Width = 150;
            // 
            // Comentarios
            // 
            this.Comentarios.DataPropertyName = "comentariosProveedores";
            this.Comentarios.HeaderText = "Comentarios";
            this.Comentarios.Name = "Comentarios";
            this.Comentarios.ReadOnly = true;
            this.Comentarios.Width = 200;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.btnFacturar);
            this.groupBox1.Controls.Add(this.btnGuardar2);
            this.groupBox1.Controls.Add(this.txtIdCotizacion);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(6, 32);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1000, 84);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Detalle";
            // 
            // btnFacturar
            // 
            this.btnFacturar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFacturar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(63)))), ((int)(((byte)(81)))));
            this.btnFacturar.FlatAppearance.BorderColor = System.Drawing.Color.DarkGoldenrod;
            this.btnFacturar.FlatAppearance.BorderSize = 0;
            this.btnFacturar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(63)))), ((int)(((byte)(81)))));
            this.btnFacturar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Goldenrod;
            this.btnFacturar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFacturar.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFacturar.ForeColor = System.Drawing.Color.White;
            this.btnFacturar.IconChar = FontAwesome.Sharp.IconChar.Save;
            this.btnFacturar.IconColor = System.Drawing.Color.Goldenrod;
            this.btnFacturar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnFacturar.IconSize = 35;
            this.btnFacturar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnFacturar.Location = new System.Drawing.Point(852, 23);
            this.btnFacturar.Name = "btnFacturar";
            this.btnFacturar.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnFacturar.Size = new System.Drawing.Size(116, 38);
            this.btnFacturar.TabIndex = 51;
            this.btnFacturar.Text = "Facturar";
            this.btnFacturar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFacturar.UseVisualStyleBackColor = false;
            this.btnFacturar.Click += new System.EventHandler(this.btnFacturar_Click);
            // 
            // btnGuardar2
            // 
            this.btnGuardar2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGuardar2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(63)))), ((int)(((byte)(81)))));
            this.btnGuardar2.FlatAppearance.BorderColor = System.Drawing.Color.DarkGoldenrod;
            this.btnGuardar2.FlatAppearance.BorderSize = 0;
            this.btnGuardar2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(63)))), ((int)(((byte)(81)))));
            this.btnGuardar2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Goldenrod;
            this.btnGuardar2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar2.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar2.ForeColor = System.Drawing.Color.White;
            this.btnGuardar2.IconChar = FontAwesome.Sharp.IconChar.Binoculars;
            this.btnGuardar2.IconColor = System.Drawing.Color.Goldenrod;
            this.btnGuardar2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnGuardar2.IconSize = 35;
            this.btnGuardar2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGuardar2.Location = new System.Drawing.Point(345, 30);
            this.btnGuardar2.Name = "btnGuardar2";
            this.btnGuardar2.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnGuardar2.Size = new System.Drawing.Size(113, 38);
            this.btnGuardar2.TabIndex = 50;
            this.btnGuardar2.Text = "Buscar";
            this.btnGuardar2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuardar2.UseVisualStyleBackColor = false;
            this.btnGuardar2.Click += new System.EventHandler(this.btnGuardar2_Click);
            // 
            // txtIdCotizacion
            // 
            this.txtIdCotizacion.Location = new System.Drawing.Point(163, 38);
            this.txtIdCotizacion.Name = "txtIdCotizacion";
            this.txtIdCotizacion.Size = new System.Drawing.Size(132, 24);
            this.txtIdCotizacion.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 16);
            this.label1.TabIndex = 26;
            this.label1.Text = "N° Cotización";
            // 
            // lblCosto
            // 
            this.lblCosto.AutoSize = true;
            this.lblCosto.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCosto.Location = new System.Drawing.Point(34, 158);
            this.lblCosto.Name = "lblCosto";
            this.lblCosto.Size = new System.Drawing.Size(40, 16);
            this.lblCosto.TabIndex = 14;
            this.lblCosto.Text = "Total";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(63)))), ((int)(((byte)(81)))));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.iconButton2);
            this.panel2.Location = new System.Drawing.Point(0, 138);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(2, 0, 0, 0);
            this.panel2.Size = new System.Drawing.Size(1012, 41);
            this.panel2.TabIndex = 26;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Goldenrod;
            this.label2.Location = new System.Drawing.Point(419, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 21);
            this.label2.TabIndex = 24;
            this.label2.Text = "Líneas de detalle";
            // 
            // iconButton2
            // 
            this.iconButton2.FlatAppearance.BorderSize = 0;
            this.iconButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton2.IconChar = FontAwesome.Sharp.IconChar.ExternalLinkAlt;
            this.iconButton2.IconColor = System.Drawing.Color.Goldenrod;
            this.iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton2.IconSize = 36;
            this.iconButton2.Location = new System.Drawing.Point(1283, 3);
            this.iconButton2.Name = "iconButton2";
            this.iconButton2.Size = new System.Drawing.Size(50, 45);
            this.iconButton2.TabIndex = 2;
            this.iconButton2.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.txtTotal);
            this.groupBox2.Controls.Add(this.txtDescuento);
            this.groupBox2.Controls.Add(this.txtIVA);
            this.groupBox2.Controls.Add(this.txtSubTotal);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.lblCosto);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(625, 413);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(365, 187);
            this.groupBox2.TabIndex = 27;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Total";
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(177, 150);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtTotal.Size = new System.Drawing.Size(136, 24);
            this.txtTotal.TabIndex = 31;
            // 
            // txtDescuento
            // 
            this.txtDescuento.Location = new System.Drawing.Point(177, 109);
            this.txtDescuento.Name = "txtDescuento";
            this.txtDescuento.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtDescuento.Size = new System.Drawing.Size(136, 24);
            this.txtDescuento.TabIndex = 30;
            // 
            // txtIVA
            // 
            this.txtIVA.Location = new System.Drawing.Point(177, 67);
            this.txtIVA.Name = "txtIVA";
            this.txtIVA.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtIVA.Size = new System.Drawing.Size(136, 24);
            this.txtIVA.TabIndex = 29;
            // 
            // txtSubTotal
            // 
            this.txtSubTotal.Location = new System.Drawing.Point(177, 27);
            this.txtSubTotal.Name = "txtSubTotal";
            this.txtSubTotal.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtSubTotal.Size = new System.Drawing.Size(136, 24);
            this.txtSubTotal.TabIndex = 28;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 16);
            this.label3.TabIndex = 26;
            this.label3.Text = "Descuento";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(34, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "IVA";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(34, 30);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 16);
            this.label5.TabIndex = 14;
            this.label5.Text = "Subtotal";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.groupBox1);
            this.groupBox3.Controls.Add(this.groupBox2);
            this.groupBox3.Controls.Add(this.dgrFactura);
            this.groupBox3.Controls.Add(this.panel2);
            this.groupBox3.Location = new System.Drawing.Point(0, 46);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1012, 612);
            this.groupBox3.TabIndex = 28;
            this.groupBox3.TabStop = false;
            // 
            // frmFacturacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1012, 658);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmFacturacion";
            this.Text = "frmFacturacion";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgrFactura)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblTitulo;
        private FontAwesome.Sharp.IconButton btnSalir;
        private System.Windows.Forms.DataGridView dgrFactura;
        private FontAwesome.Sharp.IconButton btnCerrar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtIdCotizacion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblCosto;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private FontAwesome.Sharp.IconButton iconButton2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox3;
        private FontAwesome.Sharp.IconButton btnGuardar2;
        private System.Windows.Forms.MaskedTextBox txtTotal;
        private System.Windows.Forms.MaskedTextBox txtDescuento;
        private System.Windows.Forms.MaskedTextBox txtIVA;
        private System.Windows.Forms.MaskedTextBox txtSubTotal;
        private FontAwesome.Sharp.IconButton btnFacturar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn Paquete;
        private System.Windows.Forms.DataGridViewTextBoxColumn Servicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Comentarios;
        private System.Windows.Forms.ToolTip toolTNumCotiz;
        private System.Windows.Forms.ToolTip toolTBuscar;
        private System.Windows.Forms.ToolTip toolTFacturar;
        private System.Windows.Forms.ToolTip toolTLista;
        private System.Windows.Forms.ToolTip toolTSubtotal;
        private System.Windows.Forms.ToolTip toolTIVA;
        private System.Windows.Forms.ToolTip toolTDesc;
        private System.Windows.Forms.ToolTip toolTTotal;
    }
}
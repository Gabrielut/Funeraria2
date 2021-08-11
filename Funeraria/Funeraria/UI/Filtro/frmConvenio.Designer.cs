namespace UTN.Winform.Funeraria.UI.Filtro
{
    partial class frmConvenio
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtFiltro = new System.Windows.Forms.TextBox();
            this.dgrvDatos = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCerrar = new FontAwesome.Sharp.IconButton();
            this.iconButton8 = new FontAwesome.Sharp.IconButton();
            this.btnSalir = new FontAwesome.Sharp.IconButton();
            this.label23 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NomEmpresa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ubicacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TelCelular = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TelEmpresa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TelFax = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descuento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Comentarios = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TipoServicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgrvDatos)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(63)))), ((int)(((byte)(81)))));
            this.btnBuscar.FlatAppearance.BorderSize = 0;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.ForeColor = System.Drawing.Color.White;
            this.btnBuscar.Location = new System.Drawing.Point(761, 45);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(86, 38);
            this.btnBuscar.TabIndex = 0;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txtFiltro
            // 
            this.txtFiltro.Location = new System.Drawing.Point(150, 45);
            this.txtFiltro.Name = "txtFiltro";
            this.txtFiltro.Size = new System.Drawing.Size(212, 20);
            this.txtFiltro.TabIndex = 1;
            // 
            // dgrvDatos
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgrvDatos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgrvDatos.BackgroundColor = System.Drawing.Color.White;
            this.dgrvDatos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgrvDatos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgrvDatos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(63)))), ((int)(((byte)(81)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(82)))), ((int)(((byte)(89)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgrvDatos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgrvDatos.ColumnHeadersHeight = 30;
            this.dgrvDatos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.NomEmpresa,
            this.Ubicacion,
            this.TelCelular,
            this.TelEmpresa,
            this.TelFax,
            this.Descuento,
            this.Estado,
            this.Comentarios,
            this.TipoServicio});
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(82)))), ((int)(((byte)(89)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgrvDatos.DefaultCellStyle = dataGridViewCellStyle7;
            this.dgrvDatos.EnableHeadersVisualStyles = false;
            this.dgrvDatos.Location = new System.Drawing.Point(48, 152);
            this.dgrvDatos.Name = "dgrvDatos";
            this.dgrvDatos.ReadOnly = true;
            this.dgrvDatos.RowHeadersVisible = false;
            this.dgrvDatos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgrvDatos.Size = new System.Drawing.Size(870, 158);
            this.dgrvDatos.TabIndex = 2;
            this.dgrvDatos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgrvDatos_CellClick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(63)))), ((int)(((byte)(81)))));
            this.panel1.Controls.Add(this.btnCerrar);
            this.panel1.Controls.Add(this.iconButton8);
            this.panel1.Controls.Add(this.btnSalir);
            this.panel1.Controls.Add(this.label23);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(2, 0, 0, 0);
            this.panel1.Size = new System.Drawing.Size(980, 51);
            this.panel1.TabIndex = 52;
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
            this.btnCerrar.Location = new System.Drawing.Point(945, 11);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(32, 31);
            this.btnCerrar.TabIndex = 75;
            this.btnCerrar.UseVisualStyleBackColor = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // iconButton8
            // 
            this.iconButton8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(63)))), ((int)(((byte)(81)))));
            this.iconButton8.FlatAppearance.BorderSize = 0;
            this.iconButton8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton8.IconChar = FontAwesome.Sharp.IconChar.IdCard;
            this.iconButton8.IconColor = System.Drawing.Color.Goldenrod;
            this.iconButton8.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton8.IconSize = 65;
            this.iconButton8.Location = new System.Drawing.Point(12, 5);
            this.iconButton8.Name = "iconButton8";
            this.iconButton8.Size = new System.Drawing.Size(68, 46);
            this.iconButton8.TabIndex = 73;
            this.iconButton8.UseVisualStyleBackColor = false;
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
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.ForeColor = System.Drawing.Color.Goldenrod;
            this.label23.Location = new System.Drawing.Point(361, 19);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(245, 23);
            this.label23.TabIndex = 74;
            this.label23.Text = "Información de Convenios";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblNombre);
            this.groupBox1.Controls.Add(this.btnBuscar);
            this.groupBox1.Controls.Add(this.txtFiltro);
            this.groupBox1.Location = new System.Drawing.Point(32, 19);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(886, 100);
            this.groupBox1.TabIndex = 53;
            this.groupBox1.TabStop = false;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(13, 45);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(58, 16);
            this.lblNombre.TabIndex = 6;
            this.lblNombre.Text = "Nombre";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.groupBox1);
            this.groupBox2.Controls.Add(this.dgrvDatos);
            this.groupBox2.Location = new System.Drawing.Point(0, 48);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(977, 475);
            this.groupBox2.TabIndex = 54;
            this.groupBox2.TabStop = false;
            // 
            // ID
            // 
            this.ID.DataPropertyName = "IdConvenio";
            this.ID.HeaderText = "Código";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            // 
            // NomEmpresa
            // 
            this.NomEmpresa.DataPropertyName = "NomEmpresa";
            this.NomEmpresa.HeaderText = "Nombre";
            this.NomEmpresa.Name = "NomEmpresa";
            this.NomEmpresa.ReadOnly = true;
            // 
            // Ubicacion
            // 
            this.Ubicacion.DataPropertyName = "Ubicacion";
            this.Ubicacion.HeaderText = "Ubicacion";
            this.Ubicacion.Name = "Ubicacion";
            this.Ubicacion.ReadOnly = true;
            // 
            // TelCelular
            // 
            this.TelCelular.DataPropertyName = "TelCelular";
            dataGridViewCellStyle3.Format = "0000-0000";
            dataGridViewCellStyle3.NullValue = "N/A";
            this.TelCelular.DefaultCellStyle = dataGridViewCellStyle3;
            this.TelCelular.HeaderText = "Celular";
            this.TelCelular.Name = "TelCelular";
            this.TelCelular.ReadOnly = true;
            // 
            // TelEmpresa
            // 
            this.TelEmpresa.DataPropertyName = "TelEmpresa";
            dataGridViewCellStyle4.Format = "0000-0000";
            dataGridViewCellStyle4.NullValue = "N/A";
            this.TelEmpresa.DefaultCellStyle = dataGridViewCellStyle4;
            this.TelEmpresa.HeaderText = "Teléfono";
            this.TelEmpresa.Name = "TelEmpresa";
            this.TelEmpresa.ReadOnly = true;
            // 
            // TelFax
            // 
            this.TelFax.DataPropertyName = "TelFax";
            dataGridViewCellStyle5.Format = "0000-0000";
            dataGridViewCellStyle5.NullValue = "N/A";
            this.TelFax.DefaultCellStyle = dataGridViewCellStyle5;
            this.TelFax.HeaderText = "Fax";
            this.TelFax.Name = "TelFax";
            this.TelFax.ReadOnly = true;
            // 
            // Descuento
            // 
            this.Descuento.DataPropertyName = "Descuento";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.Format = "00\"%\"";
            this.Descuento.DefaultCellStyle = dataGridViewCellStyle6;
            this.Descuento.HeaderText = "Descuento";
            this.Descuento.Name = "Descuento";
            this.Descuento.ReadOnly = true;
            // 
            // Estado
            // 
            this.Estado.DataPropertyName = "Estado";
            this.Estado.HeaderText = "Estado";
            this.Estado.Name = "Estado";
            this.Estado.ReadOnly = true;
            // 
            // Comentarios
            // 
            this.Comentarios.DataPropertyName = "Comentarios";
            this.Comentarios.HeaderText = "Comentarios";
            this.Comentarios.Name = "Comentarios";
            this.Comentarios.ReadOnly = true;
            // 
            // TipoServicio
            // 
            this.TipoServicio.DataPropertyName = "TipoServicio";
            this.TipoServicio.HeaderText = "Servicio";
            this.TipoServicio.Name = "TipoServicio";
            this.TipoServicio.ReadOnly = true;
            // 
            // frmConvenio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(980, 523);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmConvenio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmConvenio";
            ((System.ComponentModel.ISupportInitialize)(this.dgrvDatos)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtFiltro;
        private System.Windows.Forms.DataGridView dgrvDatos;
        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton iconButton8;
        private FontAwesome.Sharp.IconButton btnSalir;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.GroupBox groupBox1;
        private FontAwesome.Sharp.IconButton btnCerrar;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomEmpresa;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ubicacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn TelCelular;
        private System.Windows.Forms.DataGridViewTextBoxColumn TelEmpresa;
        private System.Windows.Forms.DataGridViewTextBoxColumn TelFax;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descuento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estado;
        private System.Windows.Forms.DataGridViewTextBoxColumn Comentarios;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipoServicio;
    }
}
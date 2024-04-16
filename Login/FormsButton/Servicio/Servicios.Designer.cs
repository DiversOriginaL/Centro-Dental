namespace Presentacion.FormsButton.Servicio
{
    partial class Servicios
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.dtgvServicios = new System.Windows.Forms.DataGridView();
            this.btnCrear = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.FacturaID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaEmision = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Servicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Importe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SubTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descuento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Remitida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvServicios)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCerrar
            // 
            this.btnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCerrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(136)))), ((int)(((byte)(68)))));
            this.btnCerrar.FlatAppearance.BorderSize = 0;
            this.btnCerrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(136)))), ((int)(((byte)(68)))));
            this.btnCerrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(204)))), ((int)(((byte)(102)))));
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrar.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCerrar.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnCerrar.Image = global::Presentacion.Properties.Resources.close;
            this.btnCerrar.Location = new System.Drawing.Point(12, 678);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(218, 72);
            this.btnCerrar.TabIndex = 1;
            this.btnCerrar.Text = " Cerrar";
            this.btnCerrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCerrar.UseVisualStyleBackColor = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // dtgvServicios
            // 
            this.dtgvServicios.AllowUserToAddRows = false;
            this.dtgvServicios.AllowUserToResizeColumns = false;
            this.dtgvServicios.AllowUserToResizeRows = false;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Sitka Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(136)))), ((int)(((byte)(68)))));
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.White;
            this.dtgvServicios.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle11;
            this.dtgvServicios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dtgvServicios.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.dtgvServicios.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(136)))), ((int)(((byte)(68)))));
            this.dtgvServicios.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgvServicios.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.dtgvServicios.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            this.dtgvServicios.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Sitka Text", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(136)))), ((int)(((byte)(51)))));
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvServicios.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.dtgvServicios.ColumnHeadersHeight = 50;
            this.dtgvServicios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dtgvServicios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FacturaID,
            this.FechaEmision,
            this.Cliente,
            this.Servicio,
            this.Precio,
            this.Cantidad,
            this.Importe,
            this.SubTotal,
            this.Descuento,
            this.Total,
            this.Remitida});
            dataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle19.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle19.Font = new System.Drawing.Font("Sitka Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle19.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle19.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(136)))), ((int)(((byte)(68)))));
            dataGridViewCellStyle19.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle19.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgvServicios.DefaultCellStyle = dataGridViewCellStyle19;
            this.dtgvServicios.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgvServicios.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(170)))), ((int)(((byte)(68)))));
            this.dtgvServicios.Location = new System.Drawing.Point(0, 83);
            this.dtgvServicios.Name = "dtgvServicios";
            this.dtgvServicios.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle20.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle20.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle20.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle20.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle20.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle20.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvServicios.RowHeadersDefaultCellStyle = dataGridViewCellStyle20;
            this.dtgvServicios.RowHeadersVisible = false;
            this.dtgvServicios.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dtgvServicios.RowTemplate.Height = 33;
            this.dtgvServicios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvServicios.Size = new System.Drawing.Size(1360, 585);
            this.dtgvServicios.TabIndex = 50;
            // 
            // btnCrear
            // 
            this.btnCrear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCrear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(136)))), ((int)(((byte)(68)))));
            this.btnCrear.FlatAppearance.BorderSize = 0;
            this.btnCrear.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(136)))), ((int)(((byte)(68)))));
            this.btnCrear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(204)))), ((int)(((byte)(102)))));
            this.btnCrear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCrear.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCrear.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnCrear.Image = global::Presentacion.Properties.Resources.create;
            this.btnCrear.Location = new System.Drawing.Point(678, 676);
            this.btnCrear.Name = "btnCrear";
            this.btnCrear.Size = new System.Drawing.Size(203, 74);
            this.btnCrear.TabIndex = 3;
            this.btnCrear.Text = " CREAR";
            this.btnCrear.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCrear.UseVisualStyleBackColor = false;
            this.btnCrear.Click += new System.EventHandler(this.btnCrear_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEditar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(136)))), ((int)(((byte)(68)))));
            this.btnEditar.FlatAppearance.BorderSize = 0;
            this.btnEditar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(136)))), ((int)(((byte)(68)))));
            this.btnEditar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(204)))), ((int)(((byte)(102)))));
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditar.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnEditar.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnEditar.Image = global::Presentacion.Properties.Resources.edit;
            this.btnEditar.Location = new System.Drawing.Point(907, 676);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(203, 74);
            this.btnEditar.TabIndex = 4;
            this.btnEditar.Text = "EDITAR";
            this.btnEditar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEditar.UseVisualStyleBackColor = false;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(136)))), ((int)(((byte)(68)))));
            this.btnEliminar.FlatAppearance.BorderSize = 0;
            this.btnEliminar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(136)))), ((int)(((byte)(68)))));
            this.btnEliminar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(204)))), ((int)(((byte)(102)))));
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnEliminar.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnEliminar.Image = global::Presentacion.Properties.Resources.trash_solid;
            this.btnEliminar.Location = new System.Drawing.Point(1133, 676);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(214, 74);
            this.btnEliminar.TabIndex = 5;
            this.btnEliminar.Text = "ELIMINAR";
            this.btnEliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEliminar.UseVisualStyleBackColor = false;
            // 
            // btnImprimir
            // 
            this.btnImprimir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnImprimir.FlatAppearance.BorderSize = 0;
            this.btnImprimir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(136)))), ((int)(((byte)(68)))));
            this.btnImprimir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(204)))), ((int)(((byte)(102)))));
            this.btnImprimir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImprimir.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnImprimir.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnImprimir.Image = global::Presentacion.Properties.Resources.Imprimir;
            this.btnImprimir.Location = new System.Drawing.Point(979, 12);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(369, 60);
            this.btnImprimir.TabIndex = 6;
            this.btnImprimir.Text = " GENERAR FACTURA";
            this.btnImprimir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnImprimir.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(136)))), ((int)(((byte)(68)))));
            this.panel1.Controls.Add(this.btnImprimir);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1360, 83);
            this.panel1.TabIndex = 7;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(136)))), ((int)(((byte)(68)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 668);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1360, 88);
            this.panel2.TabIndex = 8;
            // 
            // FacturaID
            // 
            this.FacturaID.DataPropertyName = "ID";
            this.FacturaID.HeaderText = "ID";
            this.FacturaID.MinimumWidth = 8;
            this.FacturaID.Name = "FacturaID";
            this.FacturaID.ReadOnly = true;
            this.FacturaID.Width = 85;
            // 
            // FechaEmision
            // 
            this.FechaEmision.DataPropertyName = "Fecha";
            this.FechaEmision.HeaderText = "Fecha";
            this.FechaEmision.MinimumWidth = 8;
            this.FechaEmision.Name = "FechaEmision";
            this.FechaEmision.ReadOnly = true;
            this.FechaEmision.Width = 132;
            // 
            // Cliente
            // 
            this.Cliente.DataPropertyName = "Nombre";
            this.Cliente.HeaderText = "Cliente";
            this.Cliente.MinimumWidth = 8;
            this.Cliente.Name = "Cliente";
            this.Cliente.ReadOnly = true;
            this.Cliente.Width = 151;
            // 
            // Servicio
            // 
            this.Servicio.DataPropertyName = "Servicio";
            this.Servicio.HeaderText = "Servicio";
            this.Servicio.MinimumWidth = 8;
            this.Servicio.Name = "Servicio";
            this.Servicio.ReadOnly = true;
            this.Servicio.Width = 166;
            // 
            // Precio
            // 
            this.Precio.DataPropertyName = "Precio";
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Sitka Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Precio.DefaultCellStyle = dataGridViewCellStyle13;
            this.Precio.HeaderText = "Precio";
            this.Precio.MinimumWidth = 8;
            this.Precio.Name = "Precio";
            this.Precio.Width = 141;
            // 
            // Cantidad
            // 
            this.Cantidad.DataPropertyName = "Cantidad";
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Sitka Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Cantidad.DefaultCellStyle = dataGridViewCellStyle14;
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.MinimumWidth = 8;
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.Width = 177;
            // 
            // Importe
            // 
            this.Importe.DataPropertyName = "Importe";
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Sitka Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle15.ForeColor = System.Drawing.Color.SteelBlue;
            this.Importe.DefaultCellStyle = dataGridViewCellStyle15;
            this.Importe.HeaderText = "Importe";
            this.Importe.MinimumWidth = 8;
            this.Importe.Name = "Importe";
            this.Importe.ReadOnly = true;
            this.Importe.Width = 165;
            // 
            // SubTotal
            // 
            this.SubTotal.DataPropertyName = "SubTotal";
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Sitka Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(68)))));
            this.SubTotal.DefaultCellStyle = dataGridViewCellStyle16;
            this.SubTotal.HeaderText = "SubTotal";
            this.SubTotal.MinimumWidth = 8;
            this.SubTotal.Name = "SubTotal";
            this.SubTotal.ReadOnly = true;
            this.SubTotal.Width = 176;
            // 
            // Descuento
            // 
            this.Descuento.DataPropertyName = "Descuento";
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Sitka Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle17.ForeColor = System.Drawing.Color.Red;
            this.Descuento.DefaultCellStyle = dataGridViewCellStyle17;
            this.Descuento.HeaderText = "Descuento";
            this.Descuento.MinimumWidth = 8;
            this.Descuento.Name = "Descuento";
            this.Descuento.Width = 197;
            // 
            // Total
            // 
            this.Total.DataPropertyName = "Total";
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Sitka Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle18.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(68)))));
            this.Total.DefaultCellStyle = dataGridViewCellStyle18;
            this.Total.HeaderText = "Total";
            this.Total.MinimumWidth = 8;
            this.Total.Name = "Total";
            this.Total.Width = 124;
            // 
            // Remitida
            // 
            this.Remitida.DataPropertyName = "Usuario";
            this.Remitida.HeaderText = "Remitida";
            this.Remitida.MinimumWidth = 8;
            this.Remitida.Name = "Remitida";
            this.Remitida.ReadOnly = true;
            this.Remitida.Width = 179;
            // 
            // Servicios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(34)))));
            this.ClientSize = new System.Drawing.Size(1360, 756);
            this.Controls.Add(this.dtgvServicios);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnCrear);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Servicios";
            this.Text = "Servicios";
            this.Load += new System.EventHandler(this.Servicios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvServicios)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Button btnCerrar;
        private DataGridView dtgvServicios;
        private Button btnCrear;
        private Button btnEditar;
        private Button btnEliminar;
        private Button btnImprimir;
        private Panel panel1;
        private Panel panel2;
        private DataGridViewTextBoxColumn FacturaID;
        private DataGridViewTextBoxColumn FechaEmision;
        private DataGridViewTextBoxColumn Cliente;
        private DataGridViewTextBoxColumn Servicio;
        private DataGridViewTextBoxColumn Precio;
        private DataGridViewTextBoxColumn Cantidad;
        private DataGridViewTextBoxColumn Importe;
        private DataGridViewTextBoxColumn SubTotal;
        private DataGridViewTextBoxColumn Descuento;
        private DataGridViewTextBoxColumn Total;
        private DataGridViewTextBoxColumn Remitida;
    }
}
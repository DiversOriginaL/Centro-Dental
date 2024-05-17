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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.dtgvServicios = new System.Windows.Forms.DataGridView();
            this.btnCrear = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.FacturaID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Paciente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaEmision = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Remitida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VerDetalles = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PacienteID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvServicios)).BeginInit();
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
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(136)))), ((int)(((byte)(68)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.dtgvServicios.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgvServicios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvServicios.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.dtgvServicios.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(136)))), ((int)(((byte)(68)))));
            this.dtgvServicios.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dtgvServicios.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.dtgvServicios.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            this.dtgvServicios.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Sitka Text", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(136)))), ((int)(((byte)(51)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvServicios.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dtgvServicios.ColumnHeadersHeight = 50;
            this.dtgvServicios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dtgvServicios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FacturaID,
            this.Paciente,
            this.FechaEmision,
            this.Remitida,
            this.VerDetalles,
            this.Total,
            this.PacienteID});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Sitka Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(136)))), ((int)(((byte)(68)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgvServicios.DefaultCellStyle = dataGridViewCellStyle5;
            this.dtgvServicios.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgvServicios.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(170)))), ((int)(((byte)(68)))));
            this.dtgvServicios.Location = new System.Drawing.Point(0, 0);
            this.dtgvServicios.Name = "dtgvServicios";
            this.dtgvServicios.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvServicios.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dtgvServicios.RowHeadersVisible = false;
            this.dtgvServicios.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dtgvServicios.RowTemplate.Height = 33;
            this.dtgvServicios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvServicios.Size = new System.Drawing.Size(1360, 668);
            this.dtgvServicios.TabIndex = 50;
            this.dtgvServicios.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvServicios_CellContentClick);
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
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
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
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
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
            this.FacturaID.FillWeight = 25.04432F;
            this.FacturaID.HeaderText = "ID";
            this.FacturaID.MinimumWidth = 8;
            this.FacturaID.Name = "FacturaID";
            this.FacturaID.ReadOnly = true;
            // 
            // Paciente
            // 
            this.Paciente.DataPropertyName = "Nombre";
            this.Paciente.FillWeight = 107.4179F;
            this.Paciente.HeaderText = "Paciente";
            this.Paciente.MinimumWidth = 8;
            this.Paciente.Name = "Paciente";
            this.Paciente.ReadOnly = true;
            // 
            // FechaEmision
            // 
            this.FechaEmision.DataPropertyName = "Fecha";
            this.FechaEmision.FillWeight = 107.4179F;
            this.FechaEmision.HeaderText = "Fecha";
            this.FechaEmision.MinimumWidth = 8;
            this.FechaEmision.Name = "FechaEmision";
            this.FechaEmision.ReadOnly = true;
            // 
            // Remitida
            // 
            this.Remitida.DataPropertyName = "Usuario";
            this.Remitida.FillWeight = 107.4179F;
            this.Remitida.HeaderText = "Remitida";
            this.Remitida.MinimumWidth = 8;
            this.Remitida.Name = "Remitida";
            this.Remitida.ReadOnly = true;
            // 
            // VerDetalles
            // 
            this.VerDetalles.DataPropertyName = "VerDetalles";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Sitka Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(136)))), ((int)(((byte)(68)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            this.VerDetalles.DefaultCellStyle = dataGridViewCellStyle3;
            this.VerDetalles.FillWeight = 107.4179F;
            this.VerDetalles.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.VerDetalles.HeaderText = "Detalles";
            this.VerDetalles.MinimumWidth = 8;
            this.VerDetalles.Name = "VerDetalles";
            this.VerDetalles.Text = "Ver Detalles";
            this.VerDetalles.UseColumnTextForButtonValue = true;
            // 
            // Total
            // 
            this.Total.DataPropertyName = "Total";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            this.Total.DefaultCellStyle = dataGridViewCellStyle4;
            this.Total.FillWeight = 75.28408F;
            this.Total.HeaderText = "Total";
            this.Total.MinimumWidth = 8;
            this.Total.Name = "Total";
            // 
            // PacienteID
            // 
            this.PacienteID.DataPropertyName = "PacienteID";
            this.PacienteID.HeaderText = "PacienteID";
            this.PacienteID.MinimumWidth = 8;
            this.PacienteID.Name = "PacienteID";
            this.PacienteID.Visible = false;
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
            this.Controls.Add(this.panel2);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Servicios";
            this.Text = "Servicios";
            this.Load += new System.EventHandler(this.Servicios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvServicios)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Button btnCerrar;
        private DataGridView dtgvServicios;
        private Button btnCrear;
        private Button btnEditar;
        private Button btnEliminar;
        private Panel panel2;
        private DataGridViewTextBoxColumn FacturaID;
        private DataGridViewTextBoxColumn Paciente;
        private DataGridViewTextBoxColumn FechaEmision;
        private DataGridViewTextBoxColumn Remitida;
        private DataGridViewButtonColumn VerDetalles;
        private DataGridViewTextBoxColumn Total;
        private DataGridViewTextBoxColumn PacienteID;
    }
}
namespace Presentacion.FormsButton.Paciente
{
    partial class Pacientes
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnCrear = new System.Windows.Forms.Button();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dtgvPacientes = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PApellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SApellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Edad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sexo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Celular = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Provincia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sector = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Calle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumCasa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Usuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EstadosSalud = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Enfermedad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Medicamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Alergia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Embarazo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnCabecera = new System.Windows.Forms.Panel();
            this.pbFiltrar = new System.Windows.Forms.PictureBox();
            this.pnBarra = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvPacientes)).BeginInit();
            this.pnCabecera.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbFiltrar)).BeginInit();
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
            this.btnCerrar.Location = new System.Drawing.Point(15, 801);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(218, 81);
            this.btnCerrar.TabIndex = 2;
            this.btnCerrar.Text = " Cerrar";
            this.btnCerrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCerrar.UseVisualStyleBackColor = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
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
            this.btnEliminar.Location = new System.Drawing.Point(1124, 801);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(214, 81);
            this.btnEliminar.TabIndex = 11;
            this.btnEliminar.Text = "ELIMINAR";
            this.btnEliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
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
            this.btnEditar.Location = new System.Drawing.Point(904, 801);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(203, 81);
            this.btnEditar.TabIndex = 10;
            this.btnEditar.Text = "EDITAR";
            this.btnEditar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
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
            this.btnCrear.Location = new System.Drawing.Point(684, 801);
            this.btnCrear.Name = "btnCrear";
            this.btnCrear.Size = new System.Drawing.Size(203, 81);
            this.btnCrear.TabIndex = 9;
            this.btnCrear.Text = " CREAR";
            this.btnCrear.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCrear.UseVisualStyleBackColor = false;
            this.btnCrear.Click += new System.EventHandler(this.btnCrear_Click);
            // 
            // txtBuscar
            // 
            this.txtBuscar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(136)))), ((int)(((byte)(68)))));
            this.txtBuscar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBuscar.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtBuscar.ForeColor = System.Drawing.Color.Gainsboro;
            this.txtBuscar.Location = new System.Drawing.Point(997, 10);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(308, 34);
            this.txtBuscar.TabIndex = 12;
            this.txtBuscar.TextChanged += new System.EventHandler(this.txtBuscar_TextChanged);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Location = new System.Drawing.Point(997, 50);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(365, 5);
            this.panel1.TabIndex = 13;
            // 
            // dtgvPacientes
            // 
            this.dtgvPacientes.AllowUserToAddRows = false;
            this.dtgvPacientes.AllowUserToResizeColumns = false;
            this.dtgvPacientes.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Sitka Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(136)))), ((int)(((byte)(68)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.dtgvPacientes.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgvPacientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dtgvPacientes.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dtgvPacientes.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(136)))), ((int)(((byte)(68)))));
            this.dtgvPacientes.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.dtgvPacientes.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Sitka Text", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(136)))), ((int)(((byte)(68)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvPacientes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dtgvPacientes.ColumnHeadersHeight = 50;
            this.dtgvPacientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dtgvPacientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.PNombre,
            this.SNombre,
            this.PApellido,
            this.SApellido,
            this.Edad,
            this.Sexo,
            this.Celular,
            this.Telefono,
            this.Provincia,
            this.Sector,
            this.Calle,
            this.NumCasa,
            this.Usuario,
            this.EstadosSalud,
            this.Enfermedad,
            this.Medicamento,
            this.Alergia,
            this.Embarazo,
            this.Fecha});
            this.dtgvPacientes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgvPacientes.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(170)))), ((int)(((byte)(68)))));
            this.dtgvPacientes.Location = new System.Drawing.Point(0, 65);
            this.dtgvPacientes.Name = "dtgvPacientes";
            this.dtgvPacientes.ReadOnly = true;
            this.dtgvPacientes.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dtgvPacientes.RowHeadersVisible = false;
            this.dtgvPacientes.RowHeadersWidth = 62;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Sitka Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(136)))), ((int)(((byte)(68)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            this.dtgvPacientes.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dtgvPacientes.RowTemplate.Height = 40;
            this.dtgvPacientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvPacientes.Size = new System.Drawing.Size(1374, 723);
            this.dtgvPacientes.TabIndex = 14;
            this.dtgvPacientes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvPacientes_CellContentClick);
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "ID";
            this.ID.MinimumWidth = 8;
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ID.Width = 85;
            // 
            // PNombre
            // 
            this.PNombre.DataPropertyName = "PNombre";
            this.PNombre.HeaderText = "P.Nombre";
            this.PNombre.MinimumWidth = 8;
            this.PNombre.Name = "PNombre";
            this.PNombre.ReadOnly = true;
            this.PNombre.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.PNombre.Width = 188;
            // 
            // SNombre
            // 
            this.SNombre.DataPropertyName = "SNombre";
            this.SNombre.HeaderText = "S.Nombre";
            this.SNombre.MinimumWidth = 8;
            this.SNombre.Name = "SNombre";
            this.SNombre.ReadOnly = true;
            this.SNombre.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.SNombre.Width = 190;
            // 
            // PApellido
            // 
            this.PApellido.DataPropertyName = "PApellido";
            this.PApellido.HeaderText = "P.Apellido";
            this.PApellido.MinimumWidth = 8;
            this.PApellido.Name = "PApellido";
            this.PApellido.ReadOnly = true;
            this.PApellido.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.PApellido.Width = 192;
            // 
            // SApellido
            // 
            this.SApellido.DataPropertyName = "SApellido";
            this.SApellido.HeaderText = "S.Apellido";
            this.SApellido.MinimumWidth = 8;
            this.SApellido.Name = "SApellido";
            this.SApellido.ReadOnly = true;
            this.SApellido.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.SApellido.Width = 194;
            // 
            // Edad
            // 
            this.Edad.DataPropertyName = "Edad";
            this.Edad.HeaderText = "Edad";
            this.Edad.MinimumWidth = 8;
            this.Edad.Name = "Edad";
            this.Edad.ReadOnly = true;
            this.Edad.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Edad.Width = 122;
            // 
            // Sexo
            // 
            this.Sexo.DataPropertyName = "Sexo";
            this.Sexo.HeaderText = "Sexo";
            this.Sexo.MinimumWidth = 8;
            this.Sexo.Name = "Sexo";
            this.Sexo.ReadOnly = true;
            this.Sexo.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Sexo.Width = 118;
            // 
            // Celular
            // 
            this.Celular.DataPropertyName = "Celular";
            this.Celular.HeaderText = "Celular";
            this.Celular.MinimumWidth = 8;
            this.Celular.Name = "Celular";
            this.Celular.ReadOnly = true;
            this.Celular.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Celular.Width = 154;
            // 
            // Telefono
            // 
            this.Telefono.DataPropertyName = "Telefono";
            this.Telefono.HeaderText = "Telefono";
            this.Telefono.MinimumWidth = 8;
            this.Telefono.Name = "Telefono";
            this.Telefono.ReadOnly = true;
            this.Telefono.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Telefono.Width = 172;
            // 
            // Provincia
            // 
            this.Provincia.DataPropertyName = "Provincia";
            this.Provincia.HeaderText = "Provincia";
            this.Provincia.MinimumWidth = 8;
            this.Provincia.Name = "Provincia";
            this.Provincia.ReadOnly = true;
            this.Provincia.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Provincia.Width = 186;
            // 
            // Sector
            // 
            this.Sector.DataPropertyName = "Sector";
            this.Sector.HeaderText = "Sector";
            this.Sector.MinimumWidth = 8;
            this.Sector.Name = "Sector";
            this.Sector.ReadOnly = true;
            this.Sector.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Sector.Width = 142;
            // 
            // Calle
            // 
            this.Calle.DataPropertyName = "Calle";
            this.Calle.HeaderText = "Calle";
            this.Calle.MinimumWidth = 8;
            this.Calle.Name = "Calle";
            this.Calle.ReadOnly = true;
            this.Calle.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Calle.Width = 122;
            // 
            // NumCasa
            // 
            this.NumCasa.DataPropertyName = "NumCasa";
            this.NumCasa.HeaderText = "#Casa";
            this.NumCasa.MinimumWidth = 8;
            this.NumCasa.Name = "NumCasa";
            this.NumCasa.ReadOnly = true;
            this.NumCasa.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.NumCasa.Width = 136;
            // 
            // Usuario
            // 
            this.Usuario.DataPropertyName = "Usuario";
            this.Usuario.HeaderText = "Atendido por:";
            this.Usuario.MinimumWidth = 8;
            this.Usuario.Name = "Usuario";
            this.Usuario.ReadOnly = true;
            this.Usuario.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Usuario.Width = 245;
            // 
            // EstadosSalud
            // 
            this.EstadosSalud.DataPropertyName = "EstadosSalud";
            this.EstadosSalud.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.EstadosSalud.HeaderText = "Estado Salud";
            this.EstadosSalud.MinimumWidth = 8;
            this.EstadosSalud.Name = "EstadosSalud";
            this.EstadosSalud.ReadOnly = true;
            this.EstadosSalud.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.EstadosSalud.Text = "Estado Salud";
            this.EstadosSalud.UseColumnTextForButtonValue = true;
            this.EstadosSalud.Width = 204;
            // 
            // Enfermedad
            // 
            this.Enfermedad.DataPropertyName = "Enfermedad";
            this.Enfermedad.HeaderText = "Enfermedad";
            this.Enfermedad.MinimumWidth = 8;
            this.Enfermedad.Name = "Enfermedad";
            this.Enfermedad.ReadOnly = true;
            this.Enfermedad.Visible = false;
            this.Enfermedad.Width = 193;
            // 
            // Medicamento
            // 
            this.Medicamento.DataPropertyName = "Medicamento";
            this.Medicamento.HeaderText = "Medicamento";
            this.Medicamento.MinimumWidth = 8;
            this.Medicamento.Name = "Medicamento";
            this.Medicamento.ReadOnly = true;
            this.Medicamento.Visible = false;
            this.Medicamento.Width = 210;
            // 
            // Alergia
            // 
            this.Alergia.DataPropertyName = "Alergia";
            this.Alergia.HeaderText = "Alergia";
            this.Alergia.MinimumWidth = 8;
            this.Alergia.Name = "Alergia";
            this.Alergia.ReadOnly = true;
            this.Alergia.Visible = false;
            this.Alergia.Width = 132;
            // 
            // Embarazo
            // 
            this.Embarazo.DataPropertyName = "Embarazo";
            this.Embarazo.HeaderText = "Embarazo";
            this.Embarazo.MinimumWidth = 8;
            this.Embarazo.Name = "Embarazo";
            this.Embarazo.ReadOnly = true;
            this.Embarazo.Visible = false;
            this.Embarazo.Width = 168;
            // 
            // Fecha
            // 
            this.Fecha.DataPropertyName = "Fecha";
            this.Fecha.HeaderText = "Fecha";
            this.Fecha.MinimumWidth = 8;
            this.Fecha.Name = "Fecha";
            this.Fecha.ReadOnly = true;
            this.Fecha.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Fecha.Width = 132;
            // 
            // pnCabecera
            // 
            this.pnCabecera.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(136)))), ((int)(((byte)(68)))));
            this.pnCabecera.Controls.Add(this.pbFiltrar);
            this.pnCabecera.Controls.Add(this.txtBuscar);
            this.pnCabecera.Controls.Add(this.panel1);
            this.pnCabecera.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnCabecera.Location = new System.Drawing.Point(0, 0);
            this.pnCabecera.Name = "pnCabecera";
            this.pnCabecera.Size = new System.Drawing.Size(1374, 65);
            this.pnCabecera.TabIndex = 15;
            // 
            // pbFiltrar
            // 
            this.pbFiltrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbFiltrar.BackgroundImage = global::Presentacion.Properties.Resources.filtrar;
            this.pbFiltrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbFiltrar.Location = new System.Drawing.Point(1311, 10);
            this.pbFiltrar.Name = "pbFiltrar";
            this.pbFiltrar.Size = new System.Drawing.Size(51, 37);
            this.pbFiltrar.TabIndex = 14;
            this.pbFiltrar.TabStop = false;
            // 
            // pnBarra
            // 
            this.pnBarra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(136)))), ((int)(((byte)(68)))));
            this.pnBarra.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnBarra.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.pnBarra.Location = new System.Drawing.Point(0, 788);
            this.pnBarra.Name = "pnBarra";
            this.pnBarra.Size = new System.Drawing.Size(1374, 102);
            this.pnBarra.TabIndex = 16;
            // 
            // Pacientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(34)))));
            this.ClientSize = new System.Drawing.Size(1374, 890);
            this.Controls.Add(this.dtgvPacientes);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnCrear);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.pnCabecera);
            this.Controls.Add(this.pnBarra);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Pacientes";
            this.Text = "Pacientes";
            this.Load += new System.EventHandler(this.Pacientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvPacientes)).EndInit();
            this.pnCabecera.ResumeLayout(false);
            this.pnCabecera.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbFiltrar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Button btnCerrar;
        private Button btnEliminar;
        private Button btnEditar;
        private Button btnCrear;
        private TextBox txtBuscar;
        private Panel panel1;
        private DataGridView dtgvPacientes;
        private Panel pnCabecera;
        private Panel pnBarra;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn PNombre;
        private DataGridViewTextBoxColumn SNombre;
        private DataGridViewTextBoxColumn PApellido;
        private DataGridViewTextBoxColumn SApellido;
        private DataGridViewTextBoxColumn Edad;
        private DataGridViewTextBoxColumn Sexo;
        private DataGridViewTextBoxColumn Celular;
        private DataGridViewTextBoxColumn Telefono;
        private DataGridViewTextBoxColumn Provincia;
        private DataGridViewTextBoxColumn Sector;
        private DataGridViewTextBoxColumn Calle;
        private DataGridViewTextBoxColumn NumCasa;
        private DataGridViewTextBoxColumn Usuario;
        private DataGridViewButtonColumn EstadosSalud;
        private DataGridViewTextBoxColumn Enfermedad;
        private DataGridViewTextBoxColumn Medicamento;
        private DataGridViewTextBoxColumn Alergia;
        private DataGridViewTextBoxColumn Embarazo;
        private DataGridViewTextBoxColumn Fecha;
        private PictureBox pbFiltrar;
    }
}
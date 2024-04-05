namespace Presentacion.FormsButton.Paciente.FormHijos.FormEstadoSalud
{
    partial class EstadoSalud
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
            this.lblEnfermedad = new System.Windows.Forms.Label();
            this.txtEnfermedad = new System.Windows.Forms.TextBox();
            this.lblAlergia = new System.Windows.Forms.Label();
            this.txtAlergia = new System.Windows.Forms.TextBox();
            this.lbl = new System.Windows.Forms.Label();
            this.txtMedicamento = new System.Windows.Forms.TextBox();
            this.lblEmbarazo = new System.Windows.Forms.Label();
            this.txtEmbarazo = new System.Windows.Forms.TextBox();
            this.lblEstadoSalud = new System.Windows.Forms.Label();
            this.pnCerrar = new System.Windows.Forms.Panel();
            this.pnMaximizar = new System.Windows.Forms.Panel();
            this.pnMinimizar = new System.Windows.Forms.Panel();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblEnfermedad
            // 
            this.lblEnfermedad.AutoSize = true;
            this.lblEnfermedad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblEnfermedad.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblEnfermedad.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblEnfermedad.Location = new System.Drawing.Point(77, 208);
            this.lblEnfermedad.Name = "lblEnfermedad";
            this.lblEnfermedad.Size = new System.Drawing.Size(497, 34);
            this.lblEnfermedad.TabIndex = 7;
            this.lblEnfermedad.Text = "¿Tiene algun tipo de enfermedad?";
            // 
            // txtEnfermedad
            // 
            this.txtEnfermedad.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtEnfermedad.ForeColor = System.Drawing.Color.Silver;
            this.txtEnfermedad.Location = new System.Drawing.Point(12, 260);
            this.txtEnfermedad.Multiline = true;
            this.txtEnfermedad.Name = "txtEnfermedad";
            this.txtEnfermedad.Size = new System.Drawing.Size(620, 277);
            this.txtEnfermedad.TabIndex = 10;
            this.txtEnfermedad.Text = "DESCRIPCION:";
            this.txtEnfermedad.Enter += new System.EventHandler(this.txtEnfermedad_Enter);
            this.txtEnfermedad.Leave += new System.EventHandler(this.txtEnfermedad_Leave);
            // 
            // lblAlergia
            // 
            this.lblAlergia.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblAlergia.AutoSize = true;
            this.lblAlergia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblAlergia.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblAlergia.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblAlergia.Location = new System.Drawing.Point(33, 628);
            this.lblAlergia.Name = "lblAlergia";
            this.lblAlergia.Size = new System.Drawing.Size(580, 34);
            this.lblAlergia.TabIndex = 11;
            this.lblAlergia.Text = "¿Le genera alergia algun medicamento?";
            // 
            // txtAlergia
            // 
            this.txtAlergia.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtAlergia.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtAlergia.ForeColor = System.Drawing.Color.Silver;
            this.txtAlergia.Location = new System.Drawing.Point(12, 677);
            this.txtAlergia.Multiline = true;
            this.txtAlergia.Name = "txtAlergia";
            this.txtAlergia.Size = new System.Drawing.Size(620, 299);
            this.txtAlergia.TabIndex = 14;
            this.txtAlergia.Text = "DESCRIPCION:";
            this.txtAlergia.Enter += new System.EventHandler(this.txtMedicamento_Enter);
            this.txtAlergia.Leave += new System.EventHandler(this.txtMedicamento_Leave);
            // 
            // lbl
            // 
            this.lbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl.AutoSize = true;
            this.lbl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl.Location = new System.Drawing.Point(696, 208);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(543, 34);
            this.lbl.TabIndex = 15;
            this.lbl.Text = "¿Estas tomando algun medicamento?";
            // 
            // txtMedicamento
            // 
            this.txtMedicamento.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMedicamento.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtMedicamento.ForeColor = System.Drawing.Color.Silver;
            this.txtMedicamento.Location = new System.Drawing.Point(666, 260);
            this.txtMedicamento.Multiline = true;
            this.txtMedicamento.Name = "txtMedicamento";
            this.txtMedicamento.Size = new System.Drawing.Size(620, 277);
            this.txtMedicamento.TabIndex = 18;
            this.txtMedicamento.Text = "DESCRIPCION:";
            this.txtMedicamento.Enter += new System.EventHandler(this.txtAlergia_Enter);
            this.txtMedicamento.Leave += new System.EventHandler(this.txtAlergia_Leave);
            // 
            // lblEmbarazo
            // 
            this.lblEmbarazo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblEmbarazo.AutoSize = true;
            this.lblEmbarazo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblEmbarazo.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblEmbarazo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblEmbarazo.Location = new System.Drawing.Point(824, 633);
            this.lblEmbarazo.Name = "lblEmbarazo";
            this.lblEmbarazo.Size = new System.Drawing.Size(304, 34);
            this.lblEmbarazo.TabIndex = 19;
            this.lblEmbarazo.Text = "¿Estas embarazada?";
            // 
            // txtEmbarazo
            // 
            this.txtEmbarazo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtEmbarazo.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtEmbarazo.ForeColor = System.Drawing.Color.Silver;
            this.txtEmbarazo.Location = new System.Drawing.Point(666, 677);
            this.txtEmbarazo.Multiline = true;
            this.txtEmbarazo.Name = "txtEmbarazo";
            this.txtEmbarazo.Size = new System.Drawing.Size(615, 299);
            this.txtEmbarazo.TabIndex = 20;
            this.txtEmbarazo.Text = "DESCRIPCION:";
            this.txtEmbarazo.Enter += new System.EventHandler(this.txtEmbarazo_Enter);
            this.txtEmbarazo.Leave += new System.EventHandler(this.txtEmbarazo_Leave);
            // 
            // lblEstadoSalud
            // 
            this.lblEstadoSalud.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblEstadoSalud.Font = new System.Drawing.Font("Tahoma", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblEstadoSalud.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblEstadoSalud.Image = global::Presentacion.Properties.Resources.EstadoSalud;
            this.lblEstadoSalud.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblEstadoSalud.Location = new System.Drawing.Point(297, 9);
            this.lblEstadoSalud.Name = "lblEstadoSalud";
            this.lblEstadoSalud.Size = new System.Drawing.Size(697, 122);
            this.lblEstadoSalud.TabIndex = 23;
            this.lblEstadoSalud.Text = "       ESTADO DE SALUD";
            this.lblEstadoSalud.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnCerrar
            // 
            this.pnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pnCerrar.BackgroundImage = global::Presentacion.Properties.Resources.exit;
            this.pnCerrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pnCerrar.Location = new System.Drawing.Point(1254, 9);
            this.pnCerrar.Name = "pnCerrar";
            this.pnCerrar.Size = new System.Drawing.Size(27, 35);
            this.pnCerrar.TabIndex = 24;
            this.pnCerrar.Click += new System.EventHandler(this.pnCerrar_Click);
            // 
            // pnMaximizar
            // 
            this.pnMaximizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pnMaximizar.BackgroundImage = global::Presentacion.Properties.Resources.expand_solid;
            this.pnMaximizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pnMaximizar.Location = new System.Drawing.Point(1212, 9);
            this.pnMaximizar.Name = "pnMaximizar";
            this.pnMaximizar.Size = new System.Drawing.Size(27, 35);
            this.pnMaximizar.TabIndex = 25;
            this.pnMaximizar.Click += new System.EventHandler(this.pnMaximizar_Click);
            // 
            // pnMinimizar
            // 
            this.pnMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pnMinimizar.BackgroundImage = global::Presentacion.Properties.Resources.minimize;
            this.pnMinimizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pnMinimizar.Location = new System.Drawing.Point(1169, 9);
            this.pnMinimizar.Name = "pnMinimizar";
            this.pnMinimizar.Size = new System.Drawing.Size(27, 35);
            this.pnMinimizar.TabIndex = 26;
            this.pnMinimizar.Click += new System.EventHandler(this.pnMinimizar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelar.FlatAppearance.BorderSize = 2;
            this.btnCancelar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(136)))), ((int)(((byte)(68)))));
            this.btnCancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(170)))), ((int)(((byte)(68)))));
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCancelar.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnCancelar.Image = global::Presentacion.Properties.Resources.Cancelar;
            this.btnCancelar.Location = new System.Drawing.Point(1045, 1010);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(236, 77);
            this.btnCancelar.TabIndex = 27;
            this.btnCancelar.Text = "CANCELAR";
            this.btnCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGuardar.FlatAppearance.BorderSize = 2;
            this.btnGuardar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(136)))), ((int)(((byte)(68)))));
            this.btnGuardar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(170)))), ((int)(((byte)(68)))));
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnGuardar.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnGuardar.Image = global::Presentacion.Properties.Resources.guardar;
            this.btnGuardar.Location = new System.Drawing.Point(772, 1010);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(256, 77);
            this.btnGuardar.TabIndex = 28;
            this.btnGuardar.Text = " GUARDAR";
            this.btnGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // EstadoSalud
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(34)))));
            this.ClientSize = new System.Drawing.Size(1293, 1099);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.pnMinimizar);
            this.Controls.Add(this.pnMaximizar);
            this.Controls.Add(this.pnCerrar);
            this.Controls.Add(this.lblEstadoSalud);
            this.Controls.Add(this.txtEmbarazo);
            this.Controls.Add(this.lblEmbarazo);
            this.Controls.Add(this.txtMedicamento);
            this.Controls.Add(this.lbl);
            this.Controls.Add(this.txtAlergia);
            this.Controls.Add(this.lblAlergia);
            this.Controls.Add(this.txtEnfermedad);
            this.Controls.Add(this.lblEnfermedad);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EstadoSalud";
            this.Text = "EstadoSalud";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.EstadoSalud_MouseDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblEnfermedad;
        private Label lblAlergia;
        private Label lbl;
        private Label lblEmbarazo;
        private Label lblEstadoSalud;
        private Panel pnCerrar;
        private Panel pnMaximizar;
        private Panel pnMinimizar;
        private Button btnCancelar;
        private Button btnGuardar;
        public TextBox txtEnfermedad;
        public TextBox txtAlergia;
        public TextBox txtMedicamento;
        public TextBox txtEmbarazo;
    }
}
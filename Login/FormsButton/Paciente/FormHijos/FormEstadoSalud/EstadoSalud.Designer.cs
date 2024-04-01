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
            this.rbSiEnfermedad = new System.Windows.Forms.RadioButton();
            this.rbNoEnfermedad = new System.Windows.Forms.RadioButton();
            this.txtEnfermedad = new System.Windows.Forms.TextBox();
            this.lblAlergia = new System.Windows.Forms.Label();
            this.rbNoAlergia = new System.Windows.Forms.RadioButton();
            this.rbSiAlergia = new System.Windows.Forms.RadioButton();
            this.txtAlergia = new System.Windows.Forms.TextBox();
            this.lbl = new System.Windows.Forms.Label();
            this.rbNoMedicamento = new System.Windows.Forms.RadioButton();
            this.rbSiMedicamento = new System.Windows.Forms.RadioButton();
            this.txtMedicamento = new System.Windows.Forms.TextBox();
            this.lblEmbarazo = new System.Windows.Forms.Label();
            this.txtEmbarazo = new System.Windows.Forms.TextBox();
            this.rbNoEmbarazada = new System.Windows.Forms.RadioButton();
            this.rbSiEmbarazada = new System.Windows.Forms.RadioButton();
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
            this.lblEnfermedad.Location = new System.Drawing.Point(80, 199);
            this.lblEnfermedad.Name = "lblEnfermedad";
            this.lblEnfermedad.Size = new System.Drawing.Size(497, 34);
            this.lblEnfermedad.TabIndex = 7;
            this.lblEnfermedad.Text = "¿Tiene algun tipo de enfermedad?";
            // 
            // rbSiEnfermedad
            // 
            this.rbSiEnfermedad.AutoSize = true;
            this.rbSiEnfermedad.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rbSiEnfermedad.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.rbSiEnfermedad.Location = new System.Drawing.Point(266, 247);
            this.rbSiEnfermedad.Name = "rbSiEnfermedad";
            this.rbSiEnfermedad.Size = new System.Drawing.Size(53, 28);
            this.rbSiEnfermedad.TabIndex = 8;
            this.rbSiEnfermedad.Text = "SI";
            this.rbSiEnfermedad.UseVisualStyleBackColor = true;
            this.rbSiEnfermedad.CheckedChanged += new System.EventHandler(this.rbSiEnfermedad_CheckedChanged);
            // 
            // rbNoEnfermedad
            // 
            this.rbNoEnfermedad.AutoSize = true;
            this.rbNoEnfermedad.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rbNoEnfermedad.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.rbNoEnfermedad.Location = new System.Drawing.Point(342, 247);
            this.rbNoEnfermedad.Name = "rbNoEnfermedad";
            this.rbNoEnfermedad.Size = new System.Drawing.Size(62, 28);
            this.rbNoEnfermedad.TabIndex = 9;
            this.rbNoEnfermedad.Text = "NO";
            this.rbNoEnfermedad.UseVisualStyleBackColor = true;
            this.rbNoEnfermedad.CheckedChanged += new System.EventHandler(this.rbNoEnfermedad_CheckedChanged);
            // 
            // txtEnfermedad
            // 
            this.txtEnfermedad.Enabled = false;
            this.txtEnfermedad.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtEnfermedad.ForeColor = System.Drawing.Color.Silver;
            this.txtEnfermedad.Location = new System.Drawing.Point(12, 292);
            this.txtEnfermedad.Multiline = true;
            this.txtEnfermedad.Name = "txtEnfermedad";
            this.txtEnfermedad.Size = new System.Drawing.Size(620, 377);
            this.txtEnfermedad.TabIndex = 10;
            this.txtEnfermedad.Text = "DESCRIPCION:";
            this.txtEnfermedad.Visible = false;
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
            this.lblAlergia.Location = new System.Drawing.Point(33, 701);
            this.lblAlergia.Name = "lblAlergia";
            this.lblAlergia.Size = new System.Drawing.Size(580, 34);
            this.lblAlergia.TabIndex = 11;
            this.lblAlergia.Text = "¿Le genera alergia algun medicamento?";
            // 
            // rbNoAlergia
            // 
            this.rbNoAlergia.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.rbNoAlergia.AutoSize = true;
            this.rbNoAlergia.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rbNoAlergia.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.rbNoAlergia.Location = new System.Drawing.Point(297, 745);
            this.rbNoAlergia.Name = "rbNoAlergia";
            this.rbNoAlergia.Size = new System.Drawing.Size(62, 28);
            this.rbNoAlergia.TabIndex = 13;
            this.rbNoAlergia.Text = "NO";
            this.rbNoAlergia.UseVisualStyleBackColor = true;
            this.rbNoAlergia.CheckedChanged += new System.EventHandler(this.rbNoAlergia_CheckedChanged);
            // 
            // rbSiAlergia
            // 
            this.rbSiAlergia.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.rbSiAlergia.AutoSize = true;
            this.rbSiAlergia.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rbSiAlergia.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.rbSiAlergia.Location = new System.Drawing.Point(221, 745);
            this.rbSiAlergia.Name = "rbSiAlergia";
            this.rbSiAlergia.Size = new System.Drawing.Size(53, 28);
            this.rbSiAlergia.TabIndex = 12;
            this.rbSiAlergia.Text = "SI";
            this.rbSiAlergia.UseVisualStyleBackColor = true;
            this.rbSiAlergia.CheckedChanged += new System.EventHandler(this.rbSiAlergia_CheckedChanged);
            // 
            // txtAlergia
            // 
            this.txtAlergia.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtAlergia.Enabled = false;
            this.txtAlergia.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtAlergia.ForeColor = System.Drawing.Color.Silver;
            this.txtAlergia.Location = new System.Drawing.Point(12, 790);
            this.txtAlergia.Multiline = true;
            this.txtAlergia.Name = "txtAlergia";
            this.txtAlergia.Size = new System.Drawing.Size(620, 377);
            this.txtAlergia.TabIndex = 14;
            this.txtAlergia.Text = "DESCRIPCION:";
            this.txtAlergia.Visible = false;
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
            this.lbl.Location = new System.Drawing.Point(687, 199);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(543, 34);
            this.lbl.TabIndex = 15;
            this.lbl.Text = "¿Estas tomando algun medicamento?";
            // 
            // rbNoMedicamento
            // 
            this.rbNoMedicamento.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rbNoMedicamento.AutoSize = true;
            this.rbNoMedicamento.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rbNoMedicamento.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.rbNoMedicamento.Location = new System.Drawing.Point(996, 247);
            this.rbNoMedicamento.Name = "rbNoMedicamento";
            this.rbNoMedicamento.Size = new System.Drawing.Size(62, 28);
            this.rbNoMedicamento.TabIndex = 17;
            this.rbNoMedicamento.Text = "NO";
            this.rbNoMedicamento.UseVisualStyleBackColor = true;
            this.rbNoMedicamento.CheckedChanged += new System.EventHandler(this.rdNoMedicamento_CheckedChanged);
            // 
            // rbSiMedicamento
            // 
            this.rbSiMedicamento.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rbSiMedicamento.AutoSize = true;
            this.rbSiMedicamento.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rbSiMedicamento.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.rbSiMedicamento.Location = new System.Drawing.Point(922, 247);
            this.rbSiMedicamento.Name = "rbSiMedicamento";
            this.rbSiMedicamento.Size = new System.Drawing.Size(53, 28);
            this.rbSiMedicamento.TabIndex = 16;
            this.rbSiMedicamento.Text = "SI";
            this.rbSiMedicamento.UseVisualStyleBackColor = true;
            this.rbSiMedicamento.CheckedChanged += new System.EventHandler(this.rdSiMedicamento_CheckedChanged);
            // 
            // txtMedicamento
            // 
            this.txtMedicamento.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMedicamento.Enabled = false;
            this.txtMedicamento.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtMedicamento.ForeColor = System.Drawing.Color.Silver;
            this.txtMedicamento.Location = new System.Drawing.Point(666, 292);
            this.txtMedicamento.Multiline = true;
            this.txtMedicamento.Name = "txtMedicamento";
            this.txtMedicamento.Size = new System.Drawing.Size(601, 377);
            this.txtMedicamento.TabIndex = 18;
            this.txtMedicamento.Text = "DESCRIPCION:";
            this.txtMedicamento.Visible = false;
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
            this.lblEmbarazo.Location = new System.Drawing.Point(835, 701);
            this.lblEmbarazo.Name = "lblEmbarazo";
            this.lblEmbarazo.Size = new System.Drawing.Size(304, 34);
            this.lblEmbarazo.TabIndex = 19;
            this.lblEmbarazo.Text = "¿Estas embarazada?";
            // 
            // txtEmbarazo
            // 
            this.txtEmbarazo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtEmbarazo.Enabled = false;
            this.txtEmbarazo.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtEmbarazo.ForeColor = System.Drawing.Color.Silver;
            this.txtEmbarazo.Location = new System.Drawing.Point(666, 790);
            this.txtEmbarazo.Multiline = true;
            this.txtEmbarazo.Name = "txtEmbarazo";
            this.txtEmbarazo.Size = new System.Drawing.Size(601, 377);
            this.txtEmbarazo.TabIndex = 20;
            this.txtEmbarazo.Text = "DESCRIPCION:";
            this.txtEmbarazo.Visible = false;
            this.txtEmbarazo.Enter += new System.EventHandler(this.txtEmbarazo_Enter);
            this.txtEmbarazo.Leave += new System.EventHandler(this.txtEmbarazo_Leave);
            // 
            // rbNoEmbarazada
            // 
            this.rbNoEmbarazada.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.rbNoEmbarazada.AutoSize = true;
            this.rbNoEmbarazada.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rbNoEmbarazada.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.rbNoEmbarazada.Location = new System.Drawing.Point(996, 745);
            this.rbNoEmbarazada.Name = "rbNoEmbarazada";
            this.rbNoEmbarazada.Size = new System.Drawing.Size(62, 28);
            this.rbNoEmbarazada.TabIndex = 22;
            this.rbNoEmbarazada.Text = "NO";
            this.rbNoEmbarazada.UseVisualStyleBackColor = true;
            this.rbNoEmbarazada.CheckedChanged += new System.EventHandler(this.rbNoEmbarazada_CheckedChanged);
            // 
            // rbSiEmbarazada
            // 
            this.rbSiEmbarazada.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.rbSiEmbarazada.AutoSize = true;
            this.rbSiEmbarazada.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rbSiEmbarazada.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.rbSiEmbarazada.Location = new System.Drawing.Point(922, 745);
            this.rbSiEmbarazada.Name = "rbSiEmbarazada";
            this.rbSiEmbarazada.Size = new System.Drawing.Size(53, 28);
            this.rbSiEmbarazada.TabIndex = 21;
            this.rbSiEmbarazada.Text = "SI";
            this.rbSiEmbarazada.UseVisualStyleBackColor = true;
            this.rbSiEmbarazada.CheckedChanged += new System.EventHandler(this.rbSiEmbarazada_CheckedChanged);
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
            this.lblEstadoSalud.Text = "        ESTADO DE SALUD";
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
            this.btnCancelar.Location = new System.Drawing.Point(1031, 1221);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(236, 67);
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
            this.btnGuardar.Location = new System.Drawing.Point(758, 1221);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(256, 67);
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
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(34)))));
            this.ClientSize = new System.Drawing.Size(1293, 1300);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.pnMinimizar);
            this.Controls.Add(this.pnMaximizar);
            this.Controls.Add(this.pnCerrar);
            this.Controls.Add(this.lblEstadoSalud);
            this.Controls.Add(this.rbNoEmbarazada);
            this.Controls.Add(this.rbSiEmbarazada);
            this.Controls.Add(this.txtEmbarazo);
            this.Controls.Add(this.lblEmbarazo);
            this.Controls.Add(this.txtMedicamento);
            this.Controls.Add(this.rbNoMedicamento);
            this.Controls.Add(this.rbSiMedicamento);
            this.Controls.Add(this.lbl);
            this.Controls.Add(this.txtAlergia);
            this.Controls.Add(this.rbNoAlergia);
            this.Controls.Add(this.rbSiAlergia);
            this.Controls.Add(this.lblAlergia);
            this.Controls.Add(this.txtEnfermedad);
            this.Controls.Add(this.rbNoEnfermedad);
            this.Controls.Add(this.rbSiEnfermedad);
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
        private RadioButton rbSiEnfermedad;
        private RadioButton rbNoEnfermedad;
        private TextBox txtEnfermedad;
        private Label lblAlergia;
        private RadioButton rbNoAlergia;
        private RadioButton rbSiAlergia;
        private TextBox txtAlergia;
        private Label lbl;
        private RadioButton rbNoMedicamento;
        private RadioButton rbSiMedicamento;
        private TextBox txtMedicamento;
        private Label lblEmbarazo;
        private TextBox txtEmbarazo;
        private RadioButton rbNoEmbarazada;
        private RadioButton rbSiEmbarazada;
        private Label lblEstadoSalud;
        private Panel pnCerrar;
        private Panel pnMaximizar;
        private Panel pnMinimizar;
        private Button btnCancelar;
        private Button btnGuardar;
    }
}
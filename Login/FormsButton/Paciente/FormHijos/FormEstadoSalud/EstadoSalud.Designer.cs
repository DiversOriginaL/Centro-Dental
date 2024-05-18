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
            this.lblMaxCaracteres = new System.Windows.Forms.Label();
            this.lblMaxCaracteres2 = new System.Windows.Forms.Label();
            this.lblMaxCaracteres3 = new System.Windows.Forms.Label();
            this.lblMaxCaracteres4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblEnfermedad
            // 
            this.lblEnfermedad.AutoSize = true;
            this.lblEnfermedad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblEnfermedad.Font = new System.Drawing.Font("Sitka Text", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblEnfermedad.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblEnfermedad.Location = new System.Drawing.Point(57, 224);
            this.lblEnfermedad.Name = "lblEnfermedad";
            this.lblEnfermedad.Size = new System.Drawing.Size(553, 47);
            this.lblEnfermedad.TabIndex = 7;
            this.lblEnfermedad.Text = "¿Tiene algun tipo de enfermedad?";
            // 
            // txtEnfermedad
            // 
            this.txtEnfermedad.Font = new System.Drawing.Font("Sitka Text", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtEnfermedad.ForeColor = System.Drawing.Color.Silver;
            this.txtEnfermedad.Location = new System.Drawing.Point(17, 295);
            this.txtEnfermedad.MaxLength = 2000;
            this.txtEnfermedad.Multiline = true;
            this.txtEnfermedad.Name = "txtEnfermedad";
            this.txtEnfermedad.Size = new System.Drawing.Size(620, 277);
            this.txtEnfermedad.TabIndex = 10;
            this.txtEnfermedad.Text = "DESCRIPCION:";
            this.txtEnfermedad.TextChanged += new System.EventHandler(this.txtEnfermedad_TextChanged);
            this.txtEnfermedad.Enter += new System.EventHandler(this.txtEnfermedad_Enter);
            this.txtEnfermedad.Leave += new System.EventHandler(this.txtEnfermedad_Leave);
            // 
            // lblAlergia
            // 
            this.lblAlergia.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblAlergia.AutoSize = true;
            this.lblAlergia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblAlergia.Font = new System.Drawing.Font("Sitka Text", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblAlergia.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblAlergia.Location = new System.Drawing.Point(14, 600);
            this.lblAlergia.Name = "lblAlergia";
            this.lblAlergia.Size = new System.Drawing.Size(642, 47);
            this.lblAlergia.TabIndex = 11;
            this.lblAlergia.Text = "¿Le genera alergia algun medicamento?";
            // 
            // txtAlergia
            // 
            this.txtAlergia.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtAlergia.Font = new System.Drawing.Font("Sitka Text", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtAlergia.ForeColor = System.Drawing.Color.Silver;
            this.txtAlergia.Location = new System.Drawing.Point(17, 669);
            this.txtAlergia.MaxLength = 2000;
            this.txtAlergia.Multiline = true;
            this.txtAlergia.Name = "txtAlergia";
            this.txtAlergia.Size = new System.Drawing.Size(620, 299);
            this.txtAlergia.TabIndex = 14;
            this.txtAlergia.Text = "DESCRIPCION:";
            this.txtAlergia.TextChanged += new System.EventHandler(this.txtAlergia_TextChanged);
            this.txtAlergia.Enter += new System.EventHandler(this.txtMedicamento_Enter);
            this.txtAlergia.Leave += new System.EventHandler(this.txtMedicamento_Leave);
            // 
            // lbl
            // 
            this.lbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl.AutoSize = true;
            this.lbl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl.Font = new System.Drawing.Font("Sitka Text", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl.Location = new System.Drawing.Point(671, 224);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(604, 47);
            this.lbl.TabIndex = 15;
            this.lbl.Text = "¿Estas tomando algun medicamento?";
            // 
            // txtMedicamento
            // 
            this.txtMedicamento.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMedicamento.Font = new System.Drawing.Font("Sitka Text", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtMedicamento.ForeColor = System.Drawing.Color.Silver;
            this.txtMedicamento.Location = new System.Drawing.Point(671, 295);
            this.txtMedicamento.MaxLength = 2000;
            this.txtMedicamento.Multiline = true;
            this.txtMedicamento.Name = "txtMedicamento";
            this.txtMedicamento.Size = new System.Drawing.Size(604, 277);
            this.txtMedicamento.TabIndex = 18;
            this.txtMedicamento.Text = "DESCRIPCION:";
            this.txtMedicamento.TextChanged += new System.EventHandler(this.txtMedicamento_TextChanged);
            this.txtMedicamento.Enter += new System.EventHandler(this.txtAlergia_Enter);
            this.txtMedicamento.Leave += new System.EventHandler(this.txtAlergia_Leave);
            // 
            // lblEmbarazo
            // 
            this.lblEmbarazo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblEmbarazo.AutoSize = true;
            this.lblEmbarazo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblEmbarazo.Font = new System.Drawing.Font("Sitka Text", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblEmbarazo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblEmbarazo.Location = new System.Drawing.Point(826, 600);
            this.lblEmbarazo.Name = "lblEmbarazo";
            this.lblEmbarazo.Size = new System.Drawing.Size(336, 47);
            this.lblEmbarazo.TabIndex = 19;
            this.lblEmbarazo.Text = "¿Estas embarazada?";
            // 
            // txtEmbarazo
            // 
            this.txtEmbarazo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtEmbarazo.Font = new System.Drawing.Font("Sitka Text", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtEmbarazo.ForeColor = System.Drawing.Color.Silver;
            this.txtEmbarazo.Location = new System.Drawing.Point(671, 669);
            this.txtEmbarazo.MaxLength = 2000;
            this.txtEmbarazo.Multiline = true;
            this.txtEmbarazo.Name = "txtEmbarazo";
            this.txtEmbarazo.Size = new System.Drawing.Size(604, 299);
            this.txtEmbarazo.TabIndex = 20;
            this.txtEmbarazo.Text = "DESCRIPCION:";
            this.txtEmbarazo.TextChanged += new System.EventHandler(this.txtEmbarazo_TextChanged);
            this.txtEmbarazo.Enter += new System.EventHandler(this.txtEmbarazo_Enter);
            this.txtEmbarazo.Leave += new System.EventHandler(this.txtEmbarazo_Leave);
            // 
            // lblEstadoSalud
            // 
            this.lblEstadoSalud.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblEstadoSalud.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblEstadoSalud.Font = new System.Drawing.Font("Sitka Text", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblEstadoSalud.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblEstadoSalud.Image = global::Presentacion.Properties.Resources.EstadoSalud;
            this.lblEstadoSalud.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblEstadoSalud.Location = new System.Drawing.Point(289, 12);
            this.lblEstadoSalud.Name = "lblEstadoSalud";
            this.lblEstadoSalud.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
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
            this.pnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pnCerrar.Location = new System.Drawing.Point(1260, 12);
            this.pnCerrar.Name = "pnCerrar";
            this.pnCerrar.Size = new System.Drawing.Size(26, 34);
            this.pnCerrar.TabIndex = 24;
            this.pnCerrar.Click += new System.EventHandler(this.pnCerrar_Click);
            // 
            // pnMaximizar
            // 
            this.pnMaximizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pnMaximizar.BackgroundImage = global::Presentacion.Properties.Resources.expand_solid;
            this.pnMaximizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pnMaximizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pnMaximizar.Location = new System.Drawing.Point(1224, 12);
            this.pnMaximizar.Name = "pnMaximizar";
            this.pnMaximizar.Size = new System.Drawing.Size(26, 32);
            this.pnMaximizar.TabIndex = 25;
            this.pnMaximizar.Click += new System.EventHandler(this.pnMaximizar_Click);
            // 
            // pnMinimizar
            // 
            this.pnMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pnMinimizar.BackgroundImage = global::Presentacion.Properties.Resources.minimize;
            this.pnMinimizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pnMinimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pnMinimizar.Location = new System.Drawing.Point(1182, 12);
            this.pnMinimizar.Name = "pnMinimizar";
            this.pnMinimizar.Size = new System.Drawing.Size(31, 32);
            this.pnMinimizar.TabIndex = 26;
            this.pnMinimizar.Click += new System.EventHandler(this.pnMinimizar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(136)))), ((int)(((byte)(68)))));
            this.btnCancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(204)))), ((int)(((byte)(102)))));
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCancelar.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnCancelar.Image = global::Presentacion.Properties.Resources.Cancelar;
            this.btnCancelar.Location = new System.Drawing.Point(1045, 1003);
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
            this.btnGuardar.FlatAppearance.BorderSize = 0;
            this.btnGuardar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(136)))), ((int)(((byte)(68)))));
            this.btnGuardar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(204)))), ((int)(((byte)(102)))));
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnGuardar.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnGuardar.Image = global::Presentacion.Properties.Resources.guardar;
            this.btnGuardar.Location = new System.Drawing.Point(772, 1003);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(256, 77);
            this.btnGuardar.TabIndex = 28;
            this.btnGuardar.Text = " GUARDAR";
            this.btnGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // lblMaxCaracteres
            // 
            this.lblMaxCaracteres.BackColor = System.Drawing.Color.White;
            this.lblMaxCaracteres.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblMaxCaracteres.Location = new System.Drawing.Point(522, 544);
            this.lblMaxCaracteres.Name = "lblMaxCaracteres";
            this.lblMaxCaracteres.Size = new System.Drawing.Size(108, 21);
            this.lblMaxCaracteres.TabIndex = 29;
            this.lblMaxCaracteres.Text = "2000 / 2000";
            this.lblMaxCaracteres.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMaxCaracteres2
            // 
            this.lblMaxCaracteres2.BackColor = System.Drawing.Color.White;
            this.lblMaxCaracteres2.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblMaxCaracteres2.Location = new System.Drawing.Point(1160, 544);
            this.lblMaxCaracteres2.Name = "lblMaxCaracteres2";
            this.lblMaxCaracteres2.Size = new System.Drawing.Size(108, 21);
            this.lblMaxCaracteres2.TabIndex = 30;
            this.lblMaxCaracteres2.Text = "2000 / 2000";
            this.lblMaxCaracteres2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMaxCaracteres3
            // 
            this.lblMaxCaracteres3.BackColor = System.Drawing.Color.White;
            this.lblMaxCaracteres3.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblMaxCaracteres3.Location = new System.Drawing.Point(522, 942);
            this.lblMaxCaracteres3.Name = "lblMaxCaracteres3";
            this.lblMaxCaracteres3.Size = new System.Drawing.Size(108, 21);
            this.lblMaxCaracteres3.TabIndex = 31;
            this.lblMaxCaracteres3.Text = "2000 / 2000";
            this.lblMaxCaracteres3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMaxCaracteres4
            // 
            this.lblMaxCaracteres4.BackColor = System.Drawing.Color.White;
            this.lblMaxCaracteres4.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblMaxCaracteres4.Location = new System.Drawing.Point(1160, 942);
            this.lblMaxCaracteres4.Name = "lblMaxCaracteres4";
            this.lblMaxCaracteres4.Size = new System.Drawing.Size(108, 21);
            this.lblMaxCaracteres4.TabIndex = 32;
            this.lblMaxCaracteres4.Text = "2000 / 2000";
            this.lblMaxCaracteres4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // EstadoSalud
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(137)))), ((int)(((byte)(68)))));
            this.ClientSize = new System.Drawing.Size(1293, 1092);
            this.Controls.Add(this.lblMaxCaracteres4);
            this.Controls.Add(this.lblMaxCaracteres3);
            this.Controls.Add(this.lblMaxCaracteres2);
            this.Controls.Add(this.lblMaxCaracteres);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.pnMinimizar);
            this.Controls.Add(this.pnMaximizar);
            this.Controls.Add(this.pnCerrar);
            this.Controls.Add(this.lblEstadoSalud);
            this.Controls.Add(this.lblEmbarazo);
            this.Controls.Add(this.txtMedicamento);
            this.Controls.Add(this.lbl);
            this.Controls.Add(this.lblAlergia);
            this.Controls.Add(this.txtEnfermedad);
            this.Controls.Add(this.lblEnfermedad);
            this.Controls.Add(this.txtAlergia);
            this.Controls.Add(this.txtEmbarazo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EstadoSalud";
            this.Text = "EstadoSalud";
            this.Load += new System.EventHandler(this.EstadoSalud_Load);
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
        private Label lblMaxCaracteres;
        private Label lblMaxCaracteres2;
        private Label lblMaxCaracteres3;
        private Label lblMaxCaracteres4;
    }
}
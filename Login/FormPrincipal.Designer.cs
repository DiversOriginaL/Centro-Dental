namespace Presentacion
{
    partial class FormPrincipal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPrincipal));
            this.pnContainer = new System.Windows.Forms.Panel();
            this.pnRight = new System.Windows.Forms.Panel();
            this.pnTopTop = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnSlide = new System.Windows.Forms.PictureBox();
            this.pnLeft = new System.Windows.Forms.Panel();
            this.pnUsuarios = new System.Windows.Forms.Panel();
            this.pnReporte = new System.Windows.Forms.Panel();
            this.pnPaciente = new System.Windows.Forms.Panel();
            this.btnUsuarios = new System.Windows.Forms.Button();
            this.pnServicio = new System.Windows.Forms.Panel();
            this.btnReportes = new System.Windows.Forms.Button();
            this.btnPaciente = new System.Windows.Forms.Button();
            this.btnServicio = new System.Windows.Forms.Button();
            this.btnCerrarSesion = new System.Windows.Forms.Button();
            this.pnUp = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnMaximizar = new System.Windows.Forms.PictureBox();
            this.btnMinimizar = new System.Windows.Forms.PictureBox();
            this.btnCerrar = new System.Windows.Forms.PictureBox();
            this.pnContainer.SuspendLayout();
            this.pnRight.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnSlide)).BeginInit();
            this.pnLeft.SuspendLayout();
            this.pnUp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMaximizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).BeginInit();
            this.SuspendLayout();
            // 
            // pnContainer
            // 
            this.pnContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(136)))), ((int)(((byte)(68)))));
            this.pnContainer.Controls.Add(this.pnRight);
            this.pnContainer.Controls.Add(this.pnLeft);
            this.pnContainer.Controls.Add(this.pnUp);
            this.pnContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnContainer.Location = new System.Drawing.Point(0, 0);
            this.pnContainer.Name = "pnContainer";
            this.pnContainer.Size = new System.Drawing.Size(1392, 968);
            this.pnContainer.TabIndex = 0;
            // 
            // pnRight
            // 
            this.pnRight.BackColor = System.Drawing.Color.White;
            this.pnRight.Controls.Add(this.pnTopTop);
            this.pnRight.Controls.Add(this.panel1);
            this.pnRight.Controls.Add(this.panel2);
            this.pnRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnRight.Location = new System.Drawing.Point(309, 55);
            this.pnRight.Name = "pnRight";
            this.pnRight.Size = new System.Drawing.Size(1083, 913);
            this.pnRight.TabIndex = 2;
            // 
            // pnTopTop
            // 
            this.pnTopTop.AutoSize = true;
            this.pnTopTop.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnTopTop.Location = new System.Drawing.Point(0, 913);
            this.pnTopTop.Name = "pnTopTop";
            this.pnTopTop.Size = new System.Drawing.Size(1083, 0);
            this.pnTopTop.TabIndex = 8;
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::Presentacion.Properties.Resources.logo;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel1.Controls.Add(this.lblUsuario);
            this.panel1.Controls.Add(this.lblEmail);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 69);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1083, 844);
            this.panel1.TabIndex = 10;
            // 
            // lblUsuario
            // 
            this.lblUsuario.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblUsuario.Font = new System.Drawing.Font("Sitka Text", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblUsuario.ForeColor = System.Drawing.Color.DimGray;
            this.lblUsuario.Location = new System.Drawing.Point(0, 718);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(1083, 63);
            this.lblUsuario.TabIndex = 6;
            this.lblUsuario.Text = "USUARIO";
            this.lblUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblEmail
            // 
            this.lblEmail.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblEmail.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblEmail.Font = new System.Drawing.Font("Sitka Text", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblEmail.ForeColor = System.Drawing.Color.DimGray;
            this.lblEmail.Location = new System.Drawing.Point(0, 781);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(1083, 63);
            this.lblEmail.TabIndex = 7;
            this.lblEmail.Text = "EMAIL";
            this.lblEmail.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnSlide);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1083, 69);
            this.panel2.TabIndex = 9;
            // 
            // btnSlide
            // 
            this.btnSlide.BackColor = System.Drawing.Color.White;
            this.btnSlide.BackgroundImage = global::Presentacion.Properties.Resources.bars_solid;
            this.btnSlide.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSlide.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSlide.Location = new System.Drawing.Point(6, 13);
            this.btnSlide.Name = "btnSlide";
            this.btnSlide.Size = new System.Drawing.Size(45, 45);
            this.btnSlide.TabIndex = 1;
            this.btnSlide.TabStop = false;
            this.btnSlide.Click += new System.EventHandler(this.btnSlide_Click);
            // 
            // pnLeft
            // 
            this.pnLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(136)))), ((int)(((byte)(68)))));
            this.pnLeft.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnLeft.Controls.Add(this.pnUsuarios);
            this.pnLeft.Controls.Add(this.pnReporte);
            this.pnLeft.Controls.Add(this.pnPaciente);
            this.pnLeft.Controls.Add(this.btnUsuarios);
            this.pnLeft.Controls.Add(this.pnServicio);
            this.pnLeft.Controls.Add(this.btnReportes);
            this.pnLeft.Controls.Add(this.btnPaciente);
            this.pnLeft.Controls.Add(this.btnServicio);
            this.pnLeft.Controls.Add(this.btnCerrarSesion);
            this.pnLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnLeft.Location = new System.Drawing.Point(0, 55);
            this.pnLeft.Name = "pnLeft";
            this.pnLeft.Size = new System.Drawing.Size(309, 913);
            this.pnLeft.TabIndex = 1;
            // 
            // pnUsuarios
            // 
            this.pnUsuarios.BackColor = System.Drawing.Color.White;
            this.pnUsuarios.Location = new System.Drawing.Point(1, 309);
            this.pnUsuarios.Name = "pnUsuarios";
            this.pnUsuarios.Size = new System.Drawing.Size(7, 67);
            this.pnUsuarios.TabIndex = 9;
            this.pnUsuarios.Visible = false;
            // 
            // pnReporte
            // 
            this.pnReporte.BackColor = System.Drawing.Color.White;
            this.pnReporte.Location = new System.Drawing.Point(1, 230);
            this.pnReporte.Name = "pnReporte";
            this.pnReporte.Size = new System.Drawing.Size(7, 67);
            this.pnReporte.TabIndex = 3;
            this.pnReporte.Visible = false;
            // 
            // pnPaciente
            // 
            this.pnPaciente.BackColor = System.Drawing.Color.White;
            this.pnPaciente.Location = new System.Drawing.Point(0, 153);
            this.pnPaciente.Name = "pnPaciente";
            this.pnPaciente.Size = new System.Drawing.Size(7, 65);
            this.pnPaciente.TabIndex = 2;
            this.pnPaciente.Visible = false;
            // 
            // btnUsuarios
            // 
            this.btnUsuarios.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnUsuarios.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUsuarios.FlatAppearance.BorderSize = 0;
            this.btnUsuarios.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(34)))));
            this.btnUsuarios.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(204)))), ((int)(((byte)(102)))));
            this.btnUsuarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUsuarios.Font = new System.Drawing.Font("Sitka Text", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnUsuarios.ForeColor = System.Drawing.Color.White;
            this.btnUsuarios.Image = global::Presentacion.Properties.Resources.Usuarios2;
            this.btnUsuarios.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUsuarios.Location = new System.Drawing.Point(0, 309);
            this.btnUsuarios.Margin = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnUsuarios.Name = "btnUsuarios";
            this.btnUsuarios.Padding = new System.Windows.Forms.Padding(7, 0, 0, 0);
            this.btnUsuarios.Size = new System.Drawing.Size(309, 67);
            this.btnUsuarios.TabIndex = 8;
            this.btnUsuarios.Text = " Usuarios";
            this.btnUsuarios.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnUsuarios.UseVisualStyleBackColor = true;
            this.btnUsuarios.Click += new System.EventHandler(this.btnUsuarios_Click);
            this.btnUsuarios.Leave += new System.EventHandler(this.btnUsuarios_Leave);
            // 
            // pnServicio
            // 
            this.pnServicio.BackColor = System.Drawing.Color.White;
            this.pnServicio.Location = new System.Drawing.Point(1, 75);
            this.pnServicio.Name = "pnServicio";
            this.pnServicio.Size = new System.Drawing.Size(7, 67);
            this.pnServicio.TabIndex = 1;
            this.pnServicio.Visible = false;
            // 
            // btnReportes
            // 
            this.btnReportes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnReportes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReportes.FlatAppearance.BorderSize = 0;
            this.btnReportes.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(34)))));
            this.btnReportes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(204)))), ((int)(((byte)(102)))));
            this.btnReportes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReportes.Font = new System.Drawing.Font("Sitka Text", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnReportes.ForeColor = System.Drawing.Color.White;
            this.btnReportes.Image = global::Presentacion.Properties.Resources.chart_simple_solid;
            this.btnReportes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReportes.Location = new System.Drawing.Point(0, 229);
            this.btnReportes.Margin = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnReportes.Name = "btnReportes";
            this.btnReportes.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnReportes.Size = new System.Drawing.Size(309, 68);
            this.btnReportes.TabIndex = 2;
            this.btnReportes.Text = " Reportes";
            this.btnReportes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnReportes.UseVisualStyleBackColor = true;
            this.btnReportes.Click += new System.EventHandler(this.btnReporte_Click);
            this.btnReportes.Leave += new System.EventHandler(this.btnReportes_Leave);
            // 
            // btnPaciente
            // 
            this.btnPaciente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPaciente.FlatAppearance.BorderSize = 0;
            this.btnPaciente.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(34)))));
            this.btnPaciente.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(204)))), ((int)(((byte)(102)))));
            this.btnPaciente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPaciente.Font = new System.Drawing.Font("Sitka Text", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnPaciente.ForeColor = System.Drawing.Color.White;
            this.btnPaciente.Image = ((System.Drawing.Image)(resources.GetObject("btnPaciente.Image")));
            this.btnPaciente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPaciente.Location = new System.Drawing.Point(0, 152);
            this.btnPaciente.Margin = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnPaciente.Name = "btnPaciente";
            this.btnPaciente.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnPaciente.Size = new System.Drawing.Size(309, 66);
            this.btnPaciente.TabIndex = 1;
            this.btnPaciente.Text = " Pacientes";
            this.btnPaciente.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPaciente.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPaciente.UseVisualStyleBackColor = true;
            this.btnPaciente.Click += new System.EventHandler(this.btnPaciente_Click);
            this.btnPaciente.Leave += new System.EventHandler(this.btnPaciente_Leave);
            // 
            // btnServicio
            // 
            this.btnServicio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnServicio.FlatAppearance.BorderSize = 0;
            this.btnServicio.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(34)))));
            this.btnServicio.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(204)))), ((int)(((byte)(102)))));
            this.btnServicio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnServicio.Font = new System.Drawing.Font("Sitka Text", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnServicio.ForeColor = System.Drawing.Color.White;
            this.btnServicio.Image = global::Presentacion.Properties.Resources.people_arrows_solid;
            this.btnServicio.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnServicio.Location = new System.Drawing.Point(0, 70);
            this.btnServicio.Margin = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnServicio.Name = "btnServicio";
            this.btnServicio.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnServicio.Size = new System.Drawing.Size(309, 72);
            this.btnServicio.TabIndex = 0;
            this.btnServicio.Text = " Servicios";
            this.btnServicio.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnServicio.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnServicio.UseVisualStyleBackColor = true;
            this.btnServicio.Click += new System.EventHandler(this.btnServicio_Click);
            this.btnServicio.Leave += new System.EventHandler(this.btnServicio_Leave);
            // 
            // btnCerrarSesion
            // 
            this.btnCerrarSesion.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCerrarSesion.BackgroundImage")));
            this.btnCerrarSesion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnCerrarSesion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrarSesion.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnCerrarSesion.FlatAppearance.BorderColor = System.Drawing.Color.DarkSeaGreen;
            this.btnCerrarSesion.FlatAppearance.BorderSize = 2;
            this.btnCerrarSesion.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(136)))), ((int)(((byte)(68)))));
            this.btnCerrarSesion.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(204)))), ((int)(((byte)(102)))));
            this.btnCerrarSesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrarSesion.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCerrarSesion.ForeColor = System.Drawing.Color.White;
            this.btnCerrarSesion.Location = new System.Drawing.Point(0, 808);
            this.btnCerrarSesion.Margin = new System.Windows.Forms.Padding(3, 8, 3, 3);
            this.btnCerrarSesion.Name = "btnCerrarSesion";
            this.btnCerrarSesion.Padding = new System.Windows.Forms.Padding(0, 15, 0, 0);
            this.btnCerrarSesion.Size = new System.Drawing.Size(305, 101);
            this.btnCerrarSesion.TabIndex = 5;
            this.btnCerrarSesion.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCerrarSesion.UseVisualStyleBackColor = true;
            this.btnCerrarSesion.Click += new System.EventHandler(this.btnCerrarSesion_Click);
            // 
            // pnUp
            // 
            this.pnUp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(136)))), ((int)(((byte)(68)))));
            this.pnUp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnUp.Controls.Add(this.pictureBox1);
            this.pnUp.Controls.Add(this.label1);
            this.pnUp.Controls.Add(this.btnMaximizar);
            this.pnUp.Controls.Add(this.btnMinimizar);
            this.pnUp.Controls.Add(this.btnCerrar);
            this.pnUp.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnUp.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pnUp.Location = new System.Drawing.Point(0, 0);
            this.pnUp.Name = "pnUp";
            this.pnUp.Size = new System.Drawing.Size(1392, 55);
            this.pnUp.TabIndex = 0;
            this.pnUp.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnUp_MouseMove);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Presentacion.Properties.Resources.Diseño_sin_título;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(14, 10);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(48, 37);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Sitka Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(68, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(554, 45);
            this.label1.TabIndex = 3;
            this.label1.Text = "CLINICA DENTAL POPULAR (Dra. Chanllatte)";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnMaximizar
            // 
            this.btnMaximizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMaximizar.BackgroundImage = global::Presentacion.Properties.Resources.expand_solid;
            this.btnMaximizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnMaximizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMaximizar.Location = new System.Drawing.Point(1295, 13);
            this.btnMaximizar.Name = "btnMaximizar";
            this.btnMaximizar.Size = new System.Drawing.Size(36, 30);
            this.btnMaximizar.TabIndex = 2;
            this.btnMaximizar.TabStop = false;
            this.btnMaximizar.Click += new System.EventHandler(this.btnMaximizar_Click);
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimizar.BackgroundImage = global::Presentacion.Properties.Resources.minimize;
            this.btnMinimizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnMinimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinimizar.Location = new System.Drawing.Point(1246, 12);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(32, 31);
            this.btnMinimizar.TabIndex = 1;
            this.btnMinimizar.TabStop = false;
            this.btnMinimizar.Click += new System.EventHandler(this.btnMinimizar_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrar.BackgroundImage = global::Presentacion.Properties.Resources.exit;
            this.btnCerrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrar.Location = new System.Drawing.Point(1348, 12);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(30, 30);
            this.btnCerrar.TabIndex = 0;
            this.btnCerrar.TabStop = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1392, 968);
            this.Controls.Add(this.pnContainer);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(800, 800);
            this.Name = "FormPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FormPrincipal_Load);
            this.pnContainer.ResumeLayout(false);
            this.pnRight.ResumeLayout(false);
            this.pnRight.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnSlide)).EndInit();
            this.pnLeft.ResumeLayout(false);
            this.pnUp.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMaximizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel pnContainer;
        private Panel pnRight;
        private Panel pnLeft;
        private Panel pnUp;
        private PictureBox btnMaximizar;
        private PictureBox btnMinimizar;
        private PictureBox btnCerrar;
        private Button btnReportes;
        private Button btnPaciente;
        private Button btnServicio;
        private PictureBox btnSlide;
        private Button btnCerrarSesion;
        private Button btnUsuarios;
        private Panel panel2;
        private Label lblEmail;
        private Panel pnTopTop;
        private Label lblUsuario;
        private Panel panel1;
        public Panel pnReporte;
        public Panel pnPaciente;
        public Panel pnServicio;
        public Panel pnUsuarios;
        private Label label1;
        private PictureBox pictureBox1;
    }
}
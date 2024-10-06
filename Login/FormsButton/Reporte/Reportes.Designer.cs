namespace Presentacion.FormsButton.Reporte
{
    partial class Reportes
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.cIngresosDiarios = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.cbFiltro = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTotalRecaudado = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.cIngresosDiarios)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // cIngresosDiarios
            // 
            this.cIngresosDiarios.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cIngresosDiarios.BackColor = System.Drawing.Color.SeaGreen;
            this.cIngresosDiarios.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.DiagonalRight;
            this.cIngresosDiarios.BorderlineColor = System.Drawing.Color.Black;
            this.cIngresosDiarios.BorderSkin.BackColor = System.Drawing.SystemColors.GrayText;
            this.cIngresosDiarios.BorderSkin.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.TopBottom;
            chartArea2.Name = "ChartArea1";
            this.cIngresosDiarios.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.cIngresosDiarios.Legends.Add(legend2);
            this.cIngresosDiarios.Location = new System.Drawing.Point(467, 74);
            this.cIngresosDiarios.Name = "cIngresosDiarios";
            this.cIngresosDiarios.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen;
            series2.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.TopBottom;
            series2.BackSecondaryColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            series2.BorderColor = System.Drawing.Color.ForestGreen;
            series2.BorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash;
            series2.BorderWidth = 3;
            series2.ChartArea = "ChartArea1";
            series2.Color = System.Drawing.Color.LightGreen;
            series2.Legend = "Legend1";
            series2.Name = "INGRESOS";
            series2.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen;
            series2.ShadowColor = System.Drawing.Color.Black;
            this.cIngresosDiarios.Series.Add(series2);
            this.cIngresosDiarios.Size = new System.Drawing.Size(853, 464);
            this.cIngresosDiarios.TabIndex = 0;
            // 
            // cbFiltro
            // 
            this.cbFiltro.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbFiltro.Font = new System.Drawing.Font("Sitka Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cbFiltro.FormattingEnabled = true;
            this.cbFiltro.Items.AddRange(new object[] {
            "DIARIO",
            "SEMANAL",
            "MENSUAL",
            "ANUAL",
            "ANUALES"});
            this.cbFiltro.Location = new System.Drawing.Point(1026, 15);
            this.cbFiltro.Name = "cbFiltro";
            this.cbFiltro.Size = new System.Drawing.Size(294, 43);
            this.cbFiltro.TabIndex = 1;
            this.cbFiltro.SelectedIndexChanged += new System.EventHandler(this.cbFiltro_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Left;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Sitka Text", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(796, 114);
            this.label1.TabIndex = 2;
            this.label1.Text = "TOTAL RECAUDADO:";
            // 
            // lblTotalRecaudado
            // 
            this.lblTotalRecaudado.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblTotalRecaudado.AutoSize = true;
            this.lblTotalRecaudado.Font = new System.Drawing.Font("Times New Roman", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTotalRecaudado.ForeColor = System.Drawing.Color.White;
            this.lblTotalRecaudado.Location = new System.Drawing.Point(781, 18);
            this.lblTotalRecaudado.Name = "lblTotalRecaudado";
            this.lblTotalRecaudado.Size = new System.Drawing.Size(161, 81);
            this.lblTotalRecaudado.TabIndex = 3;
            this.lblTotalRecaudado.Text = "0.00";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1334, 98);
            this.panel1.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Sitka Text", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(-2, -6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(606, 88);
            this.label2.TabIndex = 4;
            this.label2.Text = "ESTADISTICAS.";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.lblTotalRecaudado);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 658);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1334, 118);
            this.panel2.TabIndex = 5;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.button1);
            this.panel3.Controls.Add(this.cbFiltro);
            this.panel3.Controls.Add(this.cIngresosDiarios);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 98);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1334, 560);
            this.panel3.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button1.AutoSize = true;
            this.button1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Beige;
            this.button1.FlatAppearance.BorderSize = 2;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(119)))), ((int)(((byte)(68)))));
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(204)))), ((int)(((byte)(102)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(10, 490);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(144, 48);
            this.button1.TabIndex = 2;
            this.button1.Text = "CERRAR";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Reportes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(136)))), ((int)(((byte)(68)))));
            this.ClientSize = new System.Drawing.Size(1334, 776);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Reportes";
            this.Text = "Reportes";
            this.Load += new System.EventHandler(this.Reportes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cIngresosDiarios)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart cIngresosDiarios;
        private ComboBox cbFiltro;
        private Label label1;
        private Label lblTotalRecaudado;
        private Panel panel1;
        private Panel panel2;
        private Label label2;
        private Panel panel3;
        private Button button1;
    }
}
namespace Presentacion.FormWelcome
{
    partial class Welcome
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
            this.pnLogo = new System.Windows.Forms.Panel();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.cpbProgreso = new CircularProgressBar.CircularProgressBar();
            this.SuspendLayout();
            // 
            // pnLogo
            // 
            this.pnLogo.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pnLogo.BackgroundImage = global::Presentacion.Properties.Resources.logo;
            this.pnLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pnLogo.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnLogo.Location = new System.Drawing.Point(0, 0);
            this.pnLogo.Name = "pnLogo";
            this.pnLogo.Size = new System.Drawing.Size(499, 463);
            this.pnLogo.TabIndex = 1;
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Font = new System.Drawing.Font("Sitka Text", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblUsuario.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblUsuario.Location = new System.Drawing.Point(505, 9);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(171, 58);
            this.lblUsuario.TabIndex = 4;
            this.lblUsuario.Text = "Usuario";
            // 
            // timer1
            // 
            this.timer1.Interval = 40;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Interval = 30;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // cpbProgreso
            // 
            this.cpbProgreso.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cpbProgreso.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.cpbProgreso.AnimationSpeed = 500;
            this.cpbProgreso.BackColor = System.Drawing.Color.Transparent;
            this.cpbProgreso.Font = new System.Drawing.Font("Tahoma", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cpbProgreso.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(68)))));
            this.cpbProgreso.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.cpbProgreso.InnerMargin = 2;
            this.cpbProgreso.InnerWidth = -1;
            this.cpbProgreso.Location = new System.Drawing.Point(797, 181);
            this.cpbProgreso.MarqueeAnimationSpeed = 2000;
            this.cpbProgreso.Name = "cpbProgreso";
            this.cpbProgreso.OuterColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(136)))), ((int)(((byte)(68)))));
            this.cpbProgreso.OuterMargin = -25;
            this.cpbProgreso.OuterWidth = 26;
            this.cpbProgreso.ProgressColor = System.Drawing.SystemColors.ControlLight;
            this.cpbProgreso.ProgressWidth = 25;
            this.cpbProgreso.SecondaryFont = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cpbProgreso.Size = new System.Drawing.Size(268, 257);
            this.cpbProgreso.StartAngle = 270;
            this.cpbProgreso.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.cpbProgreso.SubscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.cpbProgreso.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.cpbProgreso.SubscriptText = "";
            this.cpbProgreso.SuperscriptColor = System.Drawing.Color.Black;
            this.cpbProgreso.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.cpbProgreso.SuperscriptText = "%";
            this.cpbProgreso.TabIndex = 6;
            this.cpbProgreso.Text = "0";
            this.cpbProgreso.TextMargin = new System.Windows.Forms.Padding(8, 8, 0, 0);
            this.cpbProgreso.Value = 68;
            // 
            // Welcome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(136)))), ((int)(((byte)(68)))));
            this.ClientSize = new System.Drawing.Size(1092, 463);
            this.Controls.Add(this.cpbProgreso);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.pnLogo);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Welcome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Welcome";
            this.Load += new System.EventHandler(this.Welcome_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Panel pnLogo;
        private Label lblUsuario;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private CircularProgressBar.CircularProgressBar cpbProgreso;
    }
}
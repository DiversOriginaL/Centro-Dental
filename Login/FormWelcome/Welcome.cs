using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Common.Cache;

namespace Presentacion.FormWelcome
{
    public partial class Welcome : Form
    {
        public Welcome()
        {
            InitializeComponent();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            if(this.Opacity < 1) this.Opacity += 0.05;
            cpbProgreso.Value += 1;
            cpbProgreso.Text = cpbProgreso.Value.ToString();

            if(cpbProgreso.Value == 100)
            {
                timer1.Stop();
                timer2.Start();
            }

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            this.Opacity -= 0.2;
            if (this.Opacity == 0)
            {
                timer2.Stop();
                this.Close();
            }
        }

        private void Welcome_Load(object sender, EventArgs e)
        {
            lblUsuario.Text = UserLoginCache.getUser();
            this.Opacity = 0.0;
            cpbProgreso.Value = 0;
            cpbProgreso.Minimum = 0;
            cpbProgreso.Maximum = 100;


            timer1.Start(); 
        }
    }
}

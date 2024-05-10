using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventura
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
           
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn1_pogled_Click(object sender, EventArgs e)
        {
            prikaz pr = new prikaz();
            pr.Show();
            this.Hide();
        }

        private void btn2_vnos_Click(object sender, EventArgs e)
        {
            vstavljannje vs = new vstavljannje();
            vs.Show();
            this.Hide();
        }

        private void btn3_urejanje_Click(object sender, EventArgs e)
        {
            urejanje ur = new urejanje();
            ur.Show();
            this.Hide();
        }

        private void btn4_izbis_Click(object sender, EventArgs e)
        {
            brisanje br = new brisanje();
            br.Show();
            this.Hide();
        }
    }
}

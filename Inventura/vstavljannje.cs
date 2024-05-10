using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Items;
using System.Globalization;

namespace Inventura
{
    public partial class vstavljannje : Form
    {
        public vstavljannje()
        {
            InitializeComponent();
            groupBox2.Enabled = false;
            groupBox3.Enabled = false;
            groupBox4.Enabled = false;  

        
        }


        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void vstavljannje_Load(object sender, EventArgs e)
        {

        }

        private void textBox13_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn2_nazaj_Click(object sender, EventArgs e)
        {
            Form1 fr = new Form1();
            fr.Show();
            this.Hide();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 1)
            {
                groupBox2.Enabled = true;
                groupBox3.Enabled = false;
                groupBox4.Enabled = false;
            }
            else if (comboBox1.SelectedIndex == 2)
            {
                groupBox2.Enabled = false;
                groupBox3.Enabled = true;
                groupBox4.Enabled = false;
            }
            else if(comboBox1.SelectedIndex == 0)
            {
                groupBox2.Enabled = false;
                groupBox3.Enabled = false;
                groupBox4.Enabled = true;
            }
        }
        string ime;
        int cena;
        float rateza;
        float moteza;
        int stjedr;
        int kolkpolm;
        int hdd;
        int mb;
        int licenca;
        int verzija;
        int res;
        
        string tip;
        private void btn1_vstavi_Click(object sender, EventArgs e)
        {
            //sifra = int.Parse(textBox2.Text);
            
            tip = textBox10.Text.ToString();
            if (comboBox1.SelectedIndex == 0)
            {
                ime = textBox1.Text.ToString();
                cena = int.Parse(textBox3.Text);
                mb = int.Parse(textBox11.Text);
                licenca = int.Parse(textBox12.Text);
                verzija = int.Parse(textBox13.Text);
                // it = new Software(ime,cena,licenca, mb, verzija);
                ItemsDatabase d = new ItemsDatabase();
                d.SaveintoSoftware(ime, cena, licenca, mb, verzija);
                MessageBox.Show("vpisano");
            }
            else if (comboBox1.SelectedIndex == 1)
            {
                ime = textBox1.Text.ToString();
                cena = int.Parse(textBox3.Text);
                rateza = float.Parse(textBox4.Text);
                stjedr = int.Parse(textBox5.Text);
                kolkpolm = int.Parse(textBox6.Text);
                hdd = int.Parse(textBox7.Text);
                //it = new Computer(ime, cena, rateza, stjedr, kolkpolm, hdd);
                ItemsDatabase d = new ItemsDatabase();
                d.SaveintoComputer(ime, cena, rateza, stjedr, kolkpolm, hdd);
                MessageBox.Show("vpisano");
            }
            else if ( comboBox1.SelectedIndex == 2)
            {
                ime = textBox1.Text.ToString();
                cena = int.Parse(textBox3.Text);
                moteza = float.Parse(textBox14.Text);
                res = int.Parse(textBox8.Text);
                // it = new Monitor(ime, cena, moteza, res, tip);
                ItemsDatabase d = new ItemsDatabase();
                d.SaveintoMonitor(ime, cena, moteza, res, tip);

            }
        }
    }
}

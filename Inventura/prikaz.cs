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

namespace Inventura
{
    public partial class prikaz : Form
    {
        public prikaz()
        {
            InitializeComponent();
        }

        private void btn1_nazaj_Click(object sender, EventArgs e)
        {
            Form1 fr = new Form1();
            fr.Show();
            this.Hide();
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
               /* using (SQLiteCommand cmd = new SQLiteCommand(conn))
                {
                    cmd.CommandText = "SELECT ime, opis, zival, datum , lastnik, index_naloga FROM naloge WHERE (index_naloga = '" + label1id.Text + "');";

                    reader = cmd.ExecuteReader();


                    while (reader.Read() == true)
                    {
                        string line = reader.GetString(0) + "|" + reader.GetString(1) + "|" + reader.GetString(2) + "|" + reader.GetString(3) + "|" + reader.GetString(4);
                        /*string ime = reader.GetString(0);
                        naloge.Add(line);
                        listBoxnaloge.Items.Add(line);

                    }*/

               ItemsDatabase dtb = new ItemsDatabase();
                dtb.ReadItemsFromDatabaseComputer();
               }
            else if(comboBox1.SelectedIndex == 1)
            {

                ItemsDatabase dtb = new ItemsDatabase();
                dtb.ReadItemsFromDatabaseSoftware();
            }
            else if (comboBox1.SelectedIndex == 2)
            {
                ItemsDatabase dtb = new ItemsDatabase();
                dtb.ReadItemsFromDatabaseMonitor();
            }
            else if (comboBox1.SelectedIndex == 3)
            {
                ItemsDatabase dtb = new ItemsDatabase();
                dtb.ReadItemsFromDatabaseHardware();
            }
        }

        private void prikaz_Load(object sender, EventArgs e)
        {

        }
    }
}

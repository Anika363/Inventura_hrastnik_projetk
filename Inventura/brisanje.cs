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
    public partial class brisanje : Form
    {
        public brisanje()
        {
            InitializeComponent();
        }
        ItemsDatabase idb = new ItemsDatabase();
        private void btn2_nazaj_Click(object sender, EventArgs e)
        {
            Form1 fr = new Form1();
            fr.Show();
            this.Hide();
        }

        private void btn1_brisi_Click(object sender, EventArgs e)
        {
           
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                listBox1.Items.Clear();

                ItemsDatabase idb = new ItemsDatabase();

                // Retrieve items from the database
                List<string> items = idb.ReadItemsFromDatabaseMonitor();

                // Add items to the ListBox
                foreach (string item in items)
                {
                    listBox1.Items.Add(item);
                }
            }
            else if(comboBox1.SelectedIndex == 1)
            {
                listBox1.Items.Clear();

                ItemsDatabase idb = new ItemsDatabase();

                // Retrieve items from the database
                List<string> items = idb.ReadItemsFromDatabaseComputer();

                // Add items to the ListBox
                foreach (string item in items)
                {
                    listBox1.Items.Add(item);
                }
            }
            else if(comboBox1.SelectedIndex == 2)
            {
                listBox1.Items.Clear();

                ItemsDatabase idb = new ItemsDatabase();

                // Retrieve items from the database
                List<string> items = idb.ReadItemsFromDatabaseSoftware();

                // Add items to the ListBox
                foreach (string item in items)
                {
                    listBox1.Items.Add(item);
                }
            }
            else if (comboBox1.SelectedIndex == 3)
            {
                listBox1.Items.Clear();

                ItemsDatabase idb = new ItemsDatabase();

                // Retrieve items from the database
                List<string> items = idb.ReadItemsFromDatabaseHardware();

                // Add items to the ListBox
                foreach (string item in items)
                {
                    listBox1.Items.Add(item);
                }
            }
        }
    }
}

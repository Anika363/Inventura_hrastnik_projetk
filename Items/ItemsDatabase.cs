using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using Items;

namespace Items
{
    public class ItemsDatabase
    {
        private SQLiteConnection conn;
        //SQLiteDataReader reader;
        //latnisti 
        //konsruktor
        public ItemsDatabase()
        {
             conn = new SQLiteConnection("datasource=podatkovna baza inventura.db");
            
        }
        
        //metode
        /*public string SaveItem(int kira)
        {

            using (SQLiteCommand cmd = new SQLiteCommand(conn))
            {
                if (kira == 0)
                {
                    cmd.CommandText = "INSERT INTO item (ime , cena, teza, nooforces, amountofram, hddsize) Values  ";
                }
                else if (kira == 1)
                {
                    cmd.CommandText = "INSERT INTO computer";
                }
                else if (kira == 2)
                {
                    cmd.CommandText = "INSERT INTO software";
                }
                else if (kira == 3)
                {
                    cmd.CommandText = "INSERT INTO hardware";
                }
                else if (kira == 4)
                {
                    cmd.CommandText = "INSERT INTO monitor";
                }

                return SaveItem(kira);
            }*/
        
        public string SaveintoItem(string ime , int ce, int sif)
        {
            conn.Open();
            using (SQLiteCommand cmd = new SQLiteCommand(conn))
            {
                
                cmd.CommandText = "INSERT INTO item (ime , cena) VALUES ('"+ ime +"','"+ ce + "');";
                return cmd.CommandText;
            }
            
           
        }
        public string SaveintoComputer(string ime, int ce, float tez, int noo, int ram, int hdd)
        {
            conn.Open();
            using (SQLiteCommand cmd = new SQLiteCommand(conn))
            {
                cmd.CommandText = "INSERT INTO computer (ime , cena, teza, noofcores, amountofram, hddsize) VALUES ('" + ime + "','" + ce + "','" + tez + "','" + noo + "','" + ram + "','" + hdd + "');";
                cmd.CommandText = "INSERT INTO item (ime , cena) VALUES ('" + ime + "','" + ce + "');";
                return cmd.CommandText;
                
            }
        }
        public string SaveintoHardware(string ime, int ce, float tez)
        {
            conn.Open();
            using (SQLiteCommand cmd = new SQLiteCommand(conn))
            {
                cmd.CommandText = "INSERT INTO hardware (ime , cena, teza) VALUES ('" + ime + "','" + ce + "','" + tez + "');";
                cmd.CommandText = "INSERT INTO item (ime , cena) VALUES ('" + ime + "','" + ce + "');";
                return cmd.CommandText;
            }
            
        }
        public string SaveintoMonitor(string ime, int ce, float tez, int res, string tip)
        {
            conn.Open();
            using (SQLiteCommand cmd = new SQLiteCommand(conn))
            {
                cmd.CommandText = "INSERT INTO monitor (ime , cena, teza, resolucija, tipmonitorja) VALUES ('" + ime + "','" + ce + "','" + tez + "','" + res + "','" + tip + "');";
                cmd.CommandText = "INSERT INTO item (ime , cena) VALUES ('" + ime + "','" + ce + "');";
                return cmd.CommandText;
            }
            
        }
        public string SaveintoSoftware(string ime, int ce, int lice, int mb, int verz)
        {
            conn.Open();
            using (SQLiteCommand cmd = new SQLiteCommand(conn))
            {
                cmd.CommandText = "INSERT INTO software (ime , cena, licencekey, sizemb, verzija) VALUES ('" + ime + "','" + ce + "','" + lice + "','" + mb + "','" + verz + "');";
                //cmd.CommandText = "INSERT INTO item (ime , cena) VALUES ('" + ime + "','" + ce + "');";
                return cmd.CommandText;
            }
        }

        public string ReadItem(string ime)
        {
            conn.Open();
            using (SQLiteCommand cmd = new SQLiteCommand(conn))
            {
                cmd.CommandText="SELECT * FROM '" + ime + "' ;";
                return cmd.CommandText;
            }
        }
        public string ReadItemID(string kira, int idi )
        {
            conn.Open();
            using (SQLiteCommand cmd = new SQLiteCommand(conn))
            {
                cmd.CommandText = "SELECT * FROM '" + kira + "' WHERE (id = '" + idi + "');";
                return cmd.CommandText;
            }
        }
        public string UpdateCmputer(int idi,string im, int ce, int tez, int cores, int ram,int hdd)
        {
            conn.Open();
            using (SQLiteCommand cmd = new SQLiteCommand(conn))
            {
                cmd.CommandText = "UPDATE computer SET ime='" + im + "'ime='" + im + "'cena='" + ce + "'teza='" + tez + "'noofcores='" + cores + "'amountofram='" + ram + "'hddsize='" + hdd + "' WHERE id = '"+idi+"' ;";
                return cmd.CommandText;
            }
        }
        public string UpdateHardware(int idi, string im, int ce, int tez)
        {
            conn.Open();
            using (SQLiteCommand cmd = new SQLiteCommand(conn))
            {
                cmd.CommandText = "UPDATE computer SET ime='" + im + "'ime='" + im + "'cena='" + ce + "'teza='" + tez + "' WHERE id = '" + idi + "' ;";
                return cmd.CommandText;
            }
        }
        public string UpdateItem(int idi, string im, int ce)
        {
            conn.Open();
            using (SQLiteCommand cmd = new SQLiteCommand(conn))
            {
                cmd.CommandText = "UPDATE computer SET ime='" + im + "'ime='" + im + "'cena='" + ce + "' WHERE id = '" + idi + "' ;";
                return cmd.CommandText;
            }
        }
        public string UpdateMonitor(int idi, string im, int ce, int tez, int res, string tip)
        {
            conn.Open();
            using (SQLiteCommand cmd = new SQLiteCommand(conn))
            {
                cmd.CommandText = "UPDATE computer SET ime='" + im + "'ime='" + im + "'cena='" + ce + "'teza='" + tez + "'resolucija='" + res + "'tipmonitorja='" + tip + "' WHERE id = '" + idi + "' ;";
                return cmd.CommandText;
            }
        }
        public string UpdateSoftware(int idi, string im, int ce, int key, int mb, int verz)
        {
            conn.Open();
            using (SQLiteCommand cmd = new SQLiteCommand(conn))
            {
                cmd.CommandText = "UPDATE computer SET ime='" + im + "'ime='" + im + "'cena='" + ce + "'licencekey='" + key + "'sizemb='" + mb + "'verzija='" + verz + "' WHERE id = '" + idi + "' ;";
                return cmd.CommandText;
            }
        }
        public string DeliteComputer(int idi)
        {
            conn.Open();
            using (SQLiteCommand cmd = new SQLiteCommand(conn))
            {
                cmd.CommandText = "DELETE FROM computer WHERE id = '" + idi + "';";
                return cmd.CommandText;
            }
        }
        public string DeliteHardware(int idi)
        {
            conn.Open();
            using (SQLiteCommand cmd = new SQLiteCommand(conn))
            {
                cmd.CommandText = "DELETE FROM hardware WHERE id = '" + idi + "';";
                return cmd.CommandText;
            }
        }
        public string DeliteItem(int idi)
        {
            conn.Open();
            using (SQLiteCommand cmd = new SQLiteCommand(conn))
            {
                cmd.CommandText = "DELETE FROM item WHERE id = '" + idi + "';";
                return cmd.CommandText;
            }
        }
        public string DeliteMonitor(int idi)
        {
            conn.Open();
            using (SQLiteCommand cmd = new SQLiteCommand(conn))
            {
                cmd.CommandText = "DELETE FROM monitor WHERE id = '" + idi + "';";
                return cmd.CommandText;
            }
        }
        // da prikaže na listbox
        
        public List<string> ReadItemsFromDatabaseMonitor()
        {
            List<string> items = new List<string>();
            using (SQLiteCommand cmd = new SQLiteCommand(conn))
            {
                string query = "SELECT id, ime FROM monitor"; // Assuming 'Name' is the column name in your database table

                using (SQLiteCommand command = new SQLiteCommand(query, conn))
                {

                    conn.Open();
                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string itemName = reader["ime"].ToString();
                            items.Add(itemName);
                        }
                    }
                }
            }

            return items;
           
        }
        public List<string> ReadItemsFromDatabaseSoftware()
        {
            List<string> items = new List<string>();
            
            using (SQLiteCommand cmd = new SQLiteCommand(conn))
            {
                string query = "SELECT id, ime FROM software"; // Assuming 'Name' is the column name in your database table

                using (SQLiteCommand command = new SQLiteCommand(query, conn))
                {

                    conn.Open();
                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string itemName = reader["ime"].ToString();
                            items.Add(itemName);
                        }
                    }
                }
            }

            return items;

        }
        public List<string> ReadItemsFromDatabaseHardware()
        {
            List<string> items = new List<string>();
            
            using (SQLiteCommand cmd = new SQLiteCommand(conn))
            {
                string query = "SELECT id, ime FROM hardware"; // Assuming 'Name' is the column name in your database table

                using (SQLiteCommand command = new SQLiteCommand(query, conn))
                {

                    conn.Open();
                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string itemName = reader["ime"].ToString();
                            items.Add(itemName);
                        }
                    }
                }
            }

            return items;

        }
        public List<string> ReadItemsFromDatabaseComputer()
        {
            List<string> items = new List<string>();
            
            using (SQLiteCommand cmd = new SQLiteCommand(conn))
            {
                string query = "SELECT id, ime FROM computer"; // Assuming 'Name' is the column name in your database table

                using (SQLiteCommand command = new SQLiteCommand(query, conn))
                {

                    conn.Open();
                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string itemName = reader["ime"].ToString();
                            items.Add(itemName);
                        }
                    }
                }
            }

            return items;

        }
        public string DeliteSoftware(int idi)
        {
            conn.Open();
            using (SQLiteCommand cmd = new SQLiteCommand(conn))
            {
                cmd.CommandText = "DELETE FROM software WHERE id = '" + idi + "';";
                return cmd.CommandText;
            }
        }
    }
}

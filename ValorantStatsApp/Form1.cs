using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Configuration;
using System.Diagnostics;

namespace ValorantStatsApp
{
    public partial class Form1 : Form
    {

        private string ConString = ConfigurationManager.ConnectionStrings["ConString"].ConnectionString;
        private MySqlConnection con;

        public Form1()
        {
            InitializeComponent();
            con = new MySqlConnection(ConString);
            loadComboBoxes();
            comboBox1.SelectedIndex = 0;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void loadComboBoxes()
        {
            string query = "SELECT Name FROM Maps";
            DataTable output = CreateQuery(query);
            foreach(DataRow row in output.Rows)
            {
                MapComboBox.Items.Add(row[0]);
            }
            query = "SELECT Name FROM Heroes";
            output = CreateQuery(query);
            foreach (DataRow row in output.Rows)
            {
                HeroComboBox.Items.Add(row[0]);
            }

            MapComboBox.Items.Insert(0,"Any");
            HeroComboBox.Items.Insert(0, "Any");
            MapComboBox.SelectedIndex = 0;
            HeroComboBox.SelectedIndex = 0;
            MapComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            HeroComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string CmdString = "SELECT PlayerName, Heroes.Name as Hero, Kills, Deaths, Maps.Name as Map FROM Scoreboard JOIN Heroes ON Scoreboard.Hero = Heroes.HeroID JOIN MatchDetails MD on Scoreboard.MatchID = MD.MatchID JOIN Maps ON MD.Map = Maps.MapID";
            bool hasWhere = false;
            if (HeroComboBox.SelectedIndex != 0)
            {
                CmdString += " WHERE Heroes.Name = '" + HeroComboBox.SelectedItem + "'";
                hasWhere = true;
            }
            if(MapComboBox.SelectedIndex != 0)
            {
                if(hasWhere)
                {
                    CmdString += " AND Maps.Name = '" + MapComboBox.SelectedItem + "'";
                } else
                {
                    CmdString += " WHERE Maps.Name = '" + MapComboBox.SelectedItem + "'";
                }
                
            }

            
            DataTable output = CreateQuery(CmdString);
            dataGridView1.DataSource = output.DefaultView;
            
        }

        private DataTable CreateQuery(string CmdString)
        {
            MySqlDataAdapter sda = new MySqlDataAdapter(CmdString, con);
            DataSet ds = new DataSet();
            sda.Fill(ds);
            return ds.Tables[0];
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void MapComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

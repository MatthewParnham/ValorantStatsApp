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
            UpdateMatchDetails();
            dateTimePicker1.Value = DateTime.Today.AddYears(-50);
            dateTimePicker2.Value = DateTime.Today;
            dataGridView1.MultiSelect = false;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            UpdateScoreboard();
        }

        private void UpdateScoreboard()
        {
            if (dataGridView1.SelectedCells.Count > 0)
            {
                string currMatchID = (string)dataGridView1.SelectedCells[0].Value.ToString();
                string currHero;
                if (HeroComboBox.SelectedIndex == 0)
                {
                    currHero = "";
                }
                else
                {
                    currHero = (string)HeroComboBox.SelectedItem;
                }
                string scoreboardQuery = String.Format("SELECT MatchID, PlayerName, Heroes.Name as Hero, AVGCombatScore, Kills, Deaths, Assists, EconRating, FirstBloods, Plants, Defuses FROM Scoreboard JOIN Heroes on Scoreboard.Hero = Heroes.HeroID WHERE MatchID = {0} AND Heroes.Name LIKE '%{1}%'", currMatchID, currHero);
                DataTable output = CreateQuery(scoreboardQuery);
                dataGridView2.DataSource = output.DefaultView;
                dataGridView2.Columns["MatchID"].Visible = false;
            }
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
            WinLossComboBox.SelectedIndex = 0;
            MapComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            HeroComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            WinLossComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private DataTable CreateQuery(string CmdString)
        {
            MySqlDataAdapter sda = new MySqlDataAdapter(CmdString, con);
            DataSet ds = new DataSet();
            sda.Fill(ds);
            return ds.Tables[0];
        }

        private void UpdateMatchDetails()
        {
            string mapSelection;
            if (MapComboBox.SelectedIndex == 0)
            {
                mapSelection = "";
            }
            else
            {
                mapSelection = (string)MapComboBox.SelectedItem;
            }
            string won;
            if (WinLossComboBox.SelectedIndex == 0)
            {
                won = "";
            } else if(WinLossComboBox.SelectedIndex == 1)
            {
                won = "1";
            } else
            {
                won = "0";
            }
            string minDate = dateTimePicker1.Value.Date.Year + "-" + dateTimePicker1.Value.Date.Month + "-" + dateTimePicker1.Value.Date.Day;
            string maxDate = dateTimePicker2.Value.Date.Year + "-" + dateTimePicker2.Value.Date.Month + "-" + dateTimePicker2.Value.Date.Day;
            string CmdString = String.Format("SELECT MatchID, Maps.Name as Map, Win, RoundsWon, RoundsLost, Date FROM MatchDetails JOIN Maps on MatchDetails.Map = Maps.MapID WHERE Maps.Name LIKE '%{0}%' AND Date BETWEEN '{1}' AND '{2}' AND Win LIKE '%{3}%'", mapSelection,minDate,maxDate,won);
            DataTable output = CreateQuery(CmdString);
            dataGridView1.DataSource = output.DefaultView;
            dataGridView1.Columns["MatchID"].Visible = false;
        }

        private void MapComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateMatchDetails();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            UpdateMatchDetails();
        }

        private void WinLossComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateMatchDetails();
        }

        private void HeroComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateScoreboard();
        }
    }
}

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
using System.IO;

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
            dataGridView1.AllowUserToAddRows = false;
            dataGridView2.AllowUserToAddRows = false;
            dataGridView3.AllowUserToAddRows = false;
            dataGridView4.AllowUserToAddRows = false;
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            UpdateScoreboard();
            UpdateTimeLine();
            UpdatePerformance();
        }

        private void dataGridView2_CellChanged(object sender, DataGridViewCellEventArgs e)
        {
            UpdateCell(dataGridView2, e.RowIndex, e.ColumnIndex);
        }

        private void UpdateCell(DataGridView dgv, int row, int col)
        {
            string colHeader = dgv.Columns[col].HeaderText;
            string newValue = dgv.Rows[row].Cells[col].Value.ToString();
            string pkHeader = dgv.Columns[0].HeaderText;
            string skHeader = dgv.Columns[1].HeaderText;
            string pk = dgv.Rows[row].Cells[0].Value.ToString();
            string sk = dgv.Rows[row].Cells[1].Value.ToString();
            string updateQuery = String.Format("UPDATE {0} SET {1} = '{2}' WHERE {3} = {4} AND {5} = '{6}'",dgv.Tag,colHeader,newValue,pkHeader,pk,skHeader,sk);
            Debug.WriteLine(updateQuery);
            MySqlTransaction tr = null;
            con.Open();
            try
            {
                tr = con.BeginTransaction();

                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = con;
                cmd.Transaction = tr;


                cmd.CommandText = updateQuery;

                cmd.ExecuteNonQuery();


                tr.Commit();
            }
            catch (MySqlException ex)
            {
                try
                {
                    tr.Rollback();
                }
                catch (MySqlException ex1)
                {
                    MessageBox.Show(ex1.ToString());
                }

                MessageBox.Show(ex.ToString());
            }
            con.Close();
        }

        private void Rollback()
        {
            string rollbackQuery = "";

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
                dataGridView2.Columns["PlayerName"].ReadOnly = true;
            }
        }

        private void UpdateTimeLine()
        {
            if (dataGridView1.SelectedCells.Count > 0)
            {
                string currMatchID = (string)dataGridView1.SelectedCells[0].Value.ToString();
                string scoreboardQuery = String.Format("SELECT MatchID, RoundNum, Score, Kills, Assists, Died, MoneySpent, Weapons.Name as Weapon, Won FROM Timeline JOIN Weapons on Timeline.Weapon = Weapons.WeaponID WHERE MatchID = {0}",currMatchID);
                DataTable output = CreateQuery(scoreboardQuery);
                dataGridView3.DataSource = output.DefaultView;
                dataGridView3.Columns["MatchID"].Visible = false;
                dataGridView3.Columns["RoundNum"].ReadOnly = true;
            }
        }

        private void UpdatePerformance()
        {
            if (dataGridView1.SelectedCells.Count > 0)
            {
                string currMatchID = (string)dataGridView1.SelectedCells[0].Value.ToString();
                string scoreboardQuery = String.Format("SELECT MatchID, PlayerName, Kills, Deaths, Assists FROM Performance WHERE MatchID = {0}", currMatchID);
                DataTable output = CreateQuery(scoreboardQuery);
                dataGridView4.DataSource = output.DefaultView;
                dataGridView4.Columns["MatchID"].Visible = false;
                dataGridView4.Columns["PlayerName"].ReadOnly = true;
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

        private void MatchReportButton_Click(object sender, EventArgs e)
        {
            SaveFileDialog fDialog = new SaveFileDialog
            {
                InitialDirectory = @"C:\",
                Title = "Select Location",
                FileName = "Report_" + DateTime.Today.Month + "-" + DateTime.Today.Day,

                CheckFileExists = false,
                CheckPathExists = false,

                DefaultExt = "csv",
                Filter = "csv files (*.csv)|*.csv",
                FilterIndex = 2,
                RestoreDirectory = true
            };

            if (fDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = fDialog.FileName;
                Debug.WriteLine(filePath);
                bool fileError = false;
                if (File.Exists(filePath))
                {
                    try
                    {
                        File.Delete(filePath);
                    }
                    catch (IOException ex)
                    {
                        fileError = true;
                        MessageBox.Show("It wasn't possible to write the data to the disk." + ex.Message);
                    }
                }
                if (!fileError)
                {
                    try
                    {
                        int columnCount = dataGridView1.Columns.Count;
                        string columnNames = "";
                        string matchDetails = "";
                        string[] outputCsv = new string[4 + dataGridView2.Rows.Count + 2 + dataGridView3.Rows.Count + 2 + dataGridView4.Rows.Count + 5];
                        int lineIdx = 0;
                        for (int i = 0; i < columnCount; i++)
                        {
                            columnNames += dataGridView1.Columns[i].HeaderText.ToString() + ",";
                            matchDetails += dataGridView1.SelectedCells[i].Value + ",";

                        }
                        outputCsv[lineIdx++] += columnNames;
                        outputCsv[lineIdx++] += matchDetails;
                        outputCsv[lineIdx++] += ",";
                        outputCsv[lineIdx++] += "Scoreboard,";
                        columnCount = dataGridView2.Columns.Count;
                        columnNames = "";
                        for (int i = 0; i < columnCount; i++)
                        {
                            columnNames += dataGridView2.Columns[i].HeaderText.ToString() + ",";
                        }
                        outputCsv[lineIdx++] += columnNames;
                        for (int i = 0; i < dataGridView2.Rows.Count; i++)
                        {
                            for (int j = 0; j < columnCount; j++)
                            {
                                outputCsv[lineIdx] += dataGridView2.Rows[i].Cells[j].Value.ToString() + ",";
                            }
                            lineIdx++;
                        }

                        outputCsv[lineIdx++] += ",";
                        outputCsv[lineIdx++] += "Timeline,";
                        columnCount = dataGridView3.Columns.Count;
                        columnNames = "";
                        for (int i = 0; i < columnCount; i++)
                        {
                            columnNames += dataGridView3.Columns[i].HeaderText.ToString() + ",";
                        }
                        outputCsv[lineIdx++] += columnNames;
                        for (int i = 0; i < dataGridView3.Rows.Count; i++)
                        {
                            for (int j = 0; j < columnCount; j++)
                            {
                                outputCsv[lineIdx] += dataGridView3.Rows[i].Cells[j].Value.ToString() + ",";
                            }
                            lineIdx++;
                        }

                        outputCsv[lineIdx++] += ",";
                        outputCsv[lineIdx++] += "Performance,";
                        columnCount = dataGridView4.Columns.Count;
                        columnNames = "";
                        for (int i = 0; i < columnCount; i++)
                        {
                            columnNames += dataGridView4.Columns[i].HeaderText.ToString() + ",";
                        }
                        outputCsv[lineIdx++] += columnNames;
                        for (int i = 0; i < dataGridView4.Rows.Count; i++)
                        {
                            for (int j = 0; j < columnCount; j++)
                            {
                                outputCsv[lineIdx] += dataGridView4.Rows[i].Cells[j].Value.ToString() + ",";
                            }
                            lineIdx++;
                        }

                        File.WriteAllLines(filePath, outputCsv, Encoding.UTF8);
                        MessageBox.Show("Report Generated Successfully.", "Info");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error :" + ex.Message);
                    }
                }

            }
        }
    }
}

using gambistWinForm.Models;
using gambistWinForm.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gambistWinForm
{
    public partial class ImportMatch : Form
    {

        MatchServices MatchServices = new MatchServices();

        public ImportMatch()
        {
            InitializeComponent();
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            try 
            {
                OpenFileDialog ofd = new OpenFileDialog();
                ofd.ShowDialog();
                searchTextBox.Text = ofd.FileName;
            }
            catch(Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }
        }

        public List<Match> LoadMatchesFromCSV(string fileName) 
        {
            try
            {
                var matchesInFile = from line in File.ReadAllLines(fileName)
                                 let data = line.Split(';')
                                 select new Match()
                                 {
                                     EtatImport = "Non Fait",
                                     categoryId = int.Parse(data[0]),
                                     teamAId = int.Parse(data[1]),
                                     teamBId = int.Parse(data[2]),
                                     matchDate = data[3]
                                 };
                return matchesInFile.ToList();
            } 
            catch (Exception ex) 
            {
                throw ex;
            }
        }

        private void importButton_Click(object sender, EventArgs e)
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                matchGridView.DataSource = LoadMatchesFromCSV(searchTextBox.Text);
                matchGridView.Columns["id"].Visible = false;
                matchGridView.Columns["state"].Visible = false;
                matchGridView.ClearSelection();
                matchGridView.CurrentCell = null;
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void mainMenuLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                if (matchGridView.Rows.Count == 0)
                {
                    MessageBox.Show("Aucune donnée importée");
                }
                else 
                {
                    string succes = "Succès";
                    string echec = "Echec ";
                    foreach (DataGridViewRow row in matchGridView.Rows)
                    {
                        var lastCell = row.Cells.Count - 1;
                        Match match = (Match)row.DataBoundItem;
                        if (match.EtatImport != "Non Fait") 
                        {
                            MessageBox.Show("Opération déjà effectuée sur ces données");
                            break;
                        }
                        var insertState = MatchServices.AddMatchAsync(match);

                        if (insertState.State)
                        {
                            row.Cells[lastCell].Value = succes;
                            match.EtatImport = succes;
                        }
                        else
                        {
                            row.Cells[lastCell].Value = echec + insertState.ErrorMessage;
                            match.EtatImport = echec + insertState.ErrorMessage;
                        }
                    }
                    MessageBox.Show("Opération terminée");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}

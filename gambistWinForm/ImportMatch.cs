using gambistWinForm.Models;
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
                                     IdCategory = int.Parse(data[0]),
                                     TeamA = int.Parse(data[1]),
                                     TeamB = int.Parse(data[2]),
                                     MatchDate = data[3]
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
                matchGridView.DataSource = LoadMatchesFromCSV(searchTextBox.Text);
                matchGridView.Columns["Id"].Visible = false;
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
    }
}

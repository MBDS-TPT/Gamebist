using gambistWinForm.Models;
using Microsoft.WindowsAPICodePack.Dialogs;
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
    public partial class ExportBet : Form
    {
        public ExportBet()
        {
            InitializeComponent();
        }

        private void exportPathButton_Click(object sender, EventArgs e)
        {
            try
            {
                CommonOpenFileDialog dialog = new CommonOpenFileDialog();
                dialog.IsFolderPicker = true;
                if (dialog.ShowDialog() == CommonFileDialogResult.Ok) 
                {
                    exportPathTextBox.Text = dialog.FileName;
                }
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

        private void exportButton_Click(object sender, EventArgs e)
        {
            try
            {
                string fileName = exportPathTextBox.Text + @"\exportBet"+ DateTime.Now.Ticks.ToString() +".csv";
                TextWriter writer = new StreamWriter(fileName);

                //Données fictives
                var betsToExport = new List<Pari>();
                betsToExport.Add(new Pari() { Id = 1, DatePari = exportDateTimePicker.Text, Email = "Test@test.test", IdCategoriePari = 2, TauxVictoire = 20, ValeurPari = 100 });
                betsToExport.Add(new Pari() { Id = 2, DatePari = exportDateTimePicker.Text, Email = "Test2@test.test", IdCategoriePari = 1, TauxVictoire = 10, ValeurPari = 80 });
                betsToExport.Add(new Pari() { Id = 3, DatePari = exportDateTimePicker.Text, Email = "Test3@test.test", IdCategoriePari = 2, TauxVictoire = 30, ValeurPari = 500 });

                writer.WriteLine("Id;DatePari;Email;IdCategoriePari;TauxVictoire;ValeurPari");

                foreach (var bet in betsToExport) 
                {
                    writer.WriteLine(
                        bet.Id.ToString()
                        + ";" + bet.DatePari
                        + ";" + bet.Email
                        + ";" + bet.IdCategoriePari.ToString()
                        + ";" + bet.TauxVictoire.ToString()
                        + ";" + bet.ValeurPari.ToString());
                }

                writer.Close();
                MessageBox.Show("Export terminé");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}

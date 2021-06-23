using gambistWinForm.Models;
using gambistWinForm.Services;
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

        PariServices PariServices = new PariServices();

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
                Cursor.Current = Cursors.WaitCursor;
                var betsToExport = PariServices.GetListPari();

                if (betsToExport.Any())
                {
                    string fileName = exportPathTextBox.Text + @"\exportBet" + DateTime.Now.Ticks.ToString() + ".csv";
                    TextWriter writer = new StreamWriter(fileName);

                    writer.WriteLine("Id;DatePari;Email;IdMatch;TauxVictoire;ValeurPari");

                    foreach (var bet in betsToExport)
                    {
                        writer.WriteLine(
                            bet.Id.ToString()
                            + ";" + bet.DatePari
                            + ";" + bet.Email
                            + ";" + bet.IdMatch.ToString()
                            + ";" + bet.TauxVictoire.ToString()
                            + ";" + bet.ValeurPari.ToString());
                    }

                    writer.Close();
                    MessageBox.Show("Export terminé");
                }
                else
                {
                    MessageBox.Show("Aucun pari trouvé pour la date donnée");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}

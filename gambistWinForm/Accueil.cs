using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gambistWinForm
{
    public partial class Accueil : Form
    {
        public Accueil()
        {
            InitializeComponent();
        }

        private void configButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            var configForm = new ConfigManagerForm();
            configForm.ShowDialog();
            this.Show();
        }

        private void importButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            var importForm = new ImportMatch();
            importForm.ShowDialog();
            this.Show();
        }

        private void exportButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            var exportForm = new ExportBet();
            exportForm.ShowDialog();
            this.Show();
        }
    }
}

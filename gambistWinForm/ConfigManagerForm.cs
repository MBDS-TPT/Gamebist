using gambistWinForm.Services;
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
    public partial class ConfigManagerForm : Form
    {
        ConfigurationServices configurationServices = new ConfigurationServices();

        DataTable dataTable = new DataTable();

        public ConfigManagerForm()
        {
            InitializeComponent();
            //LoadDataGridWithConfig();
        }

        private void mainMenuLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private async void addButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(keyTextBox.Text) && string.IsNullOrEmpty(valueTextBox.Text))
                {
                    MessageBox.Show("Veuillez remplir les champs Clé et Valeur");
                }
                else 
                {
                    if (await configurationServices.AddConfigAsync(keyTextBox.Text, valueTextBox.Text))
                    {
                        MessageBox.Show("Configuration créée");
                    }
                    else 
                    {
                        MessageBox.Show("Configuration non créée");
                    }
                }
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void LoadDataGridWithConfig() 
        {
            try
            {
                dataTable.Columns.Add("Clé");
                dataTable.Columns.Add("Valeur");

                var taskList = configurationServices.GetListConfigAsync();
                taskList.Wait();
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}

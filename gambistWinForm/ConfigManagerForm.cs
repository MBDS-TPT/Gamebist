using gambistWinForm.Models;
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
        ConfigurationServices ConfigurationServices = new ConfigurationServices();

        List<Configuration> ListConfigurations = new List<Configuration>();

        public ConfigManagerForm()
        {
            InitializeComponent();
        }

        private void mainMenuLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private async void addButton_Click(object sender, EventArgs e)
        {
            try
            {
                loadingLabel.Text = "Opération en cours...";
                if (string.IsNullOrEmpty(keyTextBox.Text) && string.IsNullOrEmpty(valueTextBox.Text))
                {
                    MessageBox.Show("Veuillez remplir les champs Clé et Valeur");
                }
                else if (string.IsNullOrEmpty(valueTextBox.Text)) 
                {
                    MessageBox.Show("Veuillez remplir le champs Valeur");
                }
                else if (string.IsNullOrEmpty(keyTextBox.Text))
                {
                    MessageBox.Show("Veuillez remplir le champs Clé");
                }
                else
                {
                    if (await ConfigurationServices.AddConfigAsync(keyTextBox.Text, valueTextBox.Text))
                    {
                        LoadDataGridWithConfig();
                        loadingLabel.Text = "";
                        MessageBox.Show("Configuration créée");
                    }
                    else
                    {
                        MessageBox.Show("Configuration non créée, un problème est survenu");
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
                this.ListConfigurations = ConfigurationServices.GetListConfig();

                dataGridView1.DataSource = this.ListConfigurations;
                dataGridView1.Columns["Id"].Visible = false;
                dataGridView1.ClearSelection();
                dataGridView1.CurrentCell = null;

                updateKeyTextBox.Clear();
                updateValueTextBox.Clear();
                deleteKeySelectedLabel.Text = string.Empty;
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ConfigManagerForm_Shown(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            LoadDataGridWithConfig();
        }

        private async void updateButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.CurrentCell == null)
                {
                    MessageBox.Show("Vous devez sélectionner une ligne");
                }
                else 
                {
                    if (string.IsNullOrEmpty(updateKeyTextBox.Text) && string.IsNullOrEmpty(updateValueTextBox.Text))
                    {
                        MessageBox.Show("Veuillez remplir les champs Clé et Valeur");
                    }
                    else if (string.IsNullOrEmpty(updateValueTextBox.Text))
                    {
                        MessageBox.Show("Veuillez remplir le champs Valeur");
                    }
                    else if (string.IsNullOrEmpty(updateKeyTextBox.Text))
                    {
                        MessageBox.Show("Veuillez remplir le champs Clé");
                    }
                    else
                    {
                        updateLoadingLabel.Text = "Opération en cours...";
                        var configurationSelected = dataGridView1.SelectedRows[0].DataBoundItem as Configuration;
                        configurationSelected.ConfigKey = updateKeyTextBox.Text;
                        configurationSelected.ConfigValue = updateValueTextBox.Text;
                        if (await ConfigurationServices.UpdateConfigAsync(configurationSelected))
                        {
                            LoadDataGridWithConfig();
                            updateLoadingLabel.Text = "";
                            MessageBox.Show("Configuration modifiée");
                        }
                        else
                        {
                            MessageBox.Show("Configuration non modifiée, un problème est survenu");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private async void deleteButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.CurrentCell == null)
                {
                    MessageBox.Show("Vous devez sélectionner une ligne");
                }
                else 
                {
                    deleteLoadingLabel.Text = "Opération en cours...";
                    var configurationSelected = dataGridView1.SelectedRows[0].DataBoundItem as Configuration;
                    if (await ConfigurationServices.DeleteConfigAsync(configurationSelected))
                    {
                        LoadDataGridWithConfig();
                        deleteLoadingLabel.Text = "";
                        MessageBox.Show("Configuration supprimée");
                    }
                    else
                    {
                        MessageBox.Show("Configuration non supprimée, un problème est survenu");
                    }
                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                var configurationSelected = dataGridView1.SelectedRows[0].DataBoundItem as Configuration;

                deleteKeySelectedLabel.Text = "(clé actuellement sélectionnée: " + configurationSelected.ConfigKey + ")";
                updateKeyTextBox.Text = configurationSelected.ConfigKey;
                updateValueTextBox.Text = configurationSelected.ConfigValue;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                this.ListConfigurations = ConfigurationServices.SearchConfigAsync(searchConfigTextBox.Text);

                dataGridView1.DataSource = this.ListConfigurations;
                dataGridView1.Columns["Id"].Visible = false;
                dataGridView1.ClearSelection();
                dataGridView1.CurrentCell = null;

                updateKeyTextBox.Clear();
                updateValueTextBox.Clear();
                deleteKeySelectedLabel.Text = string.Empty;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}

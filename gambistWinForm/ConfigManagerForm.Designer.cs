
namespace gambistWinForm
{
    partial class ConfigManagerForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.addConfigPage = new System.Windows.Forms.TabPage();
            this.updateConfigPage = new System.Windows.Forms.TabPage();
            this.configListPage = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.mainMenuLinkLabel = new System.Windows.Forms.LinkLabel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.keyTextBox = new System.Windows.Forms.TextBox();
            this.valueTextBox = new System.Windows.Forms.TextBox();
            this.addButton = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.addConfigPage.SuspendLayout();
            this.configListPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.configListPage);
            this.tabControl1.Controls.Add(this.addConfigPage);
            this.tabControl1.Controls.Add(this.updateConfigPage);
            this.tabControl1.Location = new System.Drawing.Point(12, 99);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(721, 339);
            this.tabControl1.TabIndex = 0;
            // 
            // addConfigPage
            // 
            this.addConfigPage.Controls.Add(this.addButton);
            this.addConfigPage.Controls.Add(this.valueTextBox);
            this.addConfigPage.Controls.Add(this.keyTextBox);
            this.addConfigPage.Controls.Add(this.label6);
            this.addConfigPage.Controls.Add(this.label5);
            this.addConfigPage.Controls.Add(this.label4);
            this.addConfigPage.Controls.Add(this.label3);
            this.addConfigPage.Location = new System.Drawing.Point(4, 22);
            this.addConfigPage.Name = "addConfigPage";
            this.addConfigPage.Padding = new System.Windows.Forms.Padding(3);
            this.addConfigPage.Size = new System.Drawing.Size(713, 313);
            this.addConfigPage.TabIndex = 0;
            this.addConfigPage.Text = "Ajouter une configuration";
            this.addConfigPage.UseVisualStyleBackColor = true;
            // 
            // updateConfigPage
            // 
            this.updateConfigPage.Location = new System.Drawing.Point(4, 22);
            this.updateConfigPage.Name = "updateConfigPage";
            this.updateConfigPage.Padding = new System.Windows.Forms.Padding(3);
            this.updateConfigPage.Size = new System.Drawing.Size(713, 313);
            this.updateConfigPage.TabIndex = 1;
            this.updateConfigPage.Text = "Modifier une configuration";
            this.updateConfigPage.UseVisualStyleBackColor = true;
            // 
            // configListPage
            // 
            this.configListPage.Controls.Add(this.dataGridView1);
            this.configListPage.Location = new System.Drawing.Point(4, 22);
            this.configListPage.Name = "configListPage";
            this.configListPage.Padding = new System.Windows.Forms.Padding(3);
            this.configListPage.Size = new System.Drawing.Size(713, 313);
            this.configListPage.TabIndex = 2;
            this.configListPage.Text = "Liste des configurations";
            this.configListPage.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Ink Free", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(230, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(325, 39);
            this.label1.TabIndex = 1;
            this.label1.Text = "Gambist Client Lourd";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(258, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Gestion des configurations";
            // 
            // mainMenuLinkLabel
            // 
            this.mainMenuLinkLabel.AutoSize = true;
            this.mainMenuLinkLabel.Location = new System.Drawing.Point(615, 9);
            this.mainMenuLinkLabel.Name = "mainMenuLinkLabel";
            this.mainMenuLinkLabel.Size = new System.Drawing.Size(140, 13);
            this.mainMenuLinkLabel.TabIndex = 3;
            this.mainMenuLinkLabel.TabStop = true;
            this.mainMenuLinkLabel.Text = "Retourner au menu principal";
            this.mainMenuLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.mainMenuLinkLabel_LinkClicked);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 16);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(454, 244);
            this.dataGridView1.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(7, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(168, 15);
            this.label3.TabIndex = 0;
            this.label3.Text = "Ajouter une configuration";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(332, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Veuillez remplir le formulaire ci-dessous pour ajouter une configuration";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 78);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(22, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Clé";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 128);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Valeur";
            // 
            // keyTextBox
            // 
            this.keyTextBox.Location = new System.Drawing.Point(53, 75);
            this.keyTextBox.Name = "keyTextBox";
            this.keyTextBox.Size = new System.Drawing.Size(286, 20);
            this.keyTextBox.TabIndex = 4;
            // 
            // valueTextBox
            // 
            this.valueTextBox.Location = new System.Drawing.Point(53, 125);
            this.valueTextBox.Name = "valueTextBox";
            this.valueTextBox.Size = new System.Drawing.Size(286, 20);
            this.valueTextBox.TabIndex = 5;
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(264, 178);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 23);
            this.addButton.TabIndex = 6;
            this.addButton.Text = "Ajouter";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // ConfigManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(767, 451);
            this.Controls.Add(this.mainMenuLinkLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tabControl1);
            this.MaximizeBox = false;
            this.Name = "ConfigManagerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ConfigManagerForm";
            this.tabControl1.ResumeLayout(false);
            this.addConfigPage.ResumeLayout(false);
            this.addConfigPage.PerformLayout();
            this.configListPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage addConfigPage;
        private System.Windows.Forms.TabPage updateConfigPage;
        private System.Windows.Forms.TabPage configListPage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.LinkLabel mainMenuLinkLabel;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.TextBox valueTextBox;
        private System.Windows.Forms.TextBox keyTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
    }
}
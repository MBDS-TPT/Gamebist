
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
            this.configListPage = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.searchConfigTextBox = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.deleteKeySelectedLabel = new System.Windows.Forms.Label();
            this.deleteLoadingLabel = new System.Windows.Forms.Label();
            this.deleteButton = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.updateLoadingLabel = new System.Windows.Forms.Label();
            this.updateButton = new System.Windows.Forms.Button();
            this.updateValueTextBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.updateKeyTextBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.addConfigPage = new System.Windows.Forms.TabPage();
            this.loadingLabel = new System.Windows.Forms.Label();
            this.addButton = new System.Windows.Forms.Button();
            this.valueTextBox = new System.Windows.Forms.TextBox();
            this.keyTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.mainMenuLinkLabel = new System.Windows.Forms.LinkLabel();
            this.tabControl1.SuspendLayout();
            this.configListPage.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.addConfigPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.configListPage);
            this.tabControl1.Controls.Add(this.addConfigPage);
            this.tabControl1.Location = new System.Drawing.Point(12, 99);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(765, 413);
            this.tabControl1.TabIndex = 0;
            // 
            // configListPage
            // 
            this.configListPage.Controls.Add(this.groupBox3);
            this.configListPage.Controls.Add(this.groupBox2);
            this.configListPage.Controls.Add(this.groupBox1);
            this.configListPage.Controls.Add(this.dataGridView1);
            this.configListPage.Location = new System.Drawing.Point(4, 22);
            this.configListPage.Name = "configListPage";
            this.configListPage.Padding = new System.Windows.Forms.Padding(3);
            this.configListPage.Size = new System.Drawing.Size(757, 387);
            this.configListPage.TabIndex = 2;
            this.configListPage.Text = "Liste des configurations";
            this.configListPage.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.searchButton);
            this.groupBox3.Controls.Add(this.searchConfigTextBox);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(6, 314);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(744, 67);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Rechercher une configuration";
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(609, 33);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(129, 23);
            this.searchButton.TabIndex = 6;
            this.searchButton.Text = "Rechercher";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // searchConfigTextBox
            // 
            this.searchConfigTextBox.Location = new System.Drawing.Point(108, 35);
            this.searchConfigTextBox.Name = "searchConfigTextBox";
            this.searchConfigTextBox.Size = new System.Drawing.Size(495, 20);
            this.searchConfigTextBox.TabIndex = 6;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 38);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(101, 13);
            this.label12.TabIndex = 6;
            this.label12.Text = "Clé à rechercher";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(6, 16);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(288, 13);
            this.label11.TabIndex = 7;
            this.label11.Text = "Rechercher une configuration par rapport à une clé donnée";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.deleteKeySelectedLabel);
            this.groupBox2.Controls.Add(this.deleteLoadingLabel);
            this.groupBox2.Controls.Add(this.deleteButton);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(437, 196);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(314, 112);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Supprimer une configuration";
            // 
            // deleteKeySelectedLabel
            // 
            this.deleteKeySelectedLabel.AutoSize = true;
            this.deleteKeySelectedLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteKeySelectedLabel.Location = new System.Drawing.Point(6, 41);
            this.deleteKeySelectedLabel.Name = "deleteKeySelectedLabel";
            this.deleteKeySelectedLabel.Size = new System.Drawing.Size(0, 13);
            this.deleteKeySelectedLabel.TabIndex = 8;
            // 
            // deleteLoadingLabel
            // 
            this.deleteLoadingLabel.AutoSize = true;
            this.deleteLoadingLabel.Location = new System.Drawing.Point(6, 88);
            this.deleteLoadingLabel.Name = "deleteLoadingLabel";
            this.deleteLoadingLabel.Size = new System.Drawing.Size(0, 13);
            this.deleteLoadingLabel.TabIndex = 7;
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(179, 83);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(129, 23);
            this.deleteButton.TabIndex = 6;
            this.deleteButton.Text = "Supprimer";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(6, 16);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(153, 13);
            this.label10.TabIndex = 6;
            this.label10.Text = "Supprimer la ligne sélectionnée";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.updateLoadingLabel);
            this.groupBox1.Controls.Add(this.updateButton);
            this.groupBox1.Controls.Add(this.updateValueTextBox);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.updateKeyTextBox);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(436, 16);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(315, 173);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Modifier une configuration";
            // 
            // updateLoadingLabel
            // 
            this.updateLoadingLabel.AutoSize = true;
            this.updateLoadingLabel.Location = new System.Drawing.Point(7, 143);
            this.updateLoadingLabel.Name = "updateLoadingLabel";
            this.updateLoadingLabel.Size = new System.Drawing.Size(0, 13);
            this.updateLoadingLabel.TabIndex = 6;
            // 
            // updateButton
            // 
            this.updateButton.Location = new System.Drawing.Point(180, 138);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(129, 23);
            this.updateButton.TabIndex = 5;
            this.updateButton.Text = "Modifier";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // updateValueTextBox
            // 
            this.updateValueTextBox.Location = new System.Drawing.Point(10, 112);
            this.updateValueTextBox.Name = "updateValueTextBox";
            this.updateValueTextBox.Size = new System.Drawing.Size(299, 20);
            this.updateValueTextBox.TabIndex = 4;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(7, 96);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(43, 13);
            this.label9.TabIndex = 3;
            this.label9.Text = "Valeur";
            // 
            // updateKeyTextBox
            // 
            this.updateKeyTextBox.Location = new System.Drawing.Point(10, 59);
            this.updateKeyTextBox.Name = "updateKeyTextBox";
            this.updateKeyTextBox.Size = new System.Drawing.Size(299, 20);
            this.updateKeyTextBox.TabIndex = 2;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(7, 42);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(25, 13);
            this.label8.TabIndex = 1;
            this.label8.Text = "Clé";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(7, 20);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(239, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Sélectionner une ligne du tableau pour la modifier";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 16);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(424, 292);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // addConfigPage
            // 
            this.addConfigPage.Controls.Add(this.loadingLabel);
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
            this.addConfigPage.Size = new System.Drawing.Size(757, 387);
            this.addConfigPage.TabIndex = 0;
            this.addConfigPage.Text = "Ajouter une configuration";
            this.addConfigPage.UseVisualStyleBackColor = true;
            // 
            // loadingLabel
            // 
            this.loadingLabel.AutoSize = true;
            this.loadingLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loadingLabel.Location = new System.Drawing.Point(394, 104);
            this.loadingLabel.Name = "loadingLabel";
            this.loadingLabel.Size = new System.Drawing.Size(0, 20);
            this.loadingLabel.TabIndex = 7;
            // 
            // addButton
            // 
            this.addButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addButton.Location = new System.Drawing.Point(221, 178);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(118, 23);
            this.addButton.TabIndex = 6;
            this.addButton.Text = "Ajouter";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // valueTextBox
            // 
            this.valueTextBox.Location = new System.Drawing.Point(53, 125);
            this.valueTextBox.Name = "valueTextBox";
            this.valueTextBox.Size = new System.Drawing.Size(286, 20);
            this.valueTextBox.TabIndex = 5;
            // 
            // keyTextBox
            // 
            this.keyTextBox.Location = new System.Drawing.Point(53, 75);
            this.keyTextBox.Name = "keyTextBox";
            this.keyTextBox.Size = new System.Drawing.Size(286, 20);
            this.keyTextBox.TabIndex = 4;
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
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 78);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(22, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Clé";
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
            this.mainMenuLinkLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainMenuLinkLabel.Location = new System.Drawing.Point(610, 9);
            this.mainMenuLinkLabel.Name = "mainMenuLinkLabel";
            this.mainMenuLinkLabel.Size = new System.Drawing.Size(167, 13);
            this.mainMenuLinkLabel.TabIndex = 3;
            this.mainMenuLinkLabel.TabStop = true;
            this.mainMenuLinkLabel.Text = "Retourner au menu principal";
            this.mainMenuLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.mainMenuLinkLabel_LinkClicked);
            // 
            // ConfigManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(789, 524);
            this.Controls.Add(this.mainMenuLinkLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tabControl1);
            this.MaximizeBox = false;
            this.Name = "ConfigManagerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ConfigManagerForm";
            this.Shown += new System.EventHandler(this.ConfigManagerForm_Shown);
            this.tabControl1.ResumeLayout(false);
            this.configListPage.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.addConfigPage.ResumeLayout(false);
            this.addConfigPage.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage addConfigPage;
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
        private System.Windows.Forms.Label loadingLabel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.TextBox searchConfigTextBox;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.TextBox updateValueTextBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox updateKeyTextBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label deleteLoadingLabel;
        private System.Windows.Forms.Label updateLoadingLabel;
        private System.Windows.Forms.Label deleteKeySelectedLabel;
    }
}
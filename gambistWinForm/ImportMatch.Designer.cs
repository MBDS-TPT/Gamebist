
namespace gambistWinForm
{
    partial class ImportMatch
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
            this.label1 = new System.Windows.Forms.Label();
            this.importButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.matchGridView = new System.Windows.Forms.DataGridView();
            this.saveButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.mainMenuLinkLabel = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.matchGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Ink Free", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(325, 39);
            this.label1.TabIndex = 1;
            this.label1.Text = "Gambist Client Lourd";
            // 
            // importButton
            // 
            this.importButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.importButton.Location = new System.Drawing.Point(591, 192);
            this.importButton.Name = "importButton";
            this.importButton.Size = new System.Drawing.Size(210, 22);
            this.importButton.TabIndex = 2;
            this.importButton.Text = "Importer le fichier de match";
            this.importButton.UseVisualStyleBackColor = true;
            this.importButton.Click += new System.EventHandler(this.importButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(219, 18);
            this.label2.TabIndex = 4;
            this.label2.Text = "Importer un fichier de match";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(789, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Saisissez le chemin physique du dossier à importer (vous pouvez aussi le sélectio" +
    "nner dans l\'explorateur de fichier en utilisant le bouton \"Rechercher dans les f" +
    "ichiers\")";
            // 
            // searchTextBox
            // 
            this.searchTextBox.Location = new System.Drawing.Point(15, 166);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(570, 20);
            this.searchTextBox.TabIndex = 6;
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(591, 164);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(210, 23);
            this.searchButton.TabIndex = 7;
            this.searchButton.Text = "Rechercher dans les fichiers";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // matchGridView
            // 
            this.matchGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.matchGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.matchGridView.Location = new System.Drawing.Point(15, 192);
            this.matchGridView.Name = "matchGridView";
            this.matchGridView.Size = new System.Drawing.Size(570, 277);
            this.matchGridView.TabIndex = 8;
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(591, 446);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(210, 23);
            this.saveButton.TabIndex = 9;
            this.saveButton.Text = "Sauvegarder les données importées";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(577, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Si les données chargées sont conformes au modèle des matches, ces données vont s\'" +
    "afficher dans le tableau ci-dessous";
            // 
            // mainMenuLinkLabel
            // 
            this.mainMenuLinkLabel.AutoSize = true;
            this.mainMenuLinkLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainMenuLinkLabel.Location = new System.Drawing.Point(643, 9);
            this.mainMenuLinkLabel.Name = "mainMenuLinkLabel";
            this.mainMenuLinkLabel.Size = new System.Drawing.Size(167, 13);
            this.mainMenuLinkLabel.TabIndex = 11;
            this.mainMenuLinkLabel.TabStop = true;
            this.mainMenuLinkLabel.Text = "Retourner au menu principal";
            this.mainMenuLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.mainMenuLinkLabel_LinkClicked);
            // 
            // ImportMatch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(822, 481);
            this.Controls.Add(this.mainMenuLinkLabel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.matchGridView);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.searchTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.importButton);
            this.Controls.Add(this.label1);
            this.Name = "ImportMatch";
            this.Text = "ImportMatch";
            ((System.ComponentModel.ISupportInitialize)(this.matchGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button importButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox searchTextBox;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.DataGridView matchGridView;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.LinkLabel mainMenuLinkLabel;
    }
}
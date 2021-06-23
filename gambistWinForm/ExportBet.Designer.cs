
namespace gambistWinForm
{
    partial class ExportBet
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.exportButton = new System.Windows.Forms.Button();
            this.exportDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.exportPathTextBox = new System.Windows.Forms.TextBox();
            this.exportPathButton = new System.Windows.Forms.Button();
            this.mainMenuLinkLabel = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Ink Free", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(325, 39);
            this.label1.TabIndex = 2;
            this.label1.Text = "Gambist Client Lourd";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(262, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "Exporter les paris d\'un jour donné";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(631, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Choisissez la date pour laquelle vous souhaitez exporter les paris, ainsi que le " +
    "chemin du dossier où vous souhaitez exporter les paris:";
            // 
            // exportButton
            // 
            this.exportButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exportButton.Location = new System.Drawing.Point(16, 286);
            this.exportButton.Name = "exportButton";
            this.exportButton.Size = new System.Drawing.Size(227, 42);
            this.exportButton.TabIndex = 6;
            this.exportButton.Text = "Exporter les paris";
            this.exportButton.UseVisualStyleBackColor = true;
            this.exportButton.Click += new System.EventHandler(this.exportButton_Click);
            // 
            // exportDateTimePicker
            // 
            this.exportDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.exportDateTimePicker.Location = new System.Drawing.Point(16, 191);
            this.exportDateTimePicker.Name = "exportDateTimePicker";
            this.exportDateTimePicker.Size = new System.Drawing.Size(104, 20);
            this.exportDateTimePicker.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 175);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Date";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 218);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Chemin d\'exportation";
            // 
            // exportPathTextBox
            // 
            this.exportPathTextBox.Location = new System.Drawing.Point(16, 235);
            this.exportPathTextBox.Name = "exportPathTextBox";
            this.exportPathTextBox.Size = new System.Drawing.Size(360, 20);
            this.exportPathTextBox.TabIndex = 10;
            // 
            // exportPathButton
            // 
            this.exportPathButton.Location = new System.Drawing.Point(382, 233);
            this.exportPathButton.Name = "exportPathButton";
            this.exportPathButton.Size = new System.Drawing.Size(242, 23);
            this.exportPathButton.TabIndex = 11;
            this.exportPathButton.Text = "Rechercher avec l\'explorateur de fichier";
            this.exportPathButton.UseVisualStyleBackColor = true;
            this.exportPathButton.Click += new System.EventHandler(this.exportPathButton_Click);
            // 
            // mainMenuLinkLabel
            // 
            this.mainMenuLinkLabel.AutoSize = true;
            this.mainMenuLinkLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainMenuLinkLabel.Location = new System.Drawing.Point(477, 9);
            this.mainMenuLinkLabel.Name = "mainMenuLinkLabel";
            this.mainMenuLinkLabel.Size = new System.Drawing.Size(167, 13);
            this.mainMenuLinkLabel.TabIndex = 12;
            this.mainMenuLinkLabel.TabStop = true;
            this.mainMenuLinkLabel.Text = "Retourner au menu principal";
            this.mainMenuLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.mainMenuLinkLabel_LinkClicked);
            // 
            // ExportBet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(654, 340);
            this.Controls.Add(this.mainMenuLinkLabel);
            this.Controls.Add(this.exportPathButton);
            this.Controls.Add(this.exportPathTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.exportDateTimePicker);
            this.Controls.Add(this.exportButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "ExportBet";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ExportBet";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button exportButton;
        private System.Windows.Forms.DateTimePicker exportDateTimePicker;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox exportPathTextBox;
        private System.Windows.Forms.Button exportPathButton;
        private System.Windows.Forms.LinkLabel mainMenuLinkLabel;
    }
}
namespace Elysium_Aube_Manage_Raid_App
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLbl = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tabControlMain = new System.Windows.Forms.TabControl();
            this.tabMain = new System.Windows.Forms.TabPage();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxFeuilleGoogle = new System.Windows.Forms.TextBox();
            this.checkBoxUploadDataOnline = new System.Windows.Forms.CheckBox();
            this.listViewEventsList = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.buttonLoadLUAFile = new System.Windows.Forms.Button();
            this.listBoxDetailsEvent = new System.Windows.Forms.ListView();
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.buttonExtractEvent = new System.Windows.Forms.Button();
            this.TabXtraUnitConv = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxSheetCName = new System.Windows.Forms.TextBox();
            this.comboBoxRaidReadingData = new System.Windows.Forms.ComboBox();
            this.buttonConvData = new System.Windows.Forms.Button();
            this.richTextBoxResult = new System.Windows.Forms.RichTextBox();
            this.tabConfig = new System.Windows.Forms.TabPage();
            this.buttonLoadFilePath = new System.Windows.Forms.Button();
            this.buttonSaveConfig = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxSeparatorPattern = new System.Windows.Forms.TextBox();
            this.textBoxPathFile = new System.Windows.Forms.TextBox();
            this.statusStrip1.SuspendLayout();
            this.tabControlMain.SuspendLayout();
            this.tabMain.SuspendLayout();
            this.TabXtraUnitConv.SuspendLayout();
            this.tabConfig.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripStatusLbl,
            this.toolStripStatusLabel3});
            this.statusStrip1.Location = new System.Drawing.Point(0, 362);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(536, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(36, 17);
            this.toolStripStatusLabel1.Text = "Etat : ";
            // 
            // toolStripStatusLbl
            // 
            this.toolStripStatusLbl.Name = "toolStripStatusLbl";
            this.toolStripStatusLbl.Size = new System.Drawing.Size(29, 17);
            this.toolStripStatusLbl.Text = "N/A";
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripStatusLabel3.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(425, 17);
            this.toolStripStatusLabel3.Spring = true;
            this.toolStripStatusLabel3.Text = "v2.5";
            this.toolStripStatusLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tabControlMain
            // 
            this.tabControlMain.Controls.Add(this.tabMain);
            this.tabControlMain.Controls.Add(this.TabXtraUnitConv);
            this.tabControlMain.Controls.Add(this.tabConfig);
            this.tabControlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlMain.Location = new System.Drawing.Point(0, 0);
            this.tabControlMain.Name = "tabControlMain";
            this.tabControlMain.SelectedIndex = 0;
            this.tabControlMain.Size = new System.Drawing.Size(536, 362);
            this.tabControlMain.TabIndex = 1;
            // 
            // tabMain
            // 
            this.tabMain.Controls.Add(this.label4);
            this.tabMain.Controls.Add(this.textBoxFeuilleGoogle);
            this.tabMain.Controls.Add(this.checkBoxUploadDataOnline);
            this.tabMain.Controls.Add(this.listViewEventsList);
            this.tabMain.Controls.Add(this.buttonLoadLUAFile);
            this.tabMain.Controls.Add(this.listBoxDetailsEvent);
            this.tabMain.Controls.Add(this.buttonExtractEvent);
            this.tabMain.Location = new System.Drawing.Point(4, 22);
            this.tabMain.Name = "tabMain";
            this.tabMain.Padding = new System.Windows.Forms.Padding(3);
            this.tabMain.Size = new System.Drawing.Size(528, 336);
            this.tabMain.TabIndex = 0;
            this.tabMain.Text = "Extraction des Données";
            this.tabMain.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(113, 264);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(156, 13);
            this.label4.TabIndex = 129;
            this.label4.Text = "Nom de la Feuille Docs.Google:";
            // 
            // textBoxFeuilleGoogle
            // 
            this.textBoxFeuilleGoogle.Location = new System.Drawing.Point(275, 261);
            this.textBoxFeuilleGoogle.Name = "textBoxFeuilleGoogle";
            this.textBoxFeuilleGoogle.Size = new System.Drawing.Size(146, 20);
            this.textBoxFeuilleGoogle.TabIndex = 128;
            // 
            // checkBoxUploadDataOnline
            // 
            this.checkBoxUploadDataOnline.AutoSize = true;
            this.checkBoxUploadDataOnline.Checked = true;
            this.checkBoxUploadDataOnline.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxUploadDataOnline.Location = new System.Drawing.Point(427, 263);
            this.checkBoxUploadDataOnline.Name = "checkBoxUploadDataOnline";
            this.checkBoxUploadDataOnline.Size = new System.Drawing.Size(93, 17);
            this.checkBoxUploadDataOnline.TabIndex = 127;
            this.checkBoxUploadDataOnline.Text = "Upload Online";
            this.checkBoxUploadDataOnline.UseVisualStyleBackColor = true;
            // 
            // listViewEventsList
            // 
            this.listViewEventsList.BackColor = System.Drawing.Color.White;
            this.listViewEventsList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.listViewEventsList.ForeColor = System.Drawing.Color.Black;
            this.listViewEventsList.FullRowSelect = true;
            this.listViewEventsList.GridLines = true;
            this.listViewEventsList.HideSelection = false;
            this.listViewEventsList.Location = new System.Drawing.Point(12, 6);
            this.listViewEventsList.MultiSelect = false;
            this.listViewEventsList.Name = "listViewEventsList";
            this.listViewEventsList.Size = new System.Drawing.Size(508, 136);
            this.listViewEventsList.TabIndex = 126;
            this.listViewEventsList.UseCompatibleStateImageBehavior = false;
            this.listViewEventsList.View = System.Windows.Forms.View.Details;
            this.listViewEventsList.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.listViewEventsList_ColumnClick);
            this.listViewEventsList.SelectedIndexChanged += new System.EventHandler(this.listViewEventsList_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ID";
            this.columnHeader1.Width = 50;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Nom de l\'Event";
            this.columnHeader2.Width = 170;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Date";
            this.columnHeader3.Width = 150;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Inscrits";
            this.columnHeader4.Width = 50;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Commentaire";
            this.columnHeader5.Width = 80;
            // 
            // buttonLoadLUAFile
            // 
            this.buttonLoadLUAFile.BackColor = System.Drawing.Color.WhiteSmoke;
            this.buttonLoadLUAFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLoadLUAFile.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonLoadLUAFile.Location = new System.Drawing.Point(8, 287);
            this.buttonLoadLUAFile.Name = "buttonLoadLUAFile";
            this.buttonLoadLUAFile.Size = new System.Drawing.Size(204, 42);
            this.buttonLoadLUAFile.TabIndex = 3;
            this.buttonLoadLUAFile.Text = "Charger/Recharger le Fichier";
            this.buttonLoadLUAFile.UseVisualStyleBackColor = false;
            this.buttonLoadLUAFile.Click += new System.EventHandler(this.buttonLoadEvents_Click);
            // 
            // listBoxDetailsEvent
            // 
            this.listBoxDetailsEvent.BackColor = System.Drawing.Color.White;
            this.listBoxDetailsEvent.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8});
            this.listBoxDetailsEvent.ForeColor = System.Drawing.Color.Black;
            this.listBoxDetailsEvent.FullRowSelect = true;
            this.listBoxDetailsEvent.GridLines = true;
            this.listBoxDetailsEvent.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listBoxDetailsEvent.HideSelection = false;
            this.listBoxDetailsEvent.Location = new System.Drawing.Point(91, 148);
            this.listBoxDetailsEvent.Name = "listBoxDetailsEvent";
            this.listBoxDetailsEvent.Size = new System.Drawing.Size(340, 104);
            this.listBoxDetailsEvent.TabIndex = 125;
            this.listBoxDetailsEvent.UseCompatibleStateImageBehavior = false;
            this.listBoxDetailsEvent.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Place";
            this.columnHeader6.Width = 50;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Pseudo";
            this.columnHeader7.Width = 170;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Classe";
            this.columnHeader8.Width = 97;
            // 
            // buttonExtractEvent
            // 
            this.buttonExtractEvent.BackColor = System.Drawing.Color.WhiteSmoke;
            this.buttonExtractEvent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonExtractEvent.ForeColor = System.Drawing.SystemColors.Highlight;
            this.buttonExtractEvent.Location = new System.Drawing.Point(223, 287);
            this.buttonExtractEvent.Name = "buttonExtractEvent";
            this.buttonExtractEvent.Size = new System.Drawing.Size(302, 42);
            this.buttonExtractEvent.TabIndex = 1;
            this.buttonExtractEvent.Text = "Extraire en .txt l\'Event";
            this.buttonExtractEvent.UseVisualStyleBackColor = false;
            this.buttonExtractEvent.Click += new System.EventHandler(this.buttonExtractEvent_Click);
            // 
            // TabXtraUnitConv
            // 
            this.TabXtraUnitConv.Controls.Add(this.label3);
            this.TabXtraUnitConv.Controls.Add(this.textBoxSheetCName);
            this.TabXtraUnitConv.Controls.Add(this.comboBoxRaidReadingData);
            this.TabXtraUnitConv.Controls.Add(this.buttonConvData);
            this.TabXtraUnitConv.Controls.Add(this.richTextBoxResult);
            this.TabXtraUnitConv.Location = new System.Drawing.Point(4, 22);
            this.TabXtraUnitConv.Name = "TabXtraUnitConv";
            this.TabXtraUnitConv.Size = new System.Drawing.Size(528, 336);
            this.TabXtraUnitConv.TabIndex = 2;
            this.TabXtraUnitConv.Text = "Converter XtraUnitFrame";
            this.TabXtraUnitConv.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(196, 219);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(156, 13);
            this.label3.TabIndex = 131;
            this.label3.Text = "Nom de la Feuille Docs.Google:";
            // 
            // textBoxSheetCName
            // 
            this.textBoxSheetCName.Location = new System.Drawing.Point(354, 216);
            this.textBoxSheetCName.Name = "textBoxSheetCName";
            this.textBoxSheetCName.Size = new System.Drawing.Size(146, 20);
            this.textBoxSheetCName.TabIndex = 130;
            // 
            // comboBoxRaidReadingData
            // 
            this.comboBoxRaidReadingData.FormattingEnabled = true;
            this.comboBoxRaidReadingData.Items.AddRange(new object[] {
            "BWL",
            "MC Raid Jeudi",
            "MC Raid Dimanche"});
            this.comboBoxRaidReadingData.Location = new System.Drawing.Point(26, 216);
            this.comboBoxRaidReadingData.Name = "comboBoxRaidReadingData";
            this.comboBoxRaidReadingData.Size = new System.Drawing.Size(163, 21);
            this.comboBoxRaidReadingData.TabIndex = 6;
            this.comboBoxRaidReadingData.SelectedIndexChanged += new System.EventHandler(this.comboBoxRaidReadingData_SelectedIndexChanged);
            // 
            // buttonConvData
            // 
            this.buttonConvData.BackColor = System.Drawing.Color.WhiteSmoke;
            this.buttonConvData.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonConvData.ForeColor = System.Drawing.SystemColors.Highlight;
            this.buttonConvData.Location = new System.Drawing.Point(59, 261);
            this.buttonConvData.Name = "buttonConvData";
            this.buttonConvData.Size = new System.Drawing.Size(398, 66);
            this.buttonConvData.TabIndex = 2;
            this.buttonConvData.Text = "Recuperer & Convertir les AssistHeal";
            this.buttonConvData.UseVisualStyleBackColor = false;
            this.buttonConvData.Click += new System.EventHandler(this.buttonConvData_Click);
            // 
            // richTextBoxResult
            // 
            this.richTextBoxResult.Location = new System.Drawing.Point(26, 10);
            this.richTextBoxResult.Name = "richTextBoxResult";
            this.richTextBoxResult.Size = new System.Drawing.Size(474, 200);
            this.richTextBoxResult.TabIndex = 1;
            this.richTextBoxResult.Text = "";
            // 
            // tabConfig
            // 
            this.tabConfig.Controls.Add(this.buttonLoadFilePath);
            this.tabConfig.Controls.Add(this.buttonSaveConfig);
            this.tabConfig.Controls.Add(this.label2);
            this.tabConfig.Controls.Add(this.label1);
            this.tabConfig.Controls.Add(this.textBoxSeparatorPattern);
            this.tabConfig.Controls.Add(this.textBoxPathFile);
            this.tabConfig.Location = new System.Drawing.Point(4, 22);
            this.tabConfig.Name = "tabConfig";
            this.tabConfig.Padding = new System.Windows.Forms.Padding(3);
            this.tabConfig.Size = new System.Drawing.Size(528, 336);
            this.tabConfig.TabIndex = 1;
            this.tabConfig.Text = "Préférences";
            this.tabConfig.UseVisualStyleBackColor = true;
            // 
            // buttonLoadFilePath
            // 
            this.buttonLoadFilePath.BackColor = System.Drawing.Color.WhiteSmoke;
            this.buttonLoadFilePath.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLoadFilePath.Location = new System.Drawing.Point(374, 78);
            this.buttonLoadFilePath.Name = "buttonLoadFilePath";
            this.buttonLoadFilePath.Size = new System.Drawing.Size(76, 21);
            this.buttonLoadFilePath.TabIndex = 5;
            this.buttonLoadFilePath.Text = "Choisir";
            this.buttonLoadFilePath.UseVisualStyleBackColor = false;
            this.buttonLoadFilePath.Click += new System.EventHandler(this.buttonLoadFilePath_Click);
            // 
            // buttonSaveConfig
            // 
            this.buttonSaveConfig.BackColor = System.Drawing.Color.WhiteSmoke;
            this.buttonSaveConfig.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSaveConfig.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.buttonSaveConfig.Location = new System.Drawing.Point(33, 197);
            this.buttonSaveConfig.Name = "buttonSaveConfig";
            this.buttonSaveConfig.Size = new System.Drawing.Size(459, 119);
            this.buttonSaveConfig.TabIndex = 4;
            this.buttonSaveConfig.Text = "Sauvegarder";
            this.buttonSaveConfig.UseVisualStyleBackColor = false;
            this.buttonSaveConfig.Click += new System.EventHandler(this.buttonSaveConfig_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(234, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Separateur";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(174, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Emplacement de la sauvegarde GEM";
            // 
            // textBoxSeparatorPattern
            // 
            this.textBoxSeparatorPattern.Location = new System.Drawing.Point(235, 146);
            this.textBoxSeparatorPattern.Name = "textBoxSeparatorPattern";
            this.textBoxSeparatorPattern.Size = new System.Drawing.Size(56, 20);
            this.textBoxSeparatorPattern.TabIndex = 1;
            this.textBoxSeparatorPattern.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxPathFile
            // 
            this.textBoxPathFile.Location = new System.Drawing.Point(154, 78);
            this.textBoxPathFile.Name = "textBoxPathFile";
            this.textBoxPathFile.Size = new System.Drawing.Size(214, 20);
            this.textBoxPathFile.TabIndex = 0;
            this.textBoxPathFile.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(536, 384);
            this.Controls.Add(this.tabControlMain);
            this.Controls.Add(this.statusStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Elysium Aube Manage Raid\'App";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.tabControlMain.ResumeLayout(false);
            this.tabMain.ResumeLayout(false);
            this.tabMain.PerformLayout();
            this.TabXtraUnitConv.ResumeLayout(false);
            this.TabXtraUnitConv.PerformLayout();
            this.tabConfig.ResumeLayout(false);
            this.tabConfig.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.TabControl tabControlMain;
        private System.Windows.Forms.TabPage tabMain;
        private System.Windows.Forms.Button buttonLoadLUAFile;
        private System.Windows.Forms.Button buttonExtractEvent;
        private System.Windows.Forms.TabPage tabConfig;
        private System.Windows.Forms.Button buttonSaveConfig;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxSeparatorPattern;
        private System.Windows.Forms.TextBox textBoxPathFile;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLbl;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        private System.Windows.Forms.Button buttonLoadFilePath;
        private System.Windows.Forms.ListView listBoxDetailsEvent;
        private System.Windows.Forms.ListView listViewEventsList;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.TabPage TabXtraUnitConv;
        private System.Windows.Forms.Button buttonConvData;
        private System.Windows.Forms.RichTextBox richTextBoxResult;
        private System.Windows.Forms.CheckBox checkBoxUploadDataOnline;
        private System.Windows.Forms.ComboBox comboBoxRaidReadingData;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxFeuilleGoogle;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxSheetCName;
    }
}


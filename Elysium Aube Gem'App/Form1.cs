using System;
using System.Windows.Forms;
using LsonLib;

namespace Elysium_Aube_Manage_Raid_App
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.FilePath == String.Empty)
                tabControlMain.SelectedTab = tabConfig;

            textBoxPathFile.Text = Properties.Settings.Default.FilePath;
            textBoxSeparatorPattern.Text = Properties.Settings.Default.SeparatorPattern;

            comboBoxRaidReadingData.SelectedIndex = 0;

            try
            {
                if (Properties.Settings.Default.FilePath != String.Empty)
                {
                    buttonLoadLUAFile.PerformClick();
                }
            }
            catch { }
        }

        String[] RaidSheetName = { "Raid BWL [Choisir]", "Raid MC Jeudi [Choisir]", "Raid MC Dimanche [Choisir]" };

        #region Config Tab
        //Setting File Path
        private void buttonLoadFilePath_Click(object sender, EventArgs e)
        {
            OpenFileDialog OpenFileDialogPath = new OpenFileDialog();
            OpenFileDialogPath.Filter = "GuildEventManager2 (GuildEventManager2.lua)|GuildEventManager2.lua";
            OpenFileDialogPath.FilterIndex = 2;

            if (OpenFileDialogPath.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    if (OpenFileDialogPath.OpenFile() != null)
                    {
                        textBoxPathFile.Text = OpenFileDialogPath.FileName;
                        toolStripStatusLbl.Text = "Emplacement Séléctionné";
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erreur: Impossible de lire le fichier. Erreur: " + ex.Message);
                }
            }
        }
        //Save Configs
        private void buttonSaveConfig_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.FilePath = textBoxPathFile.Text;
            Properties.Settings.Default.SeparatorPattern = textBoxSeparatorPattern.Text;
            Properties.Settings.Default.Save();
            toolStripStatusLbl.Text = "Préférences Sauvegarder.";
        }

        #endregion
        #region MainTab
        //Load/Reload LUA File
        private void buttonLoadEvents_Click(object sender, EventArgs e)
        {
            try
            {
                listViewEventsList.Items.Clear();
                listViewEventsList.BeginUpdate();
                Int32 Index = 0;
                foreach (var de in FuncsLib.dump["GEM_Events"]["realms"]["Elysium"]["events"].GetDict())
                {
                    String EId = de.Key.ToString().Replace("\"", "");
                    ListViewItem Items;
                    Items = new ListViewItem();
                    Items.Text = (EId);
                    Items.SubItems.Add(FuncsLib.dump["GEM_Events"]["realms"]["Elysium"]["events"].Safe[EId]["ev_place"].GetString());
                    Items.SubItems.Add(FuncsLib.UnixTimeStampToDateTime(FuncsLib.dump["GEM_Events"]["realms"]["Elysium"]["events"].Safe[EId]["ev_date"].GetInt()));
                    Items.SubItems.Add(FuncsLib.dump["GEM_Events"]["realms"]["Elysium"]["events"].Safe[EId]["titular_count"].GetStringLenient());
                    Items.SubItems.Add(FuncsLib.dump["GEM_Events"]["realms"]["Elysium"]["events"].Safe[EId]["ev_comment"].GetString());
                    listViewEventsList.Items.Add(Items);

                    Index++;
                }
                listViewEventsList.EndUpdate();

                FuncsLib.SortLVEvent(listViewEventsList, 2);
                toolStripStatusLbl.Text = "Liste des Events Chargé.";
            }
            catch { toolStripStatusLbl.Text = "Erreur, Impossible de charger le fichier LUA."; }
        }
        //Show Events Infos Trigger
        private void listViewEventsList_SelectedIndexChanged(object sender, EventArgs e)
        {
            FuncsLib.GetListViewSelectedIndex(listViewEventsList);

            for (int ev = 0; ev < listViewEventsList.Items.Count; ev++)
            {
                if (listViewEventsList.Items[ev].Selected == true)
                {
                    listBoxDetailsEvent.Items.Clear();
                    listBoxDetailsEvent.BeginUpdate();
                    Int32 Index = 0;
                    for (Int32 i = 1; i <= FuncsLib.dump["GEM_Events"]["realms"]["Elysium"]["events"][listViewEventsList.Items[ev].Text]["titulars"].Count; i++)
                    {
                        if (GetStringPlayerInfoLUA(i, "name").ToString() != null)
                        {
                            String RaidName = FuncsLib.dump["GEM_Events"]["realms"]["Elysium"]["events"][listViewEventsList.Items[FuncsLib.EventSelected].Text]["ev_place"].GetString();
                            ListViewItem Items;
                            Items = new ListViewItem();
                            Items.Text = "P" + i.ToString();
                            Items.SubItems.Add(GetStringPlayerInfoLUA(i, "name"));
                            Items.SubItems.Add(GetStringPlayerInfoLUA(i, "class"));
                            listBoxDetailsEvent.Items.Add(Items);
                            toolStripStatusLbl.Text = "Evenement: [" + RaidName + "] Chargé.";
                            if (RaidName.Contains("Molten") || RaidName.Contains("R1"))
                                textBoxFeuilleGoogle.Text = "Inscription GEM MC Jeudi [BaseDonnée]";
                            if (RaidName.Contains("Molten") && RaidName.Contains("R2"))
                                textBoxFeuilleGoogle.Text = "Inscription GEM MC Dimanche [BaseDonnée]";
                            else if (RaidName.Contains("Blackwing") || RaidName.Contains("BWL") || RaidName.Contains("Repaire"))
                                textBoxFeuilleGoogle.Text = "Inscription GEM BWL [BaseDonnée]";
                            else if (RaidName.Contains("Zul") || RaidName.Contains("ZG"))
                                textBoxFeuilleGoogle.Text = "Inscription GEM ZG [BaseDonnée]";
                            Index++;
                        }
                    }
                    listBoxDetailsEvent.EndUpdate();
                }
            }
        }
        //Extract Data to .txt
        private void buttonExtractEvent_Click(object sender, EventArgs e)
        {
            String[] lines = { };
            String PlayerPlace;
            if (!checkBoxUploadDataOnline.Checked)
            {
                if (listBoxDetailsEvent.Items.Count <= 0)
                    toolStripStatusLbl.Text = "Vous devez d'abord séléctionner un Evement dans la liste.";
                else
                {
                    for (Int32 i = 1; i <= FuncsLib.dump["GEM_Events"]["realms"]["Elysium"]["events"][listViewEventsList.Items[FuncsLib.EventSelected].Text]["titulars"].Count; i++)
                    {
                        if (GetStringPlayerInfoLUA(i, "name").ToString() != null)
                        {
                            if ((int)i <= 9)
                                PlayerPlace = "P0" + i.ToString();
                            else
                                PlayerPlace = "P" + i.ToString();
                            Array.Resize(ref lines, lines.Length + 1);
                            lines[lines.Length - 1] = PlayerPlace + Properties.Settings.Default.SeparatorPattern + GetStringPlayerInfoLUA(i, "name");
                        }
                    }
                    for (Int32 f = FuncsLib.dump["GEM_Events"]["realms"]["Elysium"]["events"][listViewEventsList.Items[FuncsLib.EventSelected].Text]["titular_count"].GetInt(); f <= 100; f++)
                    {
                        Array.Resize(ref lines, lines.Length + 1);
                        lines[lines.Length - 1] = Properties.Settings.Default.SeparatorPattern;
                    }

                    System.IO.File.WriteAllLines(AppDomain.CurrentDomain.BaseDirectory + "ExtractionEventGEM.txt", lines);
                    toolStripStatusLbl.Text = "Les données ont été extraites en fichier .txt.";
                }
            }
            else
            {
                GoogleSheetLib.PlayerNum.Clear();
                GoogleSheetLib.PlayerName.Clear();
                if (listBoxDetailsEvent.Items.Count <= 0)
                    toolStripStatusLbl.Text = "Vous devez d'abord séléctionner un Evement dans la liste.";
                else
                {
                    for (Int32 i = 1; i <= FuncsLib.dump["GEM_Events"]["realms"]["Elysium"]["events"][listViewEventsList.Items[FuncsLib.EventSelected].Text]["titulars"].Count; i++)
                    {
                        if (GetStringPlayerInfoLUA(i, "name").ToString() != null)
                        {
                            if ((int)i <= 9)
                                PlayerPlace = "P0" + i.ToString();
                            else
                                PlayerPlace = "P" + i.ToString();
                            GoogleSheetLib.PlayerNum.Add(PlayerPlace);
                            GoogleSheetLib.PlayerName.Add(GetStringPlayerInfoLUA(i, "name"));
                        }
                    }
                    for (Int32 f = FuncsLib.dump["GEM_Events"]["realms"]["Elysium"]["events"][listViewEventsList.Items[FuncsLib.EventSelected].Text]["titular_count"].GetInt(); f <= 100; f++)
                    {
                        GoogleSheetLib.PlayerNum.Add("");
                        GoogleSheetLib.PlayerName.Add("");
                    }
                    try
                    {
                        GoogleSheetLib.SendDataPlayerSub(GoogleSheetLib.ReturnValArray(GoogleSheetLib.PlayerNum), textBoxFeuilleGoogle.Text + "!A3");
                        GoogleSheetLib.SendDataPlayerSub(GoogleSheetLib.ReturnValArray(GoogleSheetLib.PlayerName), textBoxFeuilleGoogle.Text + "!B3");
                        toolStripStatusLbl.Text = "Les données ont été Upload sur le Docs.Google.";
                    }
                    catch { toolStripStatusLbl.Text = "Erreur(s) lors de l'envoie des Données sur le Docs.Google."; }
                }
            }
        }
        //TriggerColumnClick Sort
        private void listViewEventsList_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            try
            {
                if (e.Column != FuncsLib.sortColumn)
                {
                    FuncsLib.sortColumn = e.Column;
                    listViewEventsList.Sorting = SortOrder.Ascending;
                }
                else
                {
                    if (listViewEventsList.Sorting == SortOrder.Ascending)
                        listViewEventsList.Sorting = SortOrder.Descending;
                    else
                        listViewEventsList.Sorting = SortOrder.Ascending;
                }
                listViewEventsList.Sort();
                this.listViewEventsList.ListViewItemSorter = new FuncsLib.ListViewItemComparer(e.Column,
                                                                  listViewEventsList.Sorting);
            }
            catch { }
        }
        #endregion
        #region FuncsLUA
        //Get Info about Player Sub
        private String GetStringPlayerInfoLUA(LsonValue PlayerN, String InfoReturned)
        {
            return FuncsLib.dump["GEM_Events"]["realms"]["Elysium"]["events"][listViewEventsList.Items[FuncsLib.EventSelected].Text]["titulars"][PlayerN][InfoReturned].GetString();
        }

        #endregion
        #region DATA Converter
        //Return Proper LUA Func
        private String ReturnLUAStringFunc(String ProfilName, String GroupN, String Players, Int32 NGroup)
        {
            return "/run LoadReceiveSync(\"XUFSync GMXckbucl " + ProfilName + " " + GroupN + " " + NGroup.ToString() + " " + Players + "\")";
        }
        //Convert Data to LUA Func
        private void SplitBossToLineArray(String Range, String ProfilName)
        {
            try
            {
                var foos = GoogleSheetLib.GetRowVal(Range);
                var fooArray = foos.Split('_');  // now you have an array of 3 strings
                foos = String.Join("_", fooArray);
                for (int i = 0; i <= fooArray.Length - 1; i++)
                {
                    richTextBoxResult.AppendText(ReturnLUAStringFunc(ProfilName, fooArray.Length.ToString(), fooArray[i], i + 1) + "\r\n");
                }
            }
            catch { toolStripStatusLbl.Text = "Erreur(s) lors de la récupération des Données."; }
        }
        //Convert DocsGoogle assist to LUA Func
        private void buttonConvData_Click(object sender, EventArgs e)
        {
            richTextBoxResult.Text = String.Empty;
            if (comboBoxRaidReadingData.SelectedIndex == 0)
            {
                richTextBoxResult.AppendText("Razorgore Boss:\n");
                SplitBossToLineArray(RaidSheetName[1] + "!M41:P44", "Razorgore");
                richTextBoxResult.AppendText("\rVaelastraz Boss:\n");
                SplitBossToLineArray(RaidSheetName[1] + "!M47:W48", "Vael");
                richTextBoxResult.AppendText("\rBoordlord Boss:\n");
                SplitBossToLineArray(RaidSheetName[1] + "!M50:X51", "Boordlord");
                richTextBoxResult.AppendText("\rFiremaw Boss:\n");
                SplitBossToLineArray(RaidSheetName[1] + "!M53:S55", "Firemaw");
                richTextBoxResult.AppendText("\rEbonroc Boss:\n");
                SplitBossToLineArray(RaidSheetName[1] + "!M57:W58", "Ebonroc");
                richTextBoxResult.AppendText("\rFlamegore Boss:\n");
                SplitBossToLineArray(RaidSheetName[1] + "!M60:T61", "Flamegore");
                richTextBoxResult.AppendText("\rChromaggus Boss:\n");
                SplitBossToLineArray(RaidSheetName[1] + "!M63:T64", "Chromaggus");
                richTextBoxResult.AppendText("\rNefarian Boss:\n");
                SplitBossToLineArray(RaidSheetName[1] + "!M66:S70", "Nefarian");
            }
            else if (comboBoxRaidReadingData.SelectedIndex == 1)
            {
                richTextBoxResult.AppendText("Lucifront Boss:\n");
                SplitBossToLineArray(RaidSheetName[0] + "!M41:S44", "Lucifront");
                richTextBoxResult.AppendText("\rMagmadar Boss:\n");
                SplitBossToLineArray(RaidSheetName[0] + "!M47:S48", "Magmadar");
                richTextBoxResult.AppendText("\rGehenas Boss:\n");
                SplitBossToLineArray(RaidSheetName[0] + "!M50:S53", "Gehenas");
                richTextBoxResult.AppendText("\rGarr Boss:\n");
                SplitBossToLineArray(RaidSheetName[0] + "!M55:S63", "Garr");
                richTextBoxResult.AppendText("\rGeddon Boss:\n");
                SplitBossToLineArray(RaidSheetName[0] + "!M65:S67", "Geddon");
                richTextBoxResult.AppendText("\rShazzrah Boss:\n");
                SplitBossToLineArray(RaidSheetName[0] + "!M69:S75", "Shazzrah");
                richTextBoxResult.AppendText("\rSulfuron Boss:\n");
                SplitBossToLineArray(RaidSheetName[0] + "!M77:S82", "Sulfuron");
                richTextBoxResult.AppendText("\rGolemagg Boss:\n");
                SplitBossToLineArray(RaidSheetName[0] + "!M84:S87", "Golemagg");
                richTextBoxResult.AppendText("\rMajordomo Bos\n");
                SplitBossToLineArray(RaidSheetName[0] + "!M89:S93", "Majordomo");
                richTextBoxResult.AppendText("\rRagnaros Boss:\n");
                SplitBossToLineArray(RaidSheetName[0] + "!M99:S101", "Ragnaros");
            }
            else if (comboBoxRaidReadingData.SelectedIndex == 2)
            {
                richTextBoxResult.AppendText("Lucifront Boss:\n");
                SplitBossToLineArray(RaidSheetName[1] + "!M41:S44", "Lucifront");
                richTextBoxResult.AppendText("\rMagmadar Boss:\n");
                SplitBossToLineArray(RaidSheetName[1] + "!M47:S48", "Magmadar");
                richTextBoxResult.AppendText("\rGehenas Boss:\n");
                SplitBossToLineArray(RaidSheetName[1] + "!M50:S53", "Gehenas");
                richTextBoxResult.AppendText("\rGarr Boss:\n");
                SplitBossToLineArray(RaidSheetName[1] + "!M55:S63", "Garr");
                richTextBoxResult.AppendText("\rGeddon Boss:\n");
                SplitBossToLineArray(RaidSheetName[1] + "!M65:S67", "Geddon");
                richTextBoxResult.AppendText("\rShazzrah Boss:\n");
                SplitBossToLineArray(RaidSheetName[1] + "!M69:S75", "Shazzrah");
                richTextBoxResult.AppendText("\rSulfuron Boss:\n");
                SplitBossToLineArray(RaidSheetName[1] + "!M77:S82", "Sulfuron");
                richTextBoxResult.AppendText("\rGolemagg Boss:\n");
                SplitBossToLineArray(RaidSheetName[1] + "!M84:S87", "Golemagg");
                richTextBoxResult.AppendText("\rMajordomo Boss:\n");
                SplitBossToLineArray(RaidSheetName[1] + "!M89:S93", "Majordomo");
                richTextBoxResult.AppendText("\rRagnaros Boss:\n");
                SplitBossToLineArray(RaidSheetName[1] + "!M99:S101", "Ragnaros");
            }

            toolStripStatusLbl.Text = "Récupération des Données terminé.";
        }
        //Display SheetName
        private void comboBoxRaidReadingData_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBoxSheetCName.Text = RaidSheetName[comboBoxRaidReadingData.SelectedIndex];
        }
        #endregion
        
    }
}

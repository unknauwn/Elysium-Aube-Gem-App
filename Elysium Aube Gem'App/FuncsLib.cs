using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LsonLib;
using System.IO;
using System.Windows.Forms;
using System.Collections;

namespace Elysium_Aube_Manage_Raid_App
{
    class FuncsLib
    {
        public static Dictionary<string, LsonValue> dump = LsonVars.Parse(File.ReadAllText(Properties.Settings.Default.FilePath));

        public static Int32 EventSelected;
        public static Int32 sortColumn = -1;

        public static String TranslateUSDaytoFR(String Day)
        {
            if (Day == "Monday")
                return "Lundi ";
            else if (Day == "Tuesday")
                return "Mardi ";
            else if (Day == "Wednesday")
                return "Mercredi ";
            else if (Day == "Thursday")
                return "Jeudi ";
            else if (Day == "Friday")
                return "Vendredi ";
            else if (Day == "Saturday")
                return "Samedi ";
            else if (Day == "Sunday")
                return "Dimanche ";
            else
                return Day;
        }

        //Get ListViewSelectedIndex
        public static void GetListViewSelectedIndex(ListView listView)
        {
            for (int i = 0; i < listView.Items.Count; i++)
            {
                if (listView.Items[i].Selected == true)
                {
                    EventSelected = i;
                }
            }
        }

        //Func for Convert Timestamp to Time
        public static String UnixTimeStampToDateTime(double unixTimeStamp)
        {
            System.DateTime dtDateTime = new DateTime(1970, 1, 1, 0, 0, 0, 0, System.DateTimeKind.Utc);
            dtDateTime = dtDateTime.AddSeconds(unixTimeStamp).ToLocalTime();
            //string formatted = dtDateTime.ToString("dd/M HH:mm");
            string formatted = dtDateTime.ToString("dd/M - HH:mm");
            string formatted1 = TranslateUSDaytoFR(dtDateTime.DayOfWeek.ToString()) + formatted + "h";
            return formatted1;
        }
        public static Int32 ConvertToTimespan(String Date)
        {
            DateTime time = DateTime.ParseExact(Date, "dd/M HH:mm", System.Globalization.CultureInfo.InvariantCulture);
            TimeSpan span = (time - new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc));
            Int32 unixTimespan = Convert.ToInt32(span.TotalSeconds);
            return unixTimespan;
        }
        //Funcs Sort ListView
        public class ListViewItemComparer : IComparer
        {

            private int col;
            private SortOrder order;
            public ListViewItemComparer(int column, SortOrder order)
            {
                col = column;
                this.order = order;
            }
            public int Compare(object x, object y)
            {
                int returnVal;
                //returnVal = String.Compare(((ListViewItem)x).SubItems[col].Text.Replace("Lundi ", "").Replace("Mardi ", "").Replace("Mercredi ", "").Replace("Jeudi ", "").Replace("Vendredi ", "").Replace("Samedi ", "").Replace("Dimanche ", ""),
                //                ((ListViewItem)y).SubItems[col].Text.Replace("Lundi ", "").Replace("Mardi ", "").Replace("Mercredi ", "").Replace("Jeudi ", "").Replace("Vendredi ", "").Replace("Samedi ", "").Replace("Dimanche ", ""));
                //if (order == SortOrder.Descending)
                //    returnVal *= -1;
                //return returnVal;

                returnVal = String.Compare(ConvertToTimespan(((ListViewItem)x).SubItems[col].Text.Replace("Lundi ", "").Replace("Mardi ", "").Replace("Mercredi ", "").Replace("Jeudi ", "").Replace("Vendredi ", "").Replace("Samedi ", "").Replace("Dimanche ", "").Replace(" - "," ").Replace("h","")).ToString(),
                                ConvertToTimespan(((ListViewItem)y).SubItems[col].Text.Replace("Lundi ", "").Replace("Mardi ", "").Replace("Mercredi ", "").Replace("Jeudi ", "").Replace("Vendredi ", "").Replace("Samedi ", "").Replace("Dimanche ", "").Replace(" - ", " ").Replace("h", "")).ToString());
                if (order == SortOrder.Descending)
                    returnVal *= -1;
                return returnVal;
            }
        }
        public static void SortLVEvent(ListView LV, Int32 e)
        {
            if (e != sortColumn)
            {
                FuncsLib.sortColumn = e;
                LV.Sorting = SortOrder.Ascending;
            }
            LV.Sort();
            LV.ListViewItemSorter = new FuncsLib.ListViewItemComparer(e,
                                                              LV.Sorting);
        }
    }
}

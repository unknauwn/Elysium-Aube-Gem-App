using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Google.Apis.Auth.OAuth2;
using Google.Apis.Sheets.v4;
using Google.Apis.Sheets.v4.Data;
using Google.Apis.Services;
using Google.Apis.Util.Store;
using System.IO;
using System.Threading;
using Data = Google.Apis.Sheets.v4.Data;

namespace Elysium_Aube_Manage_Raid_App
{
    class GoogleSheetLib
    {

        public static string[] Scopes = { SheetsService.Scope.Spreadsheets };
        public static string ApplicationName = "Google-SheetsSample/0.1";
        public static String spreadsheetId = "SHEET_ID";
        public static List<object> PlayerNum = new List<object>() { };
        public static List<object> PlayerName = new List<object>() { };

        //Connect GoogleSheet Func
        private static SheetsService ServiceCred()
        {
            UserCredential credential;

            using (var stream =
                new FileStream("client_id.json", FileMode.Open, FileAccess.Read))
            {
                string credPath = System.Environment.GetFolderPath(
                    System.Environment.SpecialFolder.Personal);
                credPath = Path.Combine(credPath, ".credentials/sheets.googleapis.com-dotnet-quickstart.json");

                credential = GoogleWebAuthorizationBroker.AuthorizeAsync(
                    GoogleClientSecrets.Load(stream).Secrets,
                    Scopes,
                    "user",
                    CancellationToken.None,
                    new FileDataStore(credPath, true)).Result;
            }
            // Create Google Sheets API service.
            return new SheetsService(new BaseClientService.Initializer()
            {
                HttpClientInitializer = credential,
                ApplicationName = ApplicationName,
            });
        }
        #region Writing Data Docs.Google
        //Collect Data for Write Func
        public static ValueRange ReturnValArray(List<object> ListInfo)
        {
            ValueRange requestBody = new ValueRange();
            requestBody.MajorDimension = "COLUMNS";//"ROWS";//COLUMNS

            requestBody.Values = new List<IList<object>> { ListInfo };
            return requestBody;
        }
        //Writing Data Func
        public static void SendDataPlayerSub(ValueRange Data, String Range)
        {
            SpreadsheetsResource.ValuesResource.UpdateRequest request = ServiceCred().Spreadsheets.Values.Update(Data, spreadsheetId, Range);
            request.ValueInputOption = SpreadsheetsResource.ValuesResource.UpdateRequest.ValueInputOptionEnum.RAW;
            Data.UpdateValuesResponse response = request.Execute();
        }
        #endregion
        #region Reading Data Docs.Google
        public static String GetRowVal(String Range)
        {
            SpreadsheetsResource.ValuesResource.GetRequest getRequest =
           ServiceCred().Spreadsheets.Values.Get(spreadsheetId, Range);
            ValueRange getResponse = getRequest.Execute();
            IList<IList<Object>> getValues = getResponse.Values;
            return Newtonsoft.Json.JsonConvert.SerializeObject(getValues).Replace("],[", "_").Replace("[", "").Replace("]", "").Replace("\"", "").Replace(",", " ").Replace("#REF!", "");
        }
        #endregion
    }
}

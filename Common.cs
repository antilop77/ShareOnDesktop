using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolTip;

namespace ShareOnDeskTop
{
    public class Common
    {
        public static frmMain mainForm;
        public static string dbName;
        public static string dbServer;
        public static string dbPassword;
        //private readonly string _connectionString = "Server=localhost;Database=Ocean;User Id=sa;Password=zeka7744;Trusted_Connection=True;TrustServerCertificate=True;";
        public static string _connectionString;
        public static List<string> share30List = new List<string>();
        public static List<string> shareNext20List = new List<string>();
        public static List<string> shareLast50List = new List<string>();
        public static Dictionary<string, List<Analiz>> shares = new Dictionary<string, List<Analiz>>();
        public static Dictionary<string, decimal> closedValue = new Dictionary<string, decimal>();
        public static Dictionary<string, decimal> dailyUpValue = new Dictionary<string, decimal>();
        public static Dictionary<string, decimal> dailyDownValue = new Dictionary<string, decimal>();
        public static Dictionary<string, decimal> periodUpValue = new Dictionary<string, decimal>();
        public static Dictionary<string, decimal> periodDownValue = new Dictionary<string, decimal>();

        public static int lastProcessCount = 16;
        public static string interval = "1m";
        public static readonly Object obj = new Object();
        public static void fnRepeat(string symbol)
        {
            string sql = $@"select top {lastProcessCount} 
	                          Interval
	                        , convert(varchar(25), InsertDateTime, 108) InsertDateTime 
	                        , Symbol
                            , CloseValue
	                        , JSON_VALUE(SummaryJson, '$.BUY') as BuyCount
	                        , JSON_VALUE(SummaryJson, '$.NEUTRAL') as NeutralCount
	                        , JSON_VALUE(SummaryJson, '$.SELL') as SellCount
	                        , JSON_VALUE(SummaryJson, '$.RECOMMENDATION') as Recommendation
                            , IndicatorsJson
                            , OscillatorsJson
                            , SummaryJson
                            , convert(varchar(25), AnalysisTime, 108) AnalysisTime 
                            , convert(varchar(25), CreatedAt, 108) CreatedAt
                        from {dbName}.dbo.TradingViewAnalysis with (nolock)
                        where 1=1
                        and symbol = '{symbol}' --'HALKB'
                            --and InsertDateTime between '2024-11-26 17:14' and '2024-11-26 17:14.999'
                        and Interval = '{interval}' --'1m'
                        order by ID desc ";

            var connection2 = new SqlConnection(_connectionString);
            connection2.Open();
            var command = new SqlCommand(sql, connection2);

            SqlDataReader sqlDataReader = command.ExecuteReader();
            List<Analiz> analizs = new List<Analiz>();
            while (sqlDataReader.Read())
            {
                Analiz analiz = new Analiz();
                analiz.Interval = sqlDataReader["Interval"].ToString();
                analiz.InsertDateTime = sqlDataReader["InsertDateTime"].ToString();
                analiz.Symbol = sqlDataReader["Symbol"].ToString();
                analiz.CloseValue = sqlDataReader["CloseValue"].ToString();
                analiz.BuyCount = sqlDataReader["BuyCount"].ToString();
                analiz.NeutralCount = sqlDataReader["NeutralCount"].ToString();
                analiz.SellCount = sqlDataReader["SellCount"].ToString();
                analiz.Recommendation = sqlDataReader["Recommendation"].ToString();
                analiz.IndicatorsJson = sqlDataReader["IndicatorsJson"].ToString();
                analiz.OscillatorsJson = sqlDataReader["OscillatorsJson"].ToString();
                analiz.SummaryJson = sqlDataReader["SummaryJson"].ToString();
                analiz.AnalysisTime = sqlDataReader["AnalysisTime"].ToString();
                analiz.CreatedAt = sqlDataReader["CreatedAt"].ToString();
                analizs.Add(analiz);
            }
            shares[symbol] = analizs;
            connection2.Close();
        }

        public static void fnTimer()
        {
            Thread myNewThread;
            bool fFirst = true;
            while (1==1)
            {
                if (mainForm.fClose)
                    break;
                var now = DateTime.Now;
                var minute = now.Minute;
                var second = now.Second;
                if (second != 0 && !fFirst)
                {
                    Task.Delay(500);
                    continue;
                }
                fFirst = false;
                Task.Delay(1000);
                int whichDay = (int)DateTime.Now.DayOfWeek;
                if (whichDay == 6 || whichDay == 7) continue;
                List<string> x = Common.shares.Keys.ToList();
                foreach(string s in x)
                {
                    myNewThread = new Thread(() => Common.fnRepeat(s));
                    myNewThread.Start();
                }
                mainForm.fRefresh = true;
            }
        } 
    }
}

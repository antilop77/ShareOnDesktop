﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShareOnDeskTop
{
    
    public partial class frmMain : Form
    {   
        public bool fRefresh = false;
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            Common.mainForm = this;
            cbxPeriod.SelectedIndex = 0;
            dgvShare.ColumnCount = 14;
            dgvShare.Columns[0].Name = "Sıra No";
            dgvShare.Columns[1].Name = "Interval";
            dgvShare.Columns[2].Name = "InsertDateTime";
            dgvShare.Columns[3].Name = "Symbol";
            dgvShare.Columns[4].Name = "CloseValue";
            dgvShare.Columns[5].Name = "BuyCount";
            dgvShare.Columns[6].Name = "NeutralCount";
            dgvShare.Columns[7].Name = "SellCount";
            dgvShare.Columns[8].Name = "Recommendation";
            dgvShare.Columns[9].Name = "IndicatorsJson";
            dgvShare.Columns[10].Name = "OscillatorsJson";
            dgvShare.Columns[11].Name = "SummaryJson";
            dgvShare.Columns[12].Name = "AnalysisTime";
            dgvShare.Columns[13].Name = "CreatedAt";
            this.WindowState = FormWindowState.Maximized;

            dgv30.ColumnCount = 5;
            dgv30.Columns[0].Name = "Symbol";
            dgv30.Columns[1].Name = "  Anlık  ";
            dgv30.Columns[2].Name = "%-Günlük";
            dgv30.Columns[3].Name = "%-Son";
            dgv30.Columns[4].Name = "%-Aralık";

            dgv50.ColumnCount = 5;
            dgv50.Columns[0].Name = "Symbol";
            dgv50.Columns[1].Name = "  Anlık  ";
            dgv50.Columns[2].Name = "%-Günlük";
            dgv50.Columns[3].Name = "%-Son";
            dgv50.Columns[4].Name = "%-Aralık";

            dgv100_1.ColumnCount = 5;
            dgv100_1.Columns[0].Name = "Symbol";
            dgv100_1.Columns[1].Name = "  Anlık  ";
            dgv100_1.Columns[2].Name = "%-Günlük";
            dgv100_1.Columns[3].Name = "%-Son";
            dgv100_1.Columns[4].Name = "%-Aralık";

            dgv100_2.ColumnCount = 5;
            dgv100_2.Columns[0].Name = "Symbol";
            dgv100_2.Columns[1].Name = "  Anlık  ";
            dgv100_2.Columns[2].Name = "%-Günlük";
            dgv100_2.Columns[3].Name = "%-Son";
            dgv100_2.Columns[4].Name = "%-Aralık";

            dgvDailyUp.ColumnCount = 3;
            dgvDailyUp.Columns[0].Name = "Symbol";
            dgvDailyUp.Columns[1].Name = "  Anlık  ";
            dgvDailyUp.Columns[2].Name = "%-Günlük";

            dgvDailyDown.ColumnCount = 3;
            dgvDailyDown.Columns[0].Name = "Symbol";
            dgvDailyDown.Columns[1].Name = "  Anlık  ";
            dgvDailyDown.Columns[2].Name = "%-Günlük";

            dgvPeriodUp.ColumnCount = 3;
            dgvPeriodUp.Columns[0].Name = "Symbol";
            dgvPeriodUp.Columns[1].Name = "  Anlık  ";
            dgvPeriodUp.Columns[2].Name = "%-Aralık";

            dgvPeriodDown.ColumnCount = 3;
            dgvPeriodDown.Columns[0].Name = "Symbol";
            dgvPeriodDown.Columns[1].Name = "  Anlık  ";
            dgvPeriodDown.Columns[2].Name = "%-Aralık";

            lblPeriodx.Text = "Aralık (" + cbxPeriod.SelectedItem.ToString() + ")";

            var connection = new SqlConnection(Common._connectionString);
            
            connection.Open();
                    
            string sql = $@"select d.Symbol, d.BISTx , (select top 1 i.CloseValue
						                                from Ocean.dbo.TradingViewAnalysis i
						                                where 1=1
						                                and i.symbol = d.Symbol
						                                and i.InsertDateTime between '2024-12-03 09:09' and '2024-12-03 09:49.999'
						                                order by i.Id desc
						                                ) closedValue
                            from Ocean.dbo.SYMBOL d
                            where 1=1 
                            and d.Active = 1 
                            and d.Source = 'BIST' 
                            and d.BISTx in(30, 50, 100, -1) 
                            order by d.BISTx, d.Symbol ";

            var command = new SqlCommand(sql, connection);
                    
            SqlDataReader sqlDataReader = command.ExecuteReader();
            List<string> listOfShare = new List<string>();
            while (sqlDataReader.Read())
            {
                string bistX = sqlDataReader["BISTx"].ToString().Trim();
                string symbol = sqlDataReader["Symbol"].ToString().Trim();
                string closedValue = sqlDataReader["closedValue"].ToString().Trim();
                Common.shares.Add(symbol, null);
                Common.closedValue.Add(symbol, Decimal.Parse(closedValue));
                listOfShare.Add(symbol);
                switch (bistX)
                {
                    case "30" : 
                        Common.share30List.Add(symbol);
                        break;
                    case "50" : 
                        Common.shareNext20List.Add(symbol);
                        break;
                    case "100" : 
                        Common.shareLast50List.Add(symbol);
                        break;
                    default:
                        break;
                }
            }
            connection.Close();
            listOfShare = listOfShare.OrderBy(x => x).ToList();
            foreach (string share in listOfShare)
            {
                cbxSymbol.Items.Add(share);
            }
            
            cbxSymbol.SelectedItem = "XU100";

            Thread myNewThread = new Thread(() => fnTimer());
            myNewThread.Start();
        }

        
        
        private void fnRefreshGridX(int bistX, DataGridView dgvX)
        {
            int i = 0;
            int iCount = dgvX.Rows.Count;
            
            for (i = 0; i < iCount-1; i++)
            {
                dgvX.Rows.RemoveAt(0);
            }
            
            if (bistX == 100)
            {
                iCount = dgv100_2.Rows.Count;
                for (i = 0; i < iCount-1; i++)
                {
                    dgv100_2.Rows.RemoveAt(0);
                }
            }
            Refresh();
            Thread.Sleep(100);

            List<string> list = new List<string>();
            if (bistX == 30)
                list = Common.share30List;
            if (bistX == 50)
                list = Common.shareNext20List;
            if (bistX == 100)
                list = Common.shareLast50List;

            i = 0;
            foreach (string item in list)
            {
                List<Analiz> share = Common.shares[item];
                int cnt = share.Count;
                decimal closedValue = Common.closedValue[item];
                //dgv30.ColumnCount = 5;
                //dgv30.Columns[0].Name = "Symbol";
                //dgv30.Columns[1].Name = "  Anlık  ";
                //dgv30.Columns[2].Name = "%-Günlük";
                //dgv30.Columns[3].Name = "%-Son";
                //dgv30.Columns[4].Name = "%-Aralık";
                if (bistX != 100)
                {
                    dgvX.Rows.Add();
                    dgvX.Rows[i].Cells[0].Value = item;
                    dgvX.Rows[i].Cells[1].Value = Math.Round(Decimal.Parse(share[0].CloseValue), 2).ToString();
                    dgvX.Rows[i].Cells[2].Value = Math.Round((100*(Decimal.Parse(share[cnt-1].CloseValue)-Decimal.Parse(share[0].CloseValue))/Decimal.Parse(share[cnt-1].CloseValue)), 2).ToString();
                    dgvX.Rows[i].Cells[3].Value = Math.Round((100*(Decimal.Parse(share[1].CloseValue)-closedValue)/Decimal.Parse(share[1].CloseValue)), 2).ToString();
                    dgvX.Rows[i].Cells[4].Value = Math.Round((100*(Decimal.Parse(share[cnt-1].CloseValue)-Decimal.Parse(share[0].CloseValue))/Decimal.Parse(share[cnt-1].CloseValue)), 2).ToString();
                }
                else if (i < 25)
                    {
                        dgvX.Rows.Add();
                        dgvX.Rows[i].Cells[0].Value = item;
                        dgvX.Rows[i].Cells[1].Value = Math.Round(Decimal.Parse(share[0].CloseValue), 2).ToString();
                        dgvX.Rows[i].Cells[2].Value = Math.Round((100*(Decimal.Parse(share[cnt-1].CloseValue)-Decimal.Parse(share[0].CloseValue))/Decimal.Parse(share[cnt-1].CloseValue)), 2).ToString();
                        dgvX.Rows[i].Cells[3].Value = Math.Round((100*(Decimal.Parse(share[1].CloseValue)-Decimal.Parse(share[0].CloseValue))/Decimal.Parse(share[1].CloseValue)), 2).ToString();
                        dgvX.Rows[i].Cells[3].Value = Math.Round((100*(Decimal.Parse(share[cnt-1].CloseValue)-Decimal.Parse(share[0].CloseValue))/Decimal.Parse(share[cnt-1].CloseValue)), 2).ToString();
                    }
                    else
                    {
                        dgv100_2.Rows.Add();
                        dgv100_2.Rows[i-25].Cells[0].Value = item;
                        dgv100_2.Rows[i-25].Cells[1].Value = Math.Round(Decimal.Parse(share[0].CloseValue), 2).ToString();
                        dgv100_2.Rows[i-25].Cells[2].Value = Math.Round((100*(Decimal.Parse(share[cnt-1].CloseValue)-Decimal.Parse(share[0].CloseValue))/Decimal.Parse(share[cnt-1].CloseValue)), 2).ToString();
                        dgv100_2.Rows[i-25].Cells[3].Value = Math.Round((100*(Decimal.Parse(share[1].CloseValue)-Decimal.Parse(share[0].CloseValue))/Decimal.Parse(share[1].CloseValue)), 2).ToString();
                        dgv100_2.Rows[i-25].Cells[3].Value = Math.Round((100*(Decimal.Parse(share[cnt-1].CloseValue)-Decimal.Parse(share[0].CloseValue))/Decimal.Parse(share[cnt-1].CloseValue)), 2).ToString();
                    }
                i++;
            }
        }
        private void fnRefreshGrid(List<Analiz> analizs)
        {
            int i = 0;
            int iCount = dgvShare.Rows.Count;
            for (i = 0; i < iCount-1; i++)
            {
                dgvShare.Rows.RemoveAt(0);
            }
            i = 0;
            Refresh();
            Thread.Sleep(100);
            
            foreach (Analiz analiz in analizs)
            {
                dgvShare.Rows.Add();
                dgvShare.Rows[i].Cells[0].Value = i+1;
                dgvShare.Rows[i].Cells[1].Value = analiz.Interval;
                dgvShare.Rows[i].Cells[2].Value = analiz.InsertDateTime;
                dgvShare.Rows[i].Cells[3].Value = analiz.Symbol;
                dgvShare.Rows[i].Cells[4].Value = analiz.CloseValue;
                dgvShare.Rows[i].Cells[5].Value = analiz.BuyCount;
                dgvShare.Rows[i].Cells[6].Value = analiz.NeutralCount;
                dgvShare.Rows[i].Cells[7].Value = analiz.SellCount;
                dgvShare.Rows[i].Cells[8].Value = analiz.Recommendation;
                dgvShare.Rows[i].Cells[9].Value = analiz.IndicatorsJson;
                dgvShare.Rows[i].Cells[10].Value = analiz.OscillatorsJson;
                dgvShare.Rows[i].Cells[11].Value = analiz.SummaryJson;
                dgvShare.Rows[i].Cells[12].Value = analiz.AnalysisTime;
                dgvShare.Rows[i].Cells[13].Value = analiz.CreatedAt;
                i++;
            }
        }

        private void fnTimer()
        {
            Thread myNewThread;
            bool fFirst = true;
            while (1==1)
            {
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
                fRefresh = true;
            }
        }
        

        private void cbxSymbol_SelectedIndexChanged(object sender, EventArgs e)
        {
            fnCbxSymbol();
        }

        private void fnCbxSymbol()
        {
            List<Analiz> list2 = null;
            lock (Common.obj)
            {
                Common.shares.TryGetValue(cbxSymbol.SelectedItem.ToString(), out List<Analiz> list);
                list2 = list;
            }
            
            if (list2 == null) return;
            fnRefreshGrid(list2);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (!fRefresh)
            {
                Thread.Sleep(1000);
                return;
            }
            fRefresh = false;
            fnRefreshGridX(30, dgv30);
            fnRefreshGridX(50, dgv50);
            fnRefreshGridX(100, dgv100_1);
            fnCbxSymbol();
        }

        private void nudLastProcessCount_ValueChanged(object sender, EventArgs e)
        {
            Common.lastProcessCount = Int32.Parse(((NumericUpDown)sender).Value.ToString());
        }

        private void cbxPeriod_SelectedIndexChanged(object sender, EventArgs e)
        {
            Common.interval = ((ComboBox)sender).SelectedItem.ToString();
        }
    }
}
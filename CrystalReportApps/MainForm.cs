using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Windows.Forms;
using CrystalReportApps.Model;
using CrystalReportApps.Reports;

namespace CrystalReportApps
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            string connectString = System.Configuration.ConfigurationManager.ConnectionStrings["ApplicationDbContext"].ToString();
            string sqlSelect =
                "select b.CHeadName BankName,SUM(t.DeepositBalance) as CreditBalance from dbBankinfo b join tblBankTransaction t on b.ID=t.BankId where t.Date BETWEEN '2019-03-07' AND '2019-06-22' group by b.CHeadName;" +
                "select b.CHeadName BankName,SUM(t.WithdrawBalance) as DebitBalance from dbBankinfo b join tblBankTransaction t on b.ID=t.BankId where t.Date BETWEEN '2019-03-07' AND '2019-06-22' group by b.CHeadName;"+
                "select p.PartyName ClientName,SUM(t.ReciveAmount)as PaidAmount from dbPartyInfo p join tblAccountTransaction t on p.Id=t.CustomerId where t.MakeDate BETWEEN '2019-03-07' AND '2019-06-22'group by p.PartyName;"+
                "select p.PartyName ClientName,sum(t.GrandTotal)-SUM(t.ReciveAmount)as ReceivableAmount from dbPartyInfo p join tblAccountTransaction t on p.Id=t.CustomerId where t.MakeDate BETWEEN '2019-03-07' AND '2019-06-22' group by p.PartyName;";
                               
            SqlConnection sqlConnection =new SqlConnection(connectString);
            sqlConnection.Open();
            SqlDataAdapter da = new SqlDataAdapter(sqlSelect, connectString);
            da.SelectCommand.CommandType = CommandType.Text;

            DataSet ds = new DataSet();
            da.Fill(ds);
            sqlConnection.Close();

            CrystalReport2 crystalReport = new CrystalReport2();
            crystalReport.Database.Tables["BankCredit"].SetDataSource(ds.Tables[0]);
            crystalReport.Database.Tables["BankDebit"].SetDataSource(ds.Tables[1]);
            crystalReport.Database.Tables["ClientPaidAmount"].SetDataSource(ds.Tables[2]);
            crystalReport.Database.Tables["ClientReceivableAmount"].SetDataSource(ds.Tables[3]);


            this.crystalReportViewer1.ReportSource = crystalReport;
            this.crystalReportViewer1.RefreshReport();

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            using (ApplicationDbContext db = new ApplicationDbContext())
            {
                var accounts = db.dbAccountInfoes.ToList();
                var banks = db.dbBankinfoes.ToList();
                ArrayList arrayList = new ArrayList();
                arrayList.Add(accounts);
                arrayList.Add(banks);
                crystalReportViewer1.ReportSource = arrayList;

                //ReportDocument aReportDocument = new ReportDocument();
                //aReportDocument.Load("~/Reports/CrystalReport1.rpt");
                //aReportDocument.SetDataSource(arrayList);
            }
        }
    }
}

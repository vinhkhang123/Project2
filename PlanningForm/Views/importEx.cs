using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;
using System.Windows.Forms;

namespace sqlForm.Views
{
    public partial class importEx : Form
    {
        localhost.planning ws = new localhost.planning();
       string connectionString = "Data Source=LAPTOP-QMVRU8HD\\VINHKHANG0501;Initial Catalog=planing;Integrated Security=True";

        public importEx()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            DataTable dt = new DataTable();
            using (OpenFileDialog ofd=new OpenFileDialog() { Filter = "Excel Files|*.xlsx;*.xlsm;*.xlsb;*.xltx;*.xltm;*.xls;*.xlt;*.xls;*.xml;*.xml;*.xlam;*.xla;*.xlw;*.xlr;", ValidateNames = true })
            {
                if(ofd.ShowDialog()==DialogResult.OK)
                {
                    MessageBox.Show("dang");
                    FileInfo file = new FileInfo(ofd.FileName);
                    ds = this.GetExcelFileData(file);
                    dt = this.GetSheetFromExcelFileData(ds, "sheet1$");
                    AddMasterData(dt);
                }
            }
        }
        public DataSet GetExcelFileData(FileInfo file)
        {
            DataSet ds = new DataSet();
            string excel = file.FullName;
            string StrConn = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source="+excel+";Extended Properties=\"Excel 12.0 Xml;HDR=YES;\"";
            OleDbConnection oleDbConn = new OleDbConnection(StrConn);   
            OleDbDataAdapter dta = new OleDbDataAdapter("SELECT * FROM [sheet1$]",oleDbConn);
            oleDbConn.Open();
            dta.Fill(ds, "sheet1$");
            oleDbConn.Close();
            return ds;
        }
        public DataTable GetSheetFromExcelFileData(DataSet excelFileData,string sheetName)
        {
           return excelFileData.Tables[sheetName];
        }
     
        public void AddMasterData(DataTable dt)
        {
            var countT = 0;
            var countE = 0;
            List<string> headers = new List<string>() { "item", "machine", "width", "height", "scrap", "updated_by", "updated_date" };
            List<string> heardersCheck = new List<string>();
            Dictionary<string, string> sheetDataKey = new Dictionary<string, string>();
            var row0 = dt.Rows[0];
            foreach(DataColumn column in dt.Columns)
            {
                string ColumnName = column.ColumnName.ToString();
                Console.WriteLine("ColumnName:" + ColumnName);
                string index = row0.Table.Columns[ColumnName].Ordinal.ToString();
                if (headers.Contains(ColumnName))
                {
                    heardersCheck.Add(ColumnName);
                    sheetDataKey.Add(ColumnName, index);
                }
            }
            if (headers.Except(heardersCheck).ToList().Count == 0)
            {
                int ItemIndex = Int32.Parse(sheetDataKey["item"]);
                int machineIndex = Int32.Parse(sheetDataKey["machine"]);
                int widthIndex = Int32.Parse(sheetDataKey["width"]);
                int heightIndex = Int32.Parse(sheetDataKey["height"]);
                int scrapIndex = Int32.Parse(sheetDataKey["scrap"]);
                int updated_byIndex = Int32.Parse(sheetDataKey["updated_by"]);
                int updated_dateIndex = Int32.Parse(sheetDataKey["updated_date"]);
                foreach(DataRow row in dt.Rows)
                {
                    var iItem = row[ItemIndex].ToString();
                    var imachine = row[machineIndex].ToString();
                    var iwidth = row[widthIndex].ToString();
                    var iheight = row[heightIndex].ToString();
                    var iscrap = row[scrapIndex].ToString();
                    var iupdated_by = row[updated_byIndex].ToString();
                    var iupdated_date = row[updated_dateIndex].ToString();
                }
            }
            else
            {
                MessageBox.Show("Kiem tra lai");
            }

        }
        private void button2_Click(object sender, EventArgs e)
        {
           
        }
    }
}

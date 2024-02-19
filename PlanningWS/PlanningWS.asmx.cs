using Microsoft.Ajax.Utilities;
using Newtonsoft.Json;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Web.UI;
using OfficeOpenXml;
using System.Data.SqlClient;
using System.Data.OleDb;
using System.IO;
using ExcelDataReader;

namespace sqla
{
    /// <summary>
    /// Summary description for sqlWS
    /// </summary>
    [WebService(Name = "planning", Description = "Chương trình planning WS", Namespace = "https://localhost:44386/sqlWS.asmx/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class sqlWS : System.Web.Services.WebService
    {
        private const string ConnectionString = @"Data Source=LAPTOP-QMVRU8HD\\VINHKHANG0501;Initial Catalog=planing;Integrated Security=True;";

        DBAccess objDBAccess = new DBAccess();
        DataTable dtWS = new DataTable();
        #region master_Data
        [WebMethod]
        public string ReadMasterData(String item)
        {
            var query = "SELECT * FROM master_data WHERE item = '" + item + "'";
            if (item.Length == 0)
            {
                query = "SELECT * FROM master_data ORDER BY updated_date ASC";
            }
            objDBAccess.ReadPlanningData(query, dtWS);
            return JsonConvert.SerializeObject(dtWS);
        }
        [WebMethod]
        public Boolean CreateMD(string item, string machine, string process_code, int width, int height, int scrap, string updated_by)
        {

            var insert = "INSERT INTO master_data(item,machine,process_code,width,height,scrap,updated_by,updated_date) VALUES('" + item + "','" + machine + "','" + process_code + "','" + width + "','" + height + "','" + scrap + "','" + updated_by + "','" + DateTime.Now + "')";
            try
            {
                objDBAccess.InsertPlanningData(insert, dtWS);
            }
            catch (Exception ex)
            {
                return false;
            }

            return true;
        }
        [WebMethod]
        public Boolean UpdateMD(string item, string machine, string process_code, int width, int height, int scrap, string updated_by)
        {
            var update = "UPDATE  master_data set machine='" + machine + "',process_code='" + process_code + "',width='" + width + "',height='" + height + "',scrap='" + scrap + "',updated_by='" + updated_by + "',updated_date='" + DateTime.Now + "' WHERE ITEM ='" + item + "'";

            try
            {
                objDBAccess.UpdatePlanningData(update, dtWS);
            }
            catch (Exception ex)
            {
                return false;
            }

            return true;

        }
        [WebMethod]
        public Boolean DeleteMD(string item)
        {
            var delete = "DELETE FROM master_data WHERE item='" + item + "'";
            try
            {
                objDBAccess.DeletePlanningData(delete, dtWS);
            }
            catch (Exception ex)
            {
                return false;
            }

            return true;
        }
        #endregion
        #region users
        [WebMethod]
        public string ReaddUsers(String user_code)
        {
            var query = "SELECT * FROM users WHERE item = '" + user_code + "'";
            if (user_code.Length == 0)
            {
                query = "SELECT * FROM users ORDER BY user_code ASC";
            }
            objDBAccess.ReadPlanningData(query, dtWS);
            return JsonConvert.SerializeObject(dtWS);
        }
        [WebMethod]
        public Boolean CreateUsers(string user_code, string full_name, string permission, string production_line, string updated_by)
        {

            var insert = "INSERT INTO users(user_code,full_name,permission,production_line,updated_by,updated_date) VALUES('" + user_code + "','" + full_name + "','" + permission + "','" + production_line + "','" + updated_by + "','" + DateTime.Now + "')";
            try
            {
                objDBAccess.InsertPlanningData(insert, dtWS);
            }
            catch (Exception ex)
            {
                //throw ex;
                return false;
            }

            return true;
        }
        [WebMethod]

        public Boolean UpdatedUser(string user_code, string full_name, string permission, string production_line, string updated_by)
        {

            var update = "UPDATE  users set full_name='" + full_name + "',permission='" + permission + "',production_line='" + production_line + "',updated_by='" + updated_by + "',updated_date='" + DateTime.Now + "' WHERE user_code ='" + user_code + "'";
            try
            {
                objDBAccess.UpdatePlanningData(update, dtWS);
            }
            catch (Exception ex)
            {
                //throw ex;
                return false;
            }

            return true;
        }
        [WebMethod]
        public Boolean DeleteUsers(string user_code)
        {
            var delete = "DELETE FROM users WHERE user_code='" + user_code + "'";
            try
            {
                objDBAccess.DeletePlanningData(delete, dtWS);
            }
            catch (Exception ex)
            {
                //throw ex;
                return false;
            }

            return true;
        }
        #endregion
        #region master_process
        [WebMethod]
        public string ReadMaster_process(String process_code)
        {
            string query = "SELECT * FROM master_process WHERE process_code = '" + process_code + "'";
            if (process_code.Length == 0)
            {
                query = "SELECT * FROM master_process ORDER BY process_code ASC";
            }
            objDBAccess.ReadPlanningData(query, dtWS);
            return JsonConvert.SerializeObject(dtWS);
        }
        [WebMethod]
        public Boolean CreateMP(string process_code, string process_name, string process_status)
        {

            var insert = "INSERT INTO master_process(process_code,process_name,process_status) VALUES('" + process_code + "','" + process_name + "','" + process_status + "')";
            try
            {
                objDBAccess.InsertPlanningData(insert, dtWS);
            }
            catch (Exception ex)
            {
                //throw ex;
                return false;
            }

            return true;
        }
        [WebMethod]
        public Boolean UpdateMP(string process_code, string process_name, string process_status)
        {
            var update = "UPDATE  master_process set process_name='" + process_name + "',process_status='" + process_status + "' WHERE process_code= '" + process_code + "'";
            try
            {
                objDBAccess.UpdatePlanningData(update, dtWS);
            }
            catch (Exception ex)
            {
                //throw ex;
                return false;
            }

            return true;

        }
        [WebMethod]
        public Boolean DeleteMP(string process_code)
        {
            var delete = "DELETE FROM master_process WHERE process_code='" + process_code + "'";
            objDBAccess.DeletePlanningData(delete, dtWS);
            try
            {
                objDBAccess.DeletePlanningData(delete, dtWS);
            }
            catch (Exception ex)
            {
                //throw ex;
                return false;
            }

            return true;
        }
        #endregion
        #region account
        [WebMethod]
        public string ReadAccount(String username)
        {
            var query = "SELECT * FROM account WHERE username = '" + username + "'";
            if (username.Length == 0)
            {
                query = "SELECT * FROM account ORDER BY username ASC";
            }
            objDBAccess.ReadPlanningData(query, dtWS);
            return JsonConvert.SerializeObject(dtWS);
        }
        [WebMethod]
        public Boolean CreateAccount(string username, string password, string user_code)
        {

            var insert = "INSERT INTO account(username,password,user_code) VALUES('" + username + "','" + password + "','" + user_code + "')";
            try
            {
                objDBAccess.InsertPlanningData(insert, dtWS);
            }
            catch (Exception ex)
            {
                throw ex;
                //   return false;
            }

            return true;
        }
        [WebMethod]
        public Boolean UpdateAccount(string username, string password, string user_code)
        {
            var update = "UPDATE  account set password='" + password + "',user_code='" + user_code + "' WHERE username= '" + username + "'";
            try
            {
                objDBAccess.UpdatePlanningData(update, dtWS);
            }
            catch (Exception ex)
            {
                return false;
            }

            return true;

        }
        [WebMethod]
        public Boolean DeleteAccount(string username)
        {
            var delete = "DELETE FROM account WHERE username='" + username + "'";
            objDBAccess.DeletePlanningData(delete, dtWS);
            try
            {
                objDBAccess.DeletePlanningData(delete, dtWS);
            }
            catch (Exception ex)
            {
                //throw ex;
                return false;
            }

            return true;
        }
        #endregion
        #region import excel


        
        //   private const string ConnectionString = "Data Source=(local);Initial Catalog=YourDatabase;Integrated Security=true;";

        [WebMethod]
        public string HelloWorld()
        {
            return "Hello World";
        }

        [WebMethod]
        public void ImportExcelToSql(string filePath)
        {
            sqlWS importer = new sqlWS();
            importer.ImportToSql(filePath);
        }
        public void ImportToSql(string filePath)
        {
            // Định nghĩa chuỗi kết nối tới SQL Server
            string connectionString = "Data Source=LAPTOP-QMVRU8HD\\VINHKHANG0501;Initial Catalog=planing;Integrated Security=true;";

            // Mở file excel
            using (var stream = File.Open(filePath, FileMode.Open, FileAccess.Read))
            {
                // Đọc dữ liệu từ file excel
                using (var reader = ExcelReaderFactory.CreateReader(stream))
                {
                    // Đọc sheet đầu tiên
                    var dataSet = reader.AsDataSet(new ExcelDataSetConfiguration()
                    {
                        ConfigureDataTable = (data) => new ExcelDataTableConfiguration()
                        {
                            UseHeaderRow = true
                        }
                    });

                    DataTable dataTable = dataSet.Tables[0];

                    // Kết nối tới CSDL SQL Server
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        // Mở kết nối
                        connection.Open();

                        // Xóa dữ liệu trong table hiện tại nếu cần thiết
                        string deleteQuery = "TRUNCATE TABLE master_data";
                        SqlCommand deleteCommand = new SqlCommand(deleteQuery, connection);
                        deleteCommand.ExecuteNonQuery();

                        // Chèn dữ liệu vào SQL Server bằng cách duyệt qua từng dòng trong DataTable
                        foreach (DataRow row in dataTable.Rows)
                        {
                            string insertQuery = "INSERT INTO master_data (item,machine,process_code,width,height,scrap,updated_by,updated_date) VALUES (@column1, @column2, @column3, @column4, @column5, @column6, @column7, @column8)";
                            SqlCommand insertCommand = new SqlCommand(insertQuery, connection);

                            // Map giá trị từ file excel vào các tham số của câu lệnh SQL
                            insertCommand.Parameters.AddWithValue("@column1", row["item"]);
                            insertCommand.Parameters.AddWithValue("@column2", row["machine"]);
                            insertCommand.Parameters.AddWithValue("@column3", row["process_code"]);
                            insertCommand.Parameters.AddWithValue("@column4", row["width"]);
                            insertCommand.Parameters.AddWithValue("@column5", row["height"]);
                            insertCommand.Parameters.AddWithValue("@column6", row["scrap"]);
                            insertCommand.Parameters.AddWithValue("@column7", row["updated_by"]);
                            insertCommand.Parameters.AddWithValue("@column8", row["updated_date"]);
                            // Thực thi câu lệnh INSERT
                            insertCommand.ExecuteNonQuery();
                        }

                        // Đóng kết nối
                        connection.Close();
                    }
                }
            }
        }
        [WebMethod]
        public void ExportSqlToExcel(string filePath)
        {
            sqlWS exporter = new sqlWS();
            exporter.ExportFromSql(filePath);
        }
        public void ExportFromSql(string filePath)
        {
            // Định nghĩa chuỗi kết nối tới SQL Server
            string connectionString = "Data Source=LAPTOP-QMVRU8HD\\VINHKHANG0501;Initial Catalog=planing;Integrated Security=true;";
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
            // Tạo file Excel mới
            FileInfo excelFile = new FileInfo(filePath);
            using (ExcelPackage package = new ExcelPackage(excelFile))
            {
                // Tạo một sheet trong file Excel
                ExcelWorksheet worksheet = package.Workbook.Worksheets.Add("Sheet1");

                // Kết nối tới CSDL SQL Server
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    // Mở kết nối
                    connection.Open();

                    // Lấy dữ liệu từ SQL Server
                    string sqlQuery = "SELECT * FROM master_data";
                    SqlCommand command = new SqlCommand(sqlQuery, connection);

                    // Thực thi câu lệnh SELECT
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        // Lấy danh sách tên cột
                        DataTable schemaTable = reader.GetSchemaTable();
                        int columnIndex = 0;
                        foreach (DataRow row in schemaTable.Rows)
                        {
                            // Ghi tên cột vào file Excel
                            worksheet.Cells[1, columnIndex + 1].Value = row["ColumnName"].ToString();
                            columnIndex++;
                        }

                        // Duyệt qua từng dòng dữ liệu và ghi vào file Excel
                        int rowIndex = 2;
                        while (reader.Read())
                        {
                            columnIndex = 0;
                            foreach (DataRow row in schemaTable.Rows)
                            {
                                // Ghi giá trị vào file Excel
                                worksheet.Cells[rowIndex, columnIndex + 1].Value = reader[columnIndex].ToString();
                                columnIndex++;
                            }

                            rowIndex++;
                        }
                    }

                    // Đóng kết nối
                    connection.Close();
                }

                // Lưu file Excel
                package.Save();
            }
        }
        #endregion
        #region project 3
        [WebMethod]
        public string project3()
        {
            var query = "SELECT * FROM users WHERE production_line = 'admin' and WHERE production_line = 'standard'";
            
            objDBAccess.ReadPlanningData(query, dtWS);
            return JsonConvert.SerializeObject(dtWS);
        }
        #endregion
    }

}

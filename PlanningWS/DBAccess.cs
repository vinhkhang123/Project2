using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace sqla
{
    public class DBAccess
    {
        //connect
        private static SqlConnection connection = new SqlConnection();  
        //command
        private static SqlCommand command= new SqlCommand();
        //adapter
        private static SqlDataAdapter adapter= new SqlDataAdapter();
        private static string strConn = @"Data Source=LAPTOP-QMVRU8HD\VINHKHANG0501;Initial Catalog=planing;Integrated Security=True";
                                        
        public void _OpenConn()
        {
            try
            {
                if(connection.State != ConnectionState.Open)
                {
                    connection.ConnectionString= strConn;   
                    connection.Open();
                }
                
            }
            catch(Exception ex) {
                throw ex;
            }
        }
        public void _CloseConn()
        {
            connection.Close();
            connection.Dispose();
        }
        public void ReadPlanningData(string query,DataTable dataTable)
        {
            _OpenConn();
            command.Connection = connection;
            command.CommandText = query;
            command.CommandType = CommandType.Text;
            adapter = new SqlDataAdapter(command);
            adapter.Fill(dataTable);
            _CloseConn();
        }
        public void InsertPlanningData(string insert,DataTable dataTable)
        {
            _OpenConn();
            command.Connection = connection;
            command.CommandText = insert;
            command.CommandType = CommandType.Text;
            adapter = new SqlDataAdapter(command);
            adapter.Fill(dataTable);
            _CloseConn();
        }
        public void UpdatePlanningData(string update, DataTable dataTable)
        {
            _OpenConn();
            command.Connection = connection;
            command.CommandText = update;
            command.CommandType = CommandType.Text;
            adapter = new SqlDataAdapter(command);
            adapter.Fill(dataTable);
            _CloseConn();
        }
        public void DeletePlanningData(string delete, DataTable dataTable)
        {
            _OpenConn();
            command.Connection = connection;
            command.CommandText = delete;
            command.CommandType = CommandType.Text;
            adapter = new SqlDataAdapter(command);
            adapter.Fill(dataTable);
            _CloseConn();
        }
    }
}
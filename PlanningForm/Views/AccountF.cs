using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sqlForm.Views
{
    public partial class AccountF : Form
    {
        localhost.planning ws = new localhost.planning();
        private int indexRow;
        public AccountF()
        {
            InitializeComponent();
        }
        void loaddata()
        {

            string user_code = tb_ucode.Text.ToString();
            string objDBAccess = ws.ReadAccount(user_code);
            DataTable dtWS = JsonConvert.DeserializeObject<DataTable>(objDBAccess);

            dataGridView1.Sort(dataGridView1.Columns[0], ListSortDirection.Ascending);



            dataGridView1.DataSource = dtWS;
        }

        private void ClearTextBoxes()
        {
            tb_username.Text = "";
            tb_Password.Text = "";
            tb_ucode.Text = "";
        }

        private void btn_create_Click(object sender, EventArgs e)
        {
            bool isIdExist = false;
            if (tb_username.TextLength == 0 || tb_Password.TextLength == 0 || tb_ucode.TextLength == 0 )
            {
                MessageBox.Show("Bạn chưa nhập đầy đủ");
                loaddata();
            }
            else
            {
                DataGridViewRow row = dataGridView1.Rows[indexRow];

                string username = tb_username.Text;
                string password = tb_Password.Text;
                string user_code = tb_ucode.Text;
               
                if (username == row.Cells[0].Value.ToString())
                {
                    MessageBox.Show("Trùng username vui lòng nhập lại");
                }
                else
                {
                    ws.CreateAccount(username, password, user_code);
                    ClearTextBoxes();
                    loaddata();

                }
            }
        }

        private void btn_allUsers_Click(object sender, EventArgs e)
        {
            string user_code = tb_ucode.Text.ToString();

            loaddata();
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            string user_code = string.Empty;
            loaddata();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            indexRow = e.RowIndex;
            DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
            tb_username.Text = row.Cells[0].Value.ToString();
            tb_Password.Text = row.Cells[1].Value.ToString();
            tb_ucode.Text = row.Cells[2].Value.ToString();
          
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            string username = tb_username.Text;
            string password = tb_Password.Text;
            string user_code = tb_ucode.Text;
           


            ws.UpdateAccount(username, password, user_code);
            ClearTextBoxes();
            loaddata();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            string usernme = tb_username.Text;

            ws.DeleteAccount(usernme);
            ClearTextBoxes();
            loaddata();
        }
    }
}

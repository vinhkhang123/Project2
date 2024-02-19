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
    public partial class UsersF : Form
    {
        localhost.planning ws = new localhost.planning();
        private int indexRow;
        public UsersF()
        {
            InitializeComponent();
        }
        void loaddata()
        {

            string user_code = tb_ucode.Text.ToString();
                string objDBAccess = ws.ReaddUsers(user_code);
            DataTable dtWS = JsonConvert.DeserializeObject<DataTable>(objDBAccess);

            dataGridView1.Sort(dataGridView1.Columns[0], ListSortDirection.Ascending);



            dataGridView1.DataSource = dtWS;
        }
     
        private void ClearTextBoxes()
        {
            tb_ucode.Text = "";
            tb_Full_N.Text = "";
            tb_perm.Text = "";
            tb_ProL.Text = "";
            tb_UBy.Text = "";
            tb_UDate.Text = "";
          
        }
        private void btn_create_Click(object sender, EventArgs e)
        {
            bool isIdExist = false;
            if (tb_ucode.TextLength == 0 || tb_Full_N.TextLength == 0 || tb_perm.TextLength == 0 || tb_ProL.TextLength == 0 || tb_UBy.TextLength == 0  )
            {
                MessageBox.Show("Bạn chưa nhập đầy đủ");
                loaddata();
            }
            else
            {
                DataGridViewRow row = dataGridView1.Rows[indexRow];

                string user_code = tb_ucode.Text;
                string full_name = tb_Full_N.Text;
                string permission = tb_perm.Text;
                string production_line = tb_ProL.Text;
                string updated_by = tb_UBy.Text;
                if (user_code == row.Cells[0].Value.ToString())
                {
                    MessageBox.Show("Trùng Id vui lòng nhập lại");
                }
                else
                {
                    ws.CreateUsers(user_code, full_name, permission, production_line, updated_by);
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

        private void dataGridView1_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            indexRow = e.RowIndex;
            DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
            tb_ucode.Text = row.Cells[0].Value.ToString();
            tb_Full_N.Text = row.Cells[1].Value.ToString();
            tb_perm.Text = row.Cells[2].Value.ToString();
            tb_ProL.Text = row.Cells[3].Value.ToString();
            tb_UBy.Text = row.Cells[4].Value.ToString();
            tb_UDate.Text = row.Cells[5].Value.ToString();
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            string user_code = tb_ucode.Text;
            string full_name = tb_Full_N.Text;
            string permission = tb_perm.Text;
            string production_line = tb_ProL.Text;
            string updated_by = tb_UBy.Text;
           

                ws.UpdatedUser(user_code, full_name, permission, production_line, updated_by);
            ClearTextBoxes();
            loaddata();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            string user_code = tb_ucode.Text;

            ws.DeleteUsers(user_code);
            ClearTextBoxes();
            loaddata();
        }
    }
}

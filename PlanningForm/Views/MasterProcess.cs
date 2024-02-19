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
    public partial class MasterProcess : Form
    {
        localhost.planning ws = new localhost.planning();
        private int indexRow;
        public MasterProcess()
        {
            InitializeComponent();
        }
        void loaddata()
        {

            string process_code = tb_pc.Text.ToString();
            string objDBAccess = ws.ReadMaster_process(process_code);
            DataTable dtWS = JsonConvert.DeserializeObject<DataTable>(objDBAccess);

            dataGridView1.Sort(dataGridView1.Columns[0], ListSortDirection.Ascending);
            dataGridView1.DataSource = dtWS;
        }
        private void ClearTextBoxes()
        {
            tb_pc.Text = "";
            tb_PN.Text = "";
            tb_ps.Text = "";
        }
        private void btn_search_Click(object sender, EventArgs e)
        {
            string process_code = string.Empty;
            loaddata();
        }

        private void btn_allUsers_Click(object sender, EventArgs e)
        {
            string process_code = tb_pc.Text.ToString();

            loaddata();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            indexRow = e.RowIndex;
            DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
            tb_pc.Text = row.Cells[0].Value.ToString();
            tb_PN.Text = row.Cells[1].Value.ToString();
            tb_ps.Text = row.Cells[2].Value.ToString();
        }

        private void btn_create_Click(object sender, EventArgs e)
        {
            bool isIdExist = false;
            if (tb_pc.TextLength == 0 || tb_PN.TextLength == 0 || tb_ps.TextLength == 0 )
            {
                MessageBox.Show("Bạn chưa nhập đầy đủ");
                loaddata();
            }
            else
            {
                DataGridViewRow row = dataGridView1.Rows[indexRow];

                string process_code = tb_pc.Text;
                string process_name = tb_PN.Text;
                string process_status = tb_ps.Text;
               
                if (process_code == row.Cells[0].Value.ToString())
                {
                    MessageBox.Show("Trùng process_code vui lòng nhập lại");
                }
                else
                {
                    ws.CreateMP(process_code, process_name, process_status);
                    ClearTextBoxes();
                    loaddata();

                }
            }
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            string process_code = tb_pc.Text;
            string process_name = tb_PN.Text;
            string process_status = tb_ps.Text;


            ws.UpdateMP(process_code, process_name, process_status);
            ClearTextBoxes();
            loaddata();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            string process_code = tb_pc.Text;

            ws.DeleteMP(process_code);
            ClearTextBoxes();
            loaddata();
        }
    }
}

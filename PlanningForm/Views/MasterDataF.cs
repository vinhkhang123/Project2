using Newtonsoft.Json;
using System;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;
//using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace sqlForm.Views
{
    public partial class MasterDataF : Form
    {
        localhost.planning ws = new localhost.planning();
        private int indexRow;
        public MasterDataF()
        {
            InitializeComponent();

        }

        void loaddata()
        {

            string item = tb_item.Text.ToString();
            string objDBAccess = ws.ReadMasterData(item);
            DataTable dtWS = JsonConvert.DeserializeObject<DataTable>(objDBAccess);

            dataGridView1.Sort(dataGridView1.Columns[0], ListSortDirection.Ascending);



            dataGridView1.DataSource = dtWS;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            indexRow = e.RowIndex;
            DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
            tb_item.Text = row.Cells[0].Value.ToString();
            tb_machine.Text = row.Cells[1].Value.ToString();
            tb_pc.Text = row.Cells[2].Value.ToString();
            tb_width.Text = row.Cells[3].Value.ToString();
            tb_height.Text = row.Cells[4].Value.ToString();
            tb_scrap.Text = row.Cells[5].Value.ToString();
            tb_uby.Text = row.Cells[6].Value.ToString();
            tb_udate.Text = row.Cells[7].Value.ToString();
        }

        private void btn_allUsers_Click(object sender, EventArgs e)
        {
            string item = tb_item.Text.ToString();

            loaddata();
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            string item = string.Empty;
            loaddata();
        }

        private void btn_create_Click(object sender, EventArgs e)
        {
            bool isIdExist = false;
            if (tb_item.TextLength == 0 || tb_machine.TextLength == 0 || tb_pc.TextLength == 0 || tb_width.TextLength == 0 || tb_height.TextLength == 0 || tb_scrap.TextLength == 0 || tb_uby.TextLength == 0 || tb_udate.TextLength == 0)
            {
                MessageBox.Show("Bạn chưa nhập đầy đủ");
                loaddata();
            }
            else
            {
                DataGridViewRow row = dataGridView1.Rows[indexRow];

                string item = tb_item.Text;
                string machine = tb_machine.Text;
                string process_code = tb_pc.Text;
                int width = Convert.ToInt32(tb_width.Text);
                int height = Convert.ToInt32(tb_height.Text);
                int scrap = Convert.ToInt32(tb_scrap.Text);
                string updated_by = tb_uby.Text;
                if (item == row.Cells[0].Value.ToString())
                {
                    MessageBox.Show("Trùng Id vui lòng nhập lại");
                }
                else
                {
                    ws.CreateMD(item, machine, process_code, width, height, scrap, updated_by);
                    ClearTextBoxes();
                    loaddata();

                }
            }
        }
        private void ClearTextBoxes()
        {
            tb_item.Text = "";
            tb_machine.Text = "";
            tb_pc.Text = "";
            tb_width.Text = "";
            tb_height.Text = "";
            tb_scrap.Text = "";
            tb_uby.Text = "";
            tb_udate.Text = "";
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            string item = tb_item.Text;
            string machine = tb_machine.Text;
            string process_code = tb_pc.Text;
            int width = Convert.ToInt32(tb_width.Text);
            int height = Convert.ToInt32(tb_height.Text);
            int scrap = Convert.ToInt32(tb_scrap.Text);
            string updated_by = tb_uby.Text;

            ws.UpdateMD(item, machine, process_code, width, height, scrap, updated_by);
            ClearTextBoxes();
            loaddata();

        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            string item = tb_item.Text;

            ws.DeleteMD(item);
            ClearTextBoxes();
            loaddata();

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

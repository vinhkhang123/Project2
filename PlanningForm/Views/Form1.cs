using Newtonsoft.Json;
using sqlForm.Views;
//using sqlForm.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace sqlForm
{
    public partial class Form1 : Form
    {
        localhost.planning ws = new localhost.planning();
        

        public Form1()
        {
            InitializeComponent();
        
          
        }
      
    private void Form1_Load(object sender, EventArgs e)
        {
           
        }
        private void loadForm(Object form)
        {
            if (this.panel1.Controls.Count > 0)
                this.panel1.Controls.RemoveAt(0);
            Form f = form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.panel1.Controls.Add(f);
            this.panel1.Tag = f;
            f.Show();
        }
        private void btn_allUsers_Click(object sender, EventArgs e)
        {
           
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            //string item =string.Empty;  
            //loaddata(); 
        }

        private void btn_create_Click(object sender, EventArgs e)
        {
         //  CreateF fr2= new CreateF();
           // fr2.Show();
        }

        private void btn_table1_Click(object sender, EventArgs e)
        {
            loadForm(new MasterDataF());
            //MasterDataF masterData= new MasterDataF();
            //masterData.Show();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_table3_Click(object sender, EventArgs e)
        {
            loadForm(new UsersF());
        }

        private void btn_table4_Click(object sender, EventArgs e)
        {
           loadForm(new MasterProcess());
        }

        private void btn_table2_Click(object sender, EventArgs e)
        {
            loadForm(new AccountF());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            loadForm(new importEx());
        }
    }
}

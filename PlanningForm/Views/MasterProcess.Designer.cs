namespace sqlForm.Views
{
    partial class MasterProcess
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.tb_pc = new System.Windows.Forms.TextBox();
            this.btn_create = new System.Windows.Forms.Button();
            this.lb_PN = new System.Windows.Forms.Label();
            this.btn_allUsers = new System.Windows.Forms.Button();
            this.tb_PN = new System.Windows.Forms.TextBox();
            this.btn_search = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lb_pc = new System.Windows.Forms.Label();
            this.lb_ps = new System.Windows.Forms.Label();
            this.tb_ps = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Item = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.machine = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.process_code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lb_m = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_update
            // 
            this.btn_update.BackColor = System.Drawing.SystemColors.Control;
            this.btn_update.FlatAppearance.BorderColor = System.Drawing.SystemColors.MenuText;
            this.btn_update.FlatAppearance.BorderSize = 2;
            this.btn_update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_update.ForeColor = System.Drawing.SystemColors.InfoText;
            this.btn_update.Location = new System.Drawing.Point(781, 81);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(186, 33);
            this.btn_update.TabIndex = 20;
            this.btn_update.Text = "Update";
            this.btn_update.UseVisualStyleBackColor = false;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.BackColor = System.Drawing.SystemColors.Control;
            this.btn_delete.FlatAppearance.BorderColor = System.Drawing.SystemColors.MenuText;
            this.btn_delete.FlatAppearance.BorderSize = 2;
            this.btn_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_delete.ForeColor = System.Drawing.SystemColors.InfoText;
            this.btn_delete.Location = new System.Drawing.Point(499, 148);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(186, 33);
            this.btn_delete.TabIndex = 21;
            this.btn_delete.Text = "Delete";
            this.btn_delete.UseVisualStyleBackColor = false;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // tb_pc
            // 
            this.tb_pc.Location = new System.Drawing.Point(117, 20);
            this.tb_pc.Name = "tb_pc";
            this.tb_pc.Size = new System.Drawing.Size(245, 22);
            this.tb_pc.TabIndex = 16;
            // 
            // btn_create
            // 
            this.btn_create.BackColor = System.Drawing.SystemColors.Control;
            this.btn_create.FlatAppearance.BorderColor = System.Drawing.SystemColors.MenuText;
            this.btn_create.FlatAppearance.BorderSize = 2;
            this.btn_create.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_create.ForeColor = System.Drawing.SystemColors.InfoText;
            this.btn_create.Location = new System.Drawing.Point(499, 81);
            this.btn_create.Name = "btn_create";
            this.btn_create.Size = new System.Drawing.Size(186, 33);
            this.btn_create.TabIndex = 19;
            this.btn_create.Text = "Create";
            this.btn_create.UseVisualStyleBackColor = false;
            this.btn_create.Click += new System.EventHandler(this.btn_create_Click);
            // 
            // lb_PN
            // 
            this.lb_PN.AutoSize = true;
            this.lb_PN.Location = new System.Drawing.Point(12, 81);
            this.lb_PN.Name = "lb_PN";
            this.lb_PN.Size = new System.Drawing.Size(97, 16);
            this.lb_PN.TabIndex = 33;
            this.lb_PN.Text = "process_name";
            // 
            // btn_allUsers
            // 
            this.btn_allUsers.BackColor = System.Drawing.SystemColors.Control;
            this.btn_allUsers.FlatAppearance.BorderColor = System.Drawing.SystemColors.MenuText;
            this.btn_allUsers.FlatAppearance.BorderSize = 2;
            this.btn_allUsers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_allUsers.ForeColor = System.Drawing.SystemColors.InfoText;
            this.btn_allUsers.Location = new System.Drawing.Point(781, 9);
            this.btn_allUsers.Name = "btn_allUsers";
            this.btn_allUsers.Size = new System.Drawing.Size(186, 33);
            this.btn_allUsers.TabIndex = 18;
            this.btn_allUsers.Text = "ALL Users";
            this.btn_allUsers.UseVisualStyleBackColor = false;
            this.btn_allUsers.Click += new System.EventHandler(this.btn_allUsers_Click);
            // 
            // tb_PN
            // 
            this.tb_PN.Location = new System.Drawing.Point(117, 75);
            this.tb_PN.Name = "tb_PN";
            this.tb_PN.Size = new System.Drawing.Size(245, 22);
            this.tb_PN.TabIndex = 25;
            // 
            // btn_search
            // 
            this.btn_search.BackColor = System.Drawing.SystemColors.Control;
            this.btn_search.FlatAppearance.BorderColor = System.Drawing.SystemColors.MenuText;
            this.btn_search.FlatAppearance.BorderSize = 2;
            this.btn_search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_search.ForeColor = System.Drawing.SystemColors.InfoText;
            this.btn_search.Location = new System.Drawing.Point(499, 9);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(186, 33);
            this.btn_search.TabIndex = 17;
            this.btn_search.Text = "Search";
            this.btn_search.UseVisualStyleBackColor = false;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Pink;
            this.panel2.Controls.Add(this.btn_update);
            this.panel2.Controls.Add(this.btn_delete);
            this.panel2.Controls.Add(this.tb_pc);
            this.panel2.Controls.Add(this.btn_create);
            this.panel2.Controls.Add(this.lb_PN);
            this.panel2.Controls.Add(this.btn_allUsers);
            this.panel2.Controls.Add(this.tb_PN);
            this.panel2.Controls.Add(this.btn_search);
            this.panel2.Controls.Add(this.lb_pc);
            this.panel2.Controls.Add(this.lb_ps);
            this.panel2.Controls.Add(this.tb_ps);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 75);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1088, 275);
            this.panel2.TabIndex = 44;
            // 
            // lb_pc
            // 
            this.lb_pc.AutoSize = true;
            this.lb_pc.Location = new System.Drawing.Point(12, 26);
            this.lb_pc.Name = "lb_pc";
            this.lb_pc.Size = new System.Drawing.Size(94, 16);
            this.lb_pc.TabIndex = 30;
            this.lb_pc.Text = "process_code";
            // 
            // lb_ps
            // 
            this.lb_ps.AutoSize = true;
            this.lb_ps.Location = new System.Drawing.Point(12, 148);
            this.lb_ps.Name = "lb_ps";
            this.lb_ps.Size = new System.Drawing.Size(98, 16);
            this.lb_ps.TabIndex = 31;
            this.lb_ps.Text = "process_status";
            // 
            // tb_ps
            // 
            this.tb_ps.Location = new System.Drawing.Point(117, 145);
            this.tb_ps.Name = "tb_ps";
            this.tb_ps.Size = new System.Drawing.Size(245, 22);
            this.tb_ps.TabIndex = 23;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Item,
            this.machine,
            this.process_code});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.Location = new System.Drawing.Point(0, 350);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1088, 286);
            this.dataGridView1.TabIndex = 43;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // Item
            // 
            this.Item.DataPropertyName = "process_code";
            this.Item.HeaderText = "process_code";
            this.Item.MinimumWidth = 6;
            this.Item.Name = "Item";
            // 
            // machine
            // 
            this.machine.DataPropertyName = "process_name";
            this.machine.HeaderText = "process_name";
            this.machine.MinimumWidth = 6;
            this.machine.Name = "machine";
            // 
            // process_code
            // 
            this.process_code.DataPropertyName = "process_status";
            this.process_code.HeaderText = "process_status";
            this.process_code.MinimumWidth = 6;
            this.process_code.Name = "process_code";
            // 
            // lb_m
            // 
            this.lb_m.AutoSize = true;
            this.lb_m.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_m.ForeColor = System.Drawing.Color.LightPink;
            this.lb_m.Location = new System.Drawing.Point(336, 20);
            this.lb_m.Name = "lb_m";
            this.lb_m.Size = new System.Drawing.Size(407, 32);
            this.lb_m.TabIndex = 0;
            this.lb_m.Text = "Master Process Management";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.lb_m);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1088, 75);
            this.panel1.TabIndex = 42;
            // 
            // MasterProcess
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1088, 636);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MasterProcess";
            this.Text = "MasterProcess";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.TextBox tb_pc;
        private System.Windows.Forms.Button btn_create;
        private System.Windows.Forms.Label lb_PN;
        private System.Windows.Forms.Button btn_allUsers;
        private System.Windows.Forms.TextBox tb_PN;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lb_pc;
        private System.Windows.Forms.Label lb_ps;
        private System.Windows.Forms.TextBox tb_ps;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lb_m;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Item;
        private System.Windows.Forms.DataGridViewTextBoxColumn machine;
        private System.Windows.Forms.DataGridViewTextBoxColumn process_code;
    }
}
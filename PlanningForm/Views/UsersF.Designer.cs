namespace sqlForm.Views
{
    partial class UsersF
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
            this.btn_delete = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lb_m = new System.Windows.Forms.Label();
            this.btn_update = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Item = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.machine = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.process_code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.width = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.updated_by = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uodated_date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tb_ucode = new System.Windows.Forms.TextBox();
            this.btn_create = new System.Windows.Forms.Button();
            this.lb_ProL = new System.Windows.Forms.Label();
            this.btn_allUsers = new System.Windows.Forms.Button();
            this.tb_ProL = new System.Windows.Forms.TextBox();
            this.btn_search = new System.Windows.Forms.Button();
            this.lb_UBy = new System.Windows.Forms.Label();
            this.lb_UDate = new System.Windows.Forms.Label();
            this.tb_perm = new System.Windows.Forms.TextBox();
            this.lb_perm = new System.Windows.Forms.Label();
            this.lb_userCode = new System.Windows.Forms.Label();
            this.tb_UBy = new System.Windows.Forms.TextBox();
            this.tb_UDate = new System.Windows.Forms.TextBox();
            this.lb_full_name = new System.Windows.Forms.Label();
            this.tb_Full_N = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_delete
            // 
            this.btn_delete.BackColor = System.Drawing.SystemColors.Control;
            this.btn_delete.FlatAppearance.BorderColor = System.Drawing.SystemColors.MenuText;
            this.btn_delete.FlatAppearance.BorderSize = 2;
            this.btn_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_delete.ForeColor = System.Drawing.SystemColors.InfoText;
            this.btn_delete.Location = new System.Drawing.Point(437, 192);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(186, 33);
            this.btn_delete.TabIndex = 21;
            this.btn_delete.Text = "Delete";
            this.btn_delete.UseVisualStyleBackColor = false;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
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
            this.panel1.TabIndex = 39;
            // 
            // lb_m
            // 
            this.lb_m.AutoSize = true;
            this.lb_m.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_m.ForeColor = System.Drawing.Color.LightPink;
            this.lb_m.Location = new System.Drawing.Point(418, 19);
            this.lb_m.Name = "lb_m";
            this.lb_m.Size = new System.Drawing.Size(276, 32);
            this.lb_m.TabIndex = 0;
            this.lb_m.Text = "Users Management";
            // 
            // btn_update
            // 
            this.btn_update.BackColor = System.Drawing.SystemColors.Control;
            this.btn_update.FlatAppearance.BorderColor = System.Drawing.SystemColors.MenuText;
            this.btn_update.FlatAppearance.BorderSize = 2;
            this.btn_update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_update.ForeColor = System.Drawing.SystemColors.InfoText;
            this.btn_update.Location = new System.Drawing.Point(801, 119);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(186, 33);
            this.btn_update.TabIndex = 20;
            this.btn_update.Text = "Update";
            this.btn_update.UseVisualStyleBackColor = false;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Item,
            this.machine,
            this.process_code,
            this.width,
            this.updated_by,
            this.uodated_date});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.Location = new System.Drawing.Point(0, 350);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1088, 286);
            this.dataGridView1.TabIndex = 40;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick_1);
            // 
            // Item
            // 
            this.Item.DataPropertyName = "user_code";
            this.Item.HeaderText = "user_code";
            this.Item.MinimumWidth = 6;
            this.Item.Name = "Item";
            // 
            // machine
            // 
            this.machine.DataPropertyName = "full_name";
            this.machine.HeaderText = "full_name";
            this.machine.MinimumWidth = 6;
            this.machine.Name = "machine";
            // 
            // process_code
            // 
            this.process_code.DataPropertyName = "permission";
            this.process_code.HeaderText = "permission";
            this.process_code.MinimumWidth = 6;
            this.process_code.Name = "process_code";
            // 
            // width
            // 
            this.width.DataPropertyName = "production_line";
            this.width.HeaderText = "production_line";
            this.width.MinimumWidth = 6;
            this.width.Name = "width";
            // 
            // updated_by
            // 
            this.updated_by.DataPropertyName = "updated_by";
            this.updated_by.HeaderText = "updated_by";
            this.updated_by.MinimumWidth = 6;
            this.updated_by.Name = "updated_by";
            // 
            // uodated_date
            // 
            this.uodated_date.DataPropertyName = "updated_date";
            this.uodated_date.HeaderText = "updated_date";
            this.uodated_date.MinimumWidth = 6;
            this.uodated_date.Name = "uodated_date";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.Pink;
            this.panel2.Controls.Add(this.btn_update);
            this.panel2.Controls.Add(this.btn_delete);
            this.panel2.Controls.Add(this.tb_ucode);
            this.panel2.Controls.Add(this.btn_create);
            this.panel2.Controls.Add(this.lb_ProL);
            this.panel2.Controls.Add(this.btn_allUsers);
            this.panel2.Controls.Add(this.tb_ProL);
            this.panel2.Controls.Add(this.btn_search);
            this.panel2.Controls.Add(this.lb_UBy);
            this.panel2.Controls.Add(this.lb_UDate);
            this.panel2.Controls.Add(this.tb_perm);
            this.panel2.Controls.Add(this.lb_perm);
            this.panel2.Controls.Add(this.lb_userCode);
            this.panel2.Controls.Add(this.tb_UBy);
            this.panel2.Controls.Add(this.tb_UDate);
            this.panel2.Controls.Add(this.lb_full_name);
            this.panel2.Controls.Add(this.tb_Full_N);
            this.panel2.Location = new System.Drawing.Point(0, 72);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1088, 281);
            this.panel2.TabIndex = 41;
            // 
            // tb_ucode
            // 
            this.tb_ucode.Location = new System.Drawing.Point(85, 7);
            this.tb_ucode.Name = "tb_ucode";
            this.tb_ucode.Size = new System.Drawing.Size(245, 22);
            this.tb_ucode.TabIndex = 16;
            // 
            // btn_create
            // 
            this.btn_create.BackColor = System.Drawing.SystemColors.Control;
            this.btn_create.FlatAppearance.BorderColor = System.Drawing.SystemColors.MenuText;
            this.btn_create.FlatAppearance.BorderSize = 2;
            this.btn_create.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_create.ForeColor = System.Drawing.SystemColors.InfoText;
            this.btn_create.Location = new System.Drawing.Point(437, 119);
            this.btn_create.Name = "btn_create";
            this.btn_create.Size = new System.Drawing.Size(186, 33);
            this.btn_create.TabIndex = 19;
            this.btn_create.Text = "Create";
            this.btn_create.UseVisualStyleBackColor = false;
            this.btn_create.Click += new System.EventHandler(this.btn_create_Click);
            // 
            // lb_ProL
            // 
            this.lb_ProL.AutoSize = true;
            this.lb_ProL.Location = new System.Drawing.Point(12, 81);
            this.lb_ProL.Name = "lb_ProL";
            this.lb_ProL.Size = new System.Drawing.Size(99, 16);
            this.lb_ProL.TabIndex = 33;
            this.lb_ProL.Text = "Production Line";
            // 
            // btn_allUsers
            // 
            this.btn_allUsers.BackColor = System.Drawing.SystemColors.Control;
            this.btn_allUsers.FlatAppearance.BorderColor = System.Drawing.SystemColors.MenuText;
            this.btn_allUsers.FlatAppearance.BorderSize = 2;
            this.btn_allUsers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_allUsers.ForeColor = System.Drawing.SystemColors.InfoText;
            this.btn_allUsers.Location = new System.Drawing.Point(67, 192);
            this.btn_allUsers.Name = "btn_allUsers";
            this.btn_allUsers.Size = new System.Drawing.Size(186, 33);
            this.btn_allUsers.TabIndex = 18;
            this.btn_allUsers.Text = "ALL Users";
            this.btn_allUsers.UseVisualStyleBackColor = false;
            this.btn_allUsers.Click += new System.EventHandler(this.btn_allUsers_Click);
            // 
            // tb_ProL
            // 
            this.tb_ProL.Location = new System.Drawing.Point(117, 75);
            this.tb_ProL.Name = "tb_ProL";
            this.tb_ProL.Size = new System.Drawing.Size(205, 22);
            this.tb_ProL.TabIndex = 25;
            // 
            // btn_search
            // 
            this.btn_search.BackColor = System.Drawing.SystemColors.Control;
            this.btn_search.FlatAppearance.BorderColor = System.Drawing.SystemColors.MenuText;
            this.btn_search.FlatAppearance.BorderSize = 2;
            this.btn_search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_search.ForeColor = System.Drawing.SystemColors.InfoText;
            this.btn_search.Location = new System.Drawing.Point(67, 119);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(186, 33);
            this.btn_search.TabIndex = 17;
            this.btn_search.Text = "Search";
            this.btn_search.UseVisualStyleBackColor = false;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // lb_UBy
            // 
            this.lb_UBy.AutoSize = true;
            this.lb_UBy.Location = new System.Drawing.Point(341, 81);
            this.lb_UBy.Name = "lb_UBy";
            this.lb_UBy.Size = new System.Drawing.Size(78, 16);
            this.lb_UBy.TabIndex = 34;
            this.lb_UBy.Text = "Updated by";
            // 
            // lb_UDate
            // 
            this.lb_UDate.AutoSize = true;
            this.lb_UDate.Location = new System.Drawing.Point(767, 81);
            this.lb_UDate.Name = "lb_UDate";
            this.lb_UDate.Size = new System.Drawing.Size(92, 16);
            this.lb_UDate.TabIndex = 35;
            this.lb_UDate.Text = "Updated Date";
            // 
            // tb_perm
            // 
            this.tb_perm.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_perm.Location = new System.Drawing.Point(882, 7);
            this.tb_perm.Name = "tb_perm";
            this.tb_perm.Size = new System.Drawing.Size(180, 22);
            this.tb_perm.TabIndex = 24;
            // 
            // lb_perm
            // 
            this.lb_perm.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_perm.AutoSize = true;
            this.lb_perm.Location = new System.Drawing.Point(767, 13);
            this.lb_perm.Name = "lb_perm";
            this.lb_perm.Size = new System.Drawing.Size(74, 16);
            this.lb_perm.TabIndex = 32;
            this.lb_perm.Text = "Permission";
            // 
            // lb_userCode
            // 
            this.lb_userCode.AutoSize = true;
            this.lb_userCode.Location = new System.Drawing.Point(12, 13);
            this.lb_userCode.Name = "lb_userCode";
            this.lb_userCode.Size = new System.Drawing.Size(67, 16);
            this.lb_userCode.TabIndex = 30;
            this.lb_userCode.Text = "user code";
            // 
            // tb_UBy
            // 
            this.tb_UBy.Location = new System.Drawing.Point(458, 78);
            this.tb_UBy.Name = "tb_UBy";
            this.tb_UBy.Size = new System.Drawing.Size(179, 22);
            this.tb_UBy.TabIndex = 26;
            // 
            // tb_UDate
            // 
            this.tb_UDate.Location = new System.Drawing.Point(882, 78);
            this.tb_UDate.Name = "tb_UDate";
            this.tb_UDate.Size = new System.Drawing.Size(180, 22);
            this.tb_UDate.TabIndex = 27;
            // 
            // lb_full_name
            // 
            this.lb_full_name.AutoSize = true;
            this.lb_full_name.Location = new System.Drawing.Point(341, 13);
            this.lb_full_name.Name = "lb_full_name";
            this.lb_full_name.Size = new System.Drawing.Size(68, 16);
            this.lb_full_name.TabIndex = 31;
            this.lb_full_name.Text = "Full Name";
            // 
            // tb_Full_N
            // 
            this.tb_Full_N.Location = new System.Drawing.Point(458, 7);
            this.tb_Full_N.Name = "tb_Full_N";
            this.tb_Full_N.Size = new System.Drawing.Size(179, 22);
            this.tb_Full_N.TabIndex = 23;
            // 
            // UsersF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightPink;
            this.ClientSize = new System.Drawing.Size(1088, 636);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UsersF";
            this.Text = "UsersF";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lb_m;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox tb_ucode;
        private System.Windows.Forms.Button btn_create;
        private System.Windows.Forms.Label lb_ProL;
        private System.Windows.Forms.Button btn_allUsers;
        private System.Windows.Forms.TextBox tb_ProL;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.Label lb_UBy;
        private System.Windows.Forms.Label lb_UDate;
        private System.Windows.Forms.TextBox tb_perm;
        private System.Windows.Forms.Label lb_perm;
        private System.Windows.Forms.Label lb_userCode;
        private System.Windows.Forms.TextBox tb_UBy;
        private System.Windows.Forms.TextBox tb_UDate;
        private System.Windows.Forms.Label lb_full_name;
        private System.Windows.Forms.TextBox tb_Full_N;
        private System.Windows.Forms.DataGridViewTextBoxColumn Item;
        private System.Windows.Forms.DataGridViewTextBoxColumn machine;
        private System.Windows.Forms.DataGridViewTextBoxColumn process_code;
        private System.Windows.Forms.DataGridViewTextBoxColumn width;
        private System.Windows.Forms.DataGridViewTextBoxColumn updated_by;
        private System.Windows.Forms.DataGridViewTextBoxColumn uodated_date;
    }
}
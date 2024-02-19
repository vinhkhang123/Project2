namespace sqlForm
{
    partial class Form1
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
            this.btn_table1 = new System.Windows.Forms.Button();
            this.btn_table2 = new System.Windows.Forms.Button();
            this.btn_table3 = new System.Windows.Forms.Button();
            this.btn_table4 = new System.Windows.Forms.Button();
            this.control_panel = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.control_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_table1
            // 
            this.btn_table1.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_table1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_table1.Location = new System.Drawing.Point(0, 164);
            this.btn_table1.Name = "btn_table1";
            this.btn_table1.Size = new System.Drawing.Size(239, 82);
            this.btn_table1.TabIndex = 0;
            this.btn_table1.Text = "Master Data";
            this.btn_table1.UseVisualStyleBackColor = true;
            this.btn_table1.Click += new System.EventHandler(this.btn_table1_Click);
            // 
            // btn_table2
            // 
            this.btn_table2.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_table2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_table2.Location = new System.Drawing.Point(0, 82);
            this.btn_table2.Name = "btn_table2";
            this.btn_table2.Size = new System.Drawing.Size(239, 82);
            this.btn_table2.TabIndex = 1;
            this.btn_table2.Text = "Account";
            this.btn_table2.UseVisualStyleBackColor = true;
            this.btn_table2.Click += new System.EventHandler(this.btn_table2_Click);
            // 
            // btn_table3
            // 
            this.btn_table3.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_table3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_table3.Location = new System.Drawing.Point(0, 0);
            this.btn_table3.Name = "btn_table3";
            this.btn_table3.Size = new System.Drawing.Size(239, 82);
            this.btn_table3.TabIndex = 2;
            this.btn_table3.Text = "Users";
            this.btn_table3.UseVisualStyleBackColor = true;
            this.btn_table3.Click += new System.EventHandler(this.btn_table3_Click);
            // 
            // btn_table4
            // 
            this.btn_table4.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_table4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_table4.Location = new System.Drawing.Point(0, 246);
            this.btn_table4.Name = "btn_table4";
            this.btn_table4.Size = new System.Drawing.Size(239, 81);
            this.btn_table4.TabIndex = 3;
            this.btn_table4.Text = "Master Process";
            this.btn_table4.UseVisualStyleBackColor = true;
            this.btn_table4.Click += new System.EventHandler(this.btn_table4_Click);
            // 
            // control_panel
            // 
            this.control_panel.BackColor = System.Drawing.Color.MistyRose;
            this.control_panel.Controls.Add(this.pictureBox1);
            this.control_panel.Controls.Add(this.label1);
            this.control_panel.Controls.Add(this.panel2);
            this.control_panel.Dock = System.Windows.Forms.DockStyle.Left;
            this.control_panel.ForeColor = System.Drawing.Color.LightPink;
            this.control_panel.Location = new System.Drawing.Point(0, 0);
            this.control_panel.Name = "control_panel";
            this.control_panel.Size = new System.Drawing.Size(239, 683);
            this.control_panel.TabIndex = 4;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::sqlForm.Properties.Resources.taoanhdep_vinamilk_44881;
            this.pictureBox1.Location = new System.Drawing.Point(3, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(230, 173);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.LightPink;
            this.label1.Location = new System.Drawing.Point(48, 189);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Planning ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btn_table4);
            this.panel2.Controls.Add(this.btn_table1);
            this.panel2.Controls.Add(this.btn_table2);
            this.panel2.Controls.Add(this.btn_table3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 233);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(239, 450);
            this.panel2.TabIndex = 4;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.ForeColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(239, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1106, 683);
            this.panel1.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1345, 683);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.control_panel);
            this.ForeColor = System.Drawing.Color.LightPink;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.control_panel.ResumeLayout(false);
            this.control_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_table1;
        private System.Windows.Forms.Button btn_table2;
        private System.Windows.Forms.Button btn_table3;
        private System.Windows.Forms.Button btn_table4;
        private System.Windows.Forms.Panel control_panel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}


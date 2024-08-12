namespace Kaashiv_Managements_System
{
    partial class Salary
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.SalTotaltxtbox = new System.Windows.Forms.TextBox();
            this.SalBonustxtbox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SalTotalsalarytxtbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SalUsernamecombBox = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SalManagerradioBtn = new System.Windows.Forms.RadioButton();
            this.SalEmployeeradioBtn = new System.Windows.Forms.RadioButton();
            this.SalbtnAdd = new System.Windows.Forms.Button();
            this.SalbtnFetch = new System.Windows.Forms.Button();
            this.SalbtnBrowse = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Blue;
            this.panel2.Controls.Add(this.SalbtnBrowse);
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(449, 764);
            this.panel2.TabIndex = 7;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(4, 544);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(440, 208);
            this.dataGridView1.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Blue;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(34, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(352, 29);
            this.label4.TabIndex = 8;
            this.label4.Text = "Kasshiv Management System";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.pictureBox1.Location = new System.Drawing.Point(24, 98);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(362, 336);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // SalTotaltxtbox
            // 
            this.SalTotaltxtbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SalTotaltxtbox.Location = new System.Drawing.Point(513, 642);
            this.SalTotaltxtbox.Name = "SalTotaltxtbox";
            this.SalTotaltxtbox.Size = new System.Drawing.Size(426, 34);
            this.SalTotaltxtbox.TabIndex = 11;
            // 
            // SalBonustxtbox
            // 
            this.SalBonustxtbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SalBonustxtbox.Location = new System.Drawing.Point(513, 516);
            this.SalBonustxtbox.Name = "SalBonustxtbox";
            this.SalBonustxtbox.Size = new System.Drawing.Size(426, 34);
            this.SalBonustxtbox.TabIndex = 10;
            this.SalBonustxtbox.TextChanged += new System.EventHandler(this.SalBonustxtbox_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(507, 580);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 32);
            this.label3.TabIndex = 9;
            this.label3.Text = "Total";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(507, 454);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 32);
            this.label2.TabIndex = 8;
            this.label2.Text = "Bonus";
            // 
            // SalTotalsalarytxtbox
            // 
            this.SalTotalsalarytxtbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SalTotalsalarytxtbox.Location = new System.Drawing.Point(513, 390);
            this.SalTotalsalarytxtbox.Name = "SalTotalsalarytxtbox";
            this.SalTotalsalarytxtbox.Size = new System.Drawing.Size(426, 34);
            this.SalTotalsalarytxtbox.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(507, 328);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 32);
            this.label1.TabIndex = 12;
            this.label1.Text = "Total Salary";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(507, 199);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(164, 32);
            this.label5.TabIndex = 14;
            this.label5.Text = "User Name";
            // 
            // SalUsernamecombBox
            // 
            this.SalUsernamecombBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SalUsernamecombBox.FormattingEnabled = true;
            this.SalUsernamecombBox.Location = new System.Drawing.Point(513, 261);
            this.SalUsernamecombBox.Name = "SalUsernamecombBox";
            this.SalUsernamecombBox.Size = new System.Drawing.Size(426, 37);
            this.SalUsernamecombBox.TabIndex = 15;
            this.SalUsernamecombBox.SelectedIndexChanged += new System.EventHandler(this.SalUsernamecombBox_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(666, 23);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(116, 38);
            this.label6.TabIndex = 16;
            this.label6.Text = "Salary";
            // 
            // SalManagerradioBtn
            // 
            this.SalManagerradioBtn.AutoSize = true;
            this.SalManagerradioBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SalManagerradioBtn.Location = new System.Drawing.Point(513, 98);
            this.SalManagerradioBtn.Name = "SalManagerradioBtn";
            this.SalManagerradioBtn.Size = new System.Drawing.Size(136, 33);
            this.SalManagerradioBtn.TabIndex = 17;
            this.SalManagerradioBtn.TabStop = true;
            this.SalManagerradioBtn.Text = "Manager";
            this.SalManagerradioBtn.UseVisualStyleBackColor = true;
            this.SalManagerradioBtn.CheckedChanged += new System.EventHandler(this.SalManagerradioBtn_CheckedChanged);
            // 
            // SalEmployeeradioBtn
            // 
            this.SalEmployeeradioBtn.AutoSize = true;
            this.SalEmployeeradioBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SalEmployeeradioBtn.Location = new System.Drawing.Point(809, 98);
            this.SalEmployeeradioBtn.Name = "SalEmployeeradioBtn";
            this.SalEmployeeradioBtn.Size = new System.Drawing.Size(164, 33);
            this.SalEmployeeradioBtn.TabIndex = 18;
            this.SalEmployeeradioBtn.TabStop = true;
            this.SalEmployeeradioBtn.Text = "Employees";
            this.SalEmployeeradioBtn.UseVisualStyleBackColor = true;
            this.SalEmployeeradioBtn.CheckedChanged += new System.EventHandler(this.SalEmployeeradioBtn_CheckedChanged);
            // 
            // SalbtnAdd
            // 
            this.SalbtnAdd.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.SalbtnAdd.FlatAppearance.BorderSize = 3;
            this.SalbtnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SalbtnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SalbtnAdd.ForeColor = System.Drawing.Color.Blue;
            this.SalbtnAdd.Location = new System.Drawing.Point(813, 693);
            this.SalbtnAdd.Name = "SalbtnAdd";
            this.SalbtnAdd.Size = new System.Drawing.Size(126, 59);
            this.SalbtnAdd.TabIndex = 45;
            this.SalbtnAdd.Text = "Add";
            this.SalbtnAdd.UseVisualStyleBackColor = true;
            this.SalbtnAdd.Click += new System.EventHandler(this.SalbtnAdd_Click);
            this.SalbtnAdd.MouseLeave += new System.EventHandler(this.SalbtnAdd_MouseLeave);
            this.SalbtnAdd.MouseHover += new System.EventHandler(this.SalbtnAdd_MouseHover);
            // 
            // SalbtnFetch
            // 
            this.SalbtnFetch.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.SalbtnFetch.FlatAppearance.BorderSize = 3;
            this.SalbtnFetch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SalbtnFetch.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SalbtnFetch.ForeColor = System.Drawing.Color.Blue;
            this.SalbtnFetch.Location = new System.Drawing.Point(513, 693);
            this.SalbtnFetch.Name = "SalbtnFetch";
            this.SalbtnFetch.Size = new System.Drawing.Size(126, 59);
            this.SalbtnFetch.TabIndex = 46;
            this.SalbtnFetch.Text = "Fetch";
            this.SalbtnFetch.UseVisualStyleBackColor = true;
            this.SalbtnFetch.Click += new System.EventHandler(this.SalbtnFetch_Click);
            // 
            // SalbtnBrowse
            // 
            this.SalbtnBrowse.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.SalbtnBrowse.FlatAppearance.BorderSize = 3;
            this.SalbtnBrowse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SalbtnBrowse.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SalbtnBrowse.ForeColor = System.Drawing.Color.Black;
            this.SalbtnBrowse.Location = new System.Drawing.Point(133, 454);
            this.SalbtnBrowse.Name = "SalbtnBrowse";
            this.SalbtnBrowse.Size = new System.Drawing.Size(126, 59);
            this.SalbtnBrowse.TabIndex = 46;
            this.SalbtnBrowse.Text = "Browse";
            this.SalbtnBrowse.UseVisualStyleBackColor = true;
            this.SalbtnBrowse.Click += new System.EventHandler(this.SalbtnBrowse_Click);
            // 
            // Salary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1045, 764);
            this.Controls.Add(this.SalbtnFetch);
            this.Controls.Add(this.SalbtnAdd);
            this.Controls.Add(this.SalEmployeeradioBtn);
            this.Controls.Add(this.SalManagerradioBtn);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.SalUsernamecombBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.SalTotalsalarytxtbox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SalTotaltxtbox);
            this.Controls.Add(this.SalBonustxtbox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Salary";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Salary";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox SalTotaltxtbox;
        private System.Windows.Forms.TextBox SalBonustxtbox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox SalTotalsalarytxtbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox SalUsernamecombBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RadioButton SalManagerradioBtn;
        private System.Windows.Forms.RadioButton SalEmployeeradioBtn;
        private System.Windows.Forms.Button SalbtnAdd;
        private System.Windows.Forms.Button SalbtnFetch;
        private System.Windows.Forms.Button SalbtnBrowse;
    }
}
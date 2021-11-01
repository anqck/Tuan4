namespace _5
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.clmSTT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmMaSV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmTenSV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmKhoa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmDTB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmSTT,
            this.clmMaSV,
            this.clmTenSV,
            this.clmKhoa,
            this.clmDTB});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 82;
            this.dataGridView1.RowTemplate.Height = 33;
            this.dataGridView1.Size = new System.Drawing.Size(1236, 994);
            this.dataGridView1.TabIndex = 0;
            // 
            // clmSTT
            // 
            this.clmSTT.HeaderText = "STT";
            this.clmSTT.MinimumWidth = 10;
            this.clmSTT.Name = "clmSTT";
            this.clmSTT.Width = 200;
            // 
            // clmMaSV
            // 
            this.clmMaSV.HeaderText = "Mã SV";
            this.clmMaSV.MinimumWidth = 10;
            this.clmMaSV.Name = "clmMaSV";
            this.clmMaSV.Width = 200;
            // 
            // clmTenSV
            // 
            this.clmTenSV.HeaderText = "Tên SV";
            this.clmTenSV.MinimumWidth = 10;
            this.clmTenSV.Name = "clmTenSV";
            this.clmTenSV.Width = 200;
            // 
            // clmKhoa
            // 
            this.clmKhoa.HeaderText = "Khoa";
            this.clmKhoa.MinimumWidth = 10;
            this.clmKhoa.Name = "clmKhoa";
            this.clmKhoa.Width = 200;
            // 
            // clmDTB
            // 
            this.clmDTB.HeaderText = "Điểm TB";
            this.clmDTB.MinimumWidth = 10;
            this.clmDTB.Name = "clmDTB";
            this.clmDTB.Width = 200;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1236, 994);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmSTT;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmMaSV;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmTenSV;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmKhoa;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmDTB;
    }
}


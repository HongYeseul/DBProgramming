namespace test123
{
    partial class viewPastOrder
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
            this.btnModify = new System.Windows.Forms.Button();
            this.btnRemoveRow = new System.Windows.Forms.Button();
            this.btnUpDown = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 81);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(776, 345);
            this.dataGridView1.TabIndex = 0;
            // 
            // btnModify
            // 
            this.btnModify.Location = new System.Drawing.Point(681, 23);
            this.btnModify.Name = "btnModify";
            this.btnModify.Size = new System.Drawing.Size(96, 42);
            this.btnModify.TabIndex = 1;
            this.btnModify.Text = "수정하기";
            this.btnModify.UseVisualStyleBackColor = true;
            this.btnModify.Click += new System.EventHandler(this.btnModify_Click);
            // 
            // btnRemoveRow
            // 
            this.btnRemoveRow.Location = new System.Drawing.Point(498, 23);
            this.btnRemoveRow.Name = "btnRemoveRow";
            this.btnRemoveRow.Size = new System.Drawing.Size(160, 42);
            this.btnRemoveRow.TabIndex = 2;
            this.btnRemoveRow.Text = "선택한 주문번호 삭제하기";
            this.btnRemoveRow.UseVisualStyleBackColor = true;
            this.btnRemoveRow.Click += new System.EventHandler(this.btnRemoveRow_Click);
            // 
            // btnUpDown
            // 
            this.btnUpDown.Location = new System.Drawing.Point(438, 44);
            this.btnUpDown.Name = "btnUpDown";
            this.btnUpDown.Size = new System.Drawing.Size(54, 21);
            this.btnUpDown.TabIndex = 4;
            // 
            // viewPastOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnUpDown);
            this.Controls.Add(this.btnRemoveRow);
            this.Controls.Add(this.btnModify);
            this.Controls.Add(this.dataGridView1);
            this.Name = "viewPastOrder";
            this.Text = "viewPastOrder";
            this.Load += new System.EventHandler(this.viewPastOrder_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnUpDown)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnModify;
        private System.Windows.Forms.Button btnRemoveRow;
        private System.Windows.Forms.NumericUpDown btnUpDown;
    }
}
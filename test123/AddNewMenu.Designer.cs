namespace test123
{
    partial class AddNewMenu
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtBoxMenuName = new System.Windows.Forms.TextBox();
            this.txtBoxCost = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "메뉴 명";
            // 
            // txtBoxMenuName
            // 
            this.txtBoxMenuName.Location = new System.Drawing.Point(105, 35);
            this.txtBoxMenuName.Name = "txtBoxMenuName";
            this.txtBoxMenuName.Size = new System.Drawing.Size(100, 21);
            this.txtBoxMenuName.TabIndex = 1;
            // 
            // txtBoxCost
            // 
            this.txtBoxCost.Location = new System.Drawing.Point(105, 76);
            this.txtBoxCost.Name = "txtBoxCost";
            this.txtBoxCost.Size = new System.Drawing.Size(100, 21);
            this.txtBoxCost.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "메뉴 가격";
            // 
            // btnConfirm
            // 
            this.btnConfirm.Location = new System.Drawing.Point(251, 54);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(75, 23);
            this.btnConfirm.TabIndex = 4;
            this.btnConfirm.Text = "확인";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // AddNewMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(369, 137);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.txtBoxCost);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtBoxMenuName);
            this.Controls.Add(this.label1);
            this.Name = "AddNewMenu";
            this.Text = "AddNewMenu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBoxMenuName;
        private System.Windows.Forms.TextBox txtBoxCost;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnConfirm;
    }
}
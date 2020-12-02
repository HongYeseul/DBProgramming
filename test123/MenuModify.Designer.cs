namespace test123
{
    partial class MenuModify
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
            this.listBoxMenu = new System.Windows.Forms.ListBox();
            this.txtMoney = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBoxMenu
            // 
            this.listBoxMenu.FormattingEnabled = true;
            this.listBoxMenu.ItemHeight = 12;
            this.listBoxMenu.Location = new System.Drawing.Point(43, 38);
            this.listBoxMenu.Name = "listBoxMenu";
            this.listBoxMenu.Size = new System.Drawing.Size(120, 232);
            this.listBoxMenu.TabIndex = 0;
            this.listBoxMenu.SelectedIndexChanged += new System.EventHandler(this.listBoxMenu_SelectedIndexChanged);
            // 
            // txtMoney
            // 
            this.txtMoney.Location = new System.Drawing.Point(203, 100);
            this.txtMoney.Name = "txtMoney";
            this.txtMoney.Size = new System.Drawing.Size(100, 21);
            this.txtMoney.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(309, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "원";
            // 
            // btnConfirm
            // 
            this.btnConfirm.Location = new System.Drawing.Point(218, 137);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(75, 50);
            this.btnConfirm.TabIndex = 3;
            this.btnConfirm.Text = "확인";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // MenuModify
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(355, 301);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtMoney);
            this.Controls.Add(this.listBoxMenu);
            this.Name = "MenuModify";
            this.Text = "MenuModify";
            this.Load += new System.EventHandler(this.MenuModify_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxMenu;
        private System.Windows.Forms.TextBox txtMoney;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnConfirm;
    }
}
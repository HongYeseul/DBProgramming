namespace test123
{
    partial class LoginForm
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
            this.btnLogin = new System.Windows.Forms.Button();
            this.txtBoxPW = new System.Windows.Forms.TextBox();
            this.PW = new System.Windows.Forms.Label();
            this.txtBoxID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkBoxAdmin = new System.Windows.Forms.CheckBox();
            this.btnSignUp = new System.Windows.Forms.Button();
            this.txtBoxNewPW = new System.Windows.Forms.TextBox();
            this.txtBoxNewID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnPasswordM = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(223, 61);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(75, 23);
            this.btnLogin.TabIndex = 25;
            this.btnLogin.Text = "로그인";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // txtBoxPW
            // 
            this.txtBoxPW.Location = new System.Drawing.Point(81, 84);
            this.txtBoxPW.Name = "txtBoxPW";
            this.txtBoxPW.Size = new System.Drawing.Size(100, 21);
            this.txtBoxPW.TabIndex = 24;
            // 
            // PW
            // 
            this.PW.AutoSize = true;
            this.PW.Location = new System.Drawing.Point(52, 87);
            this.PW.Name = "PW";
            this.PW.Size = new System.Drawing.Size(23, 12);
            this.PW.TabIndex = 23;
            this.PW.Text = "PW";
            // 
            // txtBoxID
            // 
            this.txtBoxID.Location = new System.Drawing.Point(81, 41);
            this.txtBoxID.Name = "txtBoxID";
            this.txtBoxID.Size = new System.Drawing.Size(100, 21);
            this.txtBoxID.TabIndex = 22;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(59, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 12);
            this.label1.TabIndex = 21;
            this.label1.Text = "ID";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkBoxAdmin);
            this.groupBox1.Controls.Add(this.btnSignUp);
            this.groupBox1.Controls.Add(this.txtBoxNewPW);
            this.groupBox1.Controls.Add(this.txtBoxNewID);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(40, 147);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(276, 163);
            this.groupBox1.TabIndex = 26;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // checkBoxAdmin
            // 
            this.checkBoxAdmin.AutoSize = true;
            this.checkBoxAdmin.Location = new System.Drawing.Point(55, 113);
            this.checkBoxAdmin.Name = "checkBoxAdmin";
            this.checkBoxAdmin.Size = new System.Drawing.Size(84, 16);
            this.checkBoxAdmin.TabIndex = 32;
            this.checkBoxAdmin.Text = "관리자유무";
            this.checkBoxAdmin.UseVisualStyleBackColor = true;
            // 
            // btnSignUp
            // 
            this.btnSignUp.Location = new System.Drawing.Point(183, 42);
            this.btnSignUp.Name = "btnSignUp";
            this.btnSignUp.Size = new System.Drawing.Size(75, 83);
            this.btnSignUp.TabIndex = 27;
            this.btnSignUp.Text = "회원가입";
            this.btnSignUp.UseVisualStyleBackColor = true;
            this.btnSignUp.Click += new System.EventHandler(this.btnSignUp_Click);
            // 
            // txtBoxNewPW
            // 
            this.txtBoxNewPW.Location = new System.Drawing.Point(53, 74);
            this.txtBoxNewPW.Name = "txtBoxNewPW";
            this.txtBoxNewPW.Size = new System.Drawing.Size(100, 21);
            this.txtBoxNewPW.TabIndex = 30;
            // 
            // txtBoxNewID
            // 
            this.txtBoxNewID.Location = new System.Drawing.Point(53, 31);
            this.txtBoxNewID.Name = "txtBoxNewID";
            this.txtBoxNewID.Size = new System.Drawing.Size(100, 21);
            this.txtBoxNewID.TabIndex = 28;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 12);
            this.label2.TabIndex = 29;
            this.label2.Text = "PW";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(16, 12);
            this.label3.TabIndex = 27;
            this.label3.Text = "ID";
            // 
            // btnPasswordM
            // 
            this.btnPasswordM.Location = new System.Drawing.Point(278, 10);
            this.btnPasswordM.Name = "btnPasswordM";
            this.btnPasswordM.Size = new System.Drawing.Size(75, 43);
            this.btnPasswordM.TabIndex = 27;
            this.btnPasswordM.Text = "비밀번호 수정하기";
            this.btnPasswordM.UseVisualStyleBackColor = true;
            this.btnPasswordM.Click += new System.EventHandler(this.btnPasswordM_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(365, 342);
            this.Controls.Add(this.btnPasswordM);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.txtBoxPW);
            this.Controls.Add(this.PW);
            this.Controls.Add(this.txtBoxID);
            this.Controls.Add(this.label1);
            this.Name = "LoginForm";
            this.Text = "LoginForm";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.TextBox txtBoxPW;
        private System.Windows.Forms.Label PW;
        private System.Windows.Forms.TextBox txtBoxID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox checkBoxAdmin;
        private System.Windows.Forms.Button btnSignUp;
        private System.Windows.Forms.TextBox txtBoxNewPW;
        private System.Windows.Forms.TextBox txtBoxNewID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnPasswordM;
    }
}
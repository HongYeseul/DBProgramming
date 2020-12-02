namespace test123
{
    partial class MainForm
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.comboBoxSelect = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnLogout = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.listBoxOrderMenu = new System.Windows.Forms.ListBox();
            this.btnAddMenu = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBoxNum = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.listBoxCoffeeMenu = new System.Windows.Forms.ListBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.관리자ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.메뉴추가ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.사용자로그ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.주문ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.메뉴수정ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.수정로그보기ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.신규유저등록ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.comboBoxSelect);
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Location = new System.Drawing.Point(36, 183);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(729, 247);
            this.groupBox2.TabIndex = 31;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "관리자용 화면";
            // 
            // comboBoxSelect
            // 
            this.comboBoxSelect.FormattingEnabled = true;
            this.comboBoxSelect.Items.AddRange(new object[] {
            "사용자별 일일 판매량",
            "커피종류별 일일 판매량",
            "커피종류별 월별 판매량",
            "시간별 판매량"});
            this.comboBoxSelect.Location = new System.Drawing.Point(20, 20);
            this.comboBoxSelect.Name = "comboBoxSelect";
            this.comboBoxSelect.Size = new System.Drawing.Size(149, 20);
            this.comboBoxSelect.TabIndex = 22;
            this.comboBoxSelect.SelectedIndexChanged += new System.EventHandler(this.comboBoxSelect_SelectedIndexChanged_1);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(20, 49);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(686, 182);
            this.dataGridView1.TabIndex = 16;
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(649, 10);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(75, 23);
            this.btnLogout.TabIndex = 30;
            this.btnLogout.Text = "로그아웃";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click_1);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.listBoxOrderMenu);
            this.groupBox1.Controls.Add(this.btnAddMenu);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtBoxNum);
            this.groupBox1.Controls.Add(this.btnAdd);
            this.groupBox1.Controls.Add(this.btnClear);
            this.groupBox1.Controls.Add(this.listBoxCoffeeMenu);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Location = new System.Drawing.Point(36, 41);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(544, 136);
            this.groupBox1.TabIndex = 29;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "캐셔용 화면";
            // 
            // listBoxOrderMenu
            // 
            this.listBoxOrderMenu.FormattingEnabled = true;
            this.listBoxOrderMenu.ItemHeight = 12;
            this.listBoxOrderMenu.Location = new System.Drawing.Point(309, 20);
            this.listBoxOrderMenu.Name = "listBoxOrderMenu";
            this.listBoxOrderMenu.Size = new System.Drawing.Size(120, 100);
            this.listBoxOrderMenu.TabIndex = 33;
            // 
            // btnAddMenu
            // 
            this.btnAddMenu.Location = new System.Drawing.Point(219, 71);
            this.btnAddMenu.Name = "btnAddMenu";
            this.btnAddMenu.Size = new System.Drawing.Size(75, 23);
            this.btnAddMenu.TabIndex = 18;
            this.btnAddMenu.Text = "추가";
            this.btnAddMenu.UseVisualStyleBackColor = true;
            this.btnAddMenu.Click += new System.EventHandler(this.btnAddMenu_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(255, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 12);
            this.label3.TabIndex = 17;
            this.label3.Text = "개";
            // 
            // txtBoxNum
            // 
            this.txtBoxNum.Location = new System.Drawing.Point(219, 47);
            this.txtBoxNum.Name = "txtBoxNum";
            this.txtBoxNum.Size = new System.Drawing.Size(30, 21);
            this.txtBoxNum.TabIndex = 16;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(450, 20);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 100);
            this.btnAdd.TabIndex = 15;
            this.btnAdd.Text = "주문하기";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click_1);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(219, 96);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 8;
            this.btnClear.Text = "초기화";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click_1);
            // 
            // listBoxCoffeeMenu
            // 
            this.listBoxCoffeeMenu.FormattingEnabled = true;
            this.listBoxCoffeeMenu.ItemHeight = 12;
            this.listBoxCoffeeMenu.Location = new System.Drawing.Point(20, 47);
            this.listBoxCoffeeMenu.Name = "listBoxCoffeeMenu";
            this.listBoxCoffeeMenu.Size = new System.Drawing.Size(175, 76);
            this.listBoxCoffeeMenu.TabIndex = 8;
            this.listBoxCoffeeMenu.SelectedIndexChanged += new System.EventHandler(this.listBoxCoffeeMenu_SelectedIndexChanged_1);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(20, 20);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(175, 21);
            this.dateTimePicker1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(520, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 12);
            this.label2.TabIndex = 28;
            this.label2.Text = "님 로그인 되었습니다.";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(484, 15);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(9, 12);
            this.labelName.TabIndex = 27;
            this.labelName.Text = " ";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.관리자ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 32;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 관리자ToolStripMenuItem
            // 
            this.관리자ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.메뉴추가ToolStripMenuItem,
            this.사용자로그ToolStripMenuItem,
            this.주문ToolStripMenuItem,
            this.메뉴수정ToolStripMenuItem,
            this.수정로그보기ToolStripMenuItem,
            this.신규유저등록ToolStripMenuItem});
            this.관리자ToolStripMenuItem.Name = "관리자ToolStripMenuItem";
            this.관리자ToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.관리자ToolStripMenuItem.Text = "관리자";
            // 
            // 메뉴추가ToolStripMenuItem
            // 
            this.메뉴추가ToolStripMenuItem.Name = "메뉴추가ToolStripMenuItem";
            this.메뉴추가ToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.메뉴추가ToolStripMenuItem.Text = "메뉴 추가";
            this.메뉴추가ToolStripMenuItem.Click += new System.EventHandler(this.메뉴추가ToolStripMenuItem_Click);
            // 
            // 사용자로그ToolStripMenuItem
            // 
            this.사용자로그ToolStripMenuItem.Name = "사용자로그ToolStripMenuItem";
            this.사용자로그ToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.사용자로그ToolStripMenuItem.Text = "사용자 로그";
            this.사용자로그ToolStripMenuItem.Click += new System.EventHandler(this.사용자로그ToolStripMenuItem_Click);
            // 
            // 주문ToolStripMenuItem
            // 
            this.주문ToolStripMenuItem.Name = "주문ToolStripMenuItem";
            this.주문ToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.주문ToolStripMenuItem.Text = "지난 주문 수정/취소";
            this.주문ToolStripMenuItem.Click += new System.EventHandler(this.주문ToolStripMenuItem_Click);
            // 
            // 메뉴수정ToolStripMenuItem
            // 
            this.메뉴수정ToolStripMenuItem.Name = "메뉴수정ToolStripMenuItem";
            this.메뉴수정ToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.메뉴수정ToolStripMenuItem.Text = "메뉴 수정";
            this.메뉴수정ToolStripMenuItem.Click += new System.EventHandler(this.메뉴수정ToolStripMenuItem_Click);
            // 
            // 수정로그보기ToolStripMenuItem
            // 
            this.수정로그보기ToolStripMenuItem.Name = "수정로그보기ToolStripMenuItem";
            this.수정로그보기ToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.수정로그보기ToolStripMenuItem.Text = "수정 로그 보기";
            this.수정로그보기ToolStripMenuItem.Click += new System.EventHandler(this.수정로그보기ToolStripMenuItem_Click);
            // 
            // 신규유저등록ToolStripMenuItem
            // 
            this.신규유저등록ToolStripMenuItem.Name = "신규유저등록ToolStripMenuItem";
            this.신규유저등록ToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.신규유저등록ToolStripMenuItem.Text = "신규 유저 등록";
            this.신규유저등록ToolStripMenuItem.Click += new System.EventHandler(this.신규유저등록ToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox comboBoxSelect;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.ListBox listBoxCoffeeMenu;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBoxNum;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 관리자ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 메뉴추가ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 사용자로그ToolStripMenuItem;
        private System.Windows.Forms.ListBox listBoxOrderMenu;
        private System.Windows.Forms.Button btnAddMenu;
        private System.Windows.Forms.ToolStripMenuItem 주문ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 메뉴수정ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 수정로그보기ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 신규유저등록ToolStripMenuItem;
    }
}


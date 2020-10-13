namespace Calculator
{
    partial class Form1
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
            this.groupBoxComboCalc = new System.Windows.Forms.GroupBox();
            this.buttonComboBoxCalculator = new System.Windows.Forms.Button();
            this.comboBoxComboCalc_Operator = new System.Windows.Forms.ComboBox();
            this.textBoxComboCalc_Result = new System.Windows.Forms.TextBox();
            this.textBoxComboCalc_Oper2 = new System.Windows.Forms.TextBox();
            this.textBoxComboCalc_Oper1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButtonOperator_minus = new System.Windows.Forms.RadioButton();
            this.radioButtonOperator_plus = new System.Windows.Forms.RadioButton();
            this.buttonRadioBoxCalculator = new System.Windows.Forms.Button();
            this.textBoxRadioCalc_Result = new System.Windows.Forms.TextBox();
            this.textBoxRadioCalc_Oper2 = new System.Windows.Forms.TextBox();
            this.textBoxRadioCalc_Oper1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.radioButtonOperator_pow = new System.Windows.Forms.RadioButton();
            this.groupBoxComboCalc.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxComboCalc
            // 
            this.groupBoxComboCalc.Controls.Add(this.buttonComboBoxCalculator);
            this.groupBoxComboCalc.Controls.Add(this.comboBoxComboCalc_Operator);
            this.groupBoxComboCalc.Controls.Add(this.textBoxComboCalc_Result);
            this.groupBoxComboCalc.Controls.Add(this.textBoxComboCalc_Oper2);
            this.groupBoxComboCalc.Controls.Add(this.textBoxComboCalc_Oper1);
            this.groupBoxComboCalc.Controls.Add(this.label4);
            this.groupBoxComboCalc.Controls.Add(this.label3);
            this.groupBoxComboCalc.Controls.Add(this.label2);
            this.groupBoxComboCalc.Controls.Add(this.label1);
            this.groupBoxComboCalc.Location = new System.Drawing.Point(58, 39);
            this.groupBoxComboCalc.Name = "groupBoxComboCalc";
            this.groupBoxComboCalc.Size = new System.Drawing.Size(593, 103);
            this.groupBoxComboCalc.TabIndex = 0;
            this.groupBoxComboCalc.TabStop = false;
            this.groupBoxComboCalc.Text = "Combobox Calculator";
            // 
            // buttonComboBoxCalculator
            // 
            this.buttonComboBoxCalculator.Location = new System.Drawing.Point(326, 48);
            this.buttonComboBoxCalculator.Name = "buttonComboBoxCalculator";
            this.buttonComboBoxCalculator.Size = new System.Drawing.Size(75, 23);
            this.buttonComboBoxCalculator.TabIndex = 6;
            this.buttonComboBoxCalculator.Text = "Calculate";
            this.buttonComboBoxCalculator.UseVisualStyleBackColor = true;
            this.buttonComboBoxCalculator.Click += new System.EventHandler(this.buttonComboBoxCalculator_Click);
            // 
            // comboBoxComboCalc_Operator
            // 
            this.comboBoxComboCalc_Operator.FormattingEnabled = true;
            this.comboBoxComboCalc_Operator.Location = new System.Drawing.Point(121, 50);
            this.comboBoxComboCalc_Operator.Name = "comboBoxComboCalc_Operator";
            this.comboBoxComboCalc_Operator.Size = new System.Drawing.Size(93, 20);
            this.comboBoxComboCalc_Operator.TabIndex = 5;
            // 
            // textBoxComboCalc_Result
            // 
            this.textBoxComboCalc_Result.Location = new System.Drawing.Point(452, 50);
            this.textBoxComboCalc_Result.Name = "textBoxComboCalc_Result";
            this.textBoxComboCalc_Result.Size = new System.Drawing.Size(100, 21);
            this.textBoxComboCalc_Result.TabIndex = 1;
            // 
            // textBoxComboCalc_Oper2
            // 
            this.textBoxComboCalc_Oper2.Location = new System.Drawing.Point(220, 49);
            this.textBoxComboCalc_Oper2.Name = "textBoxComboCalc_Oper2";
            this.textBoxComboCalc_Oper2.Size = new System.Drawing.Size(100, 21);
            this.textBoxComboCalc_Oper2.TabIndex = 1;
            // 
            // textBoxComboCalc_Oper1
            // 
            this.textBoxComboCalc_Oper1.Location = new System.Drawing.Point(15, 49);
            this.textBoxComboCalc_Oper1.Name = "textBoxComboCalc_Oper1";
            this.textBoxComboCalc_Oper1.Size = new System.Drawing.Size(100, 21);
            this.textBoxComboCalc_Oper1.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(482, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 12);
            this.label4.TabIndex = 4;
            this.label4.Text = "Result";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(141, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 3;
            this.label3.Text = "Operator";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(234, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "Operand 2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "Operand 1";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButtonOperator_pow);
            this.groupBox1.Controls.Add(this.radioButtonOperator_minus);
            this.groupBox1.Controls.Add(this.radioButtonOperator_plus);
            this.groupBox1.Controls.Add(this.buttonRadioBoxCalculator);
            this.groupBox1.Controls.Add(this.textBoxRadioCalc_Result);
            this.groupBox1.Controls.Add(this.textBoxRadioCalc_Oper2);
            this.groupBox1.Controls.Add(this.textBoxRadioCalc_Oper1);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Location = new System.Drawing.Point(58, 158);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(593, 103);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Radio button Calculator";
            // 
            // radioButtonOperator_minus
            // 
            this.radioButtonOperator_minus.AutoSize = true;
            this.radioButtonOperator_minus.Location = new System.Drawing.Point(122, 70);
            this.radioButtonOperator_minus.Name = "radioButtonOperator_minus";
            this.radioButtonOperator_minus.Size = new System.Drawing.Size(29, 16);
            this.radioButtonOperator_minus.TabIndex = 8;
            this.radioButtonOperator_minus.TabStop = true;
            this.radioButtonOperator_minus.Text = "-";
            this.radioButtonOperator_minus.UseVisualStyleBackColor = true;
            // 
            // radioButtonOperator_plus
            // 
            this.radioButtonOperator_plus.AutoSize = true;
            this.radioButtonOperator_plus.Location = new System.Drawing.Point(122, 51);
            this.radioButtonOperator_plus.Name = "radioButtonOperator_plus";
            this.radioButtonOperator_plus.Size = new System.Drawing.Size(29, 16);
            this.radioButtonOperator_plus.TabIndex = 7;
            this.radioButtonOperator_plus.TabStop = true;
            this.radioButtonOperator_plus.Text = "+";
            this.radioButtonOperator_plus.UseVisualStyleBackColor = true;
            // 
            // buttonRadioBoxCalculator
            // 
            this.buttonRadioBoxCalculator.Location = new System.Drawing.Point(326, 48);
            this.buttonRadioBoxCalculator.Name = "buttonRadioBoxCalculator";
            this.buttonRadioBoxCalculator.Size = new System.Drawing.Size(75, 23);
            this.buttonRadioBoxCalculator.TabIndex = 6;
            this.buttonRadioBoxCalculator.Text = "Calculate";
            this.buttonRadioBoxCalculator.UseVisualStyleBackColor = true;
            this.buttonRadioBoxCalculator.Click += new System.EventHandler(this.buttonRadioBoxCalculator_Click);
            // 
            // textBoxRadioCalc_Result
            // 
            this.textBoxRadioCalc_Result.Location = new System.Drawing.Point(452, 50);
            this.textBoxRadioCalc_Result.Name = "textBoxRadioCalc_Result";
            this.textBoxRadioCalc_Result.Size = new System.Drawing.Size(100, 21);
            this.textBoxRadioCalc_Result.TabIndex = 1;
            // 
            // textBoxRadioCalc_Oper2
            // 
            this.textBoxRadioCalc_Oper2.Location = new System.Drawing.Point(220, 49);
            this.textBoxRadioCalc_Oper2.Name = "textBoxRadioCalc_Oper2";
            this.textBoxRadioCalc_Oper2.Size = new System.Drawing.Size(100, 21);
            this.textBoxRadioCalc_Oper2.TabIndex = 1;
            // 
            // textBoxRadioCalc_Oper1
            // 
            this.textBoxRadioCalc_Oper1.Location = new System.Drawing.Point(15, 49);
            this.textBoxRadioCalc_Oper1.Name = "textBoxRadioCalc_Oper1";
            this.textBoxRadioCalc_Oper1.Size = new System.Drawing.Size(100, 21);
            this.textBoxRadioCalc_Oper1.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(482, 34);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 12);
            this.label5.TabIndex = 4;
            this.label5.Text = "Result";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(141, 34);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 12);
            this.label6.TabIndex = 3;
            this.label6.Text = "Operator";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(234, 34);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 12);
            this.label7.TabIndex = 2;
            this.label7.Text = "Operand 2";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(35, 34);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 12);
            this.label8.TabIndex = 1;
            this.label8.Text = "Operand 1";
            // 
            // radioButtonOperator_pow
            // 
            this.radioButtonOperator_pow.AutoSize = true;
            this.radioButtonOperator_pow.Location = new System.Drawing.Point(165, 51);
            this.radioButtonOperator_pow.Name = "radioButtonOperator_pow";
            this.radioButtonOperator_pow.Size = new System.Drawing.Size(29, 16);
            this.radioButtonOperator_pow.TabIndex = 9;
            this.radioButtonOperator_pow.TabStop = true;
            this.radioButtonOperator_pow.Text = "^";
            this.radioButtonOperator_pow.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(717, 315);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBoxComboCalc);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBoxComboCalc.ResumeLayout(false);
            this.groupBoxComboCalc.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxComboCalc;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonComboBoxCalculator;
        private System.Windows.Forms.ComboBox comboBoxComboCalc_Operator;
        private System.Windows.Forms.TextBox textBoxComboCalc_Result;
        private System.Windows.Forms.TextBox textBoxComboCalc_Oper2;
        private System.Windows.Forms.TextBox textBoxComboCalc_Oper1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButtonOperator_plus;
        private System.Windows.Forms.Button buttonRadioBoxCalculator;
        private System.Windows.Forms.TextBox textBoxRadioCalc_Result;
        private System.Windows.Forms.TextBox textBoxRadioCalc_Oper2;
        private System.Windows.Forms.TextBox textBoxRadioCalc_Oper1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.RadioButton radioButtonOperator_minus;
        private System.Windows.Forms.RadioButton radioButtonOperator_pow;
    }
}


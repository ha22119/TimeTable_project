namespace TimeTable_project
{
    partial class teacherMode
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBox6 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox7 = new System.Windows.Forms.ComboBox();
            this.modiTimeTableButton = new System.Windows.Forms.Button();
            this.comboBox8 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox9 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox10 = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.changeClass_label = new System.Windows.Forms.Label();
            this.changeDay_label = new System.Windows.Forms.Label();
            this.changeTime_label = new System.Windows.Forms.Label();
            this.beforeSub_label = new System.Windows.Forms.Label();
            this.changeSub_label = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.Size = new System.Drawing.Size(384, 495);
            this.dataGridView1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.changeSub_label);
            this.groupBox1.Controls.Add(this.beforeSub_label);
            this.groupBox1.Controls.Add(this.changeTime_label);
            this.groupBox1.Controls.Add(this.changeDay_label);
            this.groupBox1.Controls.Add(this.changeClass_label);
            this.groupBox1.Controls.Add(this.comboBox6);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.comboBox7);
            this.groupBox1.Controls.Add(this.modiTimeTableButton);
            this.groupBox1.Controls.Add(this.comboBox8);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.comboBox9);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.comboBox10);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(402, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(390, 495);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "시간표 교체";
            // 
            // comboBox6
            // 
            this.comboBox6.FormattingEnabled = true;
            this.comboBox6.Items.AddRange(new object[] {
            "창체",
            "진로",
            "성공적인 직업생활",
            "응용프로그래밍",
            "앱프로그래밍",
            "컴퓨터그래픽",
            "자료구조",
            "체육",
            "미술",
            "수학",
            "영어",
            "한국사"});
            this.comboBox6.Location = new System.Drawing.Point(50, 153);
            this.comboBox6.Name = "comboBox6";
            this.comboBox6.Size = new System.Drawing.Size(306, 23);
            this.comboBox6.TabIndex = 23;
            this.comboBox6.Text = "창체";
            this.comboBox6.SelectedIndexChanged += new System.EventHandler(this.comboBox6_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 394);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 15);
            this.label1.TabIndex = 23;
            this.label1.Text = "바뀐 과목";
            // 
            // comboBox7
            // 
            this.comboBox7.FormattingEnabled = true;
            this.comboBox7.Items.AddRange(new object[] {
            "창체",
            "진로",
            "성공적인 직업생활",
            "응용프로그래밍",
            "앱프로그래밍",
            "컴퓨터그래픽",
            "자료구조",
            "체육",
            "미술",
            "수학",
            "영어",
            "한국사"});
            this.comboBox7.Location = new System.Drawing.Point(50, 193);
            this.comboBox7.Name = "comboBox7";
            this.comboBox7.Size = new System.Drawing.Size(306, 23);
            this.comboBox7.TabIndex = 22;
            this.comboBox7.Text = "창체";
            this.comboBox7.SelectedIndexChanged += new System.EventHandler(this.comboBox7_SelectedIndexChanged);
            // 
            // modiTimeTableButton
            // 
            this.modiTimeTableButton.Location = new System.Drawing.Point(205, 436);
            this.modiTimeTableButton.Name = "modiTimeTableButton";
            this.modiTimeTableButton.Size = new System.Drawing.Size(151, 34);
            this.modiTimeTableButton.TabIndex = 19;
            this.modiTimeTableButton.Text = "시간표 교체하기";
            this.modiTimeTableButton.UseVisualStyleBackColor = true;
            this.modiTimeTableButton.Click += new System.EventHandler(this.modiTimeTableButton_Click);
            // 
            // comboBox8
            // 
            this.comboBox8.FormattingEnabled = true;
            this.comboBox8.Items.AddRange(new object[] {
            "1교시",
            "2교시",
            "3교시",
            "4교시",
            "5교시",
            "6교시",
            "7교시"});
            this.comboBox8.Location = new System.Drawing.Point(50, 112);
            this.comboBox8.Name = "comboBox8";
            this.comboBox8.Size = new System.Drawing.Size(306, 23);
            this.comboBox8.TabIndex = 21;
            this.comboBox8.Text = "1교시";
            this.comboBox8.SelectedIndexChanged += new System.EventHandler(this.comboBox8_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 354);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 15);
            this.label2.TabIndex = 22;
            this.label2.Text = "원래 과목";
            // 
            // comboBox9
            // 
            this.comboBox9.FormattingEnabled = true;
            this.comboBox9.Items.AddRange(new object[] {
            "월요일",
            "화요일",
            "수요일",
            "목요일",
            "금요일"});
            this.comboBox9.Location = new System.Drawing.Point(50, 74);
            this.comboBox9.Name = "comboBox9";
            this.comboBox9.Size = new System.Drawing.Size(306, 23);
            this.comboBox9.TabIndex = 20;
            this.comboBox9.Text = "월요일";
            this.comboBox9.SelectedIndexChanged += new System.EventHandler(this.comboBox9_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(65, 317);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 15);
            this.label3.TabIndex = 21;
            this.label3.Text = "교시";
            // 
            // comboBox10
            // 
            this.comboBox10.FormattingEnabled = true;
            this.comboBox10.Items.AddRange(new object[] {
            "1반",
            "2반",
            "3반",
            "4반"});
            this.comboBox10.Location = new System.Drawing.Point(50, 39);
            this.comboBox10.Name = "comboBox10";
            this.comboBox10.Size = new System.Drawing.Size(306, 23);
            this.comboBox10.TabIndex = 19;
            this.comboBox10.Text = "1반";
            this.comboBox10.SelectedIndexChanged += new System.EventHandler(this.comboBox10_SelectedIndexChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(71, 241);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(22, 15);
            this.label10.TabIndex = 19;
            this.label10.Text = "반";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(65, 277);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 15);
            this.label4.TabIndex = 20;
            this.label4.Text = "요일";
            // 
            // changeClass_label
            // 
            this.changeClass_label.AutoSize = true;
            this.changeClass_label.Location = new System.Drawing.Point(132, 242);
            this.changeClass_label.Name = "changeClass_label";
            this.changeClass_label.Size = new System.Drawing.Size(37, 15);
            this.changeClass_label.TabIndex = 24;
            this.changeClass_label.Text = "야호";
            // 
            // changeDay_label
            // 
            this.changeDay_label.AutoSize = true;
            this.changeDay_label.Location = new System.Drawing.Point(132, 277);
            this.changeDay_label.Name = "changeDay_label";
            this.changeDay_label.Size = new System.Drawing.Size(37, 15);
            this.changeDay_label.TabIndex = 25;
            this.changeDay_label.Text = "야호";
            // 
            // changeTime_label
            // 
            this.changeTime_label.AutoSize = true;
            this.changeTime_label.Location = new System.Drawing.Point(132, 317);
            this.changeTime_label.Name = "changeTime_label";
            this.changeTime_label.Size = new System.Drawing.Size(37, 15);
            this.changeTime_label.TabIndex = 26;
            this.changeTime_label.Text = "야호";
            // 
            // beforeSub_label
            // 
            this.beforeSub_label.AutoSize = true;
            this.beforeSub_label.Location = new System.Drawing.Point(132, 354);
            this.beforeSub_label.Name = "beforeSub_label";
            this.beforeSub_label.Size = new System.Drawing.Size(37, 15);
            this.beforeSub_label.TabIndex = 27;
            this.beforeSub_label.Text = "야호";
            // 
            // changeSub_label
            // 
            this.changeSub_label.AutoSize = true;
            this.changeSub_label.Location = new System.Drawing.Point(132, 394);
            this.changeSub_label.Name = "changeSub_label";
            this.changeSub_label.Size = new System.Drawing.Size(37, 15);
            this.changeSub_label.TabIndex = 28;
            this.changeSub_label.Text = "야호";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(50, 436);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(151, 34);
            this.button1.TabIndex = 29;
            this.button1.Text = "시간표 보기";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // teacherMode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 519);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "teacherMode";
            this.Text = "teacherMode";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comboBox6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox7;
        private System.Windows.Forms.Button modiTimeTableButton;
        private System.Windows.Forms.ComboBox comboBox8;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox9;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox10;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label changeSub_label;
        private System.Windows.Forms.Label beforeSub_label;
        private System.Windows.Forms.Label changeTime_label;
        private System.Windows.Forms.Label changeDay_label;
        private System.Windows.Forms.Label changeClass_label;
        private System.Windows.Forms.Button button1;
    }
}
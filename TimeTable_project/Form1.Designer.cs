namespace TimeTable_project
{
    partial class textGridView
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
            this.seeTimeTableButton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.choiceClassBox = new System.Windows.Forms.ComboBox();
            this.choiceDayBox = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.teacherPlace = new System.Windows.Forms.Label();
            this.classPlace = new System.Windows.Forms.Label();
            this.teacherName = new System.Windows.Forms.Label();
            this.subName = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.changeTime = new System.Windows.Forms.GroupBox();
            this.beforeSub = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.comboBox5 = new System.Windows.Forms.ComboBox();
            this.changeSub = new System.Windows.Forms.Label();
            this.timeChange = new System.Windows.Forms.Label();
            this.changeDay = new System.Windows.Forms.Label();
            this.changeClass = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.changeTimeTableButton = new System.Windows.Forms.Button();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.changeTime.SuspendLayout();
            this.SuspendLayout();
            // 
            // seeTimeTableButton
            // 
            this.seeTimeTableButton.Location = new System.Drawing.Point(672, 110);
            this.seeTimeTableButton.Name = "seeTimeTableButton";
            this.seeTimeTableButton.Size = new System.Drawing.Size(341, 53);
            this.seeTimeTableButton.TabIndex = 0;
            this.seeTimeTableButton.Text = "시간표 보기";
            this.seeTimeTableButton.UseVisualStyleBackColor = true;
            this.seeTimeTableButton.Click += new System.EventHandler(this.seeTimeTableButton_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 9);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.Size = new System.Drawing.Size(654, 306);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // choiceClassBox
            // 
            this.choiceClassBox.FormattingEnabled = true;
            this.choiceClassBox.Items.AddRange(new object[] {
            "1반",
            "2반",
            "3반",
            "4반"});
            this.choiceClassBox.Location = new System.Drawing.Point(672, 25);
            this.choiceClassBox.Name = "choiceClassBox";
            this.choiceClassBox.Size = new System.Drawing.Size(341, 23);
            this.choiceClassBox.TabIndex = 2;
            this.choiceClassBox.Text = "1반";
            // 
            // choiceDayBox
            // 
            this.choiceDayBox.FormattingEnabled = true;
            this.choiceDayBox.Items.AddRange(new object[] {
            "월요일",
            "화요일",
            "수요일",
            "목요일",
            "금요일"});
            this.choiceDayBox.Location = new System.Drawing.Point(672, 63);
            this.choiceDayBox.Name = "choiceDayBox";
            this.choiceDayBox.Size = new System.Drawing.Size(341, 23);
            this.choiceDayBox.TabIndex = 3;
            this.choiceDayBox.Text = "월요일";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.teacherPlace);
            this.groupBox1.Controls.Add(this.classPlace);
            this.groupBox1.Controls.Add(this.teacherName);
            this.groupBox1.Controls.Add(this.subName);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(672, 321);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(341, 261);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = " ";
            // 
            // teacherPlace
            // 
            this.teacherPlace.AutoSize = true;
            this.teacherPlace.Location = new System.Drawing.Point(124, 210);
            this.teacherPlace.Name = "teacherPlace";
            this.teacherPlace.Size = new System.Drawing.Size(0, 15);
            this.teacherPlace.TabIndex = 7;
            // 
            // classPlace
            // 
            this.classPlace.AutoSize = true;
            this.classPlace.Location = new System.Drawing.Point(124, 144);
            this.classPlace.Name = "classPlace";
            this.classPlace.Size = new System.Drawing.Size(0, 15);
            this.classPlace.TabIndex = 6;
            // 
            // teacherName
            // 
            this.teacherName.AutoSize = true;
            this.teacherName.Location = new System.Drawing.Point(124, 83);
            this.teacherName.Name = "teacherName";
            this.teacherName.Size = new System.Drawing.Size(0, 15);
            this.teacherName.TabIndex = 5;
            // 
            // subName
            // 
            this.subName.AutoSize = true;
            this.subName.Location = new System.Drawing.Point(124, 28);
            this.subName.Name = "subName";
            this.subName.Size = new System.Drawing.Size(0, 15);
            this.subName.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 210);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "선생님 위치";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "수업 장소";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "선생님";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "과목";
            // 
            // changeTime
            // 
            this.changeTime.Controls.Add(this.beforeSub);
            this.changeTime.Controls.Add(this.label9);
            this.changeTime.Controls.Add(this.comboBox5);
            this.changeTime.Controls.Add(this.changeSub);
            this.changeTime.Controls.Add(this.timeChange);
            this.changeTime.Controls.Add(this.changeDay);
            this.changeTime.Controls.Add(this.changeClass);
            this.changeTime.Controls.Add(this.label5);
            this.changeTime.Controls.Add(this.comboBox4);
            this.changeTime.Controls.Add(this.label6);
            this.changeTime.Controls.Add(this.label7);
            this.changeTime.Controls.Add(this.comboBox3);
            this.changeTime.Controls.Add(this.label8);
            this.changeTime.Controls.Add(this.changeTimeTableButton);
            this.changeTime.Controls.Add(this.comboBox2);
            this.changeTime.Controls.Add(this.comboBox1);
            this.changeTime.Location = new System.Drawing.Point(12, 321);
            this.changeTime.Name = "changeTime";
            this.changeTime.Size = new System.Drawing.Size(654, 261);
            this.changeTime.TabIndex = 5;
            this.changeTime.TabStop = false;
            this.changeTime.Text = "시간표 교체";
            // 
            // beforeSub
            // 
            this.beforeSub.AutoSize = true;
            this.beforeSub.Location = new System.Drawing.Point(387, 140);
            this.beforeSub.Name = "beforeSub";
            this.beforeSub.Size = new System.Drawing.Size(0, 15);
            this.beforeSub.TabIndex = 18;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(295, 180);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(72, 15);
            this.label9.TabIndex = 17;
            this.label9.Text = "바뀐 과목";
            // 
            // comboBox5
            // 
            this.comboBox5.FormattingEnabled = true;
            this.comboBox5.Items.AddRange(new object[] {
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
            this.comboBox5.Location = new System.Drawing.Point(10, 138);
            this.comboBox5.Name = "comboBox5";
            this.comboBox5.Size = new System.Drawing.Size(246, 23);
            this.comboBox5.TabIndex = 16;
            this.comboBox5.Text = "창체";
            this.comboBox5.SelectedIndexChanged += new System.EventHandler(this.comboBox5_SelectedIndexChanged);
            // 
            // changeSub
            // 
            this.changeSub.AutoSize = true;
            this.changeSub.Location = new System.Drawing.Point(387, 180);
            this.changeSub.Name = "changeSub";
            this.changeSub.Size = new System.Drawing.Size(0, 15);
            this.changeSub.TabIndex = 15;
            // 
            // timeChange
            // 
            this.timeChange.AutoSize = true;
            this.timeChange.Location = new System.Drawing.Point(387, 100);
            this.timeChange.Name = "timeChange";
            this.timeChange.Size = new System.Drawing.Size(0, 15);
            this.timeChange.TabIndex = 14;
            // 
            // changeDay
            // 
            this.changeDay.AutoSize = true;
            this.changeDay.Location = new System.Drawing.Point(387, 63);
            this.changeDay.Name = "changeDay";
            this.changeDay.Size = new System.Drawing.Size(0, 15);
            this.changeDay.TabIndex = 13;
            // 
            // changeClass
            // 
            this.changeClass.AutoSize = true;
            this.changeClass.Location = new System.Drawing.Point(387, 27);
            this.changeClass.Name = "changeClass";
            this.changeClass.Size = new System.Drawing.Size(0, 15);
            this.changeClass.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(295, 140);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 15);
            this.label5.TabIndex = 11;
            this.label5.Text = "원래 과목";
            // 
            // comboBox4
            // 
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Items.AddRange(new object[] {
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
            this.comboBox4.Location = new System.Drawing.Point(10, 178);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(246, 23);
            this.comboBox4.TabIndex = 7;
            this.comboBox4.Text = "창체";
            this.comboBox4.SelectedIndexChanged += new System.EventHandler(this.comboBox4_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(313, 103);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 15);
            this.label6.TabIndex = 10;
            this.label6.Text = "교시";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(313, 63);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 15);
            this.label7.TabIndex = 9;
            this.label7.Text = "요일";
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Items.AddRange(new object[] {
            "1교시",
            "2교시",
            "3교시",
            "4교시",
            "5교시",
            "6교시",
            "7교시"});
            this.comboBox3.Location = new System.Drawing.Point(10, 97);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(246, 23);
            this.comboBox3.TabIndex = 6;
            this.comboBox3.Text = "1교시";
            this.comboBox3.SelectedIndexChanged += new System.EventHandler(this.comboBox3_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(319, 27);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(22, 15);
            this.label8.TabIndex = 8;
            this.label8.Text = "반";
            // 
            // changeTimeTableButton
            // 
            this.changeTimeTableButton.Location = new System.Drawing.Point(6, 219);
            this.changeTimeTableButton.Name = "changeTimeTableButton";
            this.changeTimeTableButton.Size = new System.Drawing.Size(638, 34);
            this.changeTimeTableButton.TabIndex = 6;
            this.changeTimeTableButton.Text = "시간표 교체하기";
            this.changeTimeTableButton.UseVisualStyleBackColor = true;
            this.changeTimeTableButton.Click += new System.EventHandler(this.changeTimeTableButton_Click);
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "월요일",
            "화요일",
            "수요일",
            "목요일",
            "금요일"});
            this.comboBox2.Location = new System.Drawing.Point(10, 59);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(246, 23);
            this.comboBox2.TabIndex = 1;
            this.comboBox2.Text = "월요일";
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "1반",
            "2반",
            "3반",
            "4반"});
            this.comboBox1.Location = new System.Drawing.Point(10, 24);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(246, 23);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.Text = "1반";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // textGridView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1025, 591);
            this.Controls.Add(this.changeTime);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.choiceDayBox);
            this.Controls.Add(this.choiceClassBox);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.seeTimeTableButton);
            this.Name = "textGridView";
            this.Text = "천방지죽 어리둥절 빙글빙글 돌아가는 지슴 시같표";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.changeTime.ResumeLayout(false);
            this.changeTime.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button seeTimeTableButton;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox choiceClassBox;
        private System.Windows.Forms.ComboBox choiceDayBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label teacherPlace;
        private System.Windows.Forms.Label classPlace;
        private System.Windows.Forms.Label teacherName;
        private System.Windows.Forms.Label subName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox changeTime;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.Button changeTimeTableButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label changeSub;
        private System.Windows.Forms.Label timeChange;
        private System.Windows.Forms.Label changeDay;
        private System.Windows.Forms.Label changeClass;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox comboBox5;
        private System.Windows.Forms.Label beforeSub;
    }
}


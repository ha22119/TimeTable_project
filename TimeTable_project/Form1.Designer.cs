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
            this.modifyButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // seeTimeTableButton
            // 
            this.seeTimeTableButton.Location = new System.Drawing.Point(13, 389);
            this.seeTimeTableButton.Name = "seeTimeTableButton";
            this.seeTimeTableButton.Size = new System.Drawing.Size(303, 53);
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
            this.choiceClassBox.Location = new System.Drawing.Point(12, 327);
            this.choiceClassBox.Name = "choiceClassBox";
            this.choiceClassBox.Size = new System.Drawing.Size(303, 23);
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
            this.choiceDayBox.Location = new System.Drawing.Point(12, 356);
            this.choiceDayBox.Name = "choiceDayBox";
            this.choiceDayBox.Size = new System.Drawing.Size(303, 23);
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
            this.groupBox1.Location = new System.Drawing.Point(325, 317);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(341, 209);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = " ";
            // 
            // teacherPlace
            // 
            this.teacherPlace.AutoSize = true;
            this.teacherPlace.Location = new System.Drawing.Point(124, 164);
            this.teacherPlace.Name = "teacherPlace";
            this.teacherPlace.Size = new System.Drawing.Size(0, 15);
            this.teacherPlace.TabIndex = 7;
            // 
            // classPlace
            // 
            this.classPlace.AutoSize = true;
            this.classPlace.Location = new System.Drawing.Point(124, 116);
            this.classPlace.Name = "classPlace";
            this.classPlace.Size = new System.Drawing.Size(0, 15);
            this.classPlace.TabIndex = 6;
            // 
            // teacherName
            // 
            this.teacherName.AutoSize = true;
            this.teacherName.Location = new System.Drawing.Point(124, 70);
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
            this.label4.Location = new System.Drawing.Point(19, 164);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "선생님 위치";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "수업 장소";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 70);
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
            // modifyButton
            // 
            this.modifyButton.Location = new System.Drawing.Point(14, 467);
            this.modifyButton.Name = "modifyButton";
            this.modifyButton.Size = new System.Drawing.Size(303, 57);
            this.modifyButton.TabIndex = 19;
            this.modifyButton.Text = "수정하러가기";
            this.modifyButton.UseVisualStyleBackColor = true;
            this.modifyButton.Click += new System.EventHandler(this.modifyButton_Click);
            // 
            // textGridView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(680, 539);
            this.Controls.Add(this.modifyButton);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.choiceDayBox);
            this.Controls.Add(this.choiceClassBox);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.seeTimeTableButton);
            this.Name = "textGridView";
            this.Text = "시간표";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
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
        private System.Windows.Forms.Button modifyButton;
    }
}


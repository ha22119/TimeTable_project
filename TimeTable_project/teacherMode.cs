using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace TimeTable_project
{
    public partial class teacherMode : Form
    {
        private SqlConnection sqlConn = null;
        private string constr = "SERVER =127.0.0.1,1433; DATABASE =TimeTable_DB;" + "UID =hasum; PASSWORD =hatnalsdl132";
        public teacherMode()
        {
            InitializeComponent();
        }

        private void comboBox10_SelectedIndexChanged(object sender, EventArgs e)
        {
            changeClass_label.Text = comboBox10.Text;
        }
        private void comboBox9_SelectedIndexChanged(object sender, EventArgs e)
        {
            changeDay_label.Text = comboBox9.Text;
        }
        private void comboBox8_SelectedIndexChanged(object sender, EventArgs e)
        {
            changeTime_label.Text = comboBox8.Text;
        }
        private void comboBox6_SelectedIndexChanged(object sender, EventArgs e)
        {
            beforeSub_label.Text = comboBox6.Text;
        }
        private void comboBox7_SelectedIndexChanged(object sender, EventArgs e)
        {
            changeSub_label.Text = comboBox7.Text;
        }

        private void modiTimeTableButton_Click(object sender, EventArgs e) // 수정하기
        {
            string className = changeClass_label.Text;
            string dayName = changeDay_label.Text;
            string classN;
            string week;
            string beforeSub = beforeSub_label.Text;
            string changeSubText = changeSub_label.Text;
            string changeTime = changeTime_label.Text;

            classN = whatIsIt_class(className);
            week = whatIsIt_day(dayName);

            using (SqlConnection conn = new SqlConnection(constr))
            {
                conn.Open();
                SqlCommand command = new SqlCommand();
                command.Connection = conn;

                command.CommandText // 데이터 내용 수정
                    = "UPDATE " + classN
                    + " SET " + week + " = '" + changeSubText + "'"
                    + " WHERE " + week + " = '" + beforeSub + "';";
                command.ExecuteNonQuery(); // sql 실행
                seeChangeTimeTableButton_Click(null, null); // 다시 전체 조회 ㄱ
            }
        }

        private void seeChangeTimeTableButton_Click(object sender, EventArgs e)
        {
            string dayName = comboBox9.Text;
            string className = comboBox10.Text;
            string classN = whatIsIt_class(className);
            string week = whatIsIt_day(dayName);

            DataSet ds = new DataSet();

            using (SqlConnection conn = new SqlConnection(constr))
            {
                conn.Open();
                string sql = "SELECT class as '시간', " + week + " as '" + dayName + "' " 
                    + " From " + classN
                    + ";";
                SqlDataAdapter adapter = new SqlDataAdapter(sql, conn);
                adapter.Fill(ds, classN);
            }
            dataGridView1.DataSource = ds.Tables[0];
        }
        private string whatIsIt_class(string className)
        {
            string classN = null;

            if (className.Equals("1반"))
            {
                classN = "class1Table";
            }
            else if (className.Equals("2반"))
            {
                classN = "class2Table";
            }
            else if (className.Equals("3반"))
            {
                classN = "class3Table";
            }
            else if (className.Equals("4반"))
            {
                classN = "class4Table";
            }
            return classN;
        }
        private string whatIsIt_day(string dayName)
        {
            string week = null;

            if (dayName.Equals("월요일"))
            {
                week = "mon";
            }
            else if (dayName.Equals("화요일"))
            {
                week = "tue";
            }
            else if (dayName.Equals("수요일"))
            {
                week = "wed";
            }
            else if (dayName.Equals("목요일"))
            {
                week = "thu";
            }
            else if (dayName.Equals("금요일"))
            {
                week = "fri";
            }

            return week;
        }
    }
}
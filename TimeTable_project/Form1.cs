using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace TimeTable_project
{
    public partial class textGridView : Form
    {
        private SqlConnection sqlConn = null;
        private string constr = "SERVER =127.0.0.1,1433; DATABASE =TimeTable_DB;" + "UID =hasum; PASSWORD =hatnalsdl132";

        public textGridView()
        {
            InitializeComponent();
        }

        private void seeTimeTableButton_Click(object sender, EventArgs e)
        {
            string dayName = choiceDayBox.Text;
            string className = choiceClassBox.Text;
            string classN = null;
            string week = null;

            classN = whatIsIt_class(className);
            week = whatIsIt_day(dayName);

            //data를 조회해 와서 저장 
            DataSet ds = new DataSet();

            using (SqlConnection conn = new SqlConnection(constr))
            {
                conn.Open();
                string sql = "SELECT class as '시간', " + week + " as '" + dayName 
                    + "', teacher_Table.teacherName as '선생님', subTable.classPlace as '수업장소'," +
                    " teacher_Table.teacherPlace as '선생님 위치'"
                    + " From " + classN
                    + " LEFT OUTER JOIN subTable ON " + classN + "." + week + " = subTable.subName"
                    + " LEFT OUTER JOIN teacher_Table ON " + classN + "." + week + " = teacher_Table.subName"
                    + ";";
                SqlDataAdapter adapter = new SqlDataAdapter(sql, conn);
                adapter.Fill(ds, classN);
            }
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string dayName = choiceDayBox.Text;

            subName.Text = dataGridView1.Rows[e.RowIndex].Cells[dayName].Value.ToString();
            teacherName.Text = dataGridView1.Rows[e.RowIndex].Cells["선생님"].Value.ToString();
            teacherPlace.Text = dataGridView1.Rows[e.RowIndex].Cells["선생님 위치"].Value.ToString();
            classPlace.Text = dataGridView1.Rows[e.RowIndex].Cells["수업장소"].Value.ToString();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            changeClass.Text = comboBox1.Text;
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            changeDay.Text = comboBox2.Text;
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            timeChange.Text = comboBox3.Text;
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            changeSub.Text = comboBox4.Text;
        }
        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {
            beforeSub.Text = comboBox5.Text;
        }

        private void changeTimeTableButton_Click(object sender, EventArgs e) // 수정하기
        {
            string className = comboBox1.Text;
            string dayName = comboBox2.Text;
            string classN;
            string week;
            string beforeSub = comboBox5.Text;
            string changeSubText = comboBox4.Text;
            string changeTime = comboBox3.Text;

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
                    + " WHERE "+week+" = '" + beforeSub + "';";
                command.ExecuteNonQuery(); // sql 실행
                seeChangeTimeTableButton_Click(null, null); // 다시 전체 조회 ㄱ
            }
        }

        private void seeChangeTimeTableButton_Click(object sender, EventArgs e)
        {
            string dayName = comboBox2.Text;
            string className = comboBox1.Text;
            string classN = whatIsIt_class(className);
            string week = whatIsIt_day(dayName);

            choiceClassBox.SelectedItem = className;
            choiceClassBox.Text = className;
            choiceDayBox.SelectedItem = dayName;
            choiceDayBox.Text = dayName;

            DataSet ds = new DataSet();

            using (SqlConnection conn = new SqlConnection(constr))
            {
                conn.Open();
                string sql = "SELECT class as '시간', " + week + " as '" + dayName + "', teacher_Table.teacherName as '선생님'," +
                    " subTable.classPlace as '수업장소', teacher_Table.teacherPlace as '선생님 위치'"
                    + " From " + classN
                    + " LEFT OUTER JOIN subTable ON " + classN + "." + week + " = subTable.subName"
                    + " LEFT OUTER JOIN teacher_Table ON " + classN + "." + week + " = teacher_Table.subName"
                    + ";";
                SqlDataAdapter adapter = new SqlDataAdapter(sql, conn);
                adapter.Fill(ds, classN);
            }
            dataGridView1.DataSource = ds.Tables[0];
        }

        private string whatIsIt_class(string className)
        {
            string classN=null;

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

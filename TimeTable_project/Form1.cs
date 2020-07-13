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
            String dayName = choiceDayBox.Text;
            String className = choiceClassBox.Text;
            String classN = null;
            String week = null;

            if (className.Equals("1반"))
            {
                classN = "class1Table";
            }else if (className.Equals("2반"))
            {
                classN = "class2Table";
            }else if (className.Equals("3반"))
            {
                classN = "class3Table";
            }else if (className.Equals("4반"))
            {
                classN = "class4Table";
            }

            if (dayName.Equals("월요일"))
            {
                week = "mon";
            }else if (dayName.Equals("화요일"))
            {
                week = "tue";
            }else if (dayName.Equals("수요일"))
            {
                week = "wed";
            }else if (dayName.Equals("목요일"))
            {
                week = "thu";
            }else if (dayName.Equals("금요일"))
            {
                week = "fri";
            }

            //data를 조회해 와서 저장 
            DataSet ds = new DataSet();

            using (SqlConnection conn = new SqlConnection(constr))
            {
                conn.Open();
                string sql = "SELECT class as '시간', " + week + " as '" + dayName+"', teacher_Table.teacherName as '선생님', subTable.classPlace as '수업장소', teacher_Table.teacherPlace as '선생님 위치'" 
                    + " From " + classN 
                    +" LEFT OUTER JOIN subTable ON "+classN+"."+week+" = subTable.subName"
                    +" LEFT OUTER JOIN teacher_Table ON "+classN+"."+week+" = teacher_Table.subName"
                    + ";" ;
                SqlDataAdapter adapter = new SqlDataAdapter(sql, conn);
                adapter.Fill(ds, classN);
            }
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            String dayName = choiceDayBox.Text;

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

        private void changeTimeTableButton_Click(object sender, EventArgs e)
        {
            String className = choiceClassBox.Text;
            String classN = null;
            String week = null;

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

            if (changeDay.Equals("월요일"))
            {
                week = "mon";
            }
            else if (changeDay.Equals("화요일"))
            {
                week = "tue";
            }
            else if (changeDay.Equals("수요일"))
            {
                week = "wed";
            }
            else if (changeDay.Equals("목요일"))
            {
                week = "thu";
            }
            else if (changeDay.Equals("금요일"))
            {
                week = "fri";
            }

            DataSet ds = new DataSet();
            using (SqlConnection conn = new SqlConnection(constr))
            {
                conn.Open();
                string sql = "UPDATE "+classN // 데이터 내용 바꾸고
                    +" SET "+ week + " = '"+changeSub+"'"
                    +" WHERE class = '"+changeTime+"';"; 
                   
                SqlDataAdapter adapter = new SqlDataAdapter(sql, conn);
                adapter.Fill(ds, classN);

                 sql = "SELECT class as '시간', " + week + " as '" + changeDay + "', teacher_Table.teacherName as '선생님', subTable.classPlace as '수업장소', teacher_Table.teacherPlace as '선생님 위치'"
                        + " From " + classN
                        + " LEFT OUTER JOIN subTable ON " + classN + "." + week + " = subTable.subName"
                        + " LEFT OUTER JOIN teacher_Table ON " + classN + "." + week + " = teacher_Table.subName"
                        + ";"; // 바뀐 내용 보여주기
                    adapter = new SqlDataAdapter(sql, conn);
                    adapter.Fill(ds, classN);
            }
            dataGridView1.DataSource = ds.Tables[0];
        }
    }
}

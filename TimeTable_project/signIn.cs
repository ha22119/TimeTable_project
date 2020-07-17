using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TimeTable_project
{
    public partial class signIn : Form
    {
        private string constr = "SERVER =127.0.0.1,1433; DATABASE =TimeTable_DB;" + "UID =hasum; PASSWORD =hatnalsdl132";
        public signIn()
        {
            InitializeComponent();
        }

        private void signUpLabel_Click(object sender, EventArgs e)
        {
            signUp signUpPage = new signUp();
            signUpPage.Show();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            string teacherName = textBox1.Text.ToString();
            string pwd = textBox2.Text;
            bool login = false;

            if (teacherName.Equals("") || pwd.Equals(""))
            {
                MessageBox.Show("이름 또는 비밀번호를 확인해주세요.");
            }
            else
            {
                DataSet ds = new DataSet();
                using (SqlConnection conn = new SqlConnection(constr))
                {
                    conn.Open();
                    string sql = "Select teacher_name, pass From signUpTable "
                    + " where teacher_name = '" + teacherName +"' AND pass = '"+pwd+"';";

                    SqlCommand cmd = new SqlCommand(sql, conn);
                    SqlDataReader sdr = cmd.ExecuteReader();

                    while (sdr.Read())
                    {
                        string dbTn = sdr["teacher_name"].ToString().Trim();
                        string dbPwd = sdr["pass"].ToString().Trim();
                        bool nameSame = dbTn.Equals(teacherName);
                        bool passSame = dbPwd.Equals(pwd);

                        if (nameSame)
                        {
                            if (passSame)
                                login = true;
                            else
                                MessageBox.Show("비밀번호 틀림");
                        }
                        else
                            MessageBox.Show("이름이 맞는지 확인하세요");
                    }
                    sdr.Close();

                    if (login)
                    {
                        teacherMode teacherModePage = new teacherMode();
                        MessageBox.Show("로그인 성공");
                        teacherModePage.Show();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("로그인 실패");
                    }
                }
            }
        }
        private void taltoiButton_Click(object sender, EventArgs e)
        {
            talToi talToiPage = new talToi();
            talToiPage.Show();
        }
    }
}
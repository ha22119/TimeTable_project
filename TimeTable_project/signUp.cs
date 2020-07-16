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
    public partial class signUp : Form
    {
        private SqlConnection sqlConn = null;
        private string constr = "SERVER =127.0.0.1,1433; DATABASE =TimeTable_DB;" + "UID =hasum; PASSWORD =hatnalsdl132";

        public signUp()
        {
            InitializeComponent();
        }

        private void signUpButton_Click(object sender, EventArgs e)
        {
            string teacher_name = nameLabel.Text;
            string pass = passLabel.Text;
            string rePass = rePassLabel.Text;
            DataSet ds = new DataSet();
            string classN = "signUpTable";

            if (pass.Equals(rePass))
            {
                if ((!pass.Equals("")))
                {
                    using (SqlConnection conn = new SqlConnection(constr))
                    {
                        conn.Open();
                        string sql = "INSERT INTO signUpTable (teacher_name,pass)"
                            + " VALUES('" + teacher_name + "', '" + pass + "');";
                        SqlDataAdapter adapter = new SqlDataAdapter(sql, conn);
                        adapter.Fill(ds, classN);

                        MessageBox.Show(teacher_name + " 회원가입 완료");
                        ;
                    }
                }
                else
                {
                    MessageBox.Show("비밀번호를 입력해주세요");
                }
            }
            else
            {
                MessageBox.Show("비밀번호가 일치하지 않습니다 ");
            }
            this.Close();
        }
    }
}
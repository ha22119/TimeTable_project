using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace TimeTable_project // 구현 완료
{
    public partial class talToi : Form
    {
        private string constr = "SERVER =127.0.0.1,1433; DATABASE =TimeTable_DB;" + "UID =hasum; PASSWORD =hatnalsdl132";

        public talToi()
        {
            InitializeComponent();
        }

        private void taltoiButton_Click(object sender, EventArgs e)
        {
            string taltoiUserName = idTextBox.Text;
            string taltoiUserPass = passTextBox.Text;

            DataSet ds = new DataSet();

            using (SqlConnection conn = new SqlConnection(constr))
            {
                string sql = "Delete From signUPTable "
                + "Where teacher_name ='"+taltoiUserName +"' AND pass = '"+ taltoiUserPass + "';";

                SqlDataAdapter adapter = new SqlDataAdapter(sql, conn);
                adapter.Fill(ds, "signUpTable");
            }
            MessageBox.Show("탈퇴 완료");
            this.Close();
        }
    }
}
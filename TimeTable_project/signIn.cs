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
            string teacherName = textBox1.Text;
            string pwd = textBox2.Text;

            using (SqlConnection conn = new SqlConnection(constr))
            {
                conn.Open();
                string sql = "SELECT class as '";
                SqlDataAdapter adapter = new SqlDataAdapter(sql, conn);
            }

            teacherMode teacherModePage = new teacherMode();
            teacherModePage.Show();
            this.Close();
        }

        private void taltoiButton_Click(object sender, EventArgs e)
        {
            talToi talToiPage = new talToi();
            talToiPage.Show();
        }
    }
}
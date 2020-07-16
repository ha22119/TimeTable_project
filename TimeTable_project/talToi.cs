using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TimeTable_project
{
    public partial class talToi : Form
    {
        public talToi()
        {
            InitializeComponent();
        }

        private void taltoiButton_Click(object sender, EventArgs e)
        {
            string taltoiUserName = idTextBox.Text;
            string taltoiUserPass = passTextBox.Text;

            MessageBox.Show("탈퇴 완료");
            this.Close();
        }
    }
}
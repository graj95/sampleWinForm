using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sampleWinForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
          if (textUserId.Text =="admin" && textPassword.Text=="123")
            {
                MessageBox.Show("Success");
            }
            else
            {
                MessageBox.Show("Faill");
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            textUserId.Clear();
            textPassword.Clear();
        }
    }
}

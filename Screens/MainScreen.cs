using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EBookReader
{
    public partial class MainScreen : Form
    {
        public MainScreen()
        {
            InitializeComponent();
        }

        private void btnUser_Click(object sender, EventArgs e)
        {
            Hide();
            UserScreen form = new UserScreen();
            form.ShowDialog();
            Close();
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            Hide();
            AdminScreen form = new AdminScreen();
            form.ShowDialog();
            Close();
        }
    }
}

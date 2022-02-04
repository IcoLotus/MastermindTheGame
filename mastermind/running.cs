using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mastermind
{
    public partial class running : Form
    {
        public running()
        {
            InitializeComponent();
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void running_Load(object sender, EventArgs e)
        {
            mainmenu lauch = new mainmenu();
            lauch.ShowDialog();
        }
    }
}

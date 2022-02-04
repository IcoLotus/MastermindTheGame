using System;
using System.Windows.Forms;

namespace mastermind_pre_2_0
{
    public partial class mastermind_pre_2 : Form
    {
        public mastermind_pre_2()
        {
            InitializeComponent();
        }

        private void mastermind_pre_2_Load(object sender, EventArgs e)
        {
            mainmenu mainmenu = new mainmenu();
            mainmenu.ShowDialog();
        }

        private void btn_quit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

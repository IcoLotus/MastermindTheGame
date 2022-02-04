using System;
using System.Windows.Forms;
using System.IO;
using System.Threading.Tasks;

namespace mastermind_pre_2_0
{
    public partial class mmgeneral : Form
    {
        public mmgeneral()
        {
            InitializeComponent();
        }

        private void mastermind_pre_2_Load(object sender, EventArgs e)
        {
            Application_Open();
            mainmenu mainmenu = new mainmenu();
            mainmenu.ShowDialog();
        }

        private void btn_quit_Click(object sender, EventArgs e)
        {
            Application_Exit();        
        }
        public void Application_Exit()
        {

            Application.Exit();
        }
        public void Application_Open()
        {

        }
    }
}

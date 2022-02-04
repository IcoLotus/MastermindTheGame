using System;
using System.Windows.Forms;
using System.IO;
using System.Collections.Generic;
using System.Linq;
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
            string s = "codelength = 4";
            String[] k =  s.Split('=');
            List<String> settingslistauto = File.ReadAllLines("settings_autocode.txt").ToList();
            String[] settings_autocode = new string[69];
            //File.WriteAllLines("settings_autocode.txt",settings_autocode[]);
        }
        public void Application_Open()
        {
            int linies = 0;
            String[] settings_auto = new string[69];
            List<String> settingslistauto = File.ReadAllLines("settings_autocode.txt").ToList();
            foreach(string lines in settingslistauto)
            {
                String[] splitter = lines.Split('=');
                settings_auto[linies] = splitter[1];
                linies++;
            }
            settings.a_codelength = Convert.ToInt32(settings_auto[0]);
            MessageBox.Show(settings_auto[0]);
            MessageBox.Show(settings_auto[1]);
        }
    }
}

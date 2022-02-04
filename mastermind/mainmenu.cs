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
    public partial class mainmenu : Form
    {
        public mainmenu()
        {
            InitializeComponent();
        }

        private void btn_start_Click(object sender, EventArgs e)
        {
            maingame game = new maingame();
            game.ShowDialog();
        }

        private void btn_options_Click(object sender, EventArgs e)
        {
            settings.settings_via_game = false;
            settings setopt = new settings();
            setopt.ShowDialog();
        }

        private void btn_quit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_rules_Click(object sender, EventArgs e)
        {
            rules rls = new rules();
            rls.Show();
        }

        private void btn_mod_Click(object sender, EventArgs e)
        {
            mod moded = new mod();
            moded.ShowDialog();
        }
    }
}

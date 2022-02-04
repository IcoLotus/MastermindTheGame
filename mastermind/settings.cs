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
    public partial class settings : Form
    {
        public settings()
        {
            InitializeComponent();
        }

        //settings - load display correct

        private void settings_Load(object sender, EventArgs e)
        {
            switch (settings.difficulty)
            {
                case 0:
                    btn_normal.ForeColor = Color.Red;
                    btn_normal.FlatAppearance.BorderColor = Color.Red;
                    btn_hard.ForeColor = SystemColors.Menu;
                    btn_hard.FlatAppearance.BorderColor = SystemColors.Menu;
                    btn_hc.ForeColor = SystemColors.Menu;
                    btn_hc.FlatAppearance.BorderColor = SystemColors.Menu;
                    btn_uhc.ForeColor = SystemColors.Menu;
                    btn_uhc.FlatAppearance.BorderColor = SystemColors.Menu;
                    break;
                case 1:
                    btn_normal.ForeColor = SystemColors.Menu;
                    btn_normal.FlatAppearance.BorderColor = SystemColors.Menu;
                    btn_hard.ForeColor = Color.Red;
                    btn_hard.FlatAppearance.BorderColor = Color.Red;
                    btn_hc.ForeColor = SystemColors.Menu;
                    btn_hc.FlatAppearance.BorderColor = SystemColors.Menu;
                    btn_uhc.ForeColor = SystemColors.Menu;
                    btn_uhc.FlatAppearance.BorderColor = SystemColors.Menu;
                    break;
                case 2:
                    btn_normal.ForeColor = SystemColors.Menu;
                    btn_normal.FlatAppearance.BorderColor = SystemColors.Menu;
                    btn_hard.ForeColor = SystemColors.Menu;
                    btn_hard.FlatAppearance.BorderColor = SystemColors.Menu;
                    btn_hc.ForeColor = Color.Red;
                    btn_hc.FlatAppearance.BorderColor = Color.Red;
                    btn_uhc.ForeColor = SystemColors.Menu;
                    btn_uhc.FlatAppearance.BorderColor = SystemColors.Menu;
                    break;
                case 3:
                    btn_normal.ForeColor = SystemColors.Menu;
                    btn_normal.FlatAppearance.BorderColor = SystemColors.Menu;
                    btn_hard.ForeColor = SystemColors.Menu;
                    btn_hard.FlatAppearance.BorderColor = SystemColors.Menu;
                    btn_hc.ForeColor = SystemColors.Menu;
                    btn_hc.FlatAppearance.BorderColor = SystemColors.Menu;
                    btn_uhc.ForeColor = Color.Red;
                    btn_uhc.FlatAppearance.BorderColor = Color.Red;
                    break;
            }

            if (settings.clear_lst_past_game == false)
            {
                btn_clear_lst.ForeColor = Color.Red;
                btn_clear_lst.FlatAppearance.BorderColor = Color.Red;
            }
            else
            {
                btn_clear_lst.ForeColor = Color.LimeGreen;
                btn_clear_lst.FlatAppearance.BorderColor = Color.LimeGreen;
            }

            if (settings.time_lst_past_game == false)
            {
                btn_time_lst.ForeColor = Color.Red;
                btn_time_lst.FlatAppearance.BorderColor = Color.Red;
            }
            else
            {
                btn_time_lst.ForeColor = Color.LimeGreen;
                btn_time_lst.FlatAppearance.BorderColor = Color.LimeGreen;
            }

            if (settings.attempts_lst_past_game == false)
            {
                btn_attempts_lst.ForeColor = Color.Red;
                btn_attempts_lst.FlatAppearance.BorderColor = Color.Red;
            }
            else
            {
                btn_attempts_lst.ForeColor = Color.LimeGreen;
                btn_attempts_lst.FlatAppearance.BorderColor = Color.LimeGreen;
            }

            if (settings.settings_via_game == true)
            {
                btn_to_game.Visible = true;
                btn_quit.Visible = false;
            }
        }

        //settings - buttons

        private void btn_normal_Click(object sender, EventArgs e)
        {
            settings.difficulty = 0;
            btn_normal.ForeColor = Color.Red;
            btn_normal.FlatAppearance.BorderColor = Color.Red;
            btn_hard.ForeColor = SystemColors.Menu;
            btn_hard.FlatAppearance.BorderColor = SystemColors.Menu;
            btn_hc.ForeColor = SystemColors.Menu;
            btn_hc.FlatAppearance.BorderColor = SystemColors.Menu;
            btn_uhc.ForeColor = SystemColors.Menu;
            btn_uhc.FlatAppearance.BorderColor = SystemColors.Menu;
        }

        private void btn_hard_Click(object sender, EventArgs e)
        {
            settings.difficulty = 1;
            btn_normal.ForeColor = SystemColors.Menu;
            btn_normal.FlatAppearance.BorderColor = SystemColors.Menu;
            btn_hard.ForeColor = Color.Red;
            btn_hard.FlatAppearance.BorderColor = Color.Red;
            btn_hc.ForeColor = SystemColors.Menu;
            btn_hc.FlatAppearance.BorderColor = SystemColors.Menu;
            btn_uhc.ForeColor = SystemColors.Menu;
            btn_uhc.FlatAppearance.BorderColor = SystemColors.Menu;
        }

        private void btn_hc_Click(object sender, EventArgs e)
        {
            settings.difficulty = 2;
            btn_normal.ForeColor = SystemColors.Menu;
            btn_normal.FlatAppearance.BorderColor = SystemColors.Menu;
            btn_hard.ForeColor = SystemColors.Menu;
            btn_hard.FlatAppearance.BorderColor = SystemColors.Menu;
            btn_hc.ForeColor = Color.Red;
            btn_hc.FlatAppearance.BorderColor = Color.Red;
            btn_uhc.ForeColor = SystemColors.Menu;
            btn_uhc.FlatAppearance.BorderColor = SystemColors.Menu;
        }

        private void btn_uhc_Click(object sender, EventArgs e)
        {
            settings.difficulty = 3;
            btn_normal.ForeColor = SystemColors.Menu;
            btn_normal.FlatAppearance.BorderColor = SystemColors.Menu;
            btn_hard.ForeColor = SystemColors.Menu;
            btn_hard.FlatAppearance.BorderColor = SystemColors.Menu;
            btn_hc.ForeColor = SystemColors.Menu;
            btn_hc.FlatAppearance.BorderColor = SystemColors.Menu;
            btn_uhc.ForeColor = Color.Red;
            btn_uhc.FlatAppearance.BorderColor = Color.Red;
        }

        private void btn_clear_lst_Click(object sender, EventArgs e)
        {
            if (settings.clear_lst_past_game == false)
            {
                btn_clear_lst.ForeColor = Color.LimeGreen;
                btn_clear_lst.FlatAppearance.BorderColor = Color.LimeGreen;
                settings.clear_lst_past_game = true;
            }
            else
            {
                btn_clear_lst.ForeColor = Color.Red;
                btn_clear_lst.FlatAppearance.BorderColor = Color.Red;
                settings.clear_lst_past_game = false;
            }
        }

        private void btn_time_lst_Click(object sender, EventArgs e)
        {
            if (settings.time_lst_past_game == false)
            {
                btn_time_lst.ForeColor = Color.LimeGreen;
                btn_time_lst.FlatAppearance.BorderColor = Color.LimeGreen;
                settings.time_lst_past_game = true;
            }
            else
            {
                btn_time_lst.ForeColor = Color.Red;
                btn_time_lst.FlatAppearance.BorderColor = Color.Red;
                settings.time_lst_past_game = false;
            }
        }

        private void btn_attempts_lst_Click(object sender, EventArgs e)
        {
            if (settings.attempts_lst_past_game == false)
            {
                btn_attempts_lst.ForeColor = Color.LimeGreen;
                btn_attempts_lst.FlatAppearance.BorderColor = Color.LimeGreen;
                settings.attempts_lst_past_game = true;
            }
            else
            {
                btn_attempts_lst.ForeColor = Color.Red;
                btn_attempts_lst.FlatAppearance.BorderColor = Color.Red;
                settings.attempts_lst_past_game = false;
            }
        }

        private void btn_quit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_to_game_Click(object sender, EventArgs e)
        {
            settings.settings_via_game = false;
            this.Close();
        }

        //settings - methods

        private static int _difficulty = 0;
        public static int difficulty
        {
            get
            {
                return _difficulty;
            }
            set
            {
                _difficulty = value;
            }
        }

        private static bool _clear_lst_past_game = false;
        public static bool clear_lst_past_game
        {
            get
            {
                return _clear_lst_past_game;
            }
            set
            {
                _clear_lst_past_game = value;
            }
        }

        private static bool _time_lst_past_game = false;
        public static bool time_lst_past_game
        {
            get
            {
                return _time_lst_past_game;
            }
            set
            {
                _time_lst_past_game = value;
            }
        }

        private static bool _attempts_lst_past_game = false;
        public static bool attempts_lst_past_game
        {
            get
            {
                return _attempts_lst_past_game;
            }
            set
            {
                _attempts_lst_past_game = value;
            }
        }

        private static bool _settings_via_game = false;
        public static bool settings_via_game
        {
            set
            {
                _settings_via_game = value;
            }
            get
            {
                return _settings_via_game;
            }
        }

        //settings - new stuff to sort

    }
}
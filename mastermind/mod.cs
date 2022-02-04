using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace mastermind
{
    public partial class mod : Form
    {
        public mod()
        {
            InitializeComponent();
        }

        //variables and arrays

        //gameessentials

        public List<String> randlist = new List<String>();
        static Random rnd = new Random();
        private String rnds = "";
        StringBuilder sb = new StringBuilder();
        private int bulls = 0;
        private int cows = 0;

        //time and scores

        private bool max_time_bool = false;
        private int max_time_int = 0;
        private bool max_attempts_bool = false;
        private int max_attempts_int = 0;
        private int hrs = 0;
        private int min = 0;
        private int sec = 0;
        private int msec = 0;
        private String time = "";
        private int attempts = 0;


        //buttons and stuff

        private void moddedgame_Load(object sender, EventArgs e)
        {
            txt_preset.Text = "";
            if (mode_code == 1)
            {
                //autocode
                btn_nmb_mode.Text = "Mode: Preset Code";
                btn_nmb_restriction.Visible = false;
                btn_allow_show_code.Visible = true;
                lbl_codelength.Visible = false;
                txt_codelength.Visible = false;
                lbl_preset.Visible = true;
                txt_preset.Visible = true;
            }
            else
            {
                //preset code
                btn_nmb_mode.Text = "Mode: Autocode";
                btn_nmb_restriction.Visible = true;
                btn_allow_show_code.Visible = false;
                lbl_codelength.Visible = true;
                txt_codelength.Visible = true;
                lbl_preset.Visible = false;
                txt_preset.Visible = false;
            }

            if (allow_code_show == true)
            {
                btn_allow_show_code.ForeColor = Color.LimeGreen;
                btn_allow_show_code.FlatAppearance.BorderColor = Color.LimeGreen;
            }
            else
            {
                btn_allow_show_code.ForeColor = Color.Red;
                btn_allow_show_code.FlatAppearance.BorderColor = Color.Red;
            }

            if (Number_Restriction == true)
            {
                btn_nmb_restriction.ForeColor = Color.LimeGreen;
                btn_nmb_restriction.FlatAppearance.BorderColor = Color.LimeGreen;
            }
            else
            {
                btn_nmb_restriction.ForeColor = Color.Red;
                btn_nmb_restriction.FlatAppearance.BorderColor = Color.Red;
            }

            if (display_time == true)
            {
                btn_show_time.ForeColor = Color.LimeGreen;
                btn_show_time.FlatAppearance.BorderColor = Color.LimeGreen;
            }
            else
            {
                btn_show_time.ForeColor = Color.Red;
                btn_show_time.FlatAppearance.BorderColor = Color.Red;
            }

            if (display_attempts == true)
            {
                btn_show_attempts.ForeColor = Color.LimeGreen;
                btn_show_attempts.FlatAppearance.BorderColor = Color.LimeGreen;
            }
            else
            {
                btn_show_attempts.ForeColor = Color.Red;
                btn_show_attempts.FlatAppearance.BorderColor = Color.Red;
            }

            if (max_time_bool == true)
            {
                btn_max_time.ForeColor = Color.LimeGreen;
                btn_max_time.FlatAppearance.BorderColor = Color.LimeGreen;
                txt_max_time.Visible = true;
            }
            else
            {
                btn_max_time.ForeColor = Color.Red;
                btn_max_time.FlatAppearance.BorderColor = Color.Red;
                txt_max_time.Visible = false;
            }

            if (max_attempts_bool == true)
            {
                btn_max_attempts.ForeColor = Color.LimeGreen;
                btn_max_attempts.FlatAppearance.BorderColor = Color.LimeGreen;
                txt_max_attempts.Visible = true;
            }
            else
            {
                btn_max_attempts.ForeColor = Color.Red;
                btn_max_attempts.FlatAppearance.BorderColor = Color.Red;
                txt_max_attempts.Visible = false;
            }

            if (clear_lst == true)
            {
                btn_clear_lst.ForeColor = Color.LimeGreen;
                btn_clear_lst.FlatAppearance.BorderColor = Color.LimeGreen;
            }
            else
            {
                btn_clear_lst.ForeColor = Color.Red;
                btn_clear_lst.FlatAppearance.BorderColor = Color.Red;
            }
        }

        private void btn_exe_Click(object sender, EventArgs e)
        {
            switch (Game_Test())
            {
                case 1:
                    Game_Running();
                    break;
                case 4:
                    Game_End(4);
                    break;
                case 2:
                    Game_End(2);
                    break;
                case 100:
                    MessageBox.Show("Error. Codelength is not matching with Inputlength.");
                    break;
                case 101:
                    MessageBox.Show("Error. Please start a new Game by clicking the Button, that reads \"New Game\"");
                    break;
            }
        }

        private void btn_new_Click(object sender, EventArgs e)
        {
            bool testpassed = true;
            int testt = 0;
            if (mode_code == 0 && txt_codelength.Text.Length > 0)
            {
                try
                {
                    testt = Convert.ToInt32(txt_codelength.Text);
                }
                catch
                {
                    testpassed = false;
                    MessageBox.Show("Error. Please use numbers larger than 0 and fit in a variable from type int.");
                }
            }
            if (testpassed == true)
            {
                if (txt_codelength.Text.Length > 0)
                {
                    Rnd_Length = testt;
                }
                else
                {
                    Rnd_Length = 4;
                }
                New_Game(Rnd_Length);
            }
        }

        private void btn_quit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            msec++;
            time = "" + hrs + ':' + min + ':' + sec + ':' + msec;
            if (msec == 1000)
            {
                msec = 0;
                sec++;
            }
            if (sec == 60)
            {
                sec = 0;
                min++;
            }
            if (min == 60)
            {
                min = 0;
                hrs++;
            }
        }

        private void btn_show_Click(object sender, EventArgs e)
        {
            if (lbl_num.Visible == false && game_started == true)
            {
                if (game_mode_code == 0)
                {
                    lbl_num.Visible = true;
                    game_showed_code = true;
                }
                else
                {
                    if (game_allow_code_show == true)
                    {
                        lbl_num.Visible = true;
                        game_showed_code = true;
                    }
                }
            }
            else
            {
                lbl_num.Visible = false;
            }
        }

        private void btn_nmb_mode_Click(object sender, EventArgs e)
        {
            if (mode_code == 0)
            {
                //autocode -> preset code
                btn_nmb_mode.Text = "Mode: Preset Code";
                mode_code = 1;
                btn_nmb_restriction.Visible = false;
                btn_allow_show_code.Visible = true;
                lbl_codelength.Visible = false;
                txt_codelength.Visible = false;
                lbl_preset.Visible = true;
                txt_preset.Visible = true;
            }
            else
            {
                //preset code -> autocode
                btn_nmb_mode.Text = "Mode: Autocode";
                mode_code = 0;
                btn_nmb_restriction.Visible = true;
                btn_allow_show_code.Visible = false;
                lbl_codelength.Visible = true;
                txt_codelength.Visible = true;
                lbl_preset.Visible = false;
                txt_preset.Visible = false;
            }
        }

        private void btn_allow_show_code_Click(object sender, EventArgs e)
        {
            if (allow_code_show == false)
            {
                btn_allow_show_code.ForeColor = Color.LimeGreen;
                btn_allow_show_code.FlatAppearance.BorderColor = Color.LimeGreen;
                allow_code_show = true;
            }
            else
            {
                btn_allow_show_code.ForeColor = Color.Red;
                btn_allow_show_code.FlatAppearance.BorderColor = Color.Red;
                allow_code_show = false;
            }
        }

        private void btn_nmb_restriction_Click(object sender, EventArgs e)
        {
            if (Number_Restriction == true)
            {
                btn_nmb_restriction.ForeColor = Color.Red;
                btn_nmb_restriction.FlatAppearance.BorderColor = Color.Red;
                Number_Restriction = false;
            }
            else
            {
                btn_nmb_restriction.ForeColor = Color.LimeGreen;
                btn_nmb_restriction.FlatAppearance.BorderColor = Color.LimeGreen;
                Number_Restriction = true;
            }
        }

        private void lbl_codelength_MouseHover(object sender, EventArgs e)
        {
            new ToolTip().SetToolTip(lbl_codelength, "default = 4");
        }

        private void txt_in_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_exe.Focus();
            }
        }

        private void btn_show_time_Click(object sender, EventArgs e)
        {
            if (display_time == false)
            {
                btn_show_time.ForeColor = Color.LimeGreen;
                btn_show_time.FlatAppearance.BorderColor = Color.LimeGreen;
                display_time = true;
            }
            else
            {
                btn_show_time.ForeColor = Color.Red;
                btn_show_time.FlatAppearance.BorderColor = Color.Red;
                display_time = false;
            }
        }

        private void btn_show_attempts_Click(object sender, EventArgs e)
        {
            if (display_attempts == false)
            {
                btn_show_attempts.ForeColor = Color.LimeGreen;
                btn_show_attempts.FlatAppearance.BorderColor = Color.LimeGreen;
                display_attempts = true;
            }
            else
            {
                btn_show_attempts.ForeColor = Color.Red;
                btn_show_attempts.FlatAppearance.BorderColor = Color.Red;
                display_attempts = false;
            }
        }

        private void btn_max_time_Click(object sender, EventArgs e)
        {
            if (max_time_bool == false)
            {
                btn_max_time.ForeColor = Color.LimeGreen;
                btn_max_time.FlatAppearance.BorderColor = Color.LimeGreen;
                max_time_bool = true;
                txt_max_time.Visible = true;
            }
            else
            {
                btn_max_time.ForeColor = Color.Red;
                btn_max_time.FlatAppearance.BorderColor = Color.Red;
                max_time_bool = false;
                txt_max_time.Visible = false;
            }
        }

        private void btn_max_attempts_Click(object sender, EventArgs e)
        {
            if (max_attempts_bool == false)
            {
                btn_max_attempts.ForeColor = Color.LimeGreen;
                btn_max_attempts.FlatAppearance.BorderColor = Color.LimeGreen;
                max_attempts_bool = true;
                txt_max_attempts.Visible = true;
            }
            else
            {
                btn_max_attempts.ForeColor = Color.Red;
                btn_max_attempts.FlatAppearance.BorderColor = Color.Red;
                max_attempts_bool = false;
                txt_max_attempts.Visible = false;
            }
        }

        private void btn_clear_lst_Click(object sender, EventArgs e)
        {
            if (clear_lst == false)
            {
                btn_clear_lst.ForeColor = Color.LimeGreen;
                btn_clear_lst.FlatAppearance.BorderColor = Color.LimeGreen;
                clear_lst = true;
            }
            else
            {
                btn_clear_lst.ForeColor = Color.Red;
                btn_clear_lst.FlatAppearance.BorderColor = Color.Red;
                clear_lst = false;
            }
        }

        //methods - settings

        private static bool _number_restiction = true;
        private static bool Number_Restriction
        {
            set
            {
                _number_restiction = value;
            }
            get
            {
                return _number_restiction;
            }
        }

        private static int _rnd_length = 4;
        private static int Rnd_Length
        {
            set
            {
                _rnd_length = value;
            }
            get
            {
                return _rnd_length;
            }
        }

        private static bool _display_time = false;
        private static bool display_time
        {
            get
            {
                return _display_time;
            }
            set
            {
                _display_time = value;
            }
        }

        private static bool _display_attemps = false;
        private static bool display_attempts
        {
            get
            {
                return _display_attemps;
            }
            set
            {
                _display_attemps = value;
            }
        }

        private static int _mode_code = 0;
        private static int mode_code
        {
            set
            {
                _mode_code = value;
            }
            get
            {
                return _mode_code;
            }
        }

        private static bool _allow_code_show = false;
        private static bool allow_code_show
        {
            get
            {
                return _allow_code_show;
            }
            set
            {
                _allow_code_show = value;
            }
        }

        private static bool _clear_lst = false;
        private static bool clear_lst
        {
            get
            {
                return _clear_lst;
            }
            set
            {
                _clear_lst = value;
            }
        }

        //methods - game

        private static bool _game_started = false;
        private static bool game_started
        {
            set
            {
                _game_started = value;
            }
            get
            {
                return _game_started;
            }
        }

        private static bool _game_allow_code_show = false;
        private static bool game_allow_code_show
        {
            get
            {
                return _game_allow_code_show;
            }
            set
            {
                _game_allow_code_show = value;
            }
        }

        private static bool _game_showed_code = false;
        private static bool game_showed_code
        {
            get
            {
                return _game_showed_code;
            }
            set
            {
                _game_showed_code = value;
            }
        }

        private static int _game_mode_code = 0;
        private static int game_mode_code
        {
            set
            {
                _game_mode_code = value;
            }
            get
            {
                return _game_mode_code;
            }
        }

        private void New_Game(int codesize)
        {
            randlist.Clear();
            if (mode_code == 1)
            {
                StringBuilder sb = new StringBuilder(txt_preset.Text);
                for (int x = 0; x < sb.Length; x++)
                {
                    randlist.Add(Convert.ToString(sb[x]));
                }
                txt_preset.Text = "";
            }
            else
            {
                if (codesize <= 10 && mod.Number_Restriction == true)
                {
                    String y = Convert.ToString(rnd.Next(0, 10));
                    for (int z = 1; z <= codesize; z++)
                    {
                        while (randlist.Contains(y))
                        {
                            y = Convert.ToString(rnd.Next(0, 10));
                        }
                        randlist.Add(y);
                    }
                }
                if (codesize > 10 || mod.Number_Restriction == false)
                {
                    for (int x = 0; x < codesize; x++)
                    {
                        randlist.Add(Convert.ToString(rnd.Next(0, 10)));
                    }
                }
            }
            rnds = "";
            foreach (String rndss in randlist)
            {
                rnds = rnds + rndss;
            }
            lbl_num.Text = rnds;
            timer1.Start();
            hrs = 0;
            min = 0;
            sec = 0;
            msec = 0;
            time = "";
            mod.game_allow_code_show = allow_code_show;
            mod.game_showed_code = false;
            mod.game_started = true;
            mod.game_mode_code = mode_code;
            txt_max_attempts.ReadOnly = true;
            txt_max_time.ReadOnly = true;
            txt_in.Focus();
            txt_in.Text = "";
            lbl_num.Visible = false;
            attempts = 0;
            if (clear_lst == true)
            {
                lst_out.Items.Clear();
            }
        }

        private int Game_Test()
        {
            int returnthis = 0;
            if (game_started == true)
            {
                if (Game_Lost_Check() == false)
                {
                    if (txt_in.Text.Length == rnds.Length)
                    {
                        returnthis = 1;
                        bulls = 0;
                        cows = 0;
                        attempts++;
                        sb.Clear();
                        sb.Append(txt_in.Text);
                        for (int x = 0; x < rnds.Length; x++)
                        {
                            if (Convert.ToString(sb[x]) == randlist[x])
                            {
                                bulls++;
                            }
                            else
                            {
                                if (randlist.Contains(Convert.ToString(sb[x])) == true)
                                {
                                    cows++;
                                }
                            }
                        }
                        if (bulls == randlist.Count)
                        {
                            returnthis = 4;
                        }
                    }
                    else
                    {
                        returnthis = 100;
                    }
                }
                else
                {
                    returnthis = 2;
                }
            }
            else
            {
                returnthis = 101;
            }
            return returnthis;
        }

        private void Game_Running()
        {
            String lst_output = " ";
            for (int x = 0; x < sb.Length; x++)
            {
                lst_output = lst_output + sb[x] + " ";
            }
            lst_output = lst_output + " | Cows: " + cows + " Bulls: " + bulls;
            lst_out.Items.Add(lst_output);
            txt_in.Text = "";
            txt_in.Focus();
        }

        private void Game_End(int vallue)
        {
            game_started = false;
            txt_max_attempts.ReadOnly = false;
            txt_max_time.ReadOnly = false;
            switch (vallue)
            {
                case 4:
                    lst_out.Items.Add(" Crongrats. You've won!!");
                    break;
                case 2:
                    lst_out.Items.Add(" You've lost. Try again.");
                    lst_out.Items.Add(" The Number, you lost against was: " + lbl_num.Text);

                    break;
            }
            if (display_time == true)
            {
                lst_out.Items.Add(" ==> Time: " + time);
            }
            if (display_attempts == true)
            {
                lst_out.Items.Add(" ==> Attempts: " + attempts);
            }
            if (game_showed_code == true)
            {
                lst_out.Items.Add(" How did you dare to take");
                lst_out.Items.Add(" a peek at the Code?");
                lst_out.Items.Add(" I can't trust");
                lst_out.Items.Add(" you any longer.");
                lst_out.Items.Add(" Fix your life bro.");
            }
        }

        private bool Game_Lost_Check()
        {
            bool glc = false;
            if (max_time_bool == true)
            {
                if (min >= max_time_int)
                {
                    glc = true;
                }
            }
            if (max_attempts_bool == true)
            {
                if (attempts > max_attempts_int)
                {
                    glc = true;
                }
            }
            return glc;
        }
        //new stuff to sort:

        int stuff = 69;
    }
}
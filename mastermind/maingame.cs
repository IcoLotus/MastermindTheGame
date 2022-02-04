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

    public partial class maingame : Form
    {
        //generate all variables and methods

        public maingame()
        {
            InitializeComponent();
        }

        private int msec = 0;
        private int sec = 0;
        private int min = 0;
        private int hrs = 0;
        private String time;

        private int attempts = 0;

        private int gamescore = 0;

        static Random rnd = new Random();
        int rnd1;
        int rnd2;
        int rnd3;
        int rnd4;

        private int _game_difficulty = 15;
        public int game_difficulty
        {
            get
            {
                return _game_difficulty;
            }
            set
            {
                _game_difficulty = value;
            }
        }

        //clickevents and stuff

        private void btn_exe_Click(object sender, EventArgs e)
        {
            if (this.game_difficulty != 15)
            {
                if (txt_in.Text.Length == 4)
                {
                    int x;
                    bool test = true;
                    try
                    {
                        x = Convert.ToInt32(txt_in.Text);
                    }
                    catch
                    {
                        MessageBox.Show("Error with Input. Please try again.");
                        test = false;
                    }
                    if (test == true)
                    {
                        attempts++;
                        String input = txt_in.Text;
                        switch (this.game_difficulty)
                        {
                            case 0:
                                Game_Normal(input);
                                break;
                            case 1:
                                Game_Difficult(input);
                                break;
                            case 2:
                                Game_Hardcore(input);
                                break;
                            case 3:
                                Game_UltraHardcore(input);
                                break;
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Don't use Codes with more or less than 4 digits");
                }
            }
            else
            {
                MessageBox.Show("Please start a Game");
            }
        }

        private void btn_new_Click(object sender, EventArgs e)
        {
            Game_Start();
        }

        private void btn_quit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_num_Click(object sender, EventArgs e)
        {
            if (game_difficulty == 0)
            {
                lbl_num.Visible = true;
            }
            else
            {
                MessageBox.Show("Can't show the Number due chosen Difficulty.");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void btn_set_Click(object sender, EventArgs e)
        {
            settings gameset = new settings();
            settings.settings_via_game = true;
            gameset.ShowDialog();
            if (game_difficulty != settings.difficulty)
            {
                MessageBox.Show("New Difficulty wont be applied, until a new Game has begun!");
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            sec++;
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

        private void timer2_Tick(object sender, EventArgs e)
        {
            msec++;
            time = Convert.ToString(hrs) + ':' + Convert.ToString(min) + ':' + Convert.ToString(sec) + ':' + Convert.ToString(msec);
            if (msec == 1000)
            {
                msec = 0;
            }
        }

        //gamestuff

        private void Game_Won()
        {
            lst_log.Items.Add("     ---   Crongrats. You've won!!   ---");
            if (settings.time_lst_past_game == true)
            {
                lst_log.Items.Add(" ==> Time: " + time);
            }
            if (settings.attempts_lst_past_game == true)
            {
                lst_log.Items.Add(" ==> Attempts: " + attempts);
            }
        }

        private void Game_Lost()
        {
            lst_log.Items.Add("     ---   You've lost. Your Score: " + gamescore + "   ---");
            lst_log.Items.Add("     ---   The Number, you lost against was: " + lbl_num.Text);
            if (settings.time_lst_past_game == true)
            {
                lst_log.Items.Add(" ==> Time: " + time);
            }
            if (settings.attempts_lst_past_game == true)
            {
                lst_log.Items.Add(" ==> Attempts: " + attempts);
            }
        }

        private void Game_Start()
        {
            attempts = 0;
            gamescore = 0;
            bool test = false;
            rnd1 = rnd.Next(0, 10);
            rnd2 = rnd.Next(0, 10);
            rnd3 = rnd.Next(0, 10);
            rnd4 = rnd.Next(0, 10);
            do
            {
                if (rnd1 == rnd2 || rnd1 == rnd3 || rnd1 == rnd4 || rnd2 == rnd3 || rnd2 == rnd4 || rnd3 == rnd4)
                {
                    rnd1 = rnd.Next(0, 10);
                    rnd2 = rnd.Next(0, 10);
                    rnd3 = rnd.Next(0, 10);
                    rnd4 = rnd.Next(0, 10);
                }
                else
                {
                    test = true;
                }
            } while (test == false);
            lbl_num.Visible = false;
            lbl_num.Text = ("" + rnd1 + rnd2 + rnd3 + rnd4);

            timer1.Start();
            timer2.Start();
            min = 0;
            sec = 0;
            hrs = 0;

            this.game_difficulty = settings.difficulty;

            if (settings.clear_lst_past_game == true)
            {
                lst_log.Items.Clear();
            }
        }

        private void Game_Normal(String input_x)
        {
            //generation of var's
            int bull = 0;
            int cow = 0;
            int x1 = 0;
            int x2 = 0;
            int x3 = 0;
            int x4 = 0;
            bool test = true;

            StringBuilder sb = new StringBuilder(input_x);
            try
            {
                x1 = Convert.ToInt32("" + sb[0]);
                x2 = Convert.ToInt32("" + sb[1]);
                x3 = Convert.ToInt32("" + sb[2]);
                x4 = Convert.ToInt32("" + sb[3]);
            }
            catch
            {
                MessageBox.Show("Error with converting the Input.");
                test = false;
            }
            if (x1 == rnd1)
            {
                bull++;
            }
            if (x2 == rnd2)
            {
                bull++;
            }
            if (x3 == rnd3)
            {
                bull++;
            }
            if (x4 == rnd4)
            {
                bull++;
            }
            if (x1 == rnd2 || x1 == rnd3 || x1 == rnd4)
            {
                cow++;
            }
            if (x2 == rnd1 || x2 == rnd3 || x2 == rnd4)
            {
                cow++;
            }
            if (x3 == rnd1 || x3 == rnd2 || x3 == rnd4)
            {
                cow++;
            }
            if (x4 == rnd2 || x4 == rnd3 || x4 == rnd1)
            {
                cow++;
            }
            if (bull == 4)
            {
                Game_Won();
            }
            else
            {
                if (test == false)
                {
                    lst_log.Items.Add("     ---   Something went Wrong   ---");
                }
                else
                {
                    lst_log.Items.Add("" + x1 + " " + x2 + " " + x3 + " " + x4 + " | Cows: " + cow + " Bulls: " + bull);
                }
            }
            txt_in.Text = "";

        }

        private void Game_Difficult(String input_x)
        {
            if (min > 29 || hrs > 0 || attempts >= 30)
            {
                Game_Lost();
            }
            else
            {
                //generation of var's
                int bull = 0;
                int cow = 0;
                int x1 = 0;
                int x2 = 0;
                int x3 = 0;
                int x4 = 0;
                int x = 0;
                bool test = true;
                try
                {
                    x = Convert.ToInt32(input_x);
                }
                catch
                {
                    MessageBox.Show("Error with Input. Please try again.");
                    test = false;
                }
                StringBuilder sb = new StringBuilder(input_x);
                try
                {
                    x1 = Convert.ToInt32("" + sb[0]);
                    x2 = Convert.ToInt32("" + sb[1]);
                    x3 = Convert.ToInt32("" + sb[2]);
                    x4 = Convert.ToInt32("" + sb[3]);
                }
                catch
                {
                    MessageBox.Show("Error with converting the Input.");
                    test = false;
                }
                if (x1 == rnd1)
                {
                    bull++;
                }
                if (x2 == rnd2)
                {
                    bull++;
                }
                if (x3 == rnd3)
                {
                    bull++;
                }
                if (x4 == rnd4)
                {
                    bull++;
                }
                if (x1 == rnd2 || x1 == rnd3 || x1 == rnd4)
                {
                    cow++;
                }
                if (x2 == rnd1 || x2 == rnd3 || x2 == rnd4)
                {
                    cow++;
                }
                if (x3 == rnd1 || x3 == rnd2 || x3 == rnd4)
                {
                    cow++;
                }
                if (x4 == rnd2 || x4 == rnd3 || x4 == rnd1)
                {
                    cow++;
                }
                if (bull == 4)
                {
                    Game_Won();
                }
                else
                {
                    if (test == false)
                    {
                        lst_log.Items.Add("     ---   Something went Wrong   ---");
                    }
                    else
                    {
                        lst_log.Items.Add("" + x1 + " " + x2 + " " + x3 + " " + x4 + " | Cows: " + cow + " Bulls: " + bull);
                    }
                }
                txt_in.Text = "";
                txt_in.Focus();
            }
        }

        private void Game_Hardcore(String input_x)
        {
            if (min > 14 || hrs > 0 || attempts >= 10)
            {
                Game_Lost();
            }
            else
            {
                //generation of var's
                int bull = 0;
                int cow = 0;
                int x1 = 0;
                int x2 = 0;
                int x3 = 0;
                int x4 = 0;
                int x = 0;
                bool test = true;
                try
                {
                    x = Convert.ToInt32(input_x);
                }
                catch
                {
                    MessageBox.Show("Error with Input. Please try again.");
                    test = false;
                }
                StringBuilder sb = new StringBuilder(input_x);
                try
                {
                    x1 = Convert.ToInt32("" + sb[0]);
                    x2 = Convert.ToInt32("" + sb[1]);
                    x3 = Convert.ToInt32("" + sb[2]);
                    x4 = Convert.ToInt32("" + sb[3]);
                }
                catch
                {
                    MessageBox.Show("Error with converting the Input.");
                    test = false;
                }
                if (x1 == rnd1)
                {
                    bull++;
                }
                if (x2 == rnd2)
                {
                    bull++;
                }
                if (x3 == rnd3)
                {
                    bull++;
                }
                if (x4 == rnd4)
                {
                    bull++;
                }
                if (x1 == rnd2 || x1 == rnd3 || x1 == rnd4)
                {
                    cow++;
                }
                if (x2 == rnd1 || x2 == rnd3 || x2 == rnd4)
                {
                    cow++;
                }
                if (x3 == rnd1 || x3 == rnd2 || x3 == rnd4)
                {
                    cow++;
                }
                if (x4 == rnd2 || x4 == rnd3 || x4 == rnd1)
                {
                    cow++;
                }
                if (bull == 4)
                {
                    Game_Won();
                }
                else
                {
                    if (test == false)
                    {
                        lst_log.Items.Add("     ---   Something went Wrong   ---");
                    }
                    else
                    {
                        lst_log.Items.Add("" + x1 + " " + x2 + " " + x3 + " " + x4 + " | Cows: " + cow + " Bulls: " + bull);
                    }
                }
                txt_in.Text = "";
                txt_in.Focus();
            }
        }

        private void Game_UltraHardcore(String input_x)
        {
            if (min > 9 || hrs > 0 || attempts >= 6)
            {
                Game_Lost();
            }
            else
            {
                //generation of var's
                int bull = 0;
                int cow = 0;
                int x1 = 0;
                int x2 = 0;
                int x3 = 0;
                int x4 = 0;
                int x = 0;
                bool test = true;
                try
                {
                    x = Convert.ToInt32(input_x);
                }
                catch
                {
                    MessageBox.Show("Error with Input. Please try again.");
                    test = false;
                }
                StringBuilder sb = new StringBuilder(input_x);
                try
                {
                    x1 = Convert.ToInt32("" + sb[0]);
                    x2 = Convert.ToInt32("" + sb[1]);
                    x3 = Convert.ToInt32("" + sb[2]);
                    x4 = Convert.ToInt32("" + sb[3]);
                }
                catch
                {
                    MessageBox.Show("Error with converting the Input.");
                    test = false;
                }
                if (x1 == rnd1)
                {
                    bull++;
                }
                if (x2 == rnd2)
                {
                    bull++;
                }
                if (x3 == rnd3)
                {
                    bull++;
                }
                if (x4 == rnd4)
                {
                    bull++;
                }
                if (x1 == rnd2 || x1 == rnd3 || x1 == rnd4)
                {
                    cow++;
                }
                if (x2 == rnd1 || x2 == rnd3 || x2 == rnd4)
                {
                    cow++;
                }
                if (x3 == rnd1 || x3 == rnd2 || x3 == rnd4)
                {
                    cow++;
                }
                if (x4 == rnd2 || x4 == rnd3 || x4 == rnd1)
                {
                    cow++;
                }
                if (bull == 4)
                {
                    Game_Won();
                }
                else
                {
                    if (test == false)
                    {
                        lst_log.Items.Add("     ---   Something went Wrong   ---");
                    }
                    else
                    {
                        lst_log.Items.Add("" + x1 + " " + x2 + " " + x3 + " " + x4 + " | Cows: " + cow + " Bulls: " + bull);
                    }
                }
                txt_in.Text = ""; 
                txt_in.Focus();
            }
        }

        //new unsorted stuff

    }
}
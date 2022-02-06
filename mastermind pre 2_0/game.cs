using System;
using System.Windows.Forms;

namespace mastermind_pre_2_0
{
    public partial class game : Form
    {
        public game()
        {
            InitializeComponent();
        }

        //       Methods

        private static bool game_ongoing = false;

        private int mseconds = 0;
        private int seconds = 0;
        private int minutes = 0;
        private int hours = 0;

        private static int current_codelength = 4;
        private static int current_difficulty = 0;
        private static bool current_max_attempts_bool = false;
        private static int current_max_attempts_int = 10;
        private static bool current_max_time_bool = false;
        private static int current_max_hours = 0;
        private static int current_max_minutes = 15;
        private static int current_max_seconds = 0;
        private static bool current_allow_showcode = true;
        private static bool current_allow_symbols = false;

        public static void Check_Input()
        {
            if (game.valid_try() == true)
            {

            }
        }
        private static bool valid_try()
        {
            if (game_ongoing == false) { return false; }
            return true;
        }
        private static bool valid_code()
        {

            return true;
        }
        private static void new_game()
        {
            game_ongoing = true;
            if (settings.mode == 0)
            {
                current_codelength = settings.auto_codelength;
            }
            else if (settings.mode == 1)
            {
                current_codelength = settings.custom_codelength;
            }
            current_difficulty = settings.difficulty;
            current_max_attempts_bool = settings.max_attempts_bool;
            current_max_attempts_int = settings.max_attempts_int;
            current_max_time_bool = settings.max_time_bool;
            current_max_hours = settings.max_hours;
            current_max_minutes = settings.max_minutes;
            current_max_seconds = settings.max_seconds;
            current_allow_showcode = settings.allow_showcode;
            current_allow_symbols = settings.allow_symbols;
        }

        private void game_Load(object sender, EventArgs e)
        {

        }

        private void btn_quit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void maintimer_Tick(object sender, EventArgs e)
        {
            mseconds++;
            if(mseconds > 999)
            {
                mseconds = 0;
                seconds++;
            }
            if(seconds > 59)
            {
                minutes++;
                seconds = 0;
            }
            if(minutes > 59)
            {
                hours++;
                minutes = 0;
            }
        }
    }
}

using System;
using System.Windows.Forms;

namespace mastermind_pre_2_0
{
    public partial class settings : Form
    {
        public settings()
        {
            InitializeComponent();
        }

        private void settings_Load(object sender, EventArgs e)
        {

        }
        public static int mode = 0;
        public static int auto_codelength = 4;
        public static int custom_codelength = 4;
        public static int difficulty = 0;
        public static bool show_timer = false;
        public static bool show_postgame_data = false;
        public static bool clear_list = false;
        public static bool max_attempts_bool = false;
        public static int max_attempts_int = 10;
        public static bool max_time_bool = false;
        public static int max_hours = 0;
        public static int max_minutes = 15;
        public static int max_seconds = 0;
        public static bool allow_showcode = true;
        public static bool allow_symbols = false;
    }
}
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
        
    }

    class setings
    {
        public int mode = 0;
        public int auto_codelength = 4;
        public int custom_codelength = 4;
        public int difficulty = 0;
        public bool show_timer = false;
        public bool show_postgame_data = false;
        public bool clear_list = false;
        public bool max_attempts_bool = false;
        public int max_attempts_int = 10;
        public bool max_time_bool = false;
        public int max_hours = 0;
        public int max_minutes = 15;
        public int max_seconds = 0;
        public bool allow_showcode = true;
        public bool allow_symbols = false;
        public int dummheitsmesser = 99999;
    }
}
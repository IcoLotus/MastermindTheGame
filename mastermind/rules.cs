using System;
using System.Windows.Forms;

namespace mastermind
{
    public partial class rules : Form
    {
        public rules()
        {
            InitializeComponent();
        }

        private void btn_quit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

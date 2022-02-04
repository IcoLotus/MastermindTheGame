
namespace mastermind
{
    partial class mod
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btn_quit = new System.Windows.Forms.Button();
            this.lst_out = new System.Windows.Forms.ListBox();
            this.txt_in = new System.Windows.Forms.TextBox();
            this.btn_exe = new System.Windows.Forms.Button();
            this.btn_new = new System.Windows.Forms.Button();
            this.lbl_num = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btn_show = new System.Windows.Forms.Button();
            this.txt_preset = new System.Windows.Forms.TextBox();
            this.lbl_preset = new System.Windows.Forms.Label();
            this.btn_nmb_mode = new System.Windows.Forms.Button();
            this.btn_nmb_restriction = new System.Windows.Forms.Button();
            this.lbl_codelength = new System.Windows.Forms.Label();
            this.txt_codelength = new System.Windows.Forms.TextBox();
            this.btn_allow_show_code = new System.Windows.Forms.Button();
            this.btn_show_time = new System.Windows.Forms.Button();
            this.btn_show_attempts = new System.Windows.Forms.Button();
            this.btn_max_time = new System.Windows.Forms.Button();
            this.btn_max_attempts = new System.Windows.Forms.Button();
            this.txt_max_time = new System.Windows.Forms.TextBox();
            this.txt_max_attempts = new System.Windows.Forms.TextBox();
            this.btn_clear_lst = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_quit
            // 
            this.btn_quit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_quit.ForeColor = System.Drawing.Color.AliceBlue;
            this.btn_quit.Location = new System.Drawing.Point(16, 446);
            this.btn_quit.Name = "btn_quit";
            this.btn_quit.Size = new System.Drawing.Size(154, 89);
            this.btn_quit.TabIndex = 0;
            this.btn_quit.Text = "End the Game";
            this.btn_quit.UseVisualStyleBackColor = true;
            this.btn_quit.Click += new System.EventHandler(this.btn_quit_Click);
            // 
            // lst_out
            // 
            this.lst_out.BackColor = System.Drawing.SystemColors.Desktop;
            this.lst_out.ForeColor = System.Drawing.Color.AliceBlue;
            this.lst_out.FormattingEnabled = true;
            this.lst_out.ItemHeight = 38;
            this.lst_out.Location = new System.Drawing.Point(882, 12);
            this.lst_out.Name = "lst_out";
            this.lst_out.Size = new System.Drawing.Size(390, 574);
            this.lst_out.TabIndex = 1;
            // 
            // txt_in
            // 
            this.txt_in.BackColor = System.Drawing.SystemColors.Window;
            this.txt_in.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txt_in.Location = new System.Drawing.Point(16, 30);
            this.txt_in.Name = "txt_in";
            this.txt_in.Size = new System.Drawing.Size(394, 45);
            this.txt_in.TabIndex = 2;
            this.txt_in.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_in_KeyDown);
            // 
            // btn_exe
            // 
            this.btn_exe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_exe.ForeColor = System.Drawing.SystemColors.Menu;
            this.btn_exe.Location = new System.Drawing.Point(471, 27);
            this.btn_exe.Name = "btn_exe";
            this.btn_exe.Size = new System.Drawing.Size(190, 47);
            this.btn_exe.TabIndex = 3;
            this.btn_exe.Text = "Check Input";
            this.btn_exe.UseVisualStyleBackColor = true;
            this.btn_exe.Click += new System.EventHandler(this.btn_exe_Click);
            // 
            // btn_new
            // 
            this.btn_new.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_new.ForeColor = System.Drawing.SystemColors.Menu;
            this.btn_new.Location = new System.Drawing.Point(686, 27);
            this.btn_new.Name = "btn_new";
            this.btn_new.Size = new System.Drawing.Size(190, 47);
            this.btn_new.TabIndex = 4;
            this.btn_new.Text = "New Game";
            this.btn_new.UseVisualStyleBackColor = true;
            this.btn_new.Click += new System.EventHandler(this.btn_new_Click);
            // 
            // lbl_num
            // 
            this.lbl_num.AutoSize = true;
            this.lbl_num.ForeColor = System.Drawing.SystemColors.Menu;
            this.lbl_num.Location = new System.Drawing.Point(13, 86);
            this.lbl_num.Name = "lbl_num";
            this.lbl_num.Size = new System.Drawing.Size(321, 38);
            this.lbl_num.TabIndex = 5;
            this.lbl_num.Text = "Autogenerated Number";
            this.lbl_num.Visible = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btn_show
            // 
            this.btn_show.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_show.ForeColor = System.Drawing.SystemColors.Menu;
            this.btn_show.Location = new System.Drawing.Point(471, 86);
            this.btn_show.Name = "btn_show";
            this.btn_show.Size = new System.Drawing.Size(405, 47);
            this.btn_show.TabIndex = 6;
            this.btn_show.Text = "Show the Code";
            this.btn_show.UseVisualStyleBackColor = true;
            this.btn_show.Click += new System.EventHandler(this.btn_show_Click);
            // 
            // txt_preset
            // 
            this.txt_preset.BackColor = System.Drawing.SystemColors.Window;
            this.txt_preset.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txt_preset.Location = new System.Drawing.Point(595, 176);
            this.txt_preset.Name = "txt_preset";
            this.txt_preset.Size = new System.Drawing.Size(275, 45);
            this.txt_preset.TabIndex = 7;
            this.txt_preset.Visible = false;
            // 
            // lbl_preset
            // 
            this.lbl_preset.AutoSize = true;
            this.lbl_preset.ForeColor = System.Drawing.SystemColors.Menu;
            this.lbl_preset.Location = new System.Drawing.Point(397, 179);
            this.lbl_preset.Name = "lbl_preset";
            this.lbl_preset.Size = new System.Drawing.Size(186, 38);
            this.lbl_preset.TabIndex = 8;
            this.lbl_preset.Text = "Preset Code:";
            this.lbl_preset.Visible = false;
            // 
            // btn_nmb_mode
            // 
            this.btn_nmb_mode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_nmb_mode.ForeColor = System.Drawing.SystemColors.Menu;
            this.btn_nmb_mode.Location = new System.Drawing.Point(16, 154);
            this.btn_nmb_mode.Name = "btn_nmb_mode";
            this.btn_nmb_mode.Size = new System.Drawing.Size(194, 88);
            this.btn_nmb_mode.TabIndex = 9;
            this.btn_nmb_mode.Text = "Mode: Autocode";
            this.btn_nmb_mode.UseVisualStyleBackColor = true;
            this.btn_nmb_mode.Click += new System.EventHandler(this.btn_nmb_mode_Click);
            // 
            // btn_nmb_restriction
            // 
            this.btn_nmb_restriction.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btn_nmb_restriction.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_nmb_restriction.ForeColor = System.Drawing.Color.Red;
            this.btn_nmb_restriction.Location = new System.Drawing.Point(216, 154);
            this.btn_nmb_restriction.Name = "btn_nmb_restriction";
            this.btn_nmb_restriction.Size = new System.Drawing.Size(158, 88);
            this.btn_nmb_restriction.TabIndex = 10;
            this.btn_nmb_restriction.Text = "Number only Once";
            this.btn_nmb_restriction.UseVisualStyleBackColor = true;
            this.btn_nmb_restriction.Click += new System.EventHandler(this.btn_nmb_restriction_Click);
            // 
            // lbl_codelength
            // 
            this.lbl_codelength.AutoSize = true;
            this.lbl_codelength.ForeColor = System.Drawing.SystemColors.Menu;
            this.lbl_codelength.Location = new System.Drawing.Point(380, 179);
            this.lbl_codelength.Name = "lbl_codelength";
            this.lbl_codelength.Size = new System.Drawing.Size(170, 38);
            this.lbl_codelength.TabIndex = 11;
            this.lbl_codelength.Text = "Codelength:";
            this.lbl_codelength.MouseHover += new System.EventHandler(this.lbl_codelength_MouseHover);
            // 
            // txt_codelength
            // 
            this.txt_codelength.BackColor = System.Drawing.SystemColors.Window;
            this.txt_codelength.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txt_codelength.Location = new System.Drawing.Point(549, 176);
            this.txt_codelength.Name = "txt_codelength";
            this.txt_codelength.Size = new System.Drawing.Size(109, 45);
            this.txt_codelength.TabIndex = 12;
            // 
            // btn_allow_show_code
            // 
            this.btn_allow_show_code.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btn_allow_show_code.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_allow_show_code.ForeColor = System.Drawing.Color.Red;
            this.btn_allow_show_code.Location = new System.Drawing.Point(216, 154);
            this.btn_allow_show_code.Name = "btn_allow_show_code";
            this.btn_allow_show_code.Size = new System.Drawing.Size(175, 88);
            this.btn_allow_show_code.TabIndex = 13;
            this.btn_allow_show_code.Text = "Allow Show the Code";
            this.btn_allow_show_code.UseVisualStyleBackColor = true;
            this.btn_allow_show_code.Visible = false;
            this.btn_allow_show_code.Click += new System.EventHandler(this.btn_allow_show_code_Click);
            // 
            // btn_show_time
            // 
            this.btn_show_time.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btn_show_time.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_show_time.ForeColor = System.Drawing.Color.Red;
            this.btn_show_time.Location = new System.Drawing.Point(16, 248);
            this.btn_show_time.Name = "btn_show_time";
            this.btn_show_time.Size = new System.Drawing.Size(237, 88);
            this.btn_show_time.TabIndex = 14;
            this.btn_show_time.Text = "Show my Time after the Game";
            this.btn_show_time.UseVisualStyleBackColor = true;
            this.btn_show_time.Click += new System.EventHandler(this.btn_show_time_Click);
            // 
            // btn_show_attempts
            // 
            this.btn_show_attempts.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btn_show_attempts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_show_attempts.ForeColor = System.Drawing.Color.Red;
            this.btn_show_attempts.Location = new System.Drawing.Point(259, 248);
            this.btn_show_attempts.Name = "btn_show_attempts";
            this.btn_show_attempts.Size = new System.Drawing.Size(284, 88);
            this.btn_show_attempts.TabIndex = 15;
            this.btn_show_attempts.Text = "Show my Attempts after the Game";
            this.btn_show_attempts.UseVisualStyleBackColor = true;
            this.btn_show_attempts.Click += new System.EventHandler(this.btn_show_attempts_Click);
            // 
            // btn_max_time
            // 
            this.btn_max_time.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btn_max_time.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_max_time.ForeColor = System.Drawing.Color.Red;
            this.btn_max_time.Location = new System.Drawing.Point(16, 342);
            this.btn_max_time.Name = "btn_max_time";
            this.btn_max_time.Size = new System.Drawing.Size(221, 46);
            this.btn_max_time.TabIndex = 16;
            this.btn_max_time.Text = "Maximum Time";
            this.btn_max_time.UseVisualStyleBackColor = true;
            this.btn_max_time.Click += new System.EventHandler(this.btn_max_time_Click);
            // 
            // btn_max_attempts
            // 
            this.btn_max_attempts.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btn_max_attempts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_max_attempts.ForeColor = System.Drawing.Color.Red;
            this.btn_max_attempts.Location = new System.Drawing.Point(16, 394);
            this.btn_max_attempts.Name = "btn_max_attempts";
            this.btn_max_attempts.Size = new System.Drawing.Size(280, 46);
            this.btn_max_attempts.TabIndex = 17;
            this.btn_max_attempts.Text = "Maximum Attempts";
            this.btn_max_attempts.UseVisualStyleBackColor = true;
            this.btn_max_attempts.Click += new System.EventHandler(this.btn_max_attempts_Click);
            // 
            // txt_max_time
            // 
            this.txt_max_time.BackColor = System.Drawing.SystemColors.Window;
            this.txt_max_time.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txt_max_time.Location = new System.Drawing.Point(243, 342);
            this.txt_max_time.Name = "txt_max_time";
            this.txt_max_time.Size = new System.Drawing.Size(275, 45);
            this.txt_max_time.TabIndex = 18;
            this.txt_max_time.Visible = false;
            // 
            // txt_max_attempts
            // 
            this.txt_max_attempts.BackColor = System.Drawing.SystemColors.Window;
            this.txt_max_attempts.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txt_max_attempts.Location = new System.Drawing.Point(302, 395);
            this.txt_max_attempts.Name = "txt_max_attempts";
            this.txt_max_attempts.Size = new System.Drawing.Size(275, 45);
            this.txt_max_attempts.TabIndex = 19;
            this.txt_max_attempts.Visible = false;
            // 
            // btn_clear_lst
            // 
            this.btn_clear_lst.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btn_clear_lst.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_clear_lst.ForeColor = System.Drawing.Color.Red;
            this.btn_clear_lst.Location = new System.Drawing.Point(549, 248);
            this.btn_clear_lst.Name = "btn_clear_lst";
            this.btn_clear_lst.Size = new System.Drawing.Size(263, 88);
            this.btn_clear_lst.TabIndex = 20;
            this.btn_clear_lst.Text = "Clear Output-List after the Game";
            this.btn_clear_lst.UseVisualStyleBackColor = true;
            this.btn_clear_lst.Click += new System.EventHandler(this.btn_clear_lst_Click);
            // 
            // mod
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 38F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Desktop;
            this.ClientSize = new System.Drawing.Size(1284, 601);
            this.Controls.Add(this.btn_clear_lst);
            this.Controls.Add(this.txt_max_attempts);
            this.Controls.Add(this.txt_max_time);
            this.Controls.Add(this.btn_max_attempts);
            this.Controls.Add(this.btn_max_time);
            this.Controls.Add(this.btn_show_attempts);
            this.Controls.Add(this.btn_show_time);
            this.Controls.Add(this.btn_allow_show_code);
            this.Controls.Add(this.txt_codelength);
            this.Controls.Add(this.lbl_codelength);
            this.Controls.Add(this.btn_nmb_restriction);
            this.Controls.Add(this.btn_nmb_mode);
            this.Controls.Add(this.lbl_preset);
            this.Controls.Add(this.txt_preset);
            this.Controls.Add(this.btn_show);
            this.Controls.Add(this.lbl_num);
            this.Controls.Add(this.btn_new);
            this.Controls.Add(this.btn_exe);
            this.Controls.Add(this.txt_in);
            this.Controls.Add(this.lst_out);
            this.Controls.Add(this.btn_quit);
            this.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.Name = "mod";
            this.Text = "Mastermind - Modded";
            this.Load += new System.EventHandler(this.moddedgame_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_quit;
        private System.Windows.Forms.ListBox lst_out;
        private System.Windows.Forms.TextBox txt_in;
        private System.Windows.Forms.Button btn_exe;
        private System.Windows.Forms.Button btn_new;
        private System.Windows.Forms.Label lbl_num;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btn_show;
        private System.Windows.Forms.TextBox txt_preset;
        private System.Windows.Forms.Label lbl_preset;
        private System.Windows.Forms.Button btn_nmb_mode;
        private System.Windows.Forms.Button btn_nmb_restriction;
        private System.Windows.Forms.Label lbl_codelength;
        private System.Windows.Forms.TextBox txt_codelength;
        private System.Windows.Forms.Button btn_allow_show_code;
        private System.Windows.Forms.Button btn_show_time;
        private System.Windows.Forms.Button btn_show_attempts;
        private System.Windows.Forms.Button btn_max_time;
        private System.Windows.Forms.Button btn_max_attempts;
        private System.Windows.Forms.TextBox txt_max_time;
        private System.Windows.Forms.TextBox txt_max_attempts;
        private System.Windows.Forms.Button btn_clear_lst;
    }
}
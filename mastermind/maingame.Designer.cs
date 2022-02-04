namespace mastermind
{
    partial class maingame
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lst_log = new System.Windows.Forms.ListBox();
            this.btn_exe = new System.Windows.Forms.Button();
            this.txt_in = new System.Windows.Forms.TextBox();
            this.btn_new = new System.Windows.Forms.Button();
            this.btn_quit = new System.Windows.Forms.Button();
            this.lbl_num = new System.Windows.Forms.Label();
            this.btn_num = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.btn_set = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lst_log
            // 
            this.lst_log.BackColor = System.Drawing.SystemColors.Desktop;
            this.lst_log.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lst_log.ForeColor = System.Drawing.Color.AliceBlue;
            this.lst_log.FormattingEnabled = true;
            this.lst_log.ItemHeight = 38;
            this.lst_log.Location = new System.Drawing.Point(707, 12);
            this.lst_log.Name = "lst_log";
            this.lst_log.Size = new System.Drawing.Size(589, 764);
            this.lst_log.TabIndex = 0;
            // 
            // btn_exe
            // 
            this.btn_exe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_exe.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_exe.ForeColor = System.Drawing.Color.AliceBlue;
            this.btn_exe.Location = new System.Drawing.Point(368, 100);
            this.btn_exe.Name = "btn_exe";
            this.btn_exe.Size = new System.Drawing.Size(232, 57);
            this.btn_exe.TabIndex = 1;
            this.btn_exe.Text = "Test my Input";
            this.btn_exe.UseVisualStyleBackColor = true;
            this.btn_exe.Click += new System.EventHandler(this.btn_exe_Click);
            // 
            // txt_in
            // 
            this.txt_in.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_in.Location = new System.Drawing.Point(127, 106);
            this.txt_in.Name = "txt_in";
            this.txt_in.Size = new System.Drawing.Size(148, 45);
            this.txt_in.TabIndex = 0;
            // 
            // btn_new
            // 
            this.btn_new.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_new.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_new.ForeColor = System.Drawing.Color.AliceBlue;
            this.btn_new.Location = new System.Drawing.Point(268, 163);
            this.btn_new.Name = "btn_new";
            this.btn_new.Size = new System.Drawing.Size(332, 56);
            this.btn_new.TabIndex = 2;
            this.btn_new.Text = "(Re-) Start the Game";
            this.btn_new.UseVisualStyleBackColor = true;
            this.btn_new.Click += new System.EventHandler(this.btn_new_Click);
            // 
            // btn_quit
            // 
            this.btn_quit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_quit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_quit.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_quit.ForeColor = System.Drawing.Color.AliceBlue;
            this.btn_quit.Location = new System.Drawing.Point(12, 685);
            this.btn_quit.Name = "btn_quit";
            this.btn_quit.Size = new System.Drawing.Size(145, 90);
            this.btn_quit.TabIndex = 4;
            this.btn_quit.Text = "End the Game";
            this.btn_quit.UseVisualStyleBackColor = true;
            this.btn_quit.Click += new System.EventHandler(this.btn_quit_Click);
            // 
            // lbl_num
            // 
            this.lbl_num.AutoSize = true;
            this.lbl_num.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_num.ForeColor = System.Drawing.Color.AliceBlue;
            this.lbl_num.Location = new System.Drawing.Point(120, 342);
            this.lbl_num.Name = "lbl_num";
            this.lbl_num.Size = new System.Drawing.Size(0, 38);
            this.lbl_num.TabIndex = 5;
            this.lbl_num.Visible = false;
            // 
            // btn_num
            // 
            this.btn_num.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_num.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_num.ForeColor = System.Drawing.Color.AliceBlue;
            this.btn_num.Location = new System.Drawing.Point(320, 333);
            this.btn_num.Name = "btn_num";
            this.btn_num.Size = new System.Drawing.Size(280, 56);
            this.btn_num.TabIndex = 3;
            this.btn_num.Text = "Show the Answer";
            this.btn_num.UseVisualStyleBackColor = true;
            this.btn_num.Click += new System.EventHandler(this.btn_num_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Interval = 1;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // btn_set
            // 
            this.btn_set.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_set.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_set.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_set.ForeColor = System.Drawing.Color.AliceBlue;
            this.btn_set.Location = new System.Drawing.Point(172, 720);
            this.btn_set.Name = "btn_set";
            this.btn_set.Size = new System.Drawing.Size(145, 55);
            this.btn_set.TabIndex = 6;
            this.btn_set.Text = "Settings";
            this.btn_set.UseVisualStyleBackColor = true;
            this.btn_set.Click += new System.EventHandler(this.btn_set_Click);
            // 
            // maingame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Desktop;
            this.ClientSize = new System.Drawing.Size(1284, 787);
            this.Controls.Add(this.btn_set);
            this.Controls.Add(this.btn_num);
            this.Controls.Add(this.lbl_num);
            this.Controls.Add(this.btn_quit);
            this.Controls.Add(this.btn_new);
            this.Controls.Add(this.txt_in);
            this.Controls.Add(this.btn_exe);
            this.Controls.Add(this.lst_log);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1324, 826);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1278, 826);
            this.Name = "maingame";
            this.Text = "Mastermind - Offline";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lst_log;
        private System.Windows.Forms.Button btn_exe;
        private System.Windows.Forms.TextBox txt_in;
        private System.Windows.Forms.Button btn_new;
        private System.Windows.Forms.Button btn_quit;
        private System.Windows.Forms.Label lbl_num;
        private System.Windows.Forms.Button btn_num;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Button btn_set;
    }
}


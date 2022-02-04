
namespace mastermind
{
    partial class settings
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
            this.btn_normal = new System.Windows.Forms.Button();
            this.btn_hard = new System.Windows.Forms.Button();
            this.btn_hc = new System.Windows.Forms.Button();
            this.btn_uhc = new System.Windows.Forms.Button();
            this.lbl_normal = new System.Windows.Forms.Label();
            this.lbl_difficult = new System.Windows.Forms.Label();
            this.lbl_hc = new System.Windows.Forms.Label();
            this.lbl_uhc = new System.Windows.Forms.Label();
            this.btn_clear_lst = new System.Windows.Forms.Button();
            this.btn_quit = new System.Windows.Forms.Button();
            this.btn_time_lst = new System.Windows.Forms.Button();
            this.btn_attempts_lst = new System.Windows.Forms.Button();
            this.btn_to_game = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_normal
            // 
            this.btn_normal.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btn_normal.FlatAppearance.BorderSize = 2;
            this.btn_normal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_normal.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_normal.ForeColor = System.Drawing.Color.Red;
            this.btn_normal.Location = new System.Drawing.Point(100, 42);
            this.btn_normal.Name = "btn_normal";
            this.btn_normal.Size = new System.Drawing.Size(200, 52);
            this.btn_normal.TabIndex = 0;
            this.btn_normal.Text = "Normal";
            this.btn_normal.UseVisualStyleBackColor = true;
            this.btn_normal.Click += new System.EventHandler(this.btn_normal_Click);
            // 
            // btn_hard
            // 
            this.btn_hard.FlatAppearance.BorderColor = System.Drawing.SystemColors.Menu;
            this.btn_hard.FlatAppearance.BorderSize = 2;
            this.btn_hard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_hard.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_hard.ForeColor = System.Drawing.SystemColors.Menu;
            this.btn_hard.Location = new System.Drawing.Point(100, 118);
            this.btn_hard.Name = "btn_hard";
            this.btn_hard.Size = new System.Drawing.Size(200, 52);
            this.btn_hard.TabIndex = 2;
            this.btn_hard.Text = "Difficult";
            this.btn_hard.UseVisualStyleBackColor = true;
            this.btn_hard.Click += new System.EventHandler(this.btn_hard_Click);
            // 
            // btn_hc
            // 
            this.btn_hc.FlatAppearance.BorderColor = System.Drawing.SystemColors.Menu;
            this.btn_hc.FlatAppearance.BorderSize = 2;
            this.btn_hc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_hc.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_hc.ForeColor = System.Drawing.SystemColors.Menu;
            this.btn_hc.Location = new System.Drawing.Point(100, 191);
            this.btn_hc.Name = "btn_hc";
            this.btn_hc.Size = new System.Drawing.Size(200, 52);
            this.btn_hc.TabIndex = 4;
            this.btn_hc.Text = "Hardcore";
            this.btn_hc.UseVisualStyleBackColor = true;
            this.btn_hc.Click += new System.EventHandler(this.btn_hc_Click);
            // 
            // btn_uhc
            // 
            this.btn_uhc.FlatAppearance.BorderColor = System.Drawing.SystemColors.Menu;
            this.btn_uhc.FlatAppearance.BorderSize = 2;
            this.btn_uhc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_uhc.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_uhc.ForeColor = System.Drawing.SystemColors.Menu;
            this.btn_uhc.Location = new System.Drawing.Point(100, 264);
            this.btn_uhc.Name = "btn_uhc";
            this.btn_uhc.Size = new System.Drawing.Size(200, 88);
            this.btn_uhc.TabIndex = 6;
            this.btn_uhc.Text = "Ultra Hardcore";
            this.btn_uhc.UseVisualStyleBackColor = true;
            this.btn_uhc.Click += new System.EventHandler(this.btn_uhc_Click);
            // 
            // lbl_normal
            // 
            this.lbl_normal.AutoSize = true;
            this.lbl_normal.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_normal.ForeColor = System.Drawing.SystemColors.Menu;
            this.lbl_normal.Location = new System.Drawing.Point(376, 49);
            this.lbl_normal.Name = "lbl_normal";
            this.lbl_normal.Size = new System.Drawing.Size(402, 38);
            this.lbl_normal.TabIndex = 7;
            this.lbl_normal.Text = "No Time, unlimited Attepmts";
            // 
            // lbl_difficult
            // 
            this.lbl_difficult.AutoSize = true;
            this.lbl_difficult.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_difficult.ForeColor = System.Drawing.SystemColors.Menu;
            this.lbl_difficult.Location = new System.Drawing.Point(376, 125);
            this.lbl_difficult.Name = "lbl_difficult";
            this.lbl_difficult.Size = new System.Drawing.Size(307, 38);
            this.lbl_difficult.TabIndex = 8;
            this.lbl_difficult.Text = "30 mins, 30 Attepmts";
            // 
            // lbl_hc
            // 
            this.lbl_hc.AutoSize = true;
            this.lbl_hc.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_hc.ForeColor = System.Drawing.SystemColors.Menu;
            this.lbl_hc.Location = new System.Drawing.Point(376, 198);
            this.lbl_hc.Name = "lbl_hc";
            this.lbl_hc.Size = new System.Drawing.Size(307, 38);
            this.lbl_hc.TabIndex = 9;
            this.lbl_hc.Text = "15 mins, 10 Attepmts";
            // 
            // lbl_uhc
            // 
            this.lbl_uhc.AutoSize = true;
            this.lbl_uhc.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_uhc.ForeColor = System.Drawing.SystemColors.Menu;
            this.lbl_uhc.Location = new System.Drawing.Point(376, 289);
            this.lbl_uhc.Name = "lbl_uhc";
            this.lbl_uhc.Size = new System.Drawing.Size(291, 38);
            this.lbl_uhc.TabIndex = 10;
            this.lbl_uhc.Text = "10 mins, 6 Attepmts";
            // 
            // btn_clear_lst
            // 
            this.btn_clear_lst.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btn_clear_lst.FlatAppearance.BorderSize = 2;
            this.btn_clear_lst.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_clear_lst.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_clear_lst.ForeColor = System.Drawing.Color.Red;
            this.btn_clear_lst.Location = new System.Drawing.Point(100, 379);
            this.btn_clear_lst.Name = "btn_clear_lst";
            this.btn_clear_lst.Size = new System.Drawing.Size(200, 95);
            this.btn_clear_lst.TabIndex = 11;
            this.btn_clear_lst.Text = "Clear lst_log after Game";
            this.btn_clear_lst.UseVisualStyleBackColor = true;
            this.btn_clear_lst.Click += new System.EventHandler(this.btn_clear_lst_Click);
            // 
            // btn_quit
            // 
            this.btn_quit.FlatAppearance.BorderColor = System.Drawing.SystemColors.Menu;
            this.btn_quit.FlatAppearance.BorderSize = 2;
            this.btn_quit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_quit.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_quit.ForeColor = System.Drawing.SystemColors.Menu;
            this.btn_quit.Location = new System.Drawing.Point(512, 517);
            this.btn_quit.Name = "btn_quit";
            this.btn_quit.Size = new System.Drawing.Size(276, 52);
            this.btn_quit.TabIndex = 12;
            this.btn_quit.Text = "Back to Mainmenu";
            this.btn_quit.UseVisualStyleBackColor = true;
            this.btn_quit.Click += new System.EventHandler(this.btn_quit_Click);
            // 
            // btn_time_lst
            // 
            this.btn_time_lst.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btn_time_lst.FlatAppearance.BorderSize = 2;
            this.btn_time_lst.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_time_lst.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_time_lst.ForeColor = System.Drawing.Color.Red;
            this.btn_time_lst.Location = new System.Drawing.Point(313, 379);
            this.btn_time_lst.Name = "btn_time_lst";
            this.btn_time_lst.Size = new System.Drawing.Size(200, 95);
            this.btn_time_lst.TabIndex = 13;
            this.btn_time_lst.Text = "Display Time after Game";
            this.btn_time_lst.UseVisualStyleBackColor = true;
            this.btn_time_lst.Click += new System.EventHandler(this.btn_time_lst_Click);
            // 
            // btn_attempts_lst
            // 
            this.btn_attempts_lst.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btn_attempts_lst.FlatAppearance.BorderSize = 2;
            this.btn_attempts_lst.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_attempts_lst.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_attempts_lst.ForeColor = System.Drawing.Color.Red;
            this.btn_attempts_lst.Location = new System.Drawing.Point(524, 379);
            this.btn_attempts_lst.Name = "btn_attempts_lst";
            this.btn_attempts_lst.Size = new System.Drawing.Size(254, 95);
            this.btn_attempts_lst.TabIndex = 14;
            this.btn_attempts_lst.Text = "Display Attepmts after Game";
            this.btn_attempts_lst.UseVisualStyleBackColor = true;
            this.btn_attempts_lst.Click += new System.EventHandler(this.btn_attempts_lst_Click);
            // 
            // btn_to_game
            // 
            this.btn_to_game.FlatAppearance.BorderColor = System.Drawing.SystemColors.Menu;
            this.btn_to_game.FlatAppearance.BorderSize = 2;
            this.btn_to_game.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_to_game.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_to_game.ForeColor = System.Drawing.SystemColors.Menu;
            this.btn_to_game.Location = new System.Drawing.Point(512, 517);
            this.btn_to_game.Name = "btn_to_game";
            this.btn_to_game.Size = new System.Drawing.Size(276, 52);
            this.btn_to_game.TabIndex = 15;
            this.btn_to_game.Text = "Back to the Game";
            this.btn_to_game.UseVisualStyleBackColor = true;
            this.btn_to_game.Visible = false;
            this.btn_to_game.Click += new System.EventHandler(this.btn_to_game_Click);
            // 
            // settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Desktop;
            this.ClientSize = new System.Drawing.Size(800, 581);
            this.Controls.Add(this.btn_to_game);
            this.Controls.Add(this.btn_attempts_lst);
            this.Controls.Add(this.btn_time_lst);
            this.Controls.Add(this.btn_quit);
            this.Controls.Add(this.btn_clear_lst);
            this.Controls.Add(this.lbl_uhc);
            this.Controls.Add(this.lbl_hc);
            this.Controls.Add(this.lbl_difficult);
            this.Controls.Add(this.lbl_normal);
            this.Controls.Add(this.btn_uhc);
            this.Controls.Add(this.btn_hc);
            this.Controls.Add(this.btn_hard);
            this.Controls.Add(this.btn_normal);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(816, 620);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(816, 620);
            this.Name = "settings";
            this.Text = "Settings";
            this.Load += new System.EventHandler(this.settings_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_normal;
        private System.Windows.Forms.Button btn_hard;
        private System.Windows.Forms.Button btn_hc;
        private System.Windows.Forms.Button btn_uhc;
        private System.Windows.Forms.Label lbl_normal;
        private System.Windows.Forms.Label lbl_difficult;
        private System.Windows.Forms.Label lbl_hc;
        private System.Windows.Forms.Label lbl_uhc;
        private System.Windows.Forms.Button btn_clear_lst;
        private System.Windows.Forms.Button btn_quit;
        private System.Windows.Forms.Button btn_time_lst;
        private System.Windows.Forms.Button btn_attempts_lst;
        private System.Windows.Forms.Button btn_to_game;
    }
}
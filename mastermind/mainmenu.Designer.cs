
namespace mastermind
{
    partial class mainmenu
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
            this.btn_start = new System.Windows.Forms.Button();
            this.btn_options = new System.Windows.Forms.Button();
            this.btn_quit = new System.Windows.Forms.Button();
            this.btn_rules = new System.Windows.Forms.Button();
            this.btn_mod = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_start
            // 
            this.btn_start.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_start.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_start.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_start.ForeColor = System.Drawing.Color.AliceBlue;
            this.btn_start.Location = new System.Drawing.Point(186, 87);
            this.btn_start.Name = "btn_start";
            this.btn_start.Size = new System.Drawing.Size(183, 51);
            this.btn_start.TabIndex = 0;
            this.btn_start.Text = "Start Game";
            this.btn_start.UseVisualStyleBackColor = true;
            this.btn_start.Click += new System.EventHandler(this.btn_start_Click);
            // 
            // btn_options
            // 
            this.btn_options.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_options.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_options.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_options.ForeColor = System.Drawing.Color.AliceBlue;
            this.btn_options.Location = new System.Drawing.Point(437, 87);
            this.btn_options.Name = "btn_options";
            this.btn_options.Size = new System.Drawing.Size(136, 51);
            this.btn_options.TabIndex = 1;
            this.btn_options.Text = "Options";
            this.btn_options.UseVisualStyleBackColor = true;
            this.btn_options.Click += new System.EventHandler(this.btn_options_Click);
            // 
            // btn_quit
            // 
            this.btn_quit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_quit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_quit.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_quit.ForeColor = System.Drawing.Color.AliceBlue;
            this.btn_quit.Location = new System.Drawing.Point(683, 387);
            this.btn_quit.Name = "btn_quit";
            this.btn_quit.Size = new System.Drawing.Size(105, 51);
            this.btn_quit.TabIndex = 3;
            this.btn_quit.Text = "Leave";
            this.btn_quit.UseVisualStyleBackColor = true;
            this.btn_quit.Click += new System.EventHandler(this.btn_quit_Click);
            // 
            // btn_rules
            // 
            this.btn_rules.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_rules.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_rules.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_rules.ForeColor = System.Drawing.Color.AliceBlue;
            this.btn_rules.Location = new System.Drawing.Point(337, 171);
            this.btn_rules.Name = "btn_rules";
            this.btn_rules.Size = new System.Drawing.Size(136, 51);
            this.btn_rules.TabIndex = 2;
            this.btn_rules.Text = "Rules";
            this.btn_rules.UseVisualStyleBackColor = true;
            this.btn_rules.Click += new System.EventHandler(this.btn_rules_Click);
            // 
            // btn_mod
            // 
            this.btn_mod.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_mod.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_mod.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_mod.ForeColor = System.Drawing.Color.AliceBlue;
            this.btn_mod.Location = new System.Drawing.Point(235, 264);
            this.btn_mod.Name = "btn_mod";
            this.btn_mod.Size = new System.Drawing.Size(326, 51);
            this.btn_mod.TabIndex = 4;
            this.btn_mod.Text = "Advanced Gamer Sh*t";
            this.btn_mod.UseVisualStyleBackColor = true;
            this.btn_mod.Click += new System.EventHandler(this.btn_mod_Click);
            // 
            // mainmenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Desktop;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_mod);
            this.Controls.Add(this.btn_rules);
            this.Controls.Add(this.btn_quit);
            this.Controls.Add(this.btn_options);
            this.Controls.Add(this.btn_start);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(816, 489);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(816, 489);
            this.Name = "mainmenu";
            this.Text = "Mastermind - The Game";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_start;
        private System.Windows.Forms.Button btn_options;
        private System.Windows.Forms.Button btn_quit;
        private System.Windows.Forms.Button btn_rules;
        private System.Windows.Forms.Button btn_mod;
    }
}
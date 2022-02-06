namespace mastermind_pre_2_0
{
    partial class game
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(game));
            this.btn_quit = new System.Windows.Forms.Button();
            this.maintimer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // btn_quit
            // 
            this.btn_quit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_quit.Location = new System.Drawing.Point(720, 321);
            this.btn_quit.Name = "btn_quit";
            this.btn_quit.Size = new System.Drawing.Size(164, 77);
            this.btn_quit.TabIndex = 0;
            this.btn_quit.Text = "Quit";
            this.btn_quit.UseVisualStyleBackColor = true;
            this.btn_quit.Click += new System.EventHandler(this.btn_quit_Click);
            // 
            // maintimer
            // 
            this.maintimer.Interval = 1;
            this.maintimer.Tick += new System.EventHandler(this.maintimer_Tick);
            // 
            // game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 38F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1683, 955);
            this.Controls.Add(this.btn_quit);
            this.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.Name = "game";
            this.Text = "f_game";
            this.Load += new System.EventHandler(this.game_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_quit;
        private System.Windows.Forms.Timer maintimer;
    }
}
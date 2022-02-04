
namespace mastermind
{
    partial class rules
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(rules));
            this.btn_quit = new System.Windows.Forms.Button();
            this.lbl_title = new System.Windows.Forms.Label();
            this.lbl_txt = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_quit
            // 
            this.btn_quit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_quit.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_quit.ForeColor = System.Drawing.SystemColors.Menu;
            this.btn_quit.Location = new System.Drawing.Point(337, 328);
            this.btn_quit.Name = "btn_quit";
            this.btn_quit.Size = new System.Drawing.Size(99, 47);
            this.btn_quit.TabIndex = 0;
            this.btn_quit.Text = "OK!";
            this.btn_quit.UseVisualStyleBackColor = true;
            this.btn_quit.Click += new System.EventHandler(this.btn_quit_Click);
            // 
            // lbl_title
            // 
            this.lbl_title.AutoSize = true;
            this.lbl_title.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_title.ForeColor = System.Drawing.SystemColors.Menu;
            this.lbl_title.Location = new System.Drawing.Point(44, 23);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(561, 38);
            this.lbl_title.TabIndex = 1;
            this.lbl_title.Text = "Mastermind - The Rules and How to Play";
            // 
            // lbl_txt
            // 
            this.lbl_txt.AutoSize = true;
            this.lbl_txt.Font = new System.Drawing.Font("Comic Sans MS", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_txt.ForeColor = System.Drawing.SystemColors.Menu;
            this.lbl_txt.Location = new System.Drawing.Point(63, 106);
            this.lbl_txt.Name = "lbl_txt";
            this.lbl_txt.Size = new System.Drawing.Size(649, 175);
            this.lbl_txt.TabIndex = 2;
            this.lbl_txt.Text = resources.GetString("lbl_txt.Text");
            // 
            // rules
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Desktop;
            this.ClientSize = new System.Drawing.Size(800, 399);
            this.Controls.Add(this.lbl_txt);
            this.Controls.Add(this.lbl_title);
            this.Controls.Add(this.btn_quit);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(816, 438);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(816, 438);
            this.Name = "rules";
            this.Text = "Rules of Mastermind";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_quit;
        private System.Windows.Forms.Label lbl_title;
        private System.Windows.Forms.Label lbl_txt;
    }
}
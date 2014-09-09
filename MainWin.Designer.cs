namespace Cameron_Edwards_Wordguess
{
    partial class MainWin
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
            this.lab_ip = new System.Windows.Forms.Label();
            this.txt_ip = new System.Windows.Forms.TextBox();
            this.lab_port = new System.Windows.Forms.Label();
            this.txt_port = new System.Windows.Forms.TextBox();
            this.but_local = new System.Windows.Forms.Button();
            this.but_course = new System.Windows.Forms.Button();
            this.but_new = new System.Windows.Forms.Button();
            this.txt_misc = new System.Windows.Forms.TextBox();
            this.txt_def = new System.Windows.Forms.TextBox();
            this.txt_hint = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_guess = new System.Windows.Forms.TextBox();
            this.but_guess = new System.Windows.Forms.Button();
            this.but_hint = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_score = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lab_ip
            // 
            this.lab_ip.AutoSize = true;
            this.lab_ip.Location = new System.Drawing.Point(13, 13);
            this.lab_ip.Name = "lab_ip";
            this.lab_ip.Size = new System.Drawing.Size(51, 13);
            this.lab_ip.TabIndex = 0;
            this.lab_ip.Text = "Server IP";
            // 
            // txt_ip
            // 
            this.txt_ip.Location = new System.Drawing.Point(13, 30);
            this.txt_ip.MaxLength = 15;
            this.txt_ip.Name = "txt_ip";
            this.txt_ip.Size = new System.Drawing.Size(88, 20);
            this.txt_ip.TabIndex = 1;
            // 
            // lab_port
            // 
            this.lab_port.AutoSize = true;
            this.lab_port.Location = new System.Drawing.Point(108, 13);
            this.lab_port.Name = "lab_port";
            this.lab_port.Size = new System.Drawing.Size(60, 13);
            this.lab_port.TabIndex = 2;
            this.lab_port.Text = "Server Port";
            // 
            // txt_port
            // 
            this.txt_port.Location = new System.Drawing.Point(111, 30);
            this.txt_port.Name = "txt_port";
            this.txt_port.Size = new System.Drawing.Size(57, 20);
            this.txt_port.TabIndex = 3;
            // 
            // but_local
            // 
            this.but_local.Location = new System.Drawing.Point(16, 57);
            this.but_local.Name = "but_local";
            this.but_local.Size = new System.Drawing.Size(152, 23);
            this.but_local.TabIndex = 4;
            this.but_local.Text = "Use Localhost";
            this.but_local.UseVisualStyleBackColor = true;
            this.but_local.Click += new System.EventHandler(this.but_local_Click);
            // 
            // but_course
            // 
            this.but_course.Location = new System.Drawing.Point(16, 87);
            this.but_course.Name = "but_course";
            this.but_course.Size = new System.Drawing.Size(152, 23);
            this.but_course.TabIndex = 5;
            this.but_course.Text = "Use Course Server";
            this.but_course.UseVisualStyleBackColor = true;
            this.but_course.Click += new System.EventHandler(this.but_course_Click);
            // 
            // but_new
            // 
            this.but_new.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.but_new.Location = new System.Drawing.Point(175, 13);
            this.but_new.Name = "but_new";
            this.but_new.Size = new System.Drawing.Size(97, 97);
            this.but_new.TabIndex = 6;
            this.but_new.Text = "New Game";
            this.but_new.UseVisualStyleBackColor = true;
            this.but_new.Click += new System.EventHandler(this.but_new_Click);
            // 
            // txt_misc
            // 
            this.txt_misc.BackColor = System.Drawing.SystemColors.Info;
            this.txt_misc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txt_misc.Location = new System.Drawing.Point(13, 139);
            this.txt_misc.Name = "txt_misc";
            this.txt_misc.ReadOnly = true;
            this.txt_misc.Size = new System.Drawing.Size(256, 20);
            this.txt_misc.TabIndex = 7;
            this.txt_misc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_def
            // 
            this.txt_def.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txt_def.Location = new System.Drawing.Point(10, 165);
            this.txt_def.MaxLength = 200;
            this.txt_def.Multiline = true;
            this.txt_def.Name = "txt_def";
            this.txt_def.ReadOnly = true;
            this.txt_def.Size = new System.Drawing.Size(259, 20);
            this.txt_def.TabIndex = 8;
            // 
            // txt_hint
            // 
            this.txt_hint.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txt_hint.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txt_hint.Location = new System.Drawing.Point(16, 206);
            this.txt_hint.Name = "txt_hint";
            this.txt_hint.ReadOnly = true;
            this.txt_hint.Size = new System.Drawing.Size(152, 20);
            this.txt_hint.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 237);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Input:";
            // 
            // txt_guess
            // 
            this.txt_guess.Location = new System.Drawing.Point(44, 234);
            this.txt_guess.Name = "txt_guess";
            this.txt_guess.Size = new System.Drawing.Size(124, 20);
            this.txt_guess.TabIndex = 11;
            // 
            // but_guess
            // 
            this.but_guess.Location = new System.Drawing.Point(175, 191);
            this.but_guess.Name = "but_guess";
            this.but_guess.Size = new System.Drawing.Size(53, 63);
            this.but_guess.TabIndex = 12;
            this.but_guess.Text = "Guess";
            this.but_guess.UseVisualStyleBackColor = true;
            this.but_guess.Click += new System.EventHandler(this.but_guess_Click);
            // 
            // but_hint
            // 
            this.but_hint.Location = new System.Drawing.Point(235, 234);
            this.but_hint.Name = "but_hint";
            this.but_hint.Size = new System.Drawing.Size(37, 20);
            this.but_hint.TabIndex = 13;
            this.but_hint.Text = "Hint";
            this.but_hint.UseVisualStyleBackColor = true;
            this.but_hint.Click += new System.EventHandler(this.but_hint_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(235, 192);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Score:";
            // 
            // txt_score
            // 
            this.txt_score.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txt_score.Location = new System.Drawing.Point(235, 205);
            this.txt_score.MaxLength = 5;
            this.txt_score.Name = "txt_score";
            this.txt_score.ReadOnly = true;
            this.txt_score.Size = new System.Drawing.Size(38, 20);
            this.txt_score.TabIndex = 15;
            // 
            // MainWin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.txt_score);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.but_hint);
            this.Controls.Add(this.but_guess);
            this.Controls.Add(this.txt_guess);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_hint);
            this.Controls.Add(this.txt_def);
            this.Controls.Add(this.txt_misc);
            this.Controls.Add(this.but_new);
            this.Controls.Add(this.but_course);
            this.Controls.Add(this.but_local);
            this.Controls.Add(this.txt_port);
            this.Controls.Add(this.lab_port);
            this.Controls.Add(this.txt_ip);
            this.Controls.Add(this.lab_ip);
            this.Name = "MainWin";
            this.Text = "Word Guess";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lab_ip;
        private System.Windows.Forms.TextBox txt_ip;
        private System.Windows.Forms.Label lab_port;
        private System.Windows.Forms.TextBox txt_port;
        private System.Windows.Forms.Button but_local;
        private System.Windows.Forms.Button but_course;
        private System.Windows.Forms.Button but_new;
        private System.Windows.Forms.TextBox txt_misc;
        private System.Windows.Forms.TextBox txt_def;
        private System.Windows.Forms.TextBox txt_hint;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_guess;
        private System.Windows.Forms.Button but_guess;
        private System.Windows.Forms.Button but_hint;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_score;
    }
}


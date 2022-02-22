namespace Minesweeper
{
    partial class Minesweeper
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Minesweeper));
            this.MainPanel = new System.Windows.Forms.Panel();
            this.Medium = new System.Windows.Forms.RadioButton();
            this.Expert = new System.Windows.Forms.RadioButton();
            this.Beginner = new System.Windows.Forms.RadioButton();
            this.Start = new System.Windows.Forms.Button();
            this.Board = new System.Windows.Forms.FlowLayoutPanel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.StopWatch = new System.Windows.Forms.Label();
            this.MainPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainPanel
            // 
            this.MainPanel.BackColor = System.Drawing.Color.Silver;
            this.MainPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.MainPanel.Controls.Add(this.StopWatch);
            this.MainPanel.Controls.Add(this.Medium);
            this.MainPanel.Controls.Add(this.Expert);
            this.MainPanel.Controls.Add(this.Beginner);
            this.MainPanel.Controls.Add(this.Start);
            this.MainPanel.ForeColor = System.Drawing.Color.DimGray;
            this.MainPanel.Location = new System.Drawing.Point(13, 12);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(725, 90);
            this.MainPanel.TabIndex = 0;
            // 
            // Medium
            // 
            this.Medium.AutoSize = true;
            this.Medium.BackColor = System.Drawing.Color.Silver;
            this.Medium.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Medium.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Medium.ForeColor = System.Drawing.Color.Black;
            this.Medium.Location = new System.Drawing.Point(32, 32);
            this.Medium.Name = "Medium";
            this.Medium.Size = new System.Drawing.Size(88, 24);
            this.Medium.TabIndex = 3;
            this.Medium.TabStop = true;
            this.Medium.Text = "Medium";
            this.Medium.UseVisualStyleBackColor = false;
            // 
            // Expert
            // 
            this.Expert.AutoSize = true;
            this.Expert.BackColor = System.Drawing.Color.Silver;
            this.Expert.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Expert.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Expert.ForeColor = System.Drawing.Color.Black;
            this.Expert.Location = new System.Drawing.Point(32, 59);
            this.Expert.Name = "Expert";
            this.Expert.Size = new System.Drawing.Size(78, 24);
            this.Expert.TabIndex = 2;
            this.Expert.TabStop = true;
            this.Expert.Text = "Expert";
            this.Expert.UseVisualStyleBackColor = false;
            // 
            // Beginner
            // 
            this.Beginner.AutoSize = true;
            this.Beginner.BackColor = System.Drawing.Color.Silver;
            this.Beginner.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Beginner.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Beginner.ForeColor = System.Drawing.Color.Black;
            this.Beginner.Location = new System.Drawing.Point(32, 3);
            this.Beginner.Name = "Beginner";
            this.Beginner.Size = new System.Drawing.Size(96, 24);
            this.Beginner.TabIndex = 1;
            this.Beginner.TabStop = true;
            this.Beginner.Text = "Beginner";
            this.Beginner.UseVisualStyleBackColor = false;
            // 
            // Start
            // 
            this.Start.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Start.BackgroundImage")));
            this.Start.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Start.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Start.Location = new System.Drawing.Point(317, 0);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(88, 90);
            this.Start.TabIndex = 0;
            this.Start.UseVisualStyleBackColor = true;
            this.Start.Click += new System.EventHandler(this.Start_Click);
            // 
            // Board
            // 
            this.Board.BackColor = System.Drawing.Color.DarkGray;
            this.Board.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Board.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Board.ForeColor = System.Drawing.Color.Maroon;
            this.Board.Location = new System.Drawing.Point(13, 101);
            this.Board.Name = "Board";
            this.Board.Size = new System.Drawing.Size(725, 549);
            this.Board.TabIndex = 1;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // StopWatch
            // 
            this.StopWatch.AutoSize = true;
            this.StopWatch.BackColor = System.Drawing.Color.Black;
            this.StopWatch.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.StopWatch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.StopWatch.Font = new System.Drawing.Font("Times New Roman", 34F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StopWatch.ForeColor = System.Drawing.Color.DarkRed;
            this.StopWatch.Location = new System.Drawing.Point(615, 3);
            this.StopWatch.Name = "StopWatch";
            this.StopWatch.Size = new System.Drawing.Size(69, 79);
            this.StopWatch.TabIndex = 4;
            this.StopWatch.Text = "0";
            this.StopWatch.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Minesweeper
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(750, 665);
            this.Controls.Add(this.Board);
            this.Controls.Add(this.MainPanel);
            this.ForeColor = System.Drawing.Color.SkyBlue;
            this.Name = "Minesweeper";
            this.Text = "Minesweeper";
            this.MainPanel.ResumeLayout(false);
            this.MainPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.Button Start;
        private System.Windows.Forms.FlowLayoutPanel Board;
        private System.Windows.Forms.Timer Timer;
        private System.Windows.Forms.RadioButton Expert;
        private System.Windows.Forms.RadioButton Beginner;
        private System.Windows.Forms.RadioButton Medium;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label StopWatch;
    }
}


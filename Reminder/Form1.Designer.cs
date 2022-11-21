namespace Reminder
{
    partial class Reminder
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
            this.Line0 = new System.Windows.Forms.Label();
            this.Timer = new System.Windows.Forms.Timer(this.components);
            this.Line1 = new System.Windows.Forms.Label();
            this.Line2 = new System.Windows.Forms.Label();
            this.Clock = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // Line0
            // 
            this.Line0.AllowDrop = true;
            this.Line0.AutoSize = true;
            this.Line0.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(1)))), ((int)(((byte)(1)))));
            this.Line0.Dock = System.Windows.Forms.DockStyle.Top;
            this.Line0.Font = new System.Drawing.Font("Lucida Sans Typewriter", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Line0.ForeColor = System.Drawing.Color.White;
            this.Line0.Location = new System.Drawing.Point(0, 0);
            this.Line0.Margin = new System.Windows.Forms.Padding(0);
            this.Line0.MaximumSize = new System.Drawing.Size(108, 22);
            this.Line0.MinimumSize = new System.Drawing.Size(108, 22);
            this.Line0.Name = "Line0";
            this.Line0.Size = new System.Drawing.Size(108, 22);
            this.Line0.TabIndex = 0;
            this.Line0.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Line0.MouseEnter += new System.EventHandler(this.Line0_MouseEnter);
            this.Line0.MouseLeave += new System.EventHandler(this.Line0_MouseLeave);
            // 
            // Timer
            // 
            this.Timer.Enabled = true;
            this.Timer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // Line1
            // 
            this.Line1.AutoSize = true;
            this.Line1.BackColor = System.Drawing.SystemColors.Desktop;
            this.Line1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Line1.Font = new System.Drawing.Font("Lucida Sans Typewriter", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Line1.ForeColor = System.Drawing.Color.White;
            this.Line1.Location = new System.Drawing.Point(0, 22);
            this.Line1.Margin = new System.Windows.Forms.Padding(0);
            this.Line1.MaximumSize = new System.Drawing.Size(108, 24);
            this.Line1.MinimumSize = new System.Drawing.Size(108, 24);
            this.Line1.Name = "Line1";
            this.Line1.Size = new System.Drawing.Size(108, 24);
            this.Line1.TabIndex = 1;
            this.Line1.Click += new System.EventHandler(this.Line1_Click);
            this.Line1.MouseEnter += new System.EventHandler(this.Line1_MouseEnter);
            this.Line1.MouseLeave += new System.EventHandler(this.Line1_MouseLeave);
            // 
            // Line2
            // 
            this.Line2.AutoSize = true;
            this.Line2.BackColor = System.Drawing.SystemColors.Desktop;
            this.Line2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Line2.Font = new System.Drawing.Font("Lucida Sans Typewriter", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Line2.ForeColor = System.Drawing.Color.White;
            this.Line2.Location = new System.Drawing.Point(0, 46);
            this.Line2.Margin = new System.Windows.Forms.Padding(0);
            this.Line2.MaximumSize = new System.Drawing.Size(108, 24);
            this.Line2.MinimumSize = new System.Drawing.Size(108, 24);
            this.Line2.Name = "Line2";
            this.Line2.Size = new System.Drawing.Size(108, 24);
            this.Line2.TabIndex = 2;
            this.Line2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Line2.Click += new System.EventHandler(this.Line2_Click);
            this.Line2.DoubleClick += new System.EventHandler(this.Line2_DoubleClick);
            this.Line2.MouseEnter += new System.EventHandler(this.Line2_MouseEnter);
            this.Line2.MouseLeave += new System.EventHandler(this.Line2_MouseLeave);
            // 
            // Clock
            // 
            this.Clock.Tick += new System.EventHandler(this.Clock_Tick);
            // 
            // Reminder
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(1)))), ((int)(((byte)(1)))));
            this.ClientSize = new System.Drawing.Size(108, 70);
            this.ControlBox = false;
            this.Controls.Add(this.Line1);
            this.Controls.Add(this.Line0);
            this.Controls.Add(this.Line2);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(1)))), ((int)(((byte)(1)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(108, 70);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(108, 70);
            this.Name = "Reminder";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.TopMost = true;
            this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(1)))), ((int)(((byte)(1)))));
            this.Load += new System.EventHandler(this.Reminder_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Line0;
        private System.Windows.Forms.Timer Timer;
        private System.Windows.Forms.Label Line1;
        private System.Windows.Forms.Label Line2;
        private System.Windows.Forms.Timer Clock;
    }
}


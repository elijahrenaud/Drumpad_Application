namespace Drumpad_Application
{
    partial class Test_timings
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
            this.start = new System.Windows.Forms.Button();
            this.pushme = new System.Windows.Forms.Button();
            this.stop = new System.Windows.Forms.Button();
            this.lbl_output = new System.Windows.Forms.Label();
            this.time = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // start
            // 
            this.start.Location = new System.Drawing.Point(12, 210);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(75, 23);
            this.start.TabIndex = 0;
            this.start.Text = "Start";
            this.start.UseVisualStyleBackColor = true;
            this.start.Click += new System.EventHandler(this.start_Click);
            // 
            // pushme
            // 
            this.pushme.Location = new System.Drawing.Point(93, 210);
            this.pushme.Name = "pushme";
            this.pushme.Size = new System.Drawing.Size(75, 23);
            this.pushme.TabIndex = 1;
            this.pushme.Text = "Push Me";
            this.pushme.UseVisualStyleBackColor = true;
            this.pushme.Click += new System.EventHandler(this.pushme_Click);
            // 
            // stop
            // 
            this.stop.Location = new System.Drawing.Point(174, 210);
            this.stop.Name = "stop";
            this.stop.Size = new System.Drawing.Size(75, 23);
            this.stop.TabIndex = 2;
            this.stop.Text = "Stop";
            this.stop.UseVisualStyleBackColor = true;
            this.stop.Click += new System.EventHandler(this.stop_Click);
            // 
            // lbl_output
            // 
            this.lbl_output.AutoSize = true;
            this.lbl_output.Location = new System.Drawing.Point(9, 34);
            this.lbl_output.Name = "lbl_output";
            this.lbl_output.Size = new System.Drawing.Size(44, 13);
            this.lbl_output.TabIndex = 3;
            this.lbl_output.Text = "Nothing";
            // 
            // time
            // 
            this.time.AutoSize = true;
            this.time.Location = new System.Drawing.Point(13, 13);
            this.time.Name = "time";
            this.time.Size = new System.Drawing.Size(19, 13);
            this.time.TabIndex = 4;
            this.time.Text = "00";
            // 
            // Test_timings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.time);
            this.Controls.Add(this.lbl_output);
            this.Controls.Add(this.stop);
            this.Controls.Add(this.pushme);
            this.Controls.Add(this.start);
            this.Name = "Test_timings";
            this.Text = "Test_timings";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button start;
        private System.Windows.Forms.Button pushme;
        private System.Windows.Forms.Button stop;
        private System.Windows.Forms.Label lbl_output;
        private System.Windows.Forms.Label time;
    }
}
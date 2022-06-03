namespace AutoClicker
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.startButton1 = new System.Windows.Forms.Button();
            this.hoursInput = new System.Windows.Forms.NumericUpDown();
            this.timerForKey = new System.Windows.Forms.Timer(this.components);
            this.timerForMouseClick = new System.Windows.Forms.Timer(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.minutesInput = new System.Windows.Forms.NumericUpDown();
            this.secondsInput = new System.Windows.Forms.NumericUpDown();
            this.millisecondsInput = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.hoursInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minutesInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.secondsInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.millisecondsInput)).BeginInit();
            this.SuspendLayout();
            // 
            // startButton1
            // 
            this.startButton1.BackColor = System.Drawing.SystemColors.Control;
            this.startButton1.ForeColor = System.Drawing.Color.Green;
            this.startButton1.Location = new System.Drawing.Point(158, 67);
            this.startButton1.Name = "startButton1";
            this.startButton1.Size = new System.Drawing.Size(75, 23);
            this.startButton1.TabIndex = 0;
            this.startButton1.Text = "Enable";
            this.startButton1.UseVisualStyleBackColor = false;
            this.startButton1.Click += new System.EventHandler(this.StartButton);
            // 
            // hoursInput
            // 
            this.hoursInput.Location = new System.Drawing.Point(37, 38);
            this.hoursInput.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.hoursInput.Name = "hoursInput";
            this.hoursInput.Size = new System.Drawing.Size(75, 23);
            this.hoursInput.TabIndex = 1;
            // 
            // timerForKey
            // 
            this.timerForKey.Enabled = true;
            this.timerForKey.Tick += new System.EventHandler(this.timerForKey_Tick);
            // 
            // timerForMouseClick
            // 
            this.timerForMouseClick.Tick += new System.EventHandler(this.timerForMouseClick_Tick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(128, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 30);
            this.label2.TabIndex = 3;
            this.label2.Text = "Press F6 or just click the\r\nEnable/Disable button.";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // minutesInput
            // 
            this.minutesInput.Location = new System.Drawing.Point(118, 38);
            this.minutesInput.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.minutesInput.Name = "minutesInput";
            this.minutesInput.Size = new System.Drawing.Size(75, 23);
            this.minutesInput.TabIndex = 4;
            // 
            // secondsInput
            // 
            this.secondsInput.Location = new System.Drawing.Point(199, 38);
            this.secondsInput.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.secondsInput.Name = "secondsInput";
            this.secondsInput.Size = new System.Drawing.Size(75, 23);
            this.secondsInput.TabIndex = 5;
            // 
            // millisecondsInput
            // 
            this.millisecondsInput.Location = new System.Drawing.Point(280, 38);
            this.millisecondsInput.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.millisecondsInput.Name = "millisecondsInput";
            this.millisecondsInput.Size = new System.Drawing.Size(75, 23);
            this.millisecondsInput.TabIndex = 6;
            this.millisecondsInput.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(57, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 15);
            this.label1.TabIndex = 7;
            this.label1.Text = "Hours";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(132, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 15);
            this.label3.TabIndex = 8;
            this.label3.Text = "Minutes";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(212, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 15);
            this.label4.TabIndex = 9;
            this.label4.Text = "Seconds";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(282, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 15);
            this.label5.TabIndex = 10;
            this.label5.Text = "Milliseconds";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Gray;
            this.label6.Location = new System.Drawing.Point(4, 121);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(108, 15);
            this.label6.TabIndex = 11;
            this.label6.Text = "Made by TankArgie";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(396, 140);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.millisecondsInput);
            this.Controls.Add(this.secondsInput);
            this.Controls.Add(this.minutesInput);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.hoursInput);
            this.Controls.Add(this.startButton1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Auto Clicker";
            ((System.ComponentModel.ISupportInitialize)(this.hoursInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minutesInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.secondsInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.millisecondsInput)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button startButton1;
        private NumericUpDown hoursInput;
        private System.Windows.Forms.Timer timerForKey;
        private System.Windows.Forms.Timer timerForMouseClick;
        private Label label2;
        private NumericUpDown minutesInput;
        private NumericUpDown secondsInput;
        private NumericUpDown millisecondsInput;
        private Label label1;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
    }
}
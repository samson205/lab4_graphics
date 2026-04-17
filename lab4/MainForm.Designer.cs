namespace lab4
{
    partial class MainForm
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
            pictureBox = new PictureBox();
            button1 = new Button();
            trackGlobalBrightness = new TrackBar();
            btnLight = new Button();
            trackContrast = new TrackBar();
            ((System.ComponentModel.ISupportInitialize)pictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackGlobalBrightness).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackContrast).BeginInit();
            SuspendLayout();
            // 
            // pictureBox
            // 
            pictureBox.BackColor = SystemColors.Control;
            pictureBox.Dock = DockStyle.Top;
            pictureBox.Location = new Point(0, 0);
            pictureBox.Margin = new Padding(5);
            pictureBox.Name = "pictureBox";
            pictureBox.Size = new Size(1124, 618);
            pictureBox.TabIndex = 0;
            pictureBox.TabStop = false;
            // 
            // button1
            // 
            button1.Location = new Point(637, 628);
            button1.Margin = new Padding(5);
            button1.Name = "button1";
            button1.Size = new Size(118, 38);
            button1.TabIndex = 2;
            button1.Text = "Загрузить";
            button1.UseVisualStyleBackColor = true;
            button1.Click += btnLoad_Click;
            // 
            // trackGlobalBrightness
            // 
            trackGlobalBrightness.Location = new Point(778, 628);
            trackGlobalBrightness.Maximum = 200;
            trackGlobalBrightness.Name = "trackGlobalBrightness";
            trackGlobalBrightness.Size = new Size(334, 45);
            trackGlobalBrightness.SmallChange = 2;
            trackGlobalBrightness.TabIndex = 3;
            trackGlobalBrightness.TickFrequency = 2;
            trackGlobalBrightness.Value = 100;
            trackGlobalBrightness.Scroll += trackGlobalBrightness_Scroll;
            // 
            // btnLight
            // 
            btnLight.Location = new Point(454, 628);
            btnLight.Name = "btnLight";
            btnLight.Size = new Size(100, 38);
            btnLight.TabIndex = 4;
            btnLight.Text = "Фонарик";
            btnLight.UseVisualStyleBackColor = true;
            btnLight.Click += btnLight_Click;
            // 
            // trackContrast
            // 
            trackContrast.Location = new Point(35, 626);
            trackContrast.Maximum = 200;
            trackContrast.Name = "trackContrast";
            trackContrast.Size = new Size(334, 45);
            trackContrast.SmallChange = 2;
            trackContrast.TabIndex = 5;
            trackContrast.TickFrequency = 2;
            trackContrast.Value = 100;
            trackContrast.Scroll += trackContrast_Scroll;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(1124, 680);
            Controls.Add(trackContrast);
            Controls.Add(btnLight);
            Controls.Add(trackGlobalBrightness);
            Controls.Add(button1);
            Controls.Add(pictureBox);
            Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(5);
            MaximizeBox = false;
            Name = "MainForm";
            Text = "ЛР4";
            ((System.ComponentModel.ISupportInitialize)pictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)trackGlobalBrightness).EndInit();
            ((System.ComponentModel.ISupportInitialize)trackContrast).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox;
        private Button button1;
        private TrackBar trackGlobalBrightness;
        private Button btnLight;
        private TrackBar trackContrast;
    }
}

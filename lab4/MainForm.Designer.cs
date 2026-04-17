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
            ((System.ComponentModel.ISupportInitialize)pictureBox).BeginInit();
            SuspendLayout();
            // 
            // pictureBox
            // 
            pictureBox.BackColor = SystemColors.Control;
            pictureBox.Dock = DockStyle.Top;
            pictureBox.Location = new Point(0, 0);
            pictureBox.Margin = new Padding(5, 5, 5, 5);
            pictureBox.Name = "pictureBox";
            pictureBox.Size = new Size(1124, 526);
            pictureBox.TabIndex = 0;
            pictureBox.TabStop = false;
            // 
            // button1
            // 
            button1.Location = new Point(515, 560);
            button1.Margin = new Padding(5, 5, 5, 5);
            button1.Name = "button1";
            button1.Size = new Size(118, 38);
            button1.TabIndex = 2;
            button1.Text = "Загрузить";
            button1.UseVisualStyleBackColor = true;
            button1.Click += btnLoad_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(1124, 631);
            Controls.Add(button1);
            Controls.Add(pictureBox);
            Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(5, 5, 5, 5);
            MaximizeBox = false;
            Name = "MainForm";
            Text = "ЛР4";
            ((System.ComponentModel.ISupportInitialize)pictureBox).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox;
        private Button button1;
    }
}

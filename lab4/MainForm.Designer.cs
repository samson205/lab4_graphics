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
            btnMoveRight = new Button();
            btnMoveLeft = new Button();
            splitContainer = new SplitContainer();
            panel2 = new Panel();
            tableLayoutPanel3 = new TableLayoutPanel();
            lblSaturation = new Label();
            trackSaturation = new TrackBar();
            titleSaturation = new Label();
            tableLayoutPanel2 = new TableLayoutPanel();
            titleContrast = new Label();
            titleBrightness = new Label();
            lblContrast = new Label();
            lblBrightness = new Label();
            panel1 = new Panel();
            tableLayoutPanel1 = new TableLayoutPanel();
            btnSave = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackGlobalBrightness).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackContrast).BeginInit();
            ((System.ComponentModel.ISupportInitialize)splitContainer).BeginInit();
            splitContainer.Panel1.SuspendLayout();
            splitContainer.Panel2.SuspendLayout();
            splitContainer.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)trackSaturation).BeginInit();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox
            // 
            pictureBox.BackColor = SystemColors.Control;
            pictureBox.Dock = DockStyle.Fill;
            pictureBox.Location = new Point(0, 0);
            pictureBox.Margin = new Padding(5);
            pictureBox.Name = "pictureBox";
            pictureBox.Size = new Size(926, 761);
            pictureBox.TabIndex = 0;
            pictureBox.TabStop = false;
            pictureBox.Paint += pictureBox_Paint;
            pictureBox.MouseDown += pictureBox_MouseDown;
            pictureBox.MouseMove += pictureBox_MouseMove;
            pictureBox.MouseUp += pictureBox_MouseUp;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.None;
            button1.Font = new Font("Segoe UI", 12F);
            button1.Location = new Point(16, 15);
            button1.Margin = new Padding(5);
            button1.Name = "button1";
            button1.Size = new Size(95, 33);
            button1.TabIndex = 2;
            button1.Text = "Загрузить";
            button1.UseVisualStyleBackColor = true;
            button1.Click += btnLoad_Click;
            // 
            // trackGlobalBrightness
            // 
            trackGlobalBrightness.Anchor = AnchorStyles.None;
            trackGlobalBrightness.Location = new Point(167, 33);
            trackGlobalBrightness.Maximum = 200;
            trackGlobalBrightness.Name = "trackGlobalBrightness";
            trackGlobalBrightness.Orientation = Orientation.Vertical;
            trackGlobalBrightness.Size = new Size(45, 138);
            trackGlobalBrightness.SmallChange = 2;
            trackGlobalBrightness.TabIndex = 3;
            trackGlobalBrightness.TickFrequency = 2;
            trackGlobalBrightness.Value = 100;
            trackGlobalBrightness.Scroll += trackGlobalBrightness_Scroll;
            // 
            // btnLight
            // 
            btnLight.Anchor = AnchorStyles.None;
            btnLight.Font = new Font("Segoe UI", 12F);
            btnLight.Location = new Point(98, 451);
            btnLight.Name = "btnLight";
            btnLight.Size = new Size(95, 33);
            btnLight.TabIndex = 4;
            btnLight.Text = "Фонарик";
            btnLight.UseVisualStyleBackColor = true;
            btnLight.Click += btnLight_Click;
            // 
            // trackContrast
            // 
            trackContrast.Anchor = AnchorStyles.None;
            trackContrast.Location = new Point(40, 33);
            trackContrast.Maximum = 200;
            trackContrast.Name = "trackContrast";
            trackContrast.Orientation = Orientation.Vertical;
            trackContrast.Size = new Size(45, 138);
            trackContrast.SmallChange = 2;
            trackContrast.TabIndex = 5;
            trackContrast.TickFrequency = 2;
            trackContrast.Value = 100;
            trackContrast.Scroll += trackContrast_Scroll;
            // 
            // btnMoveRight
            // 
            btnMoveRight.Location = new Point(149, 660);
            btnMoveRight.Name = "btnMoveRight";
            btnMoveRight.Size = new Size(45, 38);
            btnMoveRight.TabIndex = 6;
            btnMoveRight.Text = "->";
            btnMoveRight.UseVisualStyleBackColor = true;
            // 
            // btnMoveLeft
            // 
            btnMoveLeft.Location = new Point(98, 660);
            btnMoveLeft.Name = "btnMoveLeft";
            btnMoveLeft.Size = new Size(45, 38);
            btnMoveLeft.TabIndex = 7;
            btnMoveLeft.Text = "<-";
            btnMoveLeft.UseVisualStyleBackColor = true;
            // 
            // splitContainer
            // 
            splitContainer.Dock = DockStyle.Fill;
            splitContainer.Location = new Point(0, 0);
            splitContainer.Name = "splitContainer";
            // 
            // splitContainer.Panel1
            // 
            splitContainer.Panel1.BackColor = SystemColors.ControlLight;
            splitContainer.Panel1.Controls.Add(btnLight);
            splitContainer.Panel1.Controls.Add(panel2);
            splitContainer.Panel1.Controls.Add(tableLayoutPanel3);
            splitContainer.Panel1.Controls.Add(tableLayoutPanel2);
            splitContainer.Panel1.Controls.Add(panel1);
            splitContainer.Panel1.Controls.Add(tableLayoutPanel1);
            splitContainer.Panel1.Controls.Add(btnMoveLeft);
            splitContainer.Panel1.Controls.Add(btnMoveRight);
            // 
            // splitContainer.Panel2
            // 
            splitContainer.Panel2.Controls.Add(pictureBox);
            splitContainer.Size = new Size(1184, 761);
            splitContainer.SplitterDistance = 254;
            splitContainer.TabIndex = 8;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ButtonHighlight;
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 373);
            panel2.Name = "panel2";
            panel2.Size = new Size(254, 5);
            panel2.TabIndex = 10;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 1;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel3.Controls.Add(lblSaturation, 0, 2);
            tableLayoutPanel3.Controls.Add(trackSaturation, 0, 1);
            tableLayoutPanel3.Controls.Add(titleSaturation, 0, 0);
            tableLayoutPanel3.Dock = DockStyle.Top;
            tableLayoutPanel3.Location = new Point(0, 273);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 3;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tableLayoutPanel3.Size = new Size(254, 100);
            tableLayoutPanel3.TabIndex = 11;
            // 
            // lblSaturation
            // 
            lblSaturation.Anchor = AnchorStyles.None;
            lblSaturation.AutoSize = true;
            lblSaturation.Font = new Font("Segoe UI", 9.75F);
            lblSaturation.Location = new Point(114, 76);
            lblSaturation.Name = "lblSaturation";
            lblSaturation.Size = new Size(25, 17);
            lblSaturation.TabIndex = 11;
            lblSaturation.Text = "1.0";
            // 
            // trackSaturation
            // 
            trackSaturation.Anchor = AnchorStyles.None;
            trackSaturation.Location = new Point(20, 33);
            trackSaturation.Maximum = 200;
            trackSaturation.Name = "trackSaturation";
            trackSaturation.Size = new Size(214, 34);
            trackSaturation.SmallChange = 2;
            trackSaturation.TabIndex = 10;
            trackSaturation.TickFrequency = 2;
            trackSaturation.Value = 100;
            trackSaturation.Scroll += trackSaturation_Scroll;
            // 
            // titleSaturation
            // 
            titleSaturation.Anchor = AnchorStyles.None;
            titleSaturation.AutoSize = true;
            titleSaturation.Font = new Font("Segoe UI", 12F);
            titleSaturation.Location = new Point(68, 4);
            titleSaturation.Name = "titleSaturation";
            titleSaturation.Size = new Size(117, 21);
            titleSaturation.TabIndex = 7;
            titleSaturation.Text = "Насыщенность";
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 49.9999962F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50.0000076F));
            tableLayoutPanel2.Controls.Add(trackContrast, 0, 1);
            tableLayoutPanel2.Controls.Add(trackGlobalBrightness, 1, 1);
            tableLayoutPanel2.Controls.Add(titleContrast, 0, 0);
            tableLayoutPanel2.Controls.Add(titleBrightness, 1, 0);
            tableLayoutPanel2.Controls.Add(lblContrast, 0, 2);
            tableLayoutPanel2.Controls.Add(lblBrightness, 1, 2);
            tableLayoutPanel2.Dock = DockStyle.Top;
            tableLayoutPanel2.Location = new Point(0, 69);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 3;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.Size = new Size(254, 204);
            tableLayoutPanel2.TabIndex = 10;
            // 
            // titleContrast
            // 
            titleContrast.Anchor = AnchorStyles.None;
            titleContrast.AutoSize = true;
            titleContrast.Font = new Font("Segoe UI", 12F);
            titleContrast.Location = new Point(5, 4);
            titleContrast.Name = "titleContrast";
            titleContrast.Size = new Size(115, 21);
            titleContrast.TabIndex = 6;
            titleContrast.Text = "Контрастность";
            // 
            // titleBrightness
            // 
            titleBrightness.Anchor = AnchorStyles.None;
            titleBrightness.AutoSize = true;
            titleBrightness.Font = new Font("Segoe UI", 12F);
            titleBrightness.Location = new Point(156, 4);
            titleBrightness.Name = "titleBrightness";
            titleBrightness.Size = new Size(67, 21);
            titleBrightness.TabIndex = 7;
            titleBrightness.Text = "Яркость";
            // 
            // lblContrast
            // 
            lblContrast.Anchor = AnchorStyles.None;
            lblContrast.AutoSize = true;
            lblContrast.Font = new Font("Segoe UI", 9.75F);
            lblContrast.Location = new Point(50, 180);
            lblContrast.Name = "lblContrast";
            lblContrast.Size = new Size(25, 17);
            lblContrast.TabIndex = 8;
            lblContrast.Text = "1.0";
            // 
            // lblBrightness
            // 
            lblBrightness.Anchor = AnchorStyles.None;
            lblBrightness.AutoSize = true;
            lblBrightness.Font = new Font("Segoe UI", 9.75F);
            lblBrightness.Location = new Point(177, 180);
            lblBrightness.Name = "lblBrightness";
            lblBrightness.Size = new Size(25, 17);
            lblBrightness.TabIndex = 9;
            lblBrightness.Text = "1.0";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ButtonHighlight;
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 64);
            panel1.Name = "panel1";
            panel1.Size = new Size(254, 5);
            panel1.TabIndex = 9;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(btnSave, 1, 0);
            tableLayoutPanel1.Controls.Add(button1, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Top;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(254, 64);
            tableLayoutPanel1.TabIndex = 8;
            // 
            // btnSave
            // 
            btnSave.Anchor = AnchorStyles.None;
            btnSave.Font = new Font("Segoe UI", 12F);
            btnSave.Location = new Point(143, 15);
            btnSave.Margin = new Padding(5);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(95, 33);
            btnSave.TabIndex = 3;
            btnSave.Text = "Сохранить";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(1184, 761);
            Controls.Add(splitContainer);
            DoubleBuffered = true;
            Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(5);
            MaximizeBox = false;
            Name = "MainForm";
            Text = "ЛР4";
            ((System.ComponentModel.ISupportInitialize)pictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)trackGlobalBrightness).EndInit();
            ((System.ComponentModel.ISupportInitialize)trackContrast).EndInit();
            splitContainer.Panel1.ResumeLayout(false);
            splitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer).EndInit();
            splitContainer.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)trackSaturation).EndInit();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox;
        private Button button1;
        private TrackBar trackGlobalBrightness;
        private Button btnLight;
        private TrackBar trackContrast;
        private Button btnMoveRight;
        private Button btnMoveLeft;
        private SplitContainer splitContainer;
        private Panel panel1;
        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private Panel panel2;
        private Label titleContrast;
        private Label titleBrightness;
        private Label lblContrast;
        private Label lblBrightness;
        private TableLayoutPanel tableLayoutPanel3;
        private Button btnSave;
        private Label lblSaturation;
        private TrackBar trackSaturation;
        private Label titleSaturation;
    }
}

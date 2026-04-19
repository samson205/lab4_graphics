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
            btnLoad = new Button();
            trackGlobalBrightness = new TrackBar();
            trackContrast = new TrackBar();
            btnRotateRight = new Button();
            btnRotateLeft = new Button();
            splitContainer = new SplitContainer();
            tlpBottomBtns = new TableLayoutPanel();
            btnApplyUV = new Button();
            checkLight = new CheckBox();
            tlpUvRight = new TableLayoutPanel();
            tlpRightTopUV = new TableLayoutPanel();
            numV3 = new NumericUpDown();
            numU3 = new NumericUpDown();
            tlpRightBottomUV = new TableLayoutPanel();
            numV4 = new NumericUpDown();
            numU4 = new NumericUpDown();
            lblRightBottomUV = new Label();
            labelRightTopUV = new Label();
            tlpUvRightTitle = new TableLayoutPanel();
            lblRightUV = new Label();
            tlpUvLeft = new TableLayoutPanel();
            tlpLeftTopUV = new TableLayoutPanel();
            numV2 = new NumericUpDown();
            numU2 = new NumericUpDown();
            tlpLeftBottomUV = new TableLayoutPanel();
            numV1 = new NumericUpDown();
            numU1 = new NumericUpDown();
            lblLeftBottomUV = new Label();
            lblLeftTopUV = new Label();
            tlpUvTitle = new TableLayoutPanel();
            titleUV = new Label();
            lblLeftUV = new Label();
            panelSep4 = new Panel();
            tlpRotate = new TableLayoutPanel();
            tlpRotateTitle = new TableLayoutPanel();
            titleRotate = new Label();
            panelSep3 = new Panel();
            tlpScale = new TableLayoutPanel();
            tlpScaleX = new TableLayoutPanel();
            btnScalePlusX = new Button();
            btnScaleMinusX = new Button();
            tlpScaleY = new TableLayoutPanel();
            btnScalePlusY = new Button();
            btnScaleMinusY = new Button();
            lblScaleX = new Label();
            lblScaleY = new Label();
            tlpScaleTitle = new TableLayoutPanel();
            titleScale = new Label();
            panelSep2 = new Panel();
            tlpSaturation = new TableLayoutPanel();
            lblSaturation = new Label();
            trackSaturation = new TrackBar();
            titleSaturation = new Label();
            tlpFilters = new TableLayoutPanel();
            titleContrast = new Label();
            titleBrightness = new Label();
            lblContrast = new Label();
            lblBrightness = new Label();
            panelSep1 = new Panel();
            tlpTopBtns = new TableLayoutPanel();
            btnReset = new Button();
            btnSave = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackGlobalBrightness).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackContrast).BeginInit();
            ((System.ComponentModel.ISupportInitialize)splitContainer).BeginInit();
            splitContainer.Panel1.SuspendLayout();
            splitContainer.Panel2.SuspendLayout();
            splitContainer.SuspendLayout();
            tlpBottomBtns.SuspendLayout();
            tlpUvRight.SuspendLayout();
            tlpRightTopUV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numV3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numU3).BeginInit();
            tlpRightBottomUV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numV4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numU4).BeginInit();
            tlpUvRightTitle.SuspendLayout();
            tlpUvLeft.SuspendLayout();
            tlpLeftTopUV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numV2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numU2).BeginInit();
            tlpLeftBottomUV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numV1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numU1).BeginInit();
            tlpUvTitle.SuspendLayout();
            tlpRotate.SuspendLayout();
            tlpRotateTitle.SuspendLayout();
            tlpScale.SuspendLayout();
            tlpScaleX.SuspendLayout();
            tlpScaleY.SuspendLayout();
            tlpScaleTitle.SuspendLayout();
            tlpSaturation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)trackSaturation).BeginInit();
            tlpFilters.SuspendLayout();
            tlpTopBtns.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox
            // 
            pictureBox.BackColor = SystemColors.Control;
            pictureBox.Dock = DockStyle.Fill;
            pictureBox.Location = new Point(0, 0);
            pictureBox.Margin = new Padding(5);
            pictureBox.Name = "pictureBox";
            pictureBox.Size = new Size(926, 861);
            pictureBox.TabIndex = 0;
            pictureBox.TabStop = false;
            pictureBox.Paint += pictureBox_Paint;
            pictureBox.MouseDown += pictureBox_MouseDown;
            pictureBox.MouseMove += pictureBox_MouseMove;
            pictureBox.MouseUp += pictureBox_MouseUp;
            // 
            // btnLoad
            // 
            btnLoad.Anchor = AnchorStyles.None;
            btnLoad.Font = new Font("Segoe UI", 12F);
            btnLoad.Location = new Point(5, 15);
            btnLoad.Margin = new Padding(5);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(74, 33);
            btnLoad.TabIndex = 2;
            btnLoad.Text = "Load";
            btnLoad.UseVisualStyleBackColor = true;
            btnLoad.Click += btnLoad_Click;
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
            // btnRotateRight
            // 
            btnRotateRight.Anchor = AnchorStyles.None;
            btnRotateRight.Font = new Font("Segoe UI", 12F);
            btnRotateRight.Location = new Point(155, 8);
            btnRotateRight.Name = "btnRotateRight";
            btnRotateRight.Size = new Size(70, 30);
            btnRotateRight.TabIndex = 6;
            btnRotateRight.Text = "Right";
            btnRotateRight.UseVisualStyleBackColor = true;
            btnRotateRight.Click += btnRotateRight_Click;
            // 
            // btnRotateLeft
            // 
            btnRotateLeft.Anchor = AnchorStyles.None;
            btnRotateLeft.Font = new Font("Segoe UI", 12F);
            btnRotateLeft.Location = new Point(28, 8);
            btnRotateLeft.Name = "btnRotateLeft";
            btnRotateLeft.Size = new Size(70, 30);
            btnRotateLeft.TabIndex = 7;
            btnRotateLeft.Text = "Left";
            btnRotateLeft.UseVisualStyleBackColor = true;
            btnRotateLeft.Click += btnRotateLeft_Click;
            // 
            // splitContainer
            // 
            splitContainer.Dock = DockStyle.Fill;
            splitContainer.FixedPanel = FixedPanel.Panel1;
            splitContainer.IsSplitterFixed = true;
            splitContainer.Location = new Point(0, 0);
            splitContainer.Name = "splitContainer";
            // 
            // splitContainer.Panel1
            // 
            splitContainer.Panel1.BackColor = SystemColors.ControlLight;
            splitContainer.Panel1.Controls.Add(tlpBottomBtns);
            splitContainer.Panel1.Controls.Add(tlpUvRight);
            splitContainer.Panel1.Controls.Add(tlpUvRightTitle);
            splitContainer.Panel1.Controls.Add(tlpUvLeft);
            splitContainer.Panel1.Controls.Add(tlpUvTitle);
            splitContainer.Panel1.Controls.Add(panelSep4);
            splitContainer.Panel1.Controls.Add(tlpRotate);
            splitContainer.Panel1.Controls.Add(tlpRotateTitle);
            splitContainer.Panel1.Controls.Add(panelSep3);
            splitContainer.Panel1.Controls.Add(tlpScale);
            splitContainer.Panel1.Controls.Add(tlpScaleTitle);
            splitContainer.Panel1.Controls.Add(panelSep2);
            splitContainer.Panel1.Controls.Add(tlpSaturation);
            splitContainer.Panel1.Controls.Add(tlpFilters);
            splitContainer.Panel1.Controls.Add(panelSep1);
            splitContainer.Panel1.Controls.Add(tlpTopBtns);
            // 
            // splitContainer.Panel2
            // 
            splitContainer.Panel2.Controls.Add(pictureBox);
            splitContainer.Size = new Size(1184, 861);
            splitContainer.SplitterDistance = 254;
            splitContainer.TabIndex = 8;
            // 
            // tlpBottomBtns
            // 
            tlpBottomBtns.ColumnCount = 2;
            tlpBottomBtns.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlpBottomBtns.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlpBottomBtns.Controls.Add(btnApplyUV, 0, 0);
            tlpBottomBtns.Controls.Add(checkLight, 1, 0);
            tlpBottomBtns.Dock = DockStyle.Fill;
            tlpBottomBtns.Location = new Point(0, 803);
            tlpBottomBtns.Name = "tlpBottomBtns";
            tlpBottomBtns.RowCount = 1;
            tlpBottomBtns.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpBottomBtns.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tlpBottomBtns.Size = new Size(254, 58);
            tlpBottomBtns.TabIndex = 23;
            // 
            // btnApplyUV
            // 
            btnApplyUV.Anchor = AnchorStyles.None;
            btnApplyUV.Font = new Font("Segoe UI", 12F);
            btnApplyUV.Location = new Point(16, 12);
            btnApplyUV.Name = "btnApplyUV";
            btnApplyUV.Size = new Size(95, 34);
            btnApplyUV.TabIndex = 13;
            btnApplyUV.Text = "Apply";
            btnApplyUV.UseVisualStyleBackColor = true;
            btnApplyUV.Click += btnApplyUV_Click;
            // 
            // checkLight
            // 
            checkLight.Anchor = AnchorStyles.None;
            checkLight.Appearance = Appearance.Button;
            checkLight.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            checkLight.Location = new Point(143, 12);
            checkLight.Name = "checkLight";
            checkLight.Size = new Size(95, 34);
            checkLight.TabIndex = 12;
            checkLight.Text = "Light*";
            checkLight.TextAlign = ContentAlignment.MiddleCenter;
            checkLight.UseVisualStyleBackColor = true;
            checkLight.Click += checkLight_Click;
            // 
            // tlpUvRight
            // 
            tlpUvRight.ColumnCount = 2;
            tlpUvRight.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlpUvRight.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlpUvRight.Controls.Add(tlpRightTopUV, 1, 1);
            tlpUvRight.Controls.Add(tlpRightBottomUV, 0, 1);
            tlpUvRight.Controls.Add(lblRightBottomUV, 0, 0);
            tlpUvRight.Controls.Add(labelRightTopUV, 1, 0);
            tlpUvRight.Dock = DockStyle.Top;
            tlpUvRight.Location = new Point(0, 735);
            tlpUvRight.Name = "tlpUvRight";
            tlpUvRight.RowCount = 2;
            tlpUvRight.RowStyles.Add(new RowStyle(SizeType.Absolute, 25F));
            tlpUvRight.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpUvRight.Size = new Size(254, 68);
            tlpUvRight.TabIndex = 22;
            // 
            // tlpRightTopUV
            // 
            tlpRightTopUV.ColumnCount = 2;
            tlpRightTopUV.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlpRightTopUV.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlpRightTopUV.Controls.Add(numV3, 1, 0);
            tlpRightTopUV.Controls.Add(numU3, 0, 0);
            tlpRightTopUV.Location = new Point(130, 28);
            tlpRightTopUV.Name = "tlpRightTopUV";
            tlpRightTopUV.RowCount = 1;
            tlpRightTopUV.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpRightTopUV.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tlpRightTopUV.Size = new Size(121, 37);
            tlpRightTopUV.TabIndex = 5;
            // 
            // numV3
            // 
            numV3.DecimalPlaces = 1;
            numV3.Increment = new decimal(new int[] { 1, 0, 0, 65536 });
            numV3.Location = new Point(63, 3);
            numV3.Maximum = new decimal(new int[] { 1, 0, 0, 0 });
            numV3.Name = "numV3";
            numV3.Size = new Size(54, 33);
            numV3.TabIndex = 2;
            // 
            // numU3
            // 
            numU3.DecimalPlaces = 1;
            numU3.Increment = new decimal(new int[] { 1, 0, 0, 65536 });
            numU3.Location = new Point(3, 3);
            numU3.Maximum = new decimal(new int[] { 1, 0, 0, 0 });
            numU3.Name = "numU3";
            numU3.Size = new Size(54, 33);
            numU3.TabIndex = 1;
            numU3.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // tlpRightBottomUV
            // 
            tlpRightBottomUV.ColumnCount = 2;
            tlpRightBottomUV.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlpRightBottomUV.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlpRightBottomUV.Controls.Add(numV4, 1, 0);
            tlpRightBottomUV.Controls.Add(numU4, 0, 0);
            tlpRightBottomUV.Location = new Point(3, 28);
            tlpRightBottomUV.Name = "tlpRightBottomUV";
            tlpRightBottomUV.RowCount = 1;
            tlpRightBottomUV.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpRightBottomUV.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tlpRightBottomUV.Size = new Size(121, 37);
            tlpRightBottomUV.TabIndex = 4;
            // 
            // numV4
            // 
            numV4.DecimalPlaces = 1;
            numV4.Increment = new decimal(new int[] { 1, 0, 0, 65536 });
            numV4.Location = new Point(63, 3);
            numV4.Maximum = new decimal(new int[] { 1, 0, 0, 0 });
            numV4.Name = "numV4";
            numV4.Size = new Size(54, 33);
            numV4.TabIndex = 2;
            numV4.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // numU4
            // 
            numU4.DecimalPlaces = 1;
            numU4.Increment = new decimal(new int[] { 1, 0, 0, 65536 });
            numU4.Location = new Point(3, 3);
            numU4.Maximum = new decimal(new int[] { 1, 0, 0, 0 });
            numU4.Name = "numU4";
            numU4.Size = new Size(54, 33);
            numU4.TabIndex = 1;
            numU4.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // lblRightBottomUV
            // 
            lblRightBottomUV.Anchor = AnchorStyles.None;
            lblRightBottomUV.AutoSize = true;
            lblRightBottomUV.Font = new Font("Segoe UI", 12F);
            lblRightBottomUV.Location = new Point(33, 2);
            lblRightBottomUV.Name = "lblRightBottomUV";
            lblRightBottomUV.Size = new Size(61, 21);
            lblRightBottomUV.TabIndex = 2;
            lblRightBottomUV.Text = "Bottom";
            // 
            // labelRightTopUV
            // 
            labelRightTopUV.Anchor = AnchorStyles.None;
            labelRightTopUV.AutoSize = true;
            labelRightTopUV.Font = new Font("Segoe UI", 12F);
            labelRightTopUV.Location = new Point(173, 2);
            labelRightTopUV.Name = "labelRightTopUV";
            labelRightTopUV.Size = new Size(34, 21);
            labelRightTopUV.TabIndex = 3;
            labelRightTopUV.Text = "Top";
            // 
            // tlpUvRightTitle
            // 
            tlpUvRightTitle.ColumnCount = 3;
            tlpUvRightTitle.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlpUvRightTitle.ColumnStyles.Add(new ColumnStyle());
            tlpUvRightTitle.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlpUvRightTitle.Controls.Add(lblRightUV, 1, 0);
            tlpUvRightTitle.Dock = DockStyle.Top;
            tlpUvRightTitle.Location = new Point(0, 705);
            tlpUvRightTitle.Name = "tlpUvRightTitle";
            tlpUvRightTitle.RowCount = 1;
            tlpUvRightTitle.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpUvRightTitle.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tlpUvRightTitle.Size = new Size(254, 30);
            tlpUvRightTitle.TabIndex = 21;
            // 
            // lblRightUV
            // 
            lblRightUV.Anchor = AnchorStyles.None;
            lblRightUV.AutoSize = true;
            lblRightUV.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            lblRightUV.Location = new Point(103, 4);
            lblRightUV.Name = "lblRightUV";
            lblRightUV.Size = new Size(47, 21);
            lblRightUV.TabIndex = 1;
            lblRightUV.Text = "Right";
            lblRightUV.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tlpUvLeft
            // 
            tlpUvLeft.ColumnCount = 2;
            tlpUvLeft.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlpUvLeft.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlpUvLeft.Controls.Add(tlpLeftTopUV, 1, 1);
            tlpUvLeft.Controls.Add(tlpLeftBottomUV, 0, 1);
            tlpUvLeft.Controls.Add(lblLeftBottomUV, 0, 0);
            tlpUvLeft.Controls.Add(lblLeftTopUV, 1, 0);
            tlpUvLeft.Dock = DockStyle.Top;
            tlpUvLeft.Location = new Point(0, 637);
            tlpUvLeft.Name = "tlpUvLeft";
            tlpUvLeft.RowCount = 2;
            tlpUvLeft.RowStyles.Add(new RowStyle(SizeType.Absolute, 25F));
            tlpUvLeft.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpUvLeft.Size = new Size(254, 68);
            tlpUvLeft.TabIndex = 19;
            // 
            // tlpLeftTopUV
            // 
            tlpLeftTopUV.ColumnCount = 2;
            tlpLeftTopUV.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlpLeftTopUV.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlpLeftTopUV.Controls.Add(numV2, 1, 0);
            tlpLeftTopUV.Controls.Add(numU2, 0, 0);
            tlpLeftTopUV.Location = new Point(130, 28);
            tlpLeftTopUV.Name = "tlpLeftTopUV";
            tlpLeftTopUV.RowCount = 1;
            tlpLeftTopUV.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpLeftTopUV.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tlpLeftTopUV.Size = new Size(121, 37);
            tlpLeftTopUV.TabIndex = 5;
            // 
            // numV2
            // 
            numV2.DecimalPlaces = 1;
            numV2.Increment = new decimal(new int[] { 1, 0, 0, 65536 });
            numV2.Location = new Point(63, 3);
            numV2.Maximum = new decimal(new int[] { 1, 0, 0, 0 });
            numV2.Name = "numV2";
            numV2.Size = new Size(54, 33);
            numV2.TabIndex = 2;
            // 
            // numU2
            // 
            numU2.DecimalPlaces = 1;
            numU2.Increment = new decimal(new int[] { 1, 0, 0, 65536 });
            numU2.Location = new Point(3, 3);
            numU2.Maximum = new decimal(new int[] { 1, 0, 0, 0 });
            numU2.Name = "numU2";
            numU2.Size = new Size(54, 33);
            numU2.TabIndex = 1;
            // 
            // tlpLeftBottomUV
            // 
            tlpLeftBottomUV.ColumnCount = 2;
            tlpLeftBottomUV.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlpLeftBottomUV.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlpLeftBottomUV.Controls.Add(numV1, 1, 0);
            tlpLeftBottomUV.Controls.Add(numU1, 0, 0);
            tlpLeftBottomUV.Location = new Point(3, 28);
            tlpLeftBottomUV.Name = "tlpLeftBottomUV";
            tlpLeftBottomUV.RowCount = 1;
            tlpLeftBottomUV.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpLeftBottomUV.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tlpLeftBottomUV.Size = new Size(121, 37);
            tlpLeftBottomUV.TabIndex = 4;
            // 
            // numV1
            // 
            numV1.DecimalPlaces = 1;
            numV1.Increment = new decimal(new int[] { 1, 0, 0, 65536 });
            numV1.Location = new Point(63, 3);
            numV1.Maximum = new decimal(new int[] { 1, 0, 0, 0 });
            numV1.Name = "numV1";
            numV1.Size = new Size(54, 33);
            numV1.TabIndex = 1;
            numV1.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // numU1
            // 
            numU1.DecimalPlaces = 1;
            numU1.Increment = new decimal(new int[] { 1, 0, 0, 65536 });
            numU1.Location = new Point(3, 3);
            numU1.Maximum = new decimal(new int[] { 1, 0, 0, 0 });
            numU1.Name = "numU1";
            numU1.Size = new Size(54, 33);
            numU1.TabIndex = 0;
            // 
            // lblLeftBottomUV
            // 
            lblLeftBottomUV.Anchor = AnchorStyles.None;
            lblLeftBottomUV.AutoSize = true;
            lblLeftBottomUV.Font = new Font("Segoe UI", 12F);
            lblLeftBottomUV.Location = new Point(33, 2);
            lblLeftBottomUV.Name = "lblLeftBottomUV";
            lblLeftBottomUV.Size = new Size(61, 21);
            lblLeftBottomUV.TabIndex = 2;
            lblLeftBottomUV.Text = "Bottom";
            // 
            // lblLeftTopUV
            // 
            lblLeftTopUV.Anchor = AnchorStyles.None;
            lblLeftTopUV.AutoSize = true;
            lblLeftTopUV.Font = new Font("Segoe UI", 12F);
            lblLeftTopUV.Location = new Point(173, 2);
            lblLeftTopUV.Name = "lblLeftTopUV";
            lblLeftTopUV.Size = new Size(34, 21);
            lblLeftTopUV.TabIndex = 3;
            lblLeftTopUV.Text = "Top";
            // 
            // tlpUvTitle
            // 
            tlpUvTitle.ColumnCount = 3;
            tlpUvTitle.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlpUvTitle.ColumnStyles.Add(new ColumnStyle());
            tlpUvTitle.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlpUvTitle.Controls.Add(titleUV, 1, 0);
            tlpUvTitle.Controls.Add(lblLeftUV, 1, 1);
            tlpUvTitle.Dock = DockStyle.Top;
            tlpUvTitle.Location = new Point(0, 575);
            tlpUvTitle.Name = "tlpUvTitle";
            tlpUvTitle.RowCount = 2;
            tlpUvTitle.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tlpUvTitle.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tlpUvTitle.Size = new Size(254, 62);
            tlpUvTitle.TabIndex = 20;
            // 
            // titleUV
            // 
            titleUV.Anchor = AnchorStyles.None;
            titleUV.AutoSize = true;
            titleUV.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            titleUV.Location = new Point(65, 5);
            titleUV.Name = "titleUV";
            titleUV.Size = new Size(124, 21);
            titleUV.TabIndex = 0;
            titleUV.Text = "UV-coordinates";
            titleUV.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblLeftUV
            // 
            lblLeftUV.Anchor = AnchorStyles.None;
            lblLeftUV.AutoSize = true;
            lblLeftUV.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            lblLeftUV.Location = new Point(109, 36);
            lblLeftUV.Name = "lblLeftUV";
            lblLeftUV.Size = new Size(36, 21);
            lblLeftUV.TabIndex = 1;
            lblLeftUV.Text = "Left";
            lblLeftUV.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panelSep4
            // 
            panelSep4.BackColor = SystemColors.ButtonHighlight;
            panelSep4.Dock = DockStyle.Top;
            panelSep4.Location = new Point(0, 570);
            panelSep4.Name = "panelSep4";
            panelSep4.Size = new Size(254, 5);
            panelSep4.TabIndex = 18;
            // 
            // tlpRotate
            // 
            tlpRotate.ColumnCount = 2;
            tlpRotate.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlpRotate.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlpRotate.Controls.Add(btnRotateLeft, 0, 0);
            tlpRotate.Controls.Add(btnRotateRight, 1, 0);
            tlpRotate.Dock = DockStyle.Top;
            tlpRotate.Location = new Point(0, 523);
            tlpRotate.Name = "tlpRotate";
            tlpRotate.RowCount = 1;
            tlpRotate.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpRotate.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tlpRotate.Size = new Size(254, 47);
            tlpRotate.TabIndex = 17;
            // 
            // tlpRotateTitle
            // 
            tlpRotateTitle.ColumnCount = 3;
            tlpRotateTitle.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlpRotateTitle.ColumnStyles.Add(new ColumnStyle());
            tlpRotateTitle.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlpRotateTitle.Controls.Add(titleRotate, 1, 0);
            tlpRotateTitle.Dock = DockStyle.Top;
            tlpRotateTitle.Location = new Point(0, 487);
            tlpRotateTitle.Name = "tlpRotateTitle";
            tlpRotateTitle.RowCount = 1;
            tlpRotateTitle.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpRotateTitle.Size = new Size(254, 36);
            tlpRotateTitle.TabIndex = 16;
            // 
            // titleRotate
            // 
            titleRotate.Anchor = AnchorStyles.None;
            titleRotate.AutoSize = true;
            titleRotate.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            titleRotate.Location = new Point(97, 7);
            titleRotate.Name = "titleRotate";
            titleRotate.Size = new Size(59, 21);
            titleRotate.TabIndex = 0;
            titleRotate.Text = "Rotate";
            titleRotate.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panelSep3
            // 
            panelSep3.BackColor = SystemColors.ButtonHighlight;
            panelSep3.Dock = DockStyle.Top;
            panelSep3.Location = new Point(0, 482);
            panelSep3.Name = "panelSep3";
            panelSep3.Size = new Size(254, 5);
            panelSep3.TabIndex = 15;
            // 
            // tlpScale
            // 
            tlpScale.ColumnCount = 2;
            tlpScale.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlpScale.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlpScale.Controls.Add(tlpScaleX, 0, 1);
            tlpScale.Controls.Add(tlpScaleY, 1, 1);
            tlpScale.Controls.Add(lblScaleX, 0, 0);
            tlpScale.Controls.Add(lblScaleY, 1, 0);
            tlpScale.Dock = DockStyle.Top;
            tlpScale.Location = new Point(0, 414);
            tlpScale.Name = "tlpScale";
            tlpScale.RowCount = 2;
            tlpScale.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tlpScale.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpScale.Size = new Size(254, 68);
            tlpScale.TabIndex = 14;
            // 
            // tlpScaleX
            // 
            tlpScaleX.ColumnCount = 2;
            tlpScaleX.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlpScaleX.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlpScaleX.Controls.Add(btnScalePlusX, 0, 0);
            tlpScaleX.Controls.Add(btnScaleMinusX, 1, 0);
            tlpScaleX.Location = new Point(3, 23);
            tlpScaleX.Name = "tlpScaleX";
            tlpScaleX.RowCount = 1;
            tlpScaleX.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpScaleX.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tlpScaleX.Size = new Size(121, 42);
            tlpScaleX.TabIndex = 0;
            // 
            // btnScalePlusX
            // 
            btnScalePlusX.Dock = DockStyle.Fill;
            btnScalePlusX.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            btnScalePlusX.Location = new Point(3, 3);
            btnScalePlusX.Name = "btnScalePlusX";
            btnScalePlusX.Size = new Size(54, 36);
            btnScalePlusX.TabIndex = 0;
            btnScalePlusX.Text = "+";
            btnScalePlusX.UseVisualStyleBackColor = true;
            btnScalePlusX.Click += btnScalePlusX_Click;
            // 
            // btnScaleMinusX
            // 
            btnScaleMinusX.Dock = DockStyle.Fill;
            btnScaleMinusX.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            btnScaleMinusX.Location = new Point(63, 3);
            btnScaleMinusX.Name = "btnScaleMinusX";
            btnScaleMinusX.Size = new Size(55, 36);
            btnScaleMinusX.TabIndex = 1;
            btnScaleMinusX.Text = "-";
            btnScaleMinusX.UseVisualStyleBackColor = true;
            btnScaleMinusX.Click += btnScaleMinusX_Click;
            // 
            // tlpScaleY
            // 
            tlpScaleY.ColumnCount = 2;
            tlpScaleY.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlpScaleY.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlpScaleY.Controls.Add(btnScalePlusY, 0, 0);
            tlpScaleY.Controls.Add(btnScaleMinusY, 1, 0);
            tlpScaleY.Location = new Point(130, 23);
            tlpScaleY.Name = "tlpScaleY";
            tlpScaleY.RowCount = 1;
            tlpScaleY.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpScaleY.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tlpScaleY.Size = new Size(121, 42);
            tlpScaleY.TabIndex = 1;
            // 
            // btnScalePlusY
            // 
            btnScalePlusY.Dock = DockStyle.Fill;
            btnScalePlusY.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            btnScalePlusY.Location = new Point(3, 3);
            btnScalePlusY.Name = "btnScalePlusY";
            btnScalePlusY.Size = new Size(54, 36);
            btnScalePlusY.TabIndex = 0;
            btnScalePlusY.Text = "+";
            btnScalePlusY.UseVisualStyleBackColor = true;
            btnScalePlusY.Click += btnScalePlusY_Click;
            // 
            // btnScaleMinusY
            // 
            btnScaleMinusY.Dock = DockStyle.Fill;
            btnScaleMinusY.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            btnScaleMinusY.Location = new Point(63, 3);
            btnScaleMinusY.Name = "btnScaleMinusY";
            btnScaleMinusY.Size = new Size(55, 36);
            btnScaleMinusY.TabIndex = 1;
            btnScaleMinusY.Text = "-";
            btnScaleMinusY.UseVisualStyleBackColor = true;
            btnScaleMinusY.Click += btnScaleMinusY_Click;
            // 
            // lblScaleX
            // 
            lblScaleX.Anchor = AnchorStyles.None;
            lblScaleX.AutoSize = true;
            lblScaleX.Font = new Font("Segoe UI", 12F);
            lblScaleX.Location = new Point(54, 0);
            lblScaleX.Name = "lblScaleX";
            lblScaleX.Size = new Size(19, 20);
            lblScaleX.TabIndex = 2;
            lblScaleX.Text = "X";
            // 
            // lblScaleY
            // 
            lblScaleY.Anchor = AnchorStyles.None;
            lblScaleY.AutoSize = true;
            lblScaleY.Font = new Font("Segoe UI", 12F);
            lblScaleY.Location = new Point(181, 0);
            lblScaleY.Name = "lblScaleY";
            lblScaleY.Size = new Size(19, 20);
            lblScaleY.TabIndex = 3;
            lblScaleY.Text = "Y";
            // 
            // tlpScaleTitle
            // 
            tlpScaleTitle.ColumnCount = 3;
            tlpScaleTitle.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlpScaleTitle.ColumnStyles.Add(new ColumnStyle());
            tlpScaleTitle.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlpScaleTitle.Controls.Add(titleScale, 1, 0);
            tlpScaleTitle.Dock = DockStyle.Top;
            tlpScaleTitle.Location = new Point(0, 378);
            tlpScaleTitle.Name = "tlpScaleTitle";
            tlpScaleTitle.RowCount = 1;
            tlpScaleTitle.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpScaleTitle.Size = new Size(254, 36);
            tlpScaleTitle.TabIndex = 13;
            // 
            // titleScale
            // 
            titleScale.Anchor = AnchorStyles.None;
            titleScale.AutoSize = true;
            titleScale.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            titleScale.Location = new Point(103, 7);
            titleScale.Name = "titleScale";
            titleScale.Size = new Size(48, 21);
            titleScale.TabIndex = 0;
            titleScale.Text = "Scale";
            titleScale.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panelSep2
            // 
            panelSep2.BackColor = SystemColors.ButtonHighlight;
            panelSep2.Dock = DockStyle.Top;
            panelSep2.Location = new Point(0, 373);
            panelSep2.Name = "panelSep2";
            panelSep2.Size = new Size(254, 5);
            panelSep2.TabIndex = 10;
            // 
            // tlpSaturation
            // 
            tlpSaturation.ColumnCount = 1;
            tlpSaturation.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpSaturation.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tlpSaturation.Controls.Add(lblSaturation, 0, 2);
            tlpSaturation.Controls.Add(trackSaturation, 0, 1);
            tlpSaturation.Controls.Add(titleSaturation, 0, 0);
            tlpSaturation.Dock = DockStyle.Top;
            tlpSaturation.Location = new Point(0, 273);
            tlpSaturation.Name = "tlpSaturation";
            tlpSaturation.RowCount = 3;
            tlpSaturation.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tlpSaturation.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpSaturation.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tlpSaturation.Size = new Size(254, 100);
            tlpSaturation.TabIndex = 11;
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
            lblSaturation.Text = "1,0";
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
            titleSaturation.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            titleSaturation.Location = new Point(84, 4);
            titleSaturation.Name = "titleSaturation";
            titleSaturation.Size = new Size(85, 21);
            titleSaturation.TabIndex = 7;
            titleSaturation.Text = "Saturation";
            titleSaturation.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tlpFilters
            // 
            tlpFilters.ColumnCount = 2;
            tlpFilters.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 49.9999962F));
            tlpFilters.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50.0000076F));
            tlpFilters.Controls.Add(trackContrast, 0, 1);
            tlpFilters.Controls.Add(trackGlobalBrightness, 1, 1);
            tlpFilters.Controls.Add(titleContrast, 0, 0);
            tlpFilters.Controls.Add(titleBrightness, 1, 0);
            tlpFilters.Controls.Add(lblContrast, 0, 2);
            tlpFilters.Controls.Add(lblBrightness, 1, 2);
            tlpFilters.Dock = DockStyle.Top;
            tlpFilters.Location = new Point(0, 69);
            tlpFilters.Name = "tlpFilters";
            tlpFilters.RowCount = 3;
            tlpFilters.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tlpFilters.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpFilters.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tlpFilters.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tlpFilters.Size = new Size(254, 204);
            tlpFilters.TabIndex = 10;
            // 
            // titleContrast
            // 
            titleContrast.Anchor = AnchorStyles.None;
            titleContrast.AutoSize = true;
            titleContrast.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            titleContrast.Location = new Point(27, 4);
            titleContrast.Name = "titleContrast";
            titleContrast.Size = new Size(72, 21);
            titleContrast.TabIndex = 6;
            titleContrast.Text = "Contrast";
            titleContrast.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // titleBrightness
            // 
            titleBrightness.Anchor = AnchorStyles.None;
            titleBrightness.AutoSize = true;
            titleBrightness.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            titleBrightness.Location = new Point(146, 4);
            titleBrightness.Name = "titleBrightness";
            titleBrightness.Size = new Size(87, 21);
            titleBrightness.TabIndex = 7;
            titleBrightness.Text = "Brightness";
            titleBrightness.TextAlign = ContentAlignment.MiddleCenter;
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
            lblContrast.Text = "1,0";
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
            lblBrightness.Text = "1,0";
            // 
            // panelSep1
            // 
            panelSep1.BackColor = SystemColors.ButtonHighlight;
            panelSep1.Dock = DockStyle.Top;
            panelSep1.Location = new Point(0, 64);
            panelSep1.Name = "panelSep1";
            panelSep1.Size = new Size(254, 5);
            panelSep1.TabIndex = 9;
            // 
            // tlpTopBtns
            // 
            tlpTopBtns.ColumnCount = 3;
            tlpTopBtns.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tlpTopBtns.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tlpTopBtns.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tlpTopBtns.Controls.Add(btnReset, 2, 0);
            tlpTopBtns.Controls.Add(btnSave, 1, 0);
            tlpTopBtns.Controls.Add(btnLoad, 0, 0);
            tlpTopBtns.Dock = DockStyle.Top;
            tlpTopBtns.Location = new Point(0, 0);
            tlpTopBtns.Name = "tlpTopBtns";
            tlpTopBtns.RowCount = 1;
            tlpTopBtns.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpTopBtns.Size = new Size(254, 64);
            tlpTopBtns.TabIndex = 8;
            // 
            // btnReset
            // 
            btnReset.Anchor = AnchorStyles.None;
            btnReset.Font = new Font("Segoe UI", 12F);
            btnReset.Location = new Point(174, 15);
            btnReset.Margin = new Padding(5);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(74, 33);
            btnReset.TabIndex = 4;
            btnReset.Text = "Reset";
            btnReset.UseVisualStyleBackColor = true;
            btnReset.Click += btnReset_Click;
            // 
            // btnSave
            // 
            btnSave.Anchor = AnchorStyles.None;
            btnSave.Font = new Font("Segoe UI", 12F);
            btnSave.Location = new Point(89, 15);
            btnSave.Margin = new Padding(5);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(74, 33);
            btnSave.TabIndex = 3;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(1184, 861);
            Controls.Add(splitContainer);
            DoubleBuffered = true;
            Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Margin = new Padding(5);
            MinimumSize = new Size(1200, 900);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ЛР4";
            Resize += MainForm_Resize;
            ((System.ComponentModel.ISupportInitialize)pictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)trackGlobalBrightness).EndInit();
            ((System.ComponentModel.ISupportInitialize)trackContrast).EndInit();
            splitContainer.Panel1.ResumeLayout(false);
            splitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer).EndInit();
            splitContainer.ResumeLayout(false);
            tlpBottomBtns.ResumeLayout(false);
            tlpUvRight.ResumeLayout(false);
            tlpUvRight.PerformLayout();
            tlpRightTopUV.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)numV3).EndInit();
            ((System.ComponentModel.ISupportInitialize)numU3).EndInit();
            tlpRightBottomUV.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)numV4).EndInit();
            ((System.ComponentModel.ISupportInitialize)numU4).EndInit();
            tlpUvRightTitle.ResumeLayout(false);
            tlpUvRightTitle.PerformLayout();
            tlpUvLeft.ResumeLayout(false);
            tlpUvLeft.PerformLayout();
            tlpLeftTopUV.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)numV2).EndInit();
            ((System.ComponentModel.ISupportInitialize)numU2).EndInit();
            tlpLeftBottomUV.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)numV1).EndInit();
            ((System.ComponentModel.ISupportInitialize)numU1).EndInit();
            tlpUvTitle.ResumeLayout(false);
            tlpUvTitle.PerformLayout();
            tlpRotate.ResumeLayout(false);
            tlpRotateTitle.ResumeLayout(false);
            tlpRotateTitle.PerformLayout();
            tlpScale.ResumeLayout(false);
            tlpScale.PerformLayout();
            tlpScaleX.ResumeLayout(false);
            tlpScaleY.ResumeLayout(false);
            tlpScaleTitle.ResumeLayout(false);
            tlpScaleTitle.PerformLayout();
            tlpSaturation.ResumeLayout(false);
            tlpSaturation.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)trackSaturation).EndInit();
            tlpFilters.ResumeLayout(false);
            tlpFilters.PerformLayout();
            tlpTopBtns.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox;
        private Button btnLoad;
        private TrackBar trackGlobalBrightness;
        private TrackBar trackContrast;
        private Button btnRotateRight;
        private Button btnRotateLeft;
        private SplitContainer splitContainer;
        private Panel panelSep1;
        private TableLayoutPanel tlpTopBtns;
        private TableLayoutPanel tlpFilters;
        private Panel panelSep2;
        private Label titleContrast;
        private Label titleBrightness;
        private Label lblContrast;
        private Label lblBrightness;
        private TableLayoutPanel tlpSaturation;
        private Button btnSave;
        private Label lblSaturation;
        private TrackBar trackSaturation;
        private Label titleSaturation;
        private CheckBox checkLight;
        private TableLayoutPanel tlpScale;
        private TableLayoutPanel tlpScaleTitle;
        private Label titleScale;
        private TableLayoutPanel tlpScaleX;
        private Button btnScalePlusX;
        private Button btnScaleMinusX;
        private TableLayoutPanel tlpScaleY;
        private Button btnScalePlusY;
        private Button btnScaleMinusY;
        private Label lblScaleX;
        private Label lblScaleY;
        private Panel panelSep3;
        private TableLayoutPanel tlpRotateTitle;
        private Label titleRotate;
        private TableLayoutPanel tlpRotate;
        private TableLayoutPanel tlpUvLeft;
        private Label lblLeftBottomUV;
        private Label lblLeftTopUV;
        private Panel panelSep4;
        private TableLayoutPanel tlpUvRight;
        private Label lblRightBottomUV;
        private Label labelRightTopUV;
        private TableLayoutPanel tlpUvRightTitle;
        private Label lblRightUV;
        private TableLayoutPanel tlpUvTitle;
        private Label titleUV;
        private Label lblLeftUV;
        private TableLayoutPanel tlpRightTopUV;
        private NumericUpDown numV3;
        private NumericUpDown numU3;
        private TableLayoutPanel tlpRightBottomUV;
        private NumericUpDown numV4;
        private NumericUpDown numU4;
        private TableLayoutPanel tlpLeftTopUV;
        private NumericUpDown numV2;
        private NumericUpDown numU2;
        private TableLayoutPanel tlpLeftBottomUV;
        private NumericUpDown numV1;
        private NumericUpDown numU1;
        private TableLayoutPanel tlpBottomBtns;
        private Button btnApplyUV;
        private Button btnReset;
    }
}

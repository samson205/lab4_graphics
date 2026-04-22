namespace lab4
{
    public partial class MainForm : Form
    {
        const float ScalePlus = 1.05f, ScaleMinus = 0.95f;
        const int RotateAngle = 5;

        private (NumericUpDown U, NumericUpDown V)[] uvNums;

        Bitmap mainBmp;
        Bitmap textureBmp;
        List<Peak> peaks = new List<Peak>();

        float globalBr = 1.0f, contrast = 1.0f, saturation = 1.0f;
        Point lastPos;
        bool isLight = false;
        bool isWarned = false;
        bool isFirstLoad = true;
        bool isDraggin = false;
        int draggedPeakInd = -1;
        int draggedSideInd = -1;

        public MainForm()
        {
            InitializeComponent();
            uvNums = new (NumericUpDown, NumericUpDown)[]
            {
                (numU1, numV1),
                (numU2, numV2),
                (numU3, numV3),
                (numU4, numV4)
            };

            mainBmp = new Bitmap(pictureBox.Width, pictureBox.Height);
            pictureBox.Image = mainBmp;
        }

        private void MainForm_Resize(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized) return;
            mainBmp = new Bitmap(pictureBox.Width, pictureBox.Height);
            pictureBox.Invalidate();
        }

        private void pictureBox_MouseDown(object sender, MouseEventArgs e)
        {
            if (peaks.Count == 0) return;
            if (e.Button == MouseButtons.Left)
            {
                for (int i = 0; i < peaks.Count; i++)
                {
                    if (GetDist(e.Location, peaks[i]) <= 10f)
                    {
                        draggedPeakInd = i;
                        lastPos = e.Location;
                        return;
                    }
                }

                int draggedSide = Renderer.IsMouseOnSide(e.Location, peaks);
                if (draggedSide != -1)
                {
                    draggedSideInd = draggedSide;
                    lastPos = e.Location;
                    return;
                }

                if (Renderer.IsMouseOver(e.Location, peaks))
                {
                    isDraggin = true;
                    lastPos = e.Location;
                }
            }
        }

        private void pictureBox_MouseMove(object sender, MouseEventArgs e)
        {
            if (peaks.Count == 0) return;
            if (draggedPeakInd == -1 && draggedSideInd == -1 && !isDraggin)
            {
                bool isOverPeak = false;

                foreach (var peak in peaks)
                {
                    if (GetDist(e.Location, peak) <= 10f)
                    {
                        isOverPeak = true;
                        break;
                    }
                }

                int isMouseOnSide = Renderer.IsMouseOnSide(e.Location, peaks);

                if (isOverPeak)
                    pictureBox.Cursor = Cursors.Cross;
                else if (isMouseOnSide != -1)
                    if (isMouseOnSide % 2 == 0) pictureBox.Cursor = Cursors.SizeWE;
                    else pictureBox.Cursor = Cursors.SizeNS;
                else if (Renderer.IsMouseOver(e.Location, peaks))
                    pictureBox.Cursor = Cursors.Hand;
                else
                    pictureBox.Cursor = Cursors.Default;

                return;
            }

            float dx = e.X - lastPos.X;
            float dy = e.Y - lastPos.Y;
            if (draggedPeakInd != - 1)
            {
                peaks[draggedPeakInd].X += dx;
                peaks[draggedPeakInd].Y += dy;
            }
            else if (draggedSideInd != - 1)
            {
                if (draggedSideInd % 2 == 0)
                {
                    peaks[draggedSideInd].X += dx;
                    peaks[(draggedSideInd + 1) % peaks.Count].X += dx;
                }
                else
                {
                    peaks[draggedSideInd].Y += dy;
                    peaks[(draggedSideInd + 1) % peaks.Count].Y += dy;
                }
            }
            else if (isDraggin)
            {
                Transforms.Move(peaks, dx, -dy);
            }

            lastPos = e.Location;
            pictureBox.Invalidate();
        }

        private void pictureBox_MouseUp(object sender, MouseEventArgs e)
        {
            draggedPeakInd = -1;
            draggedSideInd = -1;
            isDraggin = false;
        }

        private void pictureBox_Paint(object sender, PaintEventArgs e)
        {
            Renderer.DrawObject(mainBmp, textureBmp, peaks, isLight, globalBr, contrast, saturation);
            e.Graphics.DrawImage(mainBmp, 0, 0);
        }

        private void btnLoad_Click(object? sender, EventArgs? e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    textureBmp = new Bitmap(ofd.FileName);
                    if (isFirstLoad)
                    {
                        InitDefaultRectangle();
                        isFirstLoad = false;
                    }
                    pictureBox.Invalidate();
                }
            }
        }
        private void btnSave_Click(object? sender, EventArgs? e)
        {
            using (SaveFileDialog sfd = new SaveFileDialog())
            {
                sfd.Filter = "PNG Image|*.png|JPEG Image|*.jpg";
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    mainBmp.Save(sfd.FileName);
                }
            }
        }

        private void btnReset_Click(object? sender, EventArgs? e)
        {
            if (peaks.Count == 0) return;
            var result = MessageBox.Show("Are you sure you want to reset the changes?", "Warning",
                                         MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                InitDefaultRectangle();

                trackContrast.Value = 100;
                contrast = 1.0f;
                lblContrast.Text = "1,0";
                trackGlobalBrightness.Value = 100;
                globalBr = 1.0f;
                lblBrightness.Text = "1,0";
                trackSaturation.Value = 100;
                saturation = 1.0f;
                lblSaturation.Text = "1,0";

                for (int i = 0; i < peaks.Count; i++)
                {
                    uvNums[i].U.Value = (decimal)peaks[i].U;
                    uvNums[i].V.Value = (decimal)peaks[i].V;
                }

                checkLight.Checked = false;
                isLight = false;

                pictureBox.Invalidate();
            }
        }

        private void checkLight_Click(object? sender, EventArgs? e)
        {
            if (!isWarned)
            {
                var result = MessageBox.Show("This is an experimental feature.\nDo you want to continue?", "Warning",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result != DialogResult.Yes) { checkLight.Checked = false; return; }
                else isWarned = true;
            }

            isLight = !isLight;
            pictureBox.Invalidate();
        }

        private void btnRotateLeft_Click(object? sender, EventArgs? e)
        {
            if (peaks.Count == 0) return;
            Transforms.Rotate(peaks, RotateAngle);
            pictureBox.Invalidate();
        }

        private void btnRotateRight_Click(object? sender, EventArgs? e)
        {
            if (peaks.Count == 0) return;
            Transforms.Rotate(peaks, -RotateAngle);
            pictureBox.Invalidate();
        }

        private void btnScalePlusX_Click(object? sender, EventArgs? e)
        {
            if (peaks.Count == 0) return;
            Transforms.Scale(peaks, ScalePlus, 1);
            pictureBox.Invalidate();
        }

        private void btnScaleMinusX_Click(object? sender, EventArgs? e)
        {
            if (peaks.Count == 0) return;
            Transforms.Scale(peaks, ScaleMinus, 1);
            pictureBox.Invalidate();
        }

        private void btnScalePlusY_Click(object? sender, EventArgs? e)
        {
            if (peaks.Count == 0) return;
            Transforms.Scale(peaks, 1, ScalePlus);
            pictureBox.Invalidate();
        }

        private void btnScaleMinusY_Click(object? sender, EventArgs? e)
        {
            if (peaks.Count == 0) return;
            Transforms.Scale(peaks, 1, ScaleMinus);
            pictureBox.Invalidate();
        }

        private void btnApplyUV_Click(object? sender, EventArgs? e)
        {
            for (int i = 0; i < peaks.Count; i++)
            {
                peaks[i].U = (float)uvNums[i].U.Value;
                peaks[i].V = (float)uvNums[i].V.Value;
            }
            pictureBox.Invalidate();
        }

        private void trackGlobalBrightness_Scroll(object? sender, EventArgs e)
        {
            globalBr = trackGlobalBrightness.Value / 100.0f;
            lblBrightness.Text = globalBr.ToString();
            pictureBox.Invalidate();
        }

        private void trackContrast_Scroll(object? sender, EventArgs e)
        {
            contrast = trackContrast.Value / 100.0f;
            lblContrast.Text = contrast.ToString();
            pictureBox.Invalidate();
        }

        private void trackSaturation_Scroll(object? sender, EventArgs e)
        {
            saturation = trackSaturation.Value / 100.0f;
            lblSaturation.Text = saturation.ToString();
            pictureBox.Invalidate();
        }

        private void InitDefaultRectangle()
        {
            int cx = pictureBox.Width / 2;
            int cy = pictureBox.Height / 2;
            peaks.Clear();
            peaks.Add(new Peak(cx - 250, cy + 250, 0, 1, 1.7f)); // A
            peaks.Add(new Peak(cx - 250, cy - 250, 0, 0, 1.9f)); // B
            peaks.Add(new Peak(cx + 250, cy - 250, 1, 0, 1.3f)); // C
            peaks.Add(new Peak(cx + 250, cy + 250, 1, 1, 0.7f)); // D
        }

        private float GetDist(Point p1, Peak p2) => (float)Math.Sqrt(Math.Pow(p1.X - p2.X, 2) + Math.Pow(p1.Y - p2.Y, 2));
    }
}

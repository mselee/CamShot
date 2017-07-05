namespace CamShot
{
    using System;
    using System.Drawing;
    using System.Threading.Tasks;
    using System.Windows.Forms;

    public partial class Lightbox : Form
    {
        private Point pStart;
        private readonly static Background bg = new Background();
        private readonly static Action ac = new Action();
        
        public Lightbox()
        {
            bg.BackgroundImage = Clipboard.GetImage();
            bg.Show();
            InitializeComponent();
            toolbox.Cursor = Cursors.Default;
            box.Width = box.Height = 0;
        }

        #region "UI"
        private void Overlay_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape) this.Close();
        }

        private void Overlay_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                toolbox.Visible = true;
                box.Location = new Point(e.X, e.Y);
                this.MouseMove += this.Overlay_MouseMove;
            }
        }

        private void Overlay_MouseMove(object sender, MouseEventArgs e)
        {
            box.Size = new Size(e.X - box.Location.X, e.Y - box.Location.Y);
        }

        private void Overlay_MouseUp(object sender, MouseEventArgs e)
        {
            this.MouseMove -= this.Overlay_MouseMove;
        }

        private void box_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                pStart = new Point(e.X, e.Y);
                this.box.MouseMove += this.box_MouseMove;
            }
        }

        private void box_MouseMove(object sender, MouseEventArgs e)
        {
            var left = Math.Min(Math.Max(box.Location.X + e.X - pStart.X, 0), this.Width - box.Width);
            var top = Math.Min(Math.Max(box.Location.Y + e.Y - pStart.Y, 0), this.Height - box.Height);
            box.Location = new Point(left, top);
        }

        private void box_MouseUp(object sender, MouseEventArgs e)
        {
            this.box.MouseMove -= this.box_MouseMove;
        }

        private void box_Move(object sender, EventArgs e)
        {
            toolbox.Location = new Point(box.Left, Math.Min(box.Location.Y + box.Height, this.Height - lbSize.Height));
        }

        private void box_Resize(object sender, EventArgs e)
        {
            //lbSize.Text = box.ClientRectangle.Width + "x" + box.ClientRectangle.Height + " @ " ;
            lbSize.Text = string.Format("{0}x{1} @ ({2},{3})", this.box.ClientRectangle.Width, this.box.ClientRectangle.Height, this.box.Location.X, this.box.Location.Y);
            toolbox.Location = new Point(box.Left, Math.Min(box.Location.Y + box.Height, this.Height - lbSize.Height));
        }
        #endregion

        private void btnCapture_Click(object sender, EventArgs e)
        {
            this.box.Visible = this.toolbox.Visible = false;
            CamShot.Capture.GetImage(bg.BackgroundImage, this.box.PointToScreen(Point.Empty), this.box.ClientRectangle.Size);
            ac.ShowDialog();
            this.Close();
        }
        
    }
}

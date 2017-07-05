namespace CamShot
{
    partial class Lightbox
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
            this.box = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.toolbox = new System.Windows.Forms.StatusStrip();
            this.lbSize = new System.Windows.Forms.ToolStripStatusLabel();
            this.btnCapture = new System.Windows.Forms.ToolStripDropDownButton();
            this.box.SuspendLayout();
            this.toolbox.SuspendLayout();
            this.SuspendLayout();
            // 
            // box
            // 
            this.box.BackColor = System.Drawing.Color.Blue;
            this.box.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.box.Controls.Add(this.panel2);
            this.box.Controls.Add(this.panel4);
            this.box.Controls.Add(this.panel3);
            this.box.Controls.Add(this.panel1);
            this.box.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.box.Location = new System.Drawing.Point(186, 101);
            this.box.Name = "box";
            this.box.Size = new System.Drawing.Size(326, 154);
            this.box.TabIndex = 0;
            this.box.MouseDown += new System.Windows.Forms.MouseEventHandler(this.box_MouseDown);
            this.box.MouseUp += new System.Windows.Forms.MouseEventHandler(this.box_MouseUp);
            this.box.Move += new System.EventHandler(this.box_Move);
            this.box.Resize += new System.EventHandler(this.box_Resize);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.panel2.BackColor = System.Drawing.Color.Blue;
            this.panel2.Cursor = System.Windows.Forms.Cursors.SizeNESW;
            this.panel2.ForeColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(-3, 145);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(10, 10);
            this.panel2.TabIndex = 1;
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.BackColor = System.Drawing.Color.Blue;
            this.panel4.Cursor = System.Windows.Forms.Cursors.SizeNESW;
            this.panel4.ForeColor = System.Drawing.Color.White;
            this.panel4.Location = new System.Drawing.Point(317, -3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(10, 10);
            this.panel4.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Blue;
            this.panel3.Cursor = System.Windows.Forms.Cursors.SizeNWSE;
            this.panel3.ForeColor = System.Drawing.Color.White;
            this.panel3.Location = new System.Drawing.Point(-3, -3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(10, 10);
            this.panel3.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.Blue;
            this.panel1.Cursor = System.Windows.Forms.Cursors.SizeNWSE;
            this.panel1.ForeColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(317, 145);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(10, 10);
            this.panel1.TabIndex = 0;
            // 
            // toolbox
            // 
            this.toolbox.BackColor = System.Drawing.Color.Black;
            this.toolbox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.toolbox.Dock = System.Windows.Forms.DockStyle.None;
            this.toolbox.GripMargin = new System.Windows.Forms.Padding(0);
            this.toolbox.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lbSize,
            this.btnCapture});
            this.toolbox.Location = new System.Drawing.Point(122, 293);
            this.toolbox.Name = "toolbox";
            this.toolbox.Size = new System.Drawing.Size(92, 37);
            this.toolbox.SizingGrip = false;
            this.toolbox.TabIndex = 5;
            this.toolbox.Visible = false;
            // 
            // lbSize
            // 
            this.lbSize.ForeColor = System.Drawing.Color.White;
            this.lbSize.Name = "lbSize";
            this.lbSize.Padding = new System.Windows.Forms.Padding(5);
            this.lbSize.Size = new System.Drawing.Size(34, 32);
            this.lbSize.Text = "0x0";
            // 
            // btnCapture
            // 
            this.btnCapture.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnCapture.ForeColor = System.Drawing.Color.White;
            this.btnCapture.Image = global::CamShot.Properties.Resources.cam;
            this.btnCapture.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnCapture.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCapture.Name = "btnCapture";
            this.btnCapture.Padding = new System.Windows.Forms.Padding(5);
            this.btnCapture.ShowDropDownArrow = false;
            this.btnCapture.Size = new System.Drawing.Size(41, 35);
            this.btnCapture.ToolTipText = "Save";
            this.btnCapture.Click += new System.EventHandler(this.btnCapture_Click);
            // 
            // Lightbox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(745, 382);
            this.ControlBox = false;
            this.Controls.Add(this.toolbox);
            this.Controls.Add(this.box);
            this.Cursor = System.Windows.Forms.Cursors.Cross;
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Lightbox";
            this.Opacity = 0.75D;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.TopMost = true;
            this.TransparencyKey = System.Drawing.Color.Blue;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Overlay_KeyDown);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Overlay_MouseDown);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Overlay_MouseUp);
            this.box.ResumeLayout(false);
            this.toolbox.ResumeLayout(false);
            this.toolbox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel box;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.StatusStrip toolbox;
        private System.Windows.Forms.ToolStripStatusLabel lbSize;
        private System.Windows.Forms.ToolStripDropDownButton btnCapture;

    }
}


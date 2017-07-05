namespace CamShot
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.IO;
    using System.Text;
    using System.Windows.Forms;
    using System.Drawing.Imaging;

    public partial class Action : Form
    {
        public Action()
        {
            InitializeComponent();
            if (File.Exists(Config.Path))
            {
                var config = Config.Load(Config.Path);
                foreach (ListViewItem item in listActions.Items)
                {
                    item.Checked = config[item.Index];
                }
            }
        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            pbox.Visible = true;
            btnDone.Visible = false;
            Config.Load(listActions.Items);

            using (var img =  CamShot.Capture.Screenshot)
            {
                if (Config.Disk)
                {
                    Directory.CreateDirectory("Screenshots");
                    img.Save(string.Format("Screenshots\\{0}.png", DateTime.Now.ToFileTimeUtc()), ImageFormat.Png);
                }

                if (Config.Clipboard)
                {
                    Clipboard.SetImage(img);
                }

                if (Config.Imgur)
                {
                    Uploaders.Imgur.Upload(img);
                }

                if (Uploaders.Count == 0) this.Close();
                else Uploaders.Completed += (o, args) => this.Close();
            }

            Config.Save();
        }
    }
}

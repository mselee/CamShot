using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CamShot
{
    using System.Collections.Specialized;
    using System.Diagnostics;
    using System.Drawing;
    using System.Drawing.Imaging;
    using System.IO;
    using System.Net;
    using System.Web.Helpers;
    using System.Web.Script.Serialization;
    using System.Windows.Forms;
    using System.Xml.Linq;
    
    public static class Uploaders
    {
        public static int Count;
        public static event EventHandler Completed;

        public static class Imgur
        {
            public static void Upload(Image img)
            {
                ++Count;
                using (var wc = new WebClient())
                {
                    var values = new NameValueCollection
                {
                    
                    {"image", Convert.ToBase64String(img.GetBytes())}
                };
                    wc.Headers.Add("Authorization", "Client-ID xxxxx");
                    wc.UploadValuesAsync(new Uri("https://api.imgur.com/3/upload.json"), values);
                    wc.UploadValuesCompleted += (sender, e) =>
                    {
                        var res = Json.Decode<Response>(Encoding.Default.GetString(e.Result));
                        Process.Start(res.data.link);
                        if (--Count == 0)
                        {
                            var handler = Completed;
                            if (handler != null) handler(null, EventArgs.Empty);
                        }
                    };
                }
            }

            public class Response
            {
                public Data data { get; set; }
                public bool success { get; set; }
                public int status { get; set; }

                public class Data
                {
                    public string id { get; set; }
                    public string deletehash { get; set; }
                    public string link { get; set; }
                }
            }
        }
        
    }

    public static class ImageExtensions
    {
        public static byte[] GetBytes(this Image image)
        {
            using (var ms = new MemoryStream())
            {
                image.Save(ms, ImageFormat.Png);
                return ms.ToArray();
            }
        }
    }
}

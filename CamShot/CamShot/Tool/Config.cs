using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CamShot
{
    using System.Collections;
    using System.IO;
    using System.Reflection;
    using System.Windows.Forms;

    public static class Config
    {
        public const string Path = "config.txt";
        public static bool Disk { get; set; }
        public static bool Clipboard { get; set; }
        public static bool Imgur { get; set; }

        public static void Save()
        {
            var str = new StringBuilder();
            foreach (var item in typeof(Config).GetProperties(BindingFlags.Static))
            {
                str.AppendLine(item.Name + "=" + item.GetValue(null));
            }
            File.WriteAllText(Path, str.ToString());
        }

        public static List<bool> Load(string path)
        {
            var list = new List<bool>();
            var lines = File.ReadAllLines(path);
            foreach (var line in lines)
            {
                var str = line.Split('=');
                var name = str[0];
                var value = bool.Parse(str[1]);
                typeof(Config).GetProperty(name).SetValue(null, value, null);
                list.Add(value);
            }
            return list;
        }

        public static void Load(IEnumerable items)
        {
            foreach (ListViewItem item in items)
            {
                typeof(Config).GetProperty(item.Text).SetValue(null, item.Checked, null);
            }
        }
    }
}

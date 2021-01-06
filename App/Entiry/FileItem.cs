using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace NShell
{
    public class FileItem
    {
        public FileItem(string txt)
        {
            var ts = txt.Split('|');
            if (ts.Length != 9) return;

            Text = txt;
            Name = ts[8];

            Size = decimal.Parse(ts[4]);

            Date = $"{ts[5]} {ts[6]} {ts[7]}";
            Type = ts[0][0] == 'd' ? FileItemType.DIR : FileItemType.FILE;
        }

        public FileItem(string name, decimal size, string date = "", FileItemType type = FileItemType.DIR)
        {
            Name = name;
            Size = size;
            Date = date;
            Type = type;
        }

        public FileItemType Type { get; set; }
        public string Text { get; private set; }

        public string Name { get; private set; }
        //public string NameEx => Name + (Type == FileItemType.DIR ? "/" : "");

        public decimal Size { get; private set; }
        public string SizeEx { get => getSizeEx(); }

        public string Date { get; private set; }

        public override string ToString()
        {
            return $"{Name}\t{SizeEx,8}";
        }

        string getSizeEx()
        {
            if (Size == 0) return "";

            var u = "BKMGTP";
            var i = 0;
            var size = Size;
            while (size >= 1024)
            {
                size /= 1024;
                i++;
            }
            return size.ToString("#.##") + u[i];
        }
    }

    public enum FileItemType
    {
        FILE,
        DIR
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using System.Text.RegularExpressions;
using System.IO;
using System.Runtime.CompilerServices;

namespace NShell.UserContorl
{
    public partial class FileBrowser : UserControl
    {
        public delegate void OnFocusedHandler(FileBrowser fb);
        public event OnFocusedHandler OnFocused;

        public HostInfo host { get; private set; }
        public FileItem FileItem { get; private set; }

        public string FullPath { get => tb_path.Text; }

        List<HostInfo> hosts;
        Process p;

        public FileBrowser()
        {
            InitializeComponent();
        }

        public void SetHosts(List<HostInfo> hs)
        {
            hosts = hs;
            cb_hosts.Items.AddRange(hosts.ToArray());
        }

        public new void Refresh()
        {
            changePath(".");
        }

        public void Delete()
        {
            if (host.Ipa == "127.0.0.1")
            {
                if (FileItem.Type == FileItemType.DIR)
                {
                    Directory.Delete($"{FullPath}\\{FileItem.Name}", true);
                }
                else
                {
                    File.Delete($"{FullPath}\\{FileItem.Name}");
                }
            }
            else
            {
                p = new Process();
                p.StartInfo.FileName = Application.StartupPath + "\\putty\\plink.exe";
                p.StartInfo.Arguments = $"-pw {Secret.RC4Decrypt(host.Pwd)} {host.Uin}@{host.Ipa} \"rm -rf {FullPath}/{FileItem.Name}\"";
                p.StartInfo.CreateNoWindow = true;
                p.StartInfo.UseShellExecute = false;
                p.StartInfo.StandardOutputEncoding = Encoding.UTF8;
                p.StartInfo.RedirectStandardInput = true;
                p.StartInfo.RedirectStandardOutput = true;

                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            Refresh();
        }

        public void NewFile()
        {

        }

        public void NewDir()
        {

        }

        Regex g = new Regex(" +");
        void changePath(string dir)
        {
            var path = tb_path.Text;
            var fis = new List<FileItem>();

            if (host.Ipa == "127.0.0.1")
            {
                DirectoryInfo di = null;
                if (dir == "..")
                {
                    di = new DirectoryInfo(path).Parent;
                }
                else if (dir == ".")
                {
                    if (path != "") di = new DirectoryInfo(path);
                }
                else if (dir != "")
                {
                    di = new DirectoryInfo(path == "" ? dir : $"{path}/{dir}");
                }
                if (di == null)
                {
                    foreach (DriveInfo drive in DriveInfo.GetDrives())
                    {
                        fis.Add(new FileItem($"{drive.Name}", drive.TotalSize));
                    }
                    tb_path.Text = "";
                }
                else
                {
                    foreach (var d in di.GetDirectories())
                    {
                        fis.Add(new FileItem(d.Name, 0, d.LastWriteTime.ToString("yyyy-MM-dd HH:mm")));
                    }
                    foreach (var f in di.GetFiles())
                    {
                        fis.Add(new FileItem(f.Name, f.Length, f.LastWriteTime.ToString("yyyy-MM-dd HH:mm"), FileItemType.FILE));
                    }
                    tb_path.Text = di.FullName;
                }
            }
            else
            {
                if (dir == "..")
                {
                    path = path.Remove(path.LastIndexOf('/'));
                }
                else if (dir != ".")
                {
                    path += "/" + dir;
                }
                if (path == "")
                {
                    path = "/";
                }
                tb_path.Text = path == "/" ? "" : path;

                p = new Process();
                p.StartInfo.FileName = Application.StartupPath + "\\putty\\plink.exe";
                p.StartInfo.Arguments = $"-pw {Secret.RC4Decrypt(host.Pwd)} {host.Uin}@{host.Ipa} \"pwd \n cd {path} \n ls -l \n exit\"";
                p.StartInfo.CreateNoWindow = true;
                p.StartInfo.UseShellExecute = false;
                p.StartInfo.StandardOutputEncoding = Encoding.UTF8;
                p.StartInfo.RedirectStandardInput = true;
                p.StartInfo.RedirectStandardOutput = true;

                p.Start();
                var data = p.StandardOutput.ReadToEnd();
                p.WaitForExit();
                p.Dispose();

                foreach (var l in data.Split('\n'))
                {
                    var fi = new FileItem(g.Replace(l, "|"));
                    if (!string.IsNullOrEmpty(fi.Name))
                    {
                        fis.Add(fi);
                    }
                }
            }
            path = tb_path.Text;

            dgv_fs.Rows.Clear();
            fis.Sort((x, y) => (x.Type + x.Name).CompareTo(y.Type + y.Name));

            if (tb_path.Text != "")
                fis.Insert(0, new FileItem("..", 0));

            foreach (var f in fis)
            {
                var dr = new DataGridViewRow();
                dr.Tag = f;
                dr.CreateCells(dgv_fs, f.Name, f.SizeEx, f.Date, f.Type);
                dgv_fs.Rows.Add(dr);
            }

            Debug.WriteLine("changepath->" + path);
        }

        private void dgv_fs_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex < 0) return;

            var row = dgv_fs.SelectedRows[0];
            if (row.Cells[0].Value + "" == "..")
            {
                changePath("..");
            }
            else
            {
                if (row.Cells[3].Value + "" != FileItemType.DIR.ToString()) return;
                changePath(row.Cells[0].Value + "");
            }
        }

        private void dgv_fs_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex < 0) return;
            dgv_fs.Rows[e.RowIndex].Selected = true;
            FileItem = dgv_fs.Rows[e.RowIndex].Tag as FileItem;
        }

        private void cb_hosts_SelectedIndexChanged(object sender, EventArgs e)
        {
            host = cb_hosts.SelectedItem as HostInfo;
            changePath("");
        }

        private void dgv_fs_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex < 0) return;
            dgv_fs.Rows[e.RowIndex].Selected = true;
            FileItem = dgv_fs.Rows[e.RowIndex].Tag as FileItem;
        }

        private void comm_MouseDown(object sender, MouseEventArgs e)
        {
            OnFocused?.Invoke(this);
        }
    }
}

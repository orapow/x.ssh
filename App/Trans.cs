using NShell.Service;
using NShell.Tools;
using NShell.UserContorl;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace NShell
{
    public partial class Trans : Form
    {
        FileBrowser cufb;

        public Trans()
        {
            InitializeComponent();
            fb_left.OnFocused += Fb_OnFocused;
            fb_right.OnFocused += Fb_OnFocused;
        }

        private void Fb_OnFocused(UserContorl.FileBrowser fb)
        {
            cufb = fb;
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            var tns = Hosts.LoadHosts();
            var items = new List<HostInfo>() { new HostInfo() { Ipa = "127.0.0.1", Name = "本机" } };

            toList(tns, items);

            fb_left.SetHosts(items);
            fb_right.SetHosts(items);

            void toList(List<Tn> ts, List<HostInfo> list)
            {
                foreach (var t in ts)
                {
                    if (t.Type == TnType.Group)
                        toList(t.Child, list);
                    else
                        list.Add(t.Host);
                }
            }
        }

        private void P_OutputDataReceived(object sender, DataReceivedEventArgs e)
        {
            if (!string.IsNullOrEmpty(e.Data))
            {
                tssl_info.Text = e.Data;
            }
        }

        //private void tsmi_file_down_Click(object sender, EventArgs e)
        //{
        //    if (fb_right.host == null)
        //        return;

        //    if (fb_left.host == null)
        //        return;

        //    if (string.IsNullOrEmpty(fb_left.FullPath))
        //        return;

        //    if (string.IsNullOrEmpty(fb_right.FullPath))
        //        return;

        //    if (fb_left.host.Ipa == fb_right.host.Ipa)
        //        return;

        //    var p = new Process();
        //    p.StartInfo.UseShellExecute = false;
        //    p.StartInfo.CreateNoWindow = true;
        //    if (fb_left.host.Ipa == "127.0.0.1")
        //    {
        //        p.StartInfo.FileName = Application.StartupPath + "\\putty\\pscp";
        //        if (fb_left.FileItem.Type == FileItemType.DIR)
        //            p.StartInfo.Arguments = $"-r ";
        //        p.StartInfo.Arguments += $"-pw \"{Secret.RC4Decrypt(fb_right.host.Pwd)}\" {fb_left.FullPath.Trim('/') + "/" + fb_left.FileItem.Name} {fb_right.host.Uin}@{fb_right.host.Ipa}:{fb_right.FullPath}";
        //    }
        //    else if (fb_right.host.Ipa == "127.0.0.1")
        //    {
        //        p.StartInfo.FileName = Application.StartupPath + "\\putty\\pscp";
        //        if (fb_left.FileItem.Type == FileItemType.DIR)
        //        {
        //            p.StartInfo.Arguments = "-r ";
        //        }
        //        p.StartInfo.Arguments += $"-pw \"{Secret.RC4Decrypt(fb_left.host.Pwd)}\" {fb_left.host.Uin}@{fb_left.host.Ipa}:{fb_left.FullPath}";
        //        if (fb_left.FileItem.Text == "../")
        //        {
        //            p.StartInfo.Arguments += $"* {fb_right.FullPath.Trim('/')}/{fb_left.Name}";
        //        }
        //        else
        //        {
        //            p.StartInfo.Arguments += fb_left.FileItem.Name + $"/* {fb_right.FullPath.Trim('/')}/{fb_left.FileItem.Name}";
        //        }
        //    }
        //    else
        //    {
        //        p.StartInfo.FileName = Application.StartupPath + "\\plink";
        //    }
        //    p.StartInfo.RedirectStandardOutput = true;
        //    p.OutputDataReceived += P_OutputDataReceived;
        //    p.Start();
        //    p.BeginOutputReadLine();
        //    p.WaitForExit();
        //    p.Dispose();
        //    tssl_info.Text = "传输完成";
        //}

        //private void tsmi_trans_up_Click(object sender, EventArgs e)
        //{
        //    if (fb_right.host == null)
        //        return;

        //    if (fb_left.host == null)
        //        return;

        //    //地址一样走复制流程
        //    if (fb_left.host.Ipa == fb_right.host.Ipa)
        //        return;

        //    var p = new Process();
        //    p.StartInfo.UseShellExecute = false;
        //    p.StartInfo.CreateNoWindow = true;
        //    if (fb_left.host.Ipa == "127.0.0.1")
        //    {
        //        p.StartInfo.FileName = Application.StartupPath + "\\putty\\pscp";
        //        if (fb_left.FileItem.Type == FileItemType.DIR)
        //            p.StartInfo.Arguments = $"-r ";
        //        p.StartInfo.Arguments += $"-pw \"{Secret.RC4Decrypt(fb_right.host.Pwd)}\" {fb_left.FullPath.Trim('/') + "/" + fb_left.FileItem.Name} {fb_right.host.Uin}@{fb_right.host.Ipa}:{fb_right.FullPath}";
        //    }
        //    else if (fb_right.host.Ipa == "127.0.0.1")
        //    {
        //        p.StartInfo.FileName = Application.StartupPath + "\\putty\\pscp";
        //        if (fb_left.FileItem.Type == FileItemType.DIR)
        //        {
        //            p.StartInfo.Arguments = "-r ";
        //        }
        //        p.StartInfo.Arguments += $"-pw \"{Secret.RC4Decrypt(fb_left.host.Pwd)}\" {fb_left.host.Uin}@{fb_left.host.Ipa}:{fb_left.FullPath}";
        //        if (fb_left.FileItem.Text == "../")
        //        {
        //            p.StartInfo.Arguments += $"* {fb_right.FullPath.Trim('/')}/{fb_left.Name}";
        //        }
        //        else
        //        {
        //            p.StartInfo.Arguments += fb_left.FileItem.Name + $"/* {fb_right.FullPath.Trim('/')}/{fb_left.FileItem.Name}";
        //        }
        //    }
        //    else
        //    {
        //        p.StartInfo.FileName = Application.StartupPath + "\\plink";
        //    }
        //    p.StartInfo.RedirectStandardOutput = true;
        //    p.OutputDataReceived += P_OutputDataReceived;
        //    p.Start();
        //    p.BeginOutputReadLine();
        //    p.WaitForExit();
        //    p.Dispose();
        //    tssl_info.Text = "传输完成";
        //}

        private void tsmi_trans_Click(object sender, EventArgs e)
        {
            if (fb_right.host == null)
                return;

            if (fb_left.host == null)
                return;

            //地址一样走复制流程
            if (fb_left.host.Ipa == fb_right.host.Ipa)
                return;

            if (cufb.Name == "fb_left")
            {
                left2right();
                fb_right.Refresh();
            }
            else if (cufb.Name == "fb_right")
            {
                right2left();
                fb_left.Refresh();
            }

            void left2right()
            {
                var p = new Process();
                p.StartInfo.UseShellExecute = false;
                p.StartInfo.CreateNoWindow = true;

                //上传
                if (fb_left.host.Ipa == "127.0.0.1")
                {
                    p.StartInfo.FileName = Application.StartupPath + "\\putty\\pscp";
                    if (fb_left.FileItem.Type == FileItemType.DIR)
                        p.StartInfo.Arguments = $"-r ";
                    p.StartInfo.Arguments += $"-pw \"{Secret.RC4Decrypt(fb_right.host.Pwd)}\" {fb_left.FullPath.Trim('\\') + "\\" + fb_left.FileItem.Name} {fb_right.host.Uin}@{fb_right.host.Ipa}:{fb_right.FullPath}";
                }
                //上传
                else if (fb_right.host.Ipa == "127.0.0.1")
                {
                    p.StartInfo.FileName = Application.StartupPath + "\\putty\\pscp";
                    if (fb_left.FileItem.Type == FileItemType.DIR)
                    {
                        p.StartInfo.Arguments = "-r ";
                    }
                    p.StartInfo.Arguments += $"-pw \"{Secret.RC4Decrypt(fb_left.host.Pwd)}\" {fb_left.host.Uin}@{fb_left.host.Ipa}:{fb_left.FullPath}";
                    if (fb_left.FileItem.Text == "../")
                    {
                        p.StartInfo.Arguments += $"* ";
                    }
                    else
                    {
                        p.StartInfo.Arguments += "/" + fb_left.FileItem.Name + $"/* ";
                    }
                    p.StartInfo.Arguments += $"{fb_right.FullPath.Trim('/')}/{fb_left.FileItem.Name}";
                    if (fb_left.FileItem.Type == FileItemType.DIR)
                    {
                        Directory.CreateDirectory($"{fb_right.FullPath.Trim('\\')}\\{fb_left.FileItem.Name}");
                    }
                }

                p.StartInfo.RedirectStandardOutput = true;
                p.OutputDataReceived += P_OutputDataReceived;
                p.Start();
                p.BeginOutputReadLine();
                p.WaitForExit();
                p.Dispose();
                tssl_info.Text = "传输完成";
            }

            void right2left()
            {
                var p = new Process();
                p.StartInfo.UseShellExecute = false;
                p.StartInfo.CreateNoWindow = true;

                //下载
                if (fb_left.host.Ipa == "127.0.0.1")
                {
                    p.StartInfo.FileName = Application.StartupPath + "\\putty\\pscp";
                    if (fb_right.FileItem.Type == FileItemType.DIR)
                    {
                        p.StartInfo.Arguments = "-r ";
                    }
                    p.StartInfo.Arguments += $"-pw \"{Secret.RC4Decrypt(fb_right.host.Pwd)}\" {fb_right.host.Uin}@{fb_right.host.Ipa}:{fb_right.FullPath}";
                    if (fb_left.FileItem.Text == "../")
                    {
                        p.StartInfo.Arguments += $"* ";
                    }
                    else
                    {
                        p.StartInfo.Arguments += "/" + fb_right.FileItem.Name + $"/* ";
                    }
                    p.StartInfo.Arguments += $"{fb_left.FullPath.Trim('\\')}";
                    if (fb_right.FileItem.Type == FileItemType.DIR)
                    {
                        p.StartInfo.Arguments += $"\\{fb_right.FileItem.Name}";
                        Directory.CreateDirectory($"{fb_left.FullPath.Trim('\\')}\\{fb_right.FileItem.Name}");
                    }
                }
                //上传
                else if (fb_right.host.Ipa == "127.0.0.1")
                {
                    p.StartInfo.FileName = Application.StartupPath + "\\putty\\pscp";
                    if (fb_left.FileItem.Type == FileItemType.DIR)
                        p.StartInfo.Arguments = $"-r ";
                    p.StartInfo.Arguments += $"-pw \"{Secret.RC4Decrypt(fb_left.host.Pwd)}\" {fb_right.FullPath.Trim('\\') + "\\" + fb_right.FileItem.Name} {fb_left.host.Uin}@{fb_left.host.Ipa}:{fb_left.FullPath}";
                }
                p.StartInfo.RedirectStandardInput = true;
                p.StartInfo.RedirectStandardOutput = true;
                p.OutputDataReceived += P_OutputDataReceived;
                p.Start();
                p.BeginOutputReadLine();
                p.WaitForExit();
                p.Dispose();
                tssl_info.Text = "传输完成";
            }
        }

        private void tsmi_refresh_Click(object sender, EventArgs e)
        {
            cufb.Refresh();
        }

        private void tsmi_del_Click(object sender, EventArgs e)
        {
            cufb.Delete();
        }
    }
}

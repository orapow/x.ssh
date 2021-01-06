using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NShell
{
    public class HostInfo
    {
        /// <summary>
        /// 名称
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Ip地址或域名
        /// </summary>
        public string Ipa { get; set; }
        /// <summary>
        /// 端口
        /// </summary>
        public string Port { get; set; }
        /// <summary>
        /// 用户名
        /// </summary>
        public string Uin { get; set; }
        /// <summary>
        /// 密码
        /// </summary>
        public string Pwd { get; set; }
        /// <summary>
        /// 证书
        /// </summary>
        public string Cert { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }
}

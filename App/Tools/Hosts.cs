using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace NShell.Tools
{
    public class Hosts
    {
        public static List<Tn> LoadHosts()
        {
            if (!File.Exists(Application.StartupPath + "\\host.db")) return null;

            var str = File.ReadAllText(Application.StartupPath + "\\host.db");
            var tns = JsonConvert.DeserializeObject<List<Tn>>(Secret.RC4Decrypt(str));

            return tns;
        }

        public static void SaveHosts(List<Tn> tns)
        {
            var str = Secret.RC4Encrypt(JsonConvert.SerializeObject(tns));
            File.WriteAllText(Application.StartupPath + "\\host.db", str);
        }
    }
}

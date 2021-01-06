using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NShell
{
    public enum TnType
    {
        Group = 1,
        Host = 2
    }

    public class Tn
    {
        public string Name { get; set; }
        public HostInfo Host { get; set; }
        public TnType Type { get; set; }
        public List<Tn> Child { get; set; }

        public Tn()
        {
            Child = new List<Tn>();
        }
        public override string ToString()
        {
            return Name;
        }
    }
}

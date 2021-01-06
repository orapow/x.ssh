using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NShell.Entiry
{
    public class Layout
    {
        public List<HostInfo> Hosts { get; set; }

        public SpNode Node { get; set; }

        public class SpNode
        {
            public Layout Left { get; set; }
            public Layout Right { get; set; }

            public int Orientation { get; set; }
            public decimal SplitDist { get; set; }
        }
    }
}

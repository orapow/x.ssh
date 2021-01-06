using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NShell.Service
{
    public class EventBus
    {
        public delegate void OnHandler(string name, object[] parms);
        public static event OnHandler On;

        public static void Emit(string name, object[] parms = null)
        {
            On?.Invoke(name, parms);
        }
    }
}

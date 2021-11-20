using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AutoHitManager.Structure
{
    internal class HookFunctionAttribute : Attribute
    {
        public string Hook { get; set; }
        public Delegate Action { get; set; }
    }
}

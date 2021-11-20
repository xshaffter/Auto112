using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AutoHitManager.Structure
{
    internal class Boss
    {
        public string Name;
        public string Nickname;
        public bool Defeated;

        public override string ToString()
        {
            return $"'{Name}':{{nick:'{Nickname}', defeated:{Defeated.ToString().ToLower()}}}";
        }
    }
}

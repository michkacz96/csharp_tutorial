using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Warriors
{
    class CanTeleport : ITeleports
    {
        public string teleport()
        {
            return "Teleport away";
        }
    }
}

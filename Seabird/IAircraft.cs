using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seabird
{
    // ITarget interface
    public interface IAircraft
    {
        bool Airborne { get; }
        void TakeOff();
        int Height { get; }
    }
}

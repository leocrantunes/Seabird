﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seabird
{
    // Adaptee interface
    public interface ISeacraft
    {
        int Speed { get; }
        void IncreaseRevs();
    }
}

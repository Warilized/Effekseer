﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Effekseer.GUI
{
    interface IControl
    {
        void Update();
    }

    interface IRemovableControl : IControl
    {
        bool ShouldBeRemoved { get; }
    }
}

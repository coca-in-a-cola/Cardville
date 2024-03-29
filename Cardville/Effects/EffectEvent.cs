﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cardville.Effects
{
    public delegate void EffectEventHandler(object sender, EffectEventArgs e);
    public class EffectEventArgs : EventArgs
    {
        public Effect AppliedEffect { get; }

        public EffectEventArgs(Effect effect)
        {
            AppliedEffect = effect;
        }
    }
}

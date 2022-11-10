﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    public class PremiumRemote : BaseRemote
    {
        public PremiumRemote(IDevice device) : base(device)
        {
        }

        public override void TogglePower()
        {
            _device.SetPower(!_device.GetPower());
        }

        public override void VolumeDown()
        {
            _device.SetVolume(_device.GetVolume() - 1);
        }

        public override void VolumeUp()
        {
            _device.SetVolume(_device.GetVolume() + 1);
        }

        public void Mute()
        {
            _device.SetVolume(0);
        }
    }
}

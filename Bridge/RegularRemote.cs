using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    public class RegularRemote : BaseRemote
    {
        public RegularRemote(IDevice device) : base(device)
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
    }
}

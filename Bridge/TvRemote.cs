using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    public class TvRemote : Remote
    {
        public TvRemote()
        {
            _maxVolume = 10;
        }
        public override void TogglePower()
        {
            if (_isOn)
            {
                Console.WriteLine("TV turning off...");
            } else
            {
                Console.WriteLine("TV turning on...");
            }
            _isOn = !_isOn;
        }

        public override void VolumeDown()
        {
            if (_volume > 0)
                _volume--;
            PrintVolume();
        }

        public override void VolumeUp()
        {
            if (_volume < _maxVolume)
                _volume++;
            PrintVolume();
        }

        private void PrintVolume()
        {
            Console.WriteLine("TV Volume " + _volume);
        }
    }
}

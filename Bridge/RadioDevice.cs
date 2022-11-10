using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    public class RadioDevice : IDevice
    {
        protected const int _maxVolume = 5;
        public int Volume { get; set; } = 0;
        public bool Power { get; set; } = false;

        public bool GetPower()
        {
            return Power;
        }

        public int GetVolume()
        {
            return Volume;
        }

        public void SetPower(bool power)
        {
            Power = power;
            Console.WriteLine("Radio power: " + power);
        }

        public void SetVolume(int volume)
        {
            Volume = volume;
            Console.WriteLine("Radio volume: " + Volume);
        }
    }
}

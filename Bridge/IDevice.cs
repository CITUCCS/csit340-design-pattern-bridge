using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    public interface IDevice
    {
        void SetPower(bool power);
        bool GetPower();
        int GetVolume();
        void SetVolume(int volume);
    }
}

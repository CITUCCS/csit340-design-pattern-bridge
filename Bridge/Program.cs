// See https://aka.ms/new-console-template for more information
using Bridge;


IDevice tv = new TvDevice();
IDevice radio = new RadioDevice();

DoWork(new RegularRemote(tv));
DoWork(new RegularRemote(radio));


var pr = new PremiumRemote(tv);
pr.Mute();




void DoWork(BaseRemote remote)
{
    remote.TogglePower();
    remote.VolumeUp();
    remote.VolumeUp();
    remote.VolumeUp();
    remote.VolumeUp();
    remote.VolumeDown();
}

namespace Bridge
{
    public abstract class Remote
    {
        protected bool _isOn = false;
        protected int _volume = 0;
        protected int _maxVolume = 10;
        public abstract void TogglePower();
        public abstract void VolumeUp();
        public abstract void VolumeDown();
    }
}

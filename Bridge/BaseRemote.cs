namespace Bridge
{
    public abstract class BaseRemote
    {
        protected IDevice _device;

        protected BaseRemote(IDevice device)
        {
            _device = device;
        }

        public abstract void TogglePower();
        public abstract void VolumeUp();
        public abstract void VolumeDown();
    }
}

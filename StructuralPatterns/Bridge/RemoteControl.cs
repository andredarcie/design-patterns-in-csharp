public class RemoteControl
{
    protected IDevice device;

    public RemoteControl(IDevice device)
    {
        this.device = device;
    }

    public void TogglePower()
    {
        Console.WriteLine("Power toggle requested.");
        device.TurnOn();
    }

    public void SetChannel(int channel)
    {
        device.SetChannel(channel);
    }

    public void VolumeUp()
    {
        device.SetVolume(device.GetVolume() + 1);
    }

    public void VolumeDown()
    {
        device.SetVolume(device.GetVolume() - 1);
    }
}
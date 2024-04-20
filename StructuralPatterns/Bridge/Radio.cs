public class Radio : IDevice
{
    private bool isOn = false;
    private int volume = 5;
    private int channel = 1;

    public void TurnOn() => isOn = true;
    public void TurnOff() => isOn = false;
    public void SetChannel(int channel) => this.channel = channel;
    public int GetVolume() => volume;
    public void SetVolume(int volume) => this.volume = volume;
}
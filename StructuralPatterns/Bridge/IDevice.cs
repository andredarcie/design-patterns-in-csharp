public interface IDevice
{
    void TurnOn();
    void TurnOff();
    void SetChannel(int channel);
    int GetVolume();
    void SetVolume(int volume);
}
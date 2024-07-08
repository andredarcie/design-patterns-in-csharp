// Classe abstrata que define o Template Method e seus passos
abstract class DataProcessor
{
    // Template Method
    public void ProcessData()
    {
        ReadData();
        ProcessDataCore();
        WriteData();
    }

    // Passos comuns implementados na classe abstrata
    private void ReadData()
    {
        Console.WriteLine("Reading data...");
    }

    private void WriteData()
    {
        Console.WriteLine("Writing data...");
    }

    // Passo abstrato que será implementado pelas subclasses
    protected abstract void ProcessDataCore();
}
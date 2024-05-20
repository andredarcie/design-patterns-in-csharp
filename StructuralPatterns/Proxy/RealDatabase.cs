public class RealDatabase : IDatabase
{
    public void Query(string sql)
    {
        Console.WriteLine($"Executando query: {sql}");
    }
}
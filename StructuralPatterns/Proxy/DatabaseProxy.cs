public class DatabaseProxy : IDatabase
{
    private RealDatabase _realDatabase = new RealDatabase();
    private string _userRole;

    public DatabaseProxy(string userRole)
    {
        _userRole = userRole;
    }

    public void Query(string sql)
    {
        if (HasAccess())
        {
            _realDatabase.Query(sql);
        }
        else
        {
            Console.WriteLine("Acesso negado: você não tem permissão para executar esta query.");
        }
    }

    private bool HasAccess()
    {
        // Verifica se o usuário tem permissão para acessar o banco de dados
        return _userRole == "Admin";
    }
}
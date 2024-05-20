// Flyweight Factory: Garante que cada peça única (por cor e tipo) seja criada apenas uma vez.
class ChessPieceFactory
{
    private Dictionary<string, ChessPiece> pieces = new Dictionary<string, ChessPiece>();

    // Retorna uma instância de ChessPiece, criando-a se necessário
    public ChessPiece GetChessPiece(string color, string type)
    {
        string key = $"{color}_{type}";
        if (!pieces.ContainsKey(key))
        {
            pieces[key] = new ChessPiece(color, type);
        }
        return pieces[key];
    }
}
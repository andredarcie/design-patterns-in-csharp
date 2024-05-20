class ChessBoard
{
    private List<(int x, int y, ChessPiece piece)> positions = [];
    private readonly ChessPieceFactory factory = new();

    public void PlacePiece(int x, int y, string color, string type)
    {
        ChessPiece piece = factory.GetChessPiece(color, type);
        positions.Add((x, y, piece));
    }

    public void Display()
    {
        foreach (var position in positions)
        {
            position.piece.Display(position.x, position.y);
        }
    }
}

// Dados Intrínsecos: A classe ChessPiece representa os dados intrínsecos das peças de xadrez, 
// como a cor (Color) e o tipo (Type) da peça. Esses dados são constantes e podem ser compartilhados 
// entre múltiplas instâncias de peças.
class ChessPiece
{
    public string Color { get; private set; }
    public string Type { get; private set; }

    public ChessPiece(string color, string type)
    {
        Color = color;
        Type = type;
    }

    public void Display(int x, int y)
    {
        Console.WriteLine($"{Color} {Type} at position ({x}, {y})");
    }
}
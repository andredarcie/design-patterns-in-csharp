// Produto Livro
class Book : IProduct
{
    public int Units { get; }
    public Book(int units) => Units = units;
    public void Accept(IVisitor visitor) => visitor.Visit(this);
}
// Produto Eletrônico
class Electronic : IProduct
{
    public double Price { get; }
    public Electronic(double price) => Price = price;
    public void Accept(IVisitor visitor) => visitor.Visit(this);
}
// Produto Roupa
class Clothing : IProduct
{
    public double Weight { get; }
    public Clothing(double weight) => Weight = weight;
    public void Accept(IVisitor visitor) => visitor.Visit(this);
}
// Calculador de Custo de Envio
class ShippingCostCalculator : IVisitor
{
    public void Visit(Electronic electronic) => Console.WriteLine($"Shipping cost for electronic: ${electronic.Price * 0.05}");
    public void Visit(Clothing clothing) => Console.WriteLine($"Shipping cost for clothing: ${clothing.Weight * 2.0}");
    public void Visit(Book book) => Console.WriteLine($"Shipping cost for book: ${book.Units * 1.5}");
}
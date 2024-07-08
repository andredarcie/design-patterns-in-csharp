// Aplicador de Desconto
class DiscountApplier : IVisitor
{
    public void Visit(Electronic electronic) => Console.WriteLine($"Discount for electronic: ${electronic.Price * 0.10}");
    public void Visit(Clothing clothing) => Console.WriteLine($"Discount for clothing: $5.0");
    public void Visit(Book book) => Console.WriteLine($"Discount for book: ${book.Units * 0.50}");
}
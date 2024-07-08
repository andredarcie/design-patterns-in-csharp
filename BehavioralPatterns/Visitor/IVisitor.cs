// Interface Visitor
interface IVisitor
{
    void Visit(Electronic electronic);
    void Visit(Clothing clothing);
    void Visit(Book book);
}
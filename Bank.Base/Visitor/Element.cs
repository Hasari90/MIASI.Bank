namespace Bank.Base.Visitor
{
    public abstract class Element
    {
        public abstract void Accept(IVisitor visitor);
    }
}

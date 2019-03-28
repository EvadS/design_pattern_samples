namespace VisitorNet.baseImpl
{
    class ElementB : Element
    {
        public override void Accept(Visitor visitor)
        {
            visitor.VisitElementB(this);
        }
        public void OperationB()
        { }
    }
}
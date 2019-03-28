namespace VisitorNet.baseImpl
{
    class ElementA : Element
    {
        public override void Accept(Visitor visitor)
        {
            visitor.VisitElementA(this);
        }
        public void OperationA()
        {
            
        }
    }

}
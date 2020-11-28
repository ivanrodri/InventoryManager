using InventoryManager.Domain.Specification;
using System;
using System.Linq.Expressions;

namespace InventoryManager.Domain.Elements
{
    public class ElementByDeleteDateSpec : SpecificationBase<Element>
    {
        readonly DateTime? deleteDate;

        public ElementByDeleteDateSpec(DateTime? deleteDate)
        {
            this.deleteDate = deleteDate;
        }

        public override Expression<Func<Element, bool>> SpecExpression
        {
            get
            {
                return element => element.DeleteDate == this.deleteDate;
            }
        }
    }
}

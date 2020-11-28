using InventoryManager.Domain.Specification;
using System;
using System.Linq.Expressions;

namespace InventoryManager.Domain.Elements
{
    public class ElementFindByIdSpec : SpecificationBase<Element>
    {
        readonly Guid id;

        public ElementFindByIdSpec(Guid id)
        {
            this.id = id;
        }

        public override Expression<Func<Element, bool>> SpecExpression
        {
            get
            {
                return element => element.Id == this.id;
            }
        }
    }
}

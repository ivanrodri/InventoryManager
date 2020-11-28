using InventoryManager.Domain.Specification;
using System;
using System.Linq.Expressions;

namespace InventoryManager.Domain.Elements
{
    public class ElementFindByNameSpec : SpecificationBase<Element>
    {
        readonly string name;

        public ElementFindByNameSpec(string name)
        {
            this.name = name;
        }

        public override Expression<Func<Element, bool>> SpecExpression
        {
            get
            {
                return element => element.Name == this.name;
            }
        }
    }
}

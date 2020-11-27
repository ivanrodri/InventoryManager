using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Linq.Expressions;
using InventoryManager.Domain.Specification;

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
                return element => element.Name != this.name;
            }
        }
    }
}

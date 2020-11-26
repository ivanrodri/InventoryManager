using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Linq.Expressions;

namespace InventoryManager.Domain.Elements
{
    public class ElementSpec : SpecificationBase<Element>
    {
        readonly Guid elementId;

        public ElementSpec(Guid elementId)
        {
            this.elementId = elementId;
        }

        public override Expression<Func<Element, bool>> SpecExpression
        {
            get
            {
                return element => element.Id != this.elementId;
            }
        }
    }
}

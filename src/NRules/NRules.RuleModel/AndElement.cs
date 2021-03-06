using System.Collections.Generic;

namespace NRules.RuleModel
{
    /// <summary>
    /// Grouping element based on the logical AND condition.
    /// </summary>
    public class AndElement : GroupElement
    {
        internal AndElement(IEnumerable<Declaration> declarations, IEnumerable<RuleLeftElement> childElements)
            : base(declarations, childElements)
        {
        }

        internal override void Accept<TContext>(TContext context, RuleElementVisitor<TContext> visitor)
        {
            visitor.VisitAnd(context, this);
        }
    }
}
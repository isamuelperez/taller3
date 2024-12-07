using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using taller3.Contexto;

namespace taller3.Expressions
{
    internal class BinaryExpression : IExpression
    {
        private readonly IExpression _left;
        private readonly IExpression _right;
        private readonly Func<decimal, decimal, decimal> _operation;

        public BinaryExpression(IExpression left, IExpression right, Func<decimal, decimal, decimal> operation)
        {
            _left = left;
            _right = right;
            _operation = operation;
        }

        public decimal Interpret(ExpressionContext context)
        {
            decimal leftValue = _left.Interpret(context);
            decimal rightValue = _right.Interpret(context);
            return _operation(leftValue, rightValue);
        }
    }
}

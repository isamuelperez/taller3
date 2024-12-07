using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using taller3.Contexto;

namespace taller3.Expressions
{
    internal class ConstantExpression : IExpression
    {
        private readonly decimal _value;

        public ConstantExpression(decimal value)
        {
            _value = value;
        }

        public decimal Interpret(ExpressionContext context)
        {
            return _value;
        }
    }
}

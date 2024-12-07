using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using taller3.Contexto;

namespace taller3.Expressions
{
    internal class VariableExpression : IExpression
    {
        private readonly string _name;

        public VariableExpression(string name)
        {
            _name = name;
        }

        public decimal Interpret(ExpressionContext context)
        {
            return context.GetVariable(_name);
        }
    }
}

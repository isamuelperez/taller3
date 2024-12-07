using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using taller3.Contexto;

namespace taller3.Expressions
{
    internal interface IExpression
    {
        decimal Interpret(ExpressionContext context);
    }
}

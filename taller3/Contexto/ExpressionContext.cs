using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace taller3.Contexto
{
    internal class ExpressionContext
    {
        private readonly Dictionary<string, decimal> _variables = new Dictionary<string, decimal>();

        public void SetVariable(string name, decimal value)
        {
            _variables[name] = value;
        }

        public decimal GetVariable(string name)
        {
            if (_variables.TryGetValue(name, out decimal value))
            {
                return value;
            }
            throw new KeyNotFoundException($"Variable '{name}' no encontrada.");
        }
    }
}

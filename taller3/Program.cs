



// Expresion: (minutos_locales * 0.1) + (mensajes_internacionales * 0.2) * 0.9 * ve + -4
using taller3.Contexto;
using taller3.Expressions;


IExpression expression = new BinaryExpression(
           new BinaryExpression(
               new VariableExpression("minutos_locales"),
               new ConstantExpression(0.1m),
               (left, right) => left * right
           ),
           new BinaryExpression(
               new BinaryExpression(
                   new VariableExpression("mensajes_internacionales"),
                   new ConstantExpression(0.2m),
                   (left, right) => left * right
               ),

               new ConstantExpression(0.9m),
               (left, right) => left * right
           ),
           (left, right) => left + right
       );

// Contexto con datos del cliente
var context = new ExpressionContext();
context.SetVariable("minutos_locales", 100);
context.SetVariable("mensajes_internacionales", 50);

// Evaluación de la expresión
decimal totalCost = expression.Interpret(context);
Console.WriteLine($"El costo total del plan es: ${totalCost}");

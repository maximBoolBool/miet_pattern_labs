using System.Text.RegularExpressions;

namespace PatternsLab5.Expressions.Impl;

public class DashExpression : IExpression
{
    public string Interpret(Context context)
    {
        return context.Text.Replace("-", "—");
    }
}
using System.Text.RegularExpressions;

namespace PatternsLab5.Expressions.Impl;

public class WrongBreaksExpression : IExpression
{
    public string Interpret(Context context)
    {
        return Regex.Replace(context.Text, @"\n+", "\n");
    }
}
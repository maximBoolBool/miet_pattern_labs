using System.Text.RegularExpressions;

namespace PatternsLab5.Expressions.Impl;

public class MultipleSpacesExpression : IExpression
{
    public string Interpret(Context context)
    {
        return Regex.Replace(context.Text, @"\s+", " ");
    }
}
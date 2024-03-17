using System.Text.RegularExpressions;

namespace PatternsLab5.Expressions.Impl;

public class WrongSpacesExpression : IExpression
{
    public string Interpret(Context context)
    {
        return Regex.Replace(context.Text, @"(\s)\(|\)(\s)|(\s),|(\s)\.|\(\s|\s\)", "$1$2$3$4$5");
    }
}
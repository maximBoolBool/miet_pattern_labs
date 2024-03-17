namespace PatternsLab5.Expressions.Impl;

public class WrongQuotesExpression : IExpression
{
    public string Interpret(Context context)
    {
        return context.Text.Replace("\"","«").Replace("\"", "»");
    }
}
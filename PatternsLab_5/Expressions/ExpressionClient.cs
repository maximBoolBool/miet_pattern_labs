namespace PatternsLab5.Expressions;

public class ExpressionClient
{
    private readonly List<IExpression> _expressions;
    private readonly Context _context;
    
    public ExpressionClient(List<IExpression> expressions, Context context)
    {
        _expressions = expressions;
        _context = context;
    }

    public void ApplyRules()
    {
        foreach (var expression in _expressions)
        {
            var response = expression.Interpret(_context);
            _context.Text = response;
        }
    }

    public string GetResult() =>
        _context.Text;
}

using PatternsLab5;
using PatternsLab5.Expressions;
using PatternsLab5.Expressions.Impl;

string text = "Text   with   multiple  spaces, wrong dashes -, wrong quotes \"\",\twrong tabs and wrong   line   breaks.";

Console.WriteLine(text);


var expressions = new List<IExpression>()
{
    new DashExpression(),
    new MultipleSpacesExpression(),
    new WrongBreaksExpression(),
    new WrongQuotesExpression(),
    new WrongSpacesExpression(),
    new WrongTabsExpression()
};

var client = new ExpressionClient(expressions, new Context(){Text = text});

client.ApplyRules();
Console.WriteLine(client.GetResult());
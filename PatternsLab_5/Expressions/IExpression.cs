﻿namespace PatternsLab5.Expressions;

public interface IExpression
{
    string Interpret(Context context);
}
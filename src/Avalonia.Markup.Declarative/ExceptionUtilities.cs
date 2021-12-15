using System;
using System.Diagnostics;
using System.Linq.Expressions;
using System.Reflection;

namespace Avalonia.Markup.Declarative;

public static class ExceptionExtensions
{
    public static Exception SetStackTrace(this Exception target, StackTrace stack) => _SetStackTrace(target, stack);

    private static readonly Func<Exception, StackTrace, Exception> _SetStackTrace = new Func<Func<Exception, StackTrace, Exception>>(() =>
    {
        ParameterExpression target = Expression.Parameter(typeof(Exception));
        ParameterExpression stack = Expression.Parameter(typeof(StackTrace));
        Type traceFormatType = typeof(StackTrace).GetNestedType("TraceFormat", BindingFlags.NonPublic);
        MethodInfo toString = typeof(StackTrace).GetMethod("ToString", BindingFlags.NonPublic | BindingFlags.Instance, null, new[] { traceFormatType }, null);
        object normalTraceFormat = Enum.GetValues(traceFormatType).GetValue(0);
        MethodCallExpression stackTraceString = Expression.Call(stack, toString, Expression.Constant(normalTraceFormat, traceFormatType));
        FieldInfo stackTraceStringField = typeof(Exception).GetField("_stackTraceString", BindingFlags.NonPublic | BindingFlags.Instance);
        BinaryExpression assign = Expression.Assign(Expression.Field(target, stackTraceStringField), stackTraceString);
        return Expression.Lambda<Func<Exception, StackTrace, Exception>>(Expression.Block(assign, target), target, stack).Compile();
    })();
}
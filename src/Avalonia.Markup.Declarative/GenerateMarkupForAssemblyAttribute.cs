using System;

namespace Avalonia.Markup.Declarative
{
    [AttributeUsage(AttributeTargets.Assembly, AllowMultiple = true)]
    public class GenerateMarkupForAssemblyAttribute : Attribute
    {
        public GenerateMarkupForAssemblyAttribute(Type referenceType)
        {
        }
    }
}

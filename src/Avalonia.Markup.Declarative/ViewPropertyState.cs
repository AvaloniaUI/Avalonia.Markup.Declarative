using System;
using System.Reflection;

namespace Avalonia.Markup.Declarative
{
    internal class ViewPropertyState
    {
        public object Value { get; private set; }

        public string Name { get; }
        private PropertyInfo PropertyInfo { get; }
        private ViewBase View { get; }

        public ViewPropertyState(PropertyInfo propertyInfo, ViewBase view)
        {
            this.PropertyInfo = propertyInfo;
            this.View = view;

            this.Name = propertyInfo.Name;

            Value = PropertyInfo.GetValue(View);
        }

        public bool CheckStateChangedAndUpdate()
        {
            var oldValue = Value;
            Value = PropertyInfo.GetValue(View);

            if (Value == null && oldValue != null)
                return false;

            if (Value != null && oldValue == null)
                return false;

            return
                (Value == null && oldValue == null)
                || (Value != null && !Value.Equals(oldValue));
        }
    }
}
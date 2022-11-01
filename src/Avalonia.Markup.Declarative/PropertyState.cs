using System;
using System.Reflection;

namespace Avalonia.Markup.Declarative
{
    internal class ViewPropertyState
    {
        private object _value;

        public string Name { get; }
        private PropertyInfo PropertyInfo { get; }
        private ViewBase View { get; }

        public ViewPropertyState(PropertyInfo propertyInfo, ViewBase view)
        {
            this.PropertyInfo = propertyInfo;
            this.View = view;

            this.Name = propertyInfo.Name;

            _value = PropertyInfo.GetValue(View);
        }

        public bool CheckStateChangedAndUpdate()
        {
            var oldValue = _value;
            _value = PropertyInfo.GetValue(View);

            if (_value == null && oldValue != null)
                return false;

            if (_value != null && oldValue == null)
                return false;

            return
                (_value == null && oldValue == null)
                || (_value != null && !_value.Equals(oldValue));
        }
    }
}
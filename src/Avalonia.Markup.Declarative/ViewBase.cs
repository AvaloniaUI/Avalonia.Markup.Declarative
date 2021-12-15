using System;
using System.Diagnostics;
using System.Linq.Expressions;
using Avalonia;
using Avalonia.Controls;
using Avalonia.Data;
using Avalonia.Threading;

namespace Avalonia.Markup.Declarative
{
    public abstract class ViewBase<TViewModel> : ViewBase
        where TViewModel : class
    {
        public virtual TViewModel ViewModel
        {
            get => DataContext as TViewModel;
            set => DataContext = value;
        }

        protected Binding Bind<TProp>(Expression<Func<TViewModel, TProp>> propertyGetterExp, BindingMode bindingMode = BindingMode.Default)
        {
            return Bind(ViewModel, propertyGetterExp, bindingMode);
        }
    }

    public abstract class ViewBase : Decorator, IReloadable
    {
        public event Action ViewInitialized; 

        protected abstract object Build();

        protected ViewBase()
        {
            OnCreatedCore();
            Initialize();
        }

        protected virtual void OnAfterInitialized()
        {
        }

        protected override void OnAttachedToVisualTree(VisualTreeAttachmentEventArgs e)
        {
            base.OnAttachedToVisualTree(e);
#if DEBUG
            SharpViewsHotReloadManager.RegisterInstance(this);
#endif
        }

        protected override void OnDetachedFromVisualTree(VisualTreeAttachmentEventArgs e)
        {
            base.OnDetachedFromVisualTree(e);
#if DEBUG
            SharpViewsHotReloadManager.UnregisterInstance(this);
#endif
        }

        private void OnCreatedCore()
        {
            OnCreated();
        }

        protected virtual void OnCreated()
        {
        }

        public void Reload()
        {
            Dispatcher.UIThread.InvokeAsync(() =>
            {
                Child = null;
                VisualChildren.Clear();

                OnCreatedCore();
                Initialize();

                InvalidateArrange();
                InvalidateMeasure();
                InvalidateVisual();
            });
        }


        public void Initialize()
        {
            try
            {
                var content = Build();
                Child = content as Control;

                ViewInitialized?.Invoke();
                OnAfterInitialized();
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
                Debug.WriteLine(ex.StackTrace);
                throw;
            }
        }

        public static T GetResource<T>(string key)
        {
            if (Application.Current.Resources.TryGetResource(key, out var res))
            {
                if (res is T tres)
                    return tres;
            }
            return default;
        }

        protected TControl Create<TControl>(Action<TControl> initializer)
            where TControl : Control, new()

        {
            var control = new TControl();
            initializer?.Invoke(control);
            return control;
        }

        protected static Binding Bind<T, TProp>(T source, Expression<Func<T, TProp>> propertyGetterExp, BindingMode bindingMode = BindingMode.Default)
        {
            if (propertyGetterExp.Body is MemberExpression propertyGetter)
            {
                return new Binding()
                {
                    Source = source,
                    Path = propertyGetter.Member.Name,
                    Mode = bindingMode,
                };
            }

            throw new MemberAccessException("Wrong property getter expression");
        }

        protected Binding Bind(AvaloniaProperty property, BindingMode bindingMode = BindingMode.Default)
        {
            return new Binding()
            {
                Source = this,
                Path = property.Name,
                Mode = bindingMode
            };
        }


    }
}
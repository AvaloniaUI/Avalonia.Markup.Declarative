public static class EventsExtensions
{
    public static IObservable<RoutedEventArgs> OnClick(this Button button)
    {
        return Observable.FromEventPattern<EventHandler<RoutedEventArgs>, RoutedEventArgs>(h => button.Click += h, h => button.Click -= h).Select(x => x.EventArgs);
    }
}
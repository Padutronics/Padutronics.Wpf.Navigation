using System;

namespace Padutronics.Wpf.Navigation;

public interface INavigator
{
    event EventHandler<NavigationTargetEventArgs>? NavigationRequested;

    void Navigate(NavigationTargetName target);
}
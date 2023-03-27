using System;

namespace Padutronics.Wpf.Navigation;

public sealed class Navigator : INavigator
{
    private NavigationTargetName? currentTarget;

    public event EventHandler<NavigationTargetEventArgs>? NavigationRequested;

    public void Navigate(NavigationTargetName  target)
    {
        if (currentTarget != target)
        {
            currentTarget = target;

            OnNavigationRequested(new NavigationTargetEventArgs(target));
        }
    }

    private void OnNavigationRequested(NavigationTargetEventArgs e)
    {
        NavigationRequested?.Invoke(this, e);
    }
}
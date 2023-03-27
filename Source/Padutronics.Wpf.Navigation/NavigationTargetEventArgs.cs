using System;

namespace Padutronics.Wpf.Navigation;

public sealed class NavigationTargetEventArgs : EventArgs
{
    public NavigationTargetEventArgs(NavigationTargetName target)
    {
        Target = target;
    }

    public NavigationTargetName Target { get; }
}
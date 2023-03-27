using Padutronics.Diagnostics.Debugging;
using Padutronics.Extensions.System;
using System;
using System.Diagnostics;

namespace Padutronics.Wpf.Navigation;

[DebuggerDisplay(DebuggerDisplayValues.ToStringWithQuotes)]
public sealed class NavigationTargetName : IEquatable<NavigationTargetName>
{
    private readonly string value;

    public NavigationTargetName(string value)
    {
        if (value.IsEmpty())
        {
            throw new ArgumentException("Navigation target name cannot be empty.");
        }

        this.value = value;
    }

    public override bool Equals(object? obj)
    {
        return Equals(obj as NavigationTargetName);
    }

    public bool Equals(NavigationTargetName? other)
    {
        return other is not null && value == other.value;
    }

    public override int GetHashCode()
    {
        return HashCode.Combine(value);
    }

    public override string ToString()
    {
        return value.ToString();
    }

    public static bool operator ==(NavigationTargetName? left, NavigationTargetName? right)
    {
        return left?.Equals(right) ?? right is null;
    }

    public static bool operator !=(NavigationTargetName? left, NavigationTargetName? right)
    {
        return !(left == right);
    }
}
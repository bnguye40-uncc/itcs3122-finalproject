// Credit to Kebechet: https://stackoverflow.com/a/76654797

namespace FinalProject.Shared;

public static class StateContainerExtensions
{
    public static int AddRoutingObjectParameter(this StateContainer stateContainer, object value)
    {
        stateContainer.ObjectTunnel[value.GetHashCode()] = value;
        return value.GetHashCode();
    }

    public static T GetRoutingObjectParameter<T>(this StateContainer stateContainer, int hashCode)
    {
        return (T) stateContainer.ObjectTunnel[hashCode];
    }
}
// Credit to Kebechet: https://stackoverflow.com/a/76654797

namespace FinalProject.Shared;

public class StateContainer
{
    public readonly Dictionary<int, object> ObjectTunnel = new();
}
// Credit to Kebechet: https://stackoverflow.com/a/76654797

namespace FinalProject.Shared;

public class StateContainer
{
    public readonly Dictionary<int, object> ObjectTunnel = new();
    
    private string? savedString;

    public string Property
    {
        get => savedString ?? string.Empty;
        set
        {
            savedString = value;
            NotifyStateChanged();
        }
    }

    public event Action? OnChange;

    private void NotifyStateChanged() => OnChange?.Invoke();
}
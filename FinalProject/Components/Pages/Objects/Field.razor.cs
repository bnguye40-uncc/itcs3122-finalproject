using Microsoft.AspNetCore.Components;

namespace FinalProject.Components.Pages.Objects;

[Serializable]
public partial class Field : ComponentBase
{
    [Parameter] public string Class { get; set; } = "";
    [Parameter] public string Name { get; set; } = "Default Field";
    [Parameter] public string Value { get; set; } = "Lorem ipsum dolor sit amet, consectetur adipiscing elit.";
    [Parameter] public string Placeholder { get; set; } = "Write your text here...";

    private string showDisplay = "";
    private string showEditing = "hidden";
    public string newValue = "";
    public string newName = "";

    protected override void OnInitialized()
    {
        newValue = Value;
        newName = Name;
    }

    private void ToggleEditMode() {
        showDisplay = showDisplay == string.Empty ? "hidden" : "";
        showEditing = showEditing == string.Empty ? "hidden" : "";
    }

    private async Task SetValue() {
        if ((newName != string.Empty) && (Class == "custom-field")) { Name = newName; }
        if (newValue != string.Empty) { Value = newValue; }
        ToggleEditMode();

        await NameChanged.InvokeAsync(Name);
        await ValueChanged.InvokeAsync(Value);
    }

    private void CancelEdit() {
        newName = Name;
        newValue = Value;
        ToggleEditMode();
    }

    // Two-way binding
    [Parameter] public EventCallback<string> NameChanged { get; set; }
    [Parameter] public EventCallback<string> ValueChanged { get; set; }
}
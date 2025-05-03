using Microsoft.AspNetCore.Components;

namespace FinalProject.Components.Pages.Objects;

[Serializable]
public abstract class AbstractFolderItem : ComponentBase {
    // Virtual parameters
    [Parameter] public virtual string Class { get; set; } = "";
    [Parameter] public virtual string Name { get; set; } = "";
    [Parameter] public virtual bool IsSelected { get; set; }
    [Parameter] public virtual bool IsFolder { get; set; } 

    // Abstract variables
    public virtual string showDisplay { get; set; } = "";
    public virtual string showEditing { get; set; } = "hidden";
    public virtual string newName { get; set; } = "";

    public virtual void ToggleEditMode() {
        showDisplay = showDisplay == string.Empty ? "hidden" : "";
        showEditing = showEditing == string.Empty ? "hidden" : "";
    }

    public async virtual void SetValue() {
        if (newName != string.Empty) { Name = newName; }
        else { Name = "Untitled"; }
        ToggleEditMode();
        await NameChanged.InvokeAsync(Name);
    }

    // Two-way binding
    [Parameter] public virtual EventCallback<string> NameChanged { get; set; }
}
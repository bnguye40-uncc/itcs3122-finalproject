using Microsoft.AspNetCore.Components;
using System.Text.Json.Serialization;
using System.Text.Json;
using FinalProject.Layout;

namespace FinalProject.Components.Pages.Objects;

[Serializable]
[JsonPolymorphic(TypeDiscriminatorPropertyName = "type")]
[JsonDerivedType(typeof(Folder), "folder")]
[JsonDerivedType(typeof(Bookmark), "bookmark")]
public abstract class AbstractFolderItem : ComponentBase {
    // Cascading Parameters
    [CascadingParameter] public virtual MainLayout _MainLayout { get; set; }

    // Virtual parameters
    [Parameter] public virtual string Class { get; set; } = "";
    [Parameter] public virtual string Name { get; set; } = "";

    // Virtual variables
    public virtual string showDisplay { get; set; } = "";
    public virtual string showEditing { get; set; } = "hidden";
    public virtual string newName { get; set; } = "";

    // Virtual component functions
    protected override void OnInitialized() {
        newName = Name;
    }

    public virtual void ToggleEditMode() {
        showDisplay = showDisplay == string.Empty ? "hidden" : "";
        showEditing = showEditing == string.Empty ? "hidden" : "";
    }

    public async virtual void SetValue() {
        if (newName != string.Empty) { Name = newName; }
        else { Name = "Untitled"; }
        ToggleEditMode();
        await NameChanged.InvokeAsync(Name);
        _MainLayout.UpdateLocalStorage();
    }

    public virtual bool IsFolder() {
        if ( Class == "folder" ) { return true; }
        else { return false; }
    }

    // Two-way binding
    [Parameter] public virtual EventCallback<string> NameChanged { get; set; }
}
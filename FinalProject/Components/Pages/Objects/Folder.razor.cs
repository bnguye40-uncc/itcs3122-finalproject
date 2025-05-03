using Microsoft.AspNetCore.Components;

namespace FinalProject.Components.Pages.Objects;

[Serializable]
public partial class Folder : AbstractFolderItem
{
    // Parameters
    [Parameter] public override string Class { get; set; } = "";
    [Parameter] public override string Name { get; set; } = "Default Folder";
    [Parameter] public List<AbstractFolderItem> Items { get; set; } = new List<AbstractFolderItem>();
    [Parameter] public override bool IsSelected { get; set; } = false;
    public override bool IsFolder { get; set; } = true;

    // Variables
    private string showDisplay = "";
    private string showEditing = "hidden";
    private string newName = "";
    private string expandFolder = "";
    private bool isExpanded = true;

    protected override void OnInitialized()
    {
        newName = Name;
    }

    private void Expand() {
        if (Class == "root") { return; }
        isExpanded = !isExpanded;
        expandFolder = isExpanded ? "" : "hidden";
    }

    private void AddBookmark() {
        Items.Add(new Bookmark());
    }

    private void AddFolder() {
        Items.Add(new Folder());
    }

    private void ToggleEditMode() {
        showDisplay = showDisplay == string.Empty ? "hidden" : "";
        showEditing = showEditing == string.Empty ? "hidden" : "";
    }

    private void SetValue() {
        if (newName != string.Empty) { Name = newName; }
        else { Name = "Untitled"; }
        ToggleEditMode();
    }

    private void DeleteItem(int index) {
        Items.RemoveAt(index);
    }
}
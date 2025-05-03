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
    private string expandFolder = "";
    private bool isExpanded = true;

    // Component functions
    protected override void OnInitialized() { newName = Name; }

    private void AddBookmark() { Items.Add(new Bookmark()); }

    private void AddFolder() { Items.Add(new Folder()); }

    private void Expand() {
        if (Class == "root") { return; }
        isExpanded = !isExpanded;
        expandFolder = isExpanded ? "" : "hidden";
    }

    private async void DeleteItem(int index) {
        Items.Remove(Items[index]);
        await ItemsChanged.InvokeAsync(Items);
    }

    // Two-way binding
    [Parameter] public virtual EventCallback<List<AbstractFolderItem>> ItemsChanged { get; set; }
}
using Microsoft.AspNetCore.Components;
using FinalProject.Layout;

namespace FinalProject.Components.Pages.Objects;

[Serializable]
public partial class Folder : AbstractFolderItem
{
    // Cascading Parameters
    [CascadingParameter] public MainLayout _Parent { get; set; }
    
    // Parameters
    [Parameter] public override string Class { get; set; } = "folder";
    [Parameter] public override string Name { get; set; } = "Default Folder";
    [Parameter] public List<AbstractFolderItem> Items { get; set; } = new List<AbstractFolderItem>();
    [Parameter] public override bool IsSelected { get; set; } = false;
    public override bool IsFolder { get; set; } = true;

    // Variables
    private string expandFolder = "";
    private bool isExpanded = true;

    // Component functions
    private void AddBookmark() {
        Items.Add(new Bookmark());
        _Parent.RefreshState();
    }

    private void AddFolder() {
        Items.Add(new Folder());
        _Parent.RefreshState();
    }

    private void Expand() {
        if (Class == "root") { return; }
        isExpanded = !isExpanded;
        expandFolder = isExpanded ? "" : "hidden";
    }

    private async void DeleteItem(int index) {
        Items.Remove(Items[index]);
        await ItemsChanged.InvokeAsync(Items);
        _Parent.RefreshState();
    }

    // Two-way binding
    [Parameter] public virtual EventCallback<List<AbstractFolderItem>> ItemsChanged { get; set; }
}
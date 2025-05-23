using Microsoft.AspNetCore.Components;
using FinalProject.Layout;

namespace FinalProject.Components.Pages.Objects;

[Serializable]
public partial class Folder : AbstractFolderItem
{
    // Parameters
    [Parameter] public override string Class { get; set; } = "folder";
    [Parameter] public override string Name { get; set; } = "Default Folder";
    [Parameter] public List<AbstractFolderItem> Items { get; set; } = new List<AbstractFolderItem>();

    // Variables
    private string expandFolder = "";
    private bool isExpanded = true;

    // Component functions
    private void AddBookmark() {
        Items.Add(new BookmarkFolderItem());
        _MainLayout.UpdateLocalStorage();
    }

    private void AddFolder() {
        Items.Add(new Folder());
        _MainLayout.UpdateLocalStorage();
    }

    private void Expand() {
        if (Class == "root folder") { return; }
        isExpanded = !isExpanded;
        expandFolder = isExpanded ? "" : "hidden";
    }

    private async void DeleteItem(int index) {
        Items.Remove(Items[index]);
        await ItemsChanged.InvokeAsync(Items);
        _MainLayout.UpdateLocalStorage();
    }

    // Two-way binding
    [Parameter] public EventCallback<List<AbstractFolderItem>> ItemsChanged { get; set; }
}
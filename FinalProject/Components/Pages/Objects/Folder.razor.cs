using Microsoft.AspNetCore.Components;

namespace FinalProject.Components.Pages.Objects;

public partial class Folder : ComponentBase, IFolderItem
{
    [Parameter]
    public string Name { get; set; } = "Default Folder";
    [Parameter]
    public string Description { get; set; } = "Lorem ipsum dolor sit amet, consectetur adipiscing elit.";
    public List<IFolderItem> Items { get; set; } = new List<IFolderItem>();
    public bool IsCollapsed { get; set; } = false;
}
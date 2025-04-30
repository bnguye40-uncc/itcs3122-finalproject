using Microsoft.AspNetCore.Components;

namespace FinalProject.Components.Pages.Objects;

public partial class Folder : ComponentBase, IFolderItem
{
    [Parameter]
    public string Class { get; set; } = "";
    [Parameter]
    public string Name { get; set; } = "Default Folder";
    [Parameter]
    public string Description { get; set; } = "Lorem ipsum dolor sit amet, consectetur adipiscing elit.";
    [Parameter]
    public List<IFolderItem> Items { get; set; } = new List<IFolderItem>();
    public bool isExpanded { get; set; } = false;
    public bool IsFolder { get; } = true;
}
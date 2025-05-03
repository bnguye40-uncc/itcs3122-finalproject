using Microsoft.AspNetCore.Components;

namespace FinalProject.Components.Pages.Objects;

[Serializable]
public partial class Folder : AbstractFolderItem
{
    [Parameter]
    public override string Class { get; set; } = "";
    [Parameter]
    public override string Name { get; set; } = "Default Folder";
    [Parameter]
    public List<AbstractFolderItem> Items { get; set; } = new List<AbstractFolderItem>();
    [Parameter]
    public override bool IsSelected { get; set; } = false;
    public override bool IsFolder { get; set; } = true;
}
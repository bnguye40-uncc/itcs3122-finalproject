using Microsoft.AspNetCore.Components;

namespace FinalProject.Components.Pages.Objects;

public partial class Folder : ComponentBase
{
    public string Name { get; set; } = "";
    public string Description { get; set; } = "";
    public List<ComponentBase> Items { get; set; } = [];
    public bool IsCollapsed { get; set; } = false;
}
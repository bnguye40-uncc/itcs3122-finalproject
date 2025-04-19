using Microsoft.AspNetCore.Components;

namespace FinalProject.Components.Pages.Objects;

public partial class Folder : ComponentBase
{
    public string name { get; set; } = "";
    public string description { get; set; } = "";
    public ComponentBase[] items { get; set; } = [];
    public bool isCollapsed { get; set; } = false;
}
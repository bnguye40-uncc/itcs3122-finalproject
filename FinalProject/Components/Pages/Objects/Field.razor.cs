using Microsoft.AspNetCore.Components;

namespace FinalProject.Components.Pages.Objects;

public partial class Field : ComponentBase
{
    [Parameter]
    public string Name { get; set; } = "Default Field";
    [Parameter]
    public string Text { get; set; } = "Lorem ipsum dolor sit amet, consectetur adipiscing elit.";
    [Parameter]
    public string Placeholder { get; set; } = "Placeholder...";
}
using Microsoft.AspNetCore.Components;

namespace FinalProject.Components.Pages.Objects;

public partial class Field : ComponentBase
{
    public string Name { get; set; } = "Default Field";
    public string Text { get; set; } = "Lorem ipsum dolor sit amet, consectetur adipiscing elit.";
    public string Placeholder { get; set; } = "Placeholder...";
}
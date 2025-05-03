using Microsoft.AspNetCore.Components;

namespace FinalProject.Components.Pages.Objects;

[Serializable]
public partial class Field : ComponentBase
{
    [Parameter]
    public int Index { get; set; } = -1;
    [Parameter]
    public string Class { get; set; } = "";
    [Parameter]
    public string Name { get; set; } = "Default Field";
    [Parameter]
    public string Value { get; set; } = "Lorem ipsum dolor sit amet, consectetur adipiscing elit.";
    [Parameter]
    public string Placeholder { get; set; } = "Write your text here...";
}
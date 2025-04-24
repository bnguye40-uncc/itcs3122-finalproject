using Microsoft.AspNetCore.Components;

namespace FinalProject.Components.Pages.Objects;

public partial class Template : ComponentBase
{
    [Parameter]
    public string Name { get; set; } = "Default Template";
    [Parameter]
    public string Description { get; set; } = "Lorem ipsum dolor sit amet, consectetur adipiscing elit.";
    [Parameter]
    public List<Field> TemplateFieldsArray { get; set; } = [];
}
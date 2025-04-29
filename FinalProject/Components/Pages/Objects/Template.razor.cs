using Microsoft.AspNetCore.Components;

namespace FinalProject.Components.Pages.Objects;

public partial class Template : ComponentBase
{
    [Parameter]
    public string Name { get; set; } = "Default Template";
    [Parameter]
    public string Description { get; set; } = "Lorem ipsum dolor sit amet, consectetur adipiscing elit.";
    [Parameter]
    public string[] TemplateTags { get; set; } = ["tag1", "tag2", "tag3"];
    [Parameter]
    public List<Field> TemplateFields { get; set; } = [];
}
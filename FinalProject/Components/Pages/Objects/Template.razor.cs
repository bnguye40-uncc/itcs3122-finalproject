using Microsoft.AspNetCore.Components;

namespace FinalProject.Components.Pages.Objects;

public partial class Template : ComponentBase
{
    public string Name { get; set; } = "Default Template";
    public string Description { get; set; } = "Lorem ipsum dolor sit amet, consectetur adipiscing elit.";
    public List<Field> TemplateFieldsArray { get; set; } = [];
}
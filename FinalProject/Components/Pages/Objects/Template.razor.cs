using Microsoft.AspNetCore.Components;

namespace FinalProject.Components.Pages.Objects;

public partial class Template : ComponentBase
{
    public string name { get; set; } = "";
    public string description { get; set; } = "";
    public List<Field> customFieldsArray { get; set; } = [];
}
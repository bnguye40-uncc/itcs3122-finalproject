using Microsoft.AspNetCore.Components;

namespace FinalProject.Components.Pages.Objects;

public partial class Bookmark : ComponentBase
{
    public string name { get; set; } = "";
    public string description { get; set; } = "";
    public string url { get; set; } = "";
    public string[] tags { get; set; } = [];
    public string keyword { get; set; } = "";
    public Template customTemplate { get; set; } = new Template();
    public List<Field> customFieldsArray { get; set; } = [];
}
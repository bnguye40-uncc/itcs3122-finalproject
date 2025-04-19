using Microsoft.AspNetCore.Components;

namespace FinalProject.Components.Pages.Objects;

public partial class Field : ComponentBase
{
    public string name { get; set; } = "";
    public string text { get; set; } = "";
    public string place { get; set; } = "";
}
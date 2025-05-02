using Microsoft.AspNetCore.Components;

namespace FinalProject.Components.Pages.Objects;

[Serializable]
public abstract class AbstractFolderItem : ComponentBase {
    [Parameter]
    public abstract string Class { get; set; }
    [Parameter]
    public abstract string Name { get; set; }
    [Parameter]
    public abstract string Description { get; set; }
    [Parameter]
    public abstract bool IsSelected { get; set; }
    [Parameter]
    public abstract bool IsFolder { get; set; } 
}
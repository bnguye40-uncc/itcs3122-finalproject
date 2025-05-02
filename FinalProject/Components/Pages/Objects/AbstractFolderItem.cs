using Microsoft.AspNetCore.Components;

namespace FinalProject.Components.Pages.Objects;

[Serializable]
public abstract class AbstractFolderItem : ComponentBase {
    [Parameter]
    public virtual string Class { get; set; } = "";
    [Parameter]
    public virtual string Name { get; set; } = "";
    [Parameter]
    public virtual string Description { get; set; } = "";
    [Parameter]
    public virtual bool IsSelected { get; set; }
    [Parameter]
    public virtual bool IsFolder { get; set; } 
}
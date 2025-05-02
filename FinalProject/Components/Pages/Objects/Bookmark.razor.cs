using Microsoft.AspNetCore.Components;

namespace FinalProject.Components.Pages.Objects;

public partial class Bookmark : ComponentBase, IFolderItem
{
    [Parameter]
    public string Class { get; set; } = "bookmark";
    [Parameter]
    public string Name { get; set; } = "Default";
    [Parameter]
    public string Description { get; set; } = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Aenean imperdiet quam at sem semper ultricies. Nunc orci justo, blandit non arcu at, auctor feugiat neque. Nunc vel dapibus leo, eget porttitor leo.";
    [Parameter]
    public string URL { get; set; } = "https://docs.microsoft.com/aspnet/";
    // [Parameter]
    // public string[] Tags { get; set; } = ["tag1", "tag2", "tag3"];       Implementation WIP
    [Parameter]
    public string Keyword { get; set; } = "keyword";
    [Parameter]
    public Template CustomTemplate { get; set; } = new Template();
    [Parameter]
    public List<Field> CustomFields { get; set; } = new List<Field> { new Field(), new Field() };
    [Parameter]
    public bool IsSelected { get; set; } = false;
    [Parameter]
    public bool DisplayAsFolderItem { get; set; } = false;
    public bool IsFolder { get; } = false;
}
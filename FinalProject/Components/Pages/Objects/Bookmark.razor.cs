using Microsoft.AspNetCore.Components;

namespace FinalProject.Components.Pages.Objects;

public partial class Bookmark : ComponentBase
{
    public string Name { get; set; } = "Default";
    public string Description { get; set; } = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Aenean imperdiet quam at sem semper ultricies. Nunc orci justo, blandit non arcu at, auctor feugiat neque. Nunc vel dapibus leo, eget porttitor leo.";
    public string URL { get; set; } = "https://docs.microsoft.com/aspnet/";
    public string[] Tags { get; set; } = ["tag1", "tag2", "tag3"];
    public string Keyword { get; set; } = "keyword";
    public Template CustomTemplate { get; set; } = new Template();
    public List<Field> CustomFieldsArray { get; set; } = new List<Field> { new Field(), new Field() };
}
using Microsoft.AspNetCore.Components;
using FinalProject.Layout;
using FinalProject.Shared;

namespace FinalProject.Components.Pages.Objects;

[Serializable]
public partial class Bookmark : AbstractFolderItem
{ 
    // Cascading parameters
    [CascadingParameter] public Bookmark _Retrieved { get; set; }
    
    // Parameters
    [Parameter] public override string Class { get; set; } = "bookmark";
    [Parameter] public override string Name { get; set; } = "Default";
    [Parameter] public string Description { get; set; } = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Aenean imperdiet quam at sem semper ultricies. Nunc orci justo, blandit non arcu at, auctor feugiat neque. Nunc vel dapibus leo, eget porttitor leo.";
    [Parameter] public string URL { get; set; } = "https://docs.microsoft.com/aspnet/";
    [Parameter] public string Keyword { get; set; } = "keyword";
    [Parameter] public List<Field> CustomFields { get; set; } = new List<Field> { new Field(), new Field() };
    [Parameter] public bool DisplayAsFolderItem { get; set; } = false;
    [Parameter] public int SetHashCode { get; set; }        // Used for hashed routing

    // Component functions
    protected override void OnInitialized()
    {
        _stateContainer.AddRoutingObjectParameter(this);
    }

    private void AddField() {
        CustomFields.Add(new Field());
        _MainLayout.UpdateLocalStorage();
    }

    private void DeleteField(int index) {
        CustomFields.Remove(CustomFields[index]);
        _MainLayout.UpdateLocalStorage();
    }

    private void NavigateToBookmark() {
        _navigationManager.NavigateTo($"bookmark/{this.GetHashCode()}");
    }
}
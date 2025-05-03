using Microsoft.AspNetCore.Components;

namespace FinalProject.Components.Pages.Objects;

[Serializable]
public partial class Bookmark : AbstractFolderItem
{
    // Parameters
    [Parameter] public override string Class { get; set; } = "bookmark";
    [Parameter] public override string Name { get; set; } = "Default";
    [Parameter] public string Description { get; set; } = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Aenean imperdiet quam at sem semper ultricies. Nunc orci justo, blandit non arcu at, auctor feugiat neque. Nunc vel dapibus leo, eget porttitor leo.";
    [Parameter] public string URL { get; set; } = "https://docs.microsoft.com/aspnet/";
    [Parameter] public string Keyword { get; set; } = "keyword";
    [Parameter] public List<Field> CustomFields { get; set; } = new List<Field> { new Field(), new Field() };
    [Parameter] public override bool IsSelected { get; set; } = false;
    [Parameter] public bool DisplayAsFolderItem { get; set; } = false;
    public override bool IsFolder { get; set; } = false;

    // Variables
    private string showDisplay = "";
    private string showEditing = "hidden";
    private string newName = "";

    protected override void OnInitialized()
    {
        newName = Name;
    }

    private void ToggleEditMode() {
        showDisplay = showDisplay == string.Empty ? "hidden" : "";
        showEditing = showEditing == string.Empty ? "hidden" : "";
    }

    private void SetValue() {
        if (newName != string.Empty) { Name = newName; }
        else { Name = "Untitled"; }
        ToggleEditMode();
    }

    private void AddField() {
        CustomFields.Add(new Field());
    }

    private void DeleteField(int index) {
        CustomFields.Remove(CustomFields[index]);
    }
}
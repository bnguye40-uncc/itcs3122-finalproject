using Microsoft.AspNetCore.Components;
using FinalProject.Shared;
using FinalProject.Components.Pages;
using FinalProject.Components.Pages.Objects;

namespace FinalProject.Layout;

public partial class MainLayout : LayoutComponentBase
{
    public List<AbstractFolderItem> RootFolder = new List<AbstractFolderItem>();
    public string rootFolderKey = "root-folder";

    protected override async Task OnInitializedAsync()
    {
        if (await _localStorage.ContainKeyAsync(rootFolderKey)) {
            RootFolder = await _localStorage.GetItemAsync<List<AbstractFolderItem>>(rootFolderKey);
        } else {
            await _localStorage.SetItemAsync<List<AbstractFolderItem>>(rootFolderKey, RootFolder);
        }   
    }

    public async void UpdateLocalStorage() {
        await _localStorage.SetItemAsync<List<AbstractFolderItem>>(rootFolderKey, RootFolder);
    }
}
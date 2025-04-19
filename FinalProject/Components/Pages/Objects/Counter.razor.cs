using Microsoft.AspNetCore.Components;

namespace FinalProject.Components.Pages.Objects;

public partial class Counter : ComponentBase
{
    private int currentCount = 0;

    private void IncrementCount() => currentCount++;
}
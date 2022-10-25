namespace EncyclopediaGalactica.UI.FAST.FastCombobox;

using Microsoft.AspNetCore.Components;

public partial class FastCombobox
{
    [Parameter]
    public bool IsDisabled { get; set; }

    [Parameter]
    public string? Name { get; set; }

    [Parameter]
    public string? Autocomplete { get; set; }

    [Parameter]
    public string? Position { get; set; }
    
    [Parameter]
    public string? Placeholder { get; set; }
    
    [Parameter]
    public string? Value { get; set; }

    [Parameter]
    public RenderFragment? ChildContent { get; set; }
}
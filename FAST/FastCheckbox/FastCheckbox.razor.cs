namespace EncyclopediaGalactica.UI.FAST.FastCheckbox;

using Microsoft.AspNetCore.Components;

public partial class FastCheckbox
{
    [Parameter]
    public bool IsChecked { get; set; }
    
    [Parameter]
    public bool IsDisabled { get; set; }
    
    [Parameter]
    public bool IsRequired { get; set; }
    
    [Parameter]
    public bool IsReadOnly { get; set; }
    
    [Parameter]
    public string? Name { get; set; }
    
    [Parameter]
    public RenderFragment? ChildContent { get; set; }
}
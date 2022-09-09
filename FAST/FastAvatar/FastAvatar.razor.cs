namespace com.encyclopediagalactica.ui.fast.FastAvatar;

using Microsoft.AspNetCore.Components;

public partial class FastAvatar
{
    [Parameter]
    public string? AltTag { get; set; }
    
    [Parameter]
    public string? Href { get; set; }
    
    [Parameter]
    public string? Name { get; set; }
    
    [Parameter]
    public string? Shape { get; set; }
    
    [Parameter]
    public string? Fill { get; set; }
    
    [Parameter]
    public RenderFragment? ChildContent { get; set; }
}
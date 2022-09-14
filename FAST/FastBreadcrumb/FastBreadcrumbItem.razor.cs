namespace EncyclopediaGalactica.UI.FAST.FastBreadcrumb;

using Microsoft.AspNetCore.Components;

public partial class FastBreadcrumbItem
{
    [Parameter]
    public string? Href { get; set; }
    
    [Parameter]
    public RenderFragment? ChildContent { get; set; }
}
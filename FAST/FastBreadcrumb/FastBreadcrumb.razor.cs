namespace EncyclopediaGalactica.UI.FAST.FastBreadcrumb;

using Microsoft.AspNetCore.Components;

public partial class FastBreadcrumb
{
    [Parameter]
    public RenderFragment? ChildContent { get; set; }
}
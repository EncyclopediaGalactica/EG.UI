namespace EncyclopediaGalactica.UI.FAST.FastCard;

using Microsoft.AspNetCore.Components;

public partial class FastCard
{
    [Parameter]
    public RenderFragment? ChildContent { get; set; }
}
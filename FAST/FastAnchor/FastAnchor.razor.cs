namespace EncyclopediaGalactica.UI.FAST.FastAnchor;

using Microsoft.AspNetCore.Components;

public partial class FastAnchor
{
    [Parameter]
    public string? Href { get; set; } = "#";

    [Parameter]
    public string Appearance { get; set; } = Configuration.Appearance.Neutral;

    [Parameter]
    public RenderFragment? ChildContent { get; set; }
}
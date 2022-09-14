namespace EncyclopediaGalactica.UI.FAST.FastBadge;

using Microsoft.AspNetCore.Components;

/// <summary>
///     FastBadge Component
/// </summary>
/// <remarks>
///     It generates the proper HTML code for FAST Design framework
/// </remarks>
/// <example>
///     <list type="bullet">
///         <item>
///             <FastBadge>[...]</FastBadge>
///         </item>
///         <item>
///             <FastBadge Color="" Fill="">[...]</FastBadge>
///         </item>
///     </list>
/// </example>
public partial class FastBadge
{
    /// <summary>
    ///     The fill parameter
    /// </summary>
    [Parameter]
    public string? Fill { get; set; }

    /// <summary>
    ///     The color parameter
    /// </summary>
    [Parameter]
    public string? Color { get; set; }

    /// <summary>
    ///     The child content parameter
    /// </summary>
    [Parameter]
    public RenderFragment? ChildContent { get; set; }
}
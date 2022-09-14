namespace EncyclopediaGalactica.UI.FAST.FastAvatar;

using Microsoft.AspNetCore.Components;

/// <summary>
///     FastAvatar Blazor Component
/// </summary>
/// <remarks>
///     It generates the proper HTML for a
///     <a
///         href="https://github.com/microsoft/fast/blob/master/packages/web-components/fast-foundation/src/avatar/avatar.spec.md">
///         FAST Avatar
///     </a>
///     element which will be transformed by the
///     <a href="https://fast.design">FAST Framework</a>.
/// </remarks>
/// <para>
///     <list type="bullet">
///         <item>
///             <FastAvatar>[..]</FastAvatar>
///         </item>
///         <item>
///             <FastAvatar AltTag="" Href="" Name="" Shape="" Fill="" Color="">[..]</FastAvatar>
///         </item>
///     </list>
/// </para>
public partial class FastAvatar
{
    /// <summary>
    ///     Alternative Tag field
    /// </summary>
    /// <remarks>
    ///     The text defined here will be displayed when the cursor hovers over the element
    /// </remarks>
    [Parameter]
    public string? AltTag { get; set; }

    /// <summary>
    ///     The link attribute
    /// </summary>
    [Parameter]
    public string? Href { get; set; }

    /// <summary>
    ///     The name attribute
    /// </summary>
    [Parameter]
    public string? Name { get; set; }

    /// <summary>
    ///     The shape attribute
    /// </summary>
    [Parameter]
    public string? Shape { get; set; }

    /// <summary>
    ///     The fill attribute
    /// </summary>
    [Parameter]
    public string? Fill { get; set; }

    /// <summary>
    ///     The color attribute
    /// </summary>
    [Parameter]
    public string? Color { get; set; }

    /// <summary>
    ///     The ChildContent
    /// </summary>
    [Parameter]
    public RenderFragment? ChildContent { get; set; }
}
namespace EncyclopediaGalactica.UI.FAST.FastButton;

using Microsoft.AspNetCore.Components;

/// <summary>
///     FastButton Component
/// </summary>
/// <remarks>
///     It generates the proper HTML to display a FAST Button component
///     <para>
///         Defaults:
///         <list type="bullet">
///             <item>Appearance default is <b>Neutral</b></item>
///             <item>Href default is <b>#</b></item>
///             <item>Autofocus is <b>false</b></item>
///             <item>Disabled is <b>false</b></item>
///         </list>
///     </para>
/// </remarks>
/// <example>
///     <list type="bullet">
///         <item>
///             <FastButton>[...]</FastButton>
///         </item>
///     </list>
/// </example>
public partial class FastButton
{
    [Parameter]
    public string Href { get; set; } = "#";

    [Parameter]
    public string Appearance { get; set; } = Configuration.Appearance.Neutral;

    [Parameter]
    public bool Autofocus { get; set; }

    [Parameter]
    public bool Disabled { get; set; }

    [Parameter]
    public string? FormId { get; set; }

    [Parameter]
    public string? FormAction { get; set; }

    [Parameter]
    public string? FormEncType { get; set; }

    [Parameter]
    public string? FormMethod { get; set; }

    [Parameter]
    public bool FormNoValidate { get; set; }

    [Parameter]
    public string? FormTarget { get; set; }

    [Parameter]
    public string? Name { get; set; }

    [Parameter]
    public string ButtonType { get; set; } = Configuration.Button.Type.Button;

    [Parameter]
    public string? Value { get; set; }

    [Parameter]
    public RenderFragment? ChildContent { get; set; }
}
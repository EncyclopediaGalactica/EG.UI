namespace com.encyclopediagalactica.ui.fast.Accordion;

using Microsoft.AspNetCore.Components;

/// <summary>
///     FastAccordion component.
/// </summary>
/// <remarks>
///     It produces the proper HTML content which will be transformed by the FAST framework will transform it to the proper
///     display elements. For further details see
///     <a href="https://github.com/microsoft/fast/tree/master/packages/web-components/fast-foundation/src/accordion">
///         FAST
///         documentation
///     </a>
///     .
/// </remarks>
/// <para>
///     <example>
///         <FastAccordion>[...]</FastAccordion>
///     </example>
/// </para>
public partial class FastAccordion
{
    [Parameter]
    public RenderFragment? ChildContent { get; set; }
}
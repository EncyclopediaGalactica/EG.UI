namespace com.encyclopediagalactica.ui.fast.FastAccordion;

using Microsoft.AspNetCore.Components;

/// <summary>
///     FastAccordionItem Component
/// </summary>
/// <remarks>
///     <para>
///         It produces the proper HTML content which will be transformed to elements by the FAST Framework.
///         It must be placed in a <see cref="FastAccordion" /> component.
///         For further details see
///         <a
///             href="https://github.com/microsoft/fast/tree/master/packages/web-components/fast-foundation/src/accordion-item">
///             FAST
///             Documentation
///         </a>
///         .
///     </para>
///     <para>
///         Supported input parameters:
///         <list type="bullet">
///             <item>IsExpanded - defines whether the accordion item is opened by default</item>
///         </list>
///     </para>
/// </remarks>
/// <example>
///     <list type="bullet">
///         <item>
///             <FastAccordionItem>[...]</FastAccordionItem>
///         </item>
///         <item>
///             <FastAccordionItem IsExpanded="true">[...]</FastAccordionItem>
///         </item>
///     </list>
/// </example>
public partial class FastAccordionItem
{
    [Parameter]
    public RenderFragment? ChildContent { get; set; }

    [Parameter]
    public bool IsExpanded { get; set; }
}
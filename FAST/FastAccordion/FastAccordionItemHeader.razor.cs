namespace EncyclopediaGalactica.UI.FAST.FastAccordion;

using Microsoft.AspNetCore.Components;

/// <summary>
///     FastAccordionItemHeader component
/// </summary>
/// <remarks>
///     It produces the proper HTML content to display the header element of a <see cref="FastAccordionItem" /> header.
///     This component must be placed within a <see cref="FastAccordionItem" /> element.
///     This item does not have FAST Documentation. It is the product of my fantastic brain! :)
/// </remarks>
/// <example>
///     <list type="bullet">
///         <item>
///             <FastAccordionItemHeader>Header value</FastAccordionItemHeader>
///         </item>
///     </list>
/// </example>
public partial class FastAccordionItemHeader
{
    [Parameter]
    public RenderFragment? ChildContent { get; set; }
}
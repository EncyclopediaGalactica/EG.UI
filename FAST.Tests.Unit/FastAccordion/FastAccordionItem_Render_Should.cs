namespace com.encyclopediagalactica.ui.fast.test.unit.FastAccordion;

using System.Diagnostics.CodeAnalysis;
using Bunit;
using fast.FastAccordion;
using Xunit;
using Xunit.Abstractions;

[ExcludeFromCodeCoverage]
[SuppressMessage("ReSharper", "InconsistentNaming")]
public class FastAccordionItem_Render_Should
{
    private readonly ITestOutputHelper _outputHelper;
    private readonly TestContext _testContext;

    public FastAccordionItem_Render_Should(ITestOutputHelper outputHelper)
    {
        ArgumentNullException.ThrowIfNull(outputHelper);
        _outputHelper = outputHelper;
        _testContext = new TestContext();
    }

    [Fact]
    public void RenderProperly_WithoutAnyProvided_Content()
    {
        // Arrange
        IRenderedComponent<FastAccordionItem> cut = _testContext.RenderComponent<FastAccordionItem>();

        // Assert
        cut.MarkupMatches("<fast-accordion-item class=\"\"></fast-accordion-item>");
    }

    [Fact]
    public void RenderProperly_WithAnyProvided_Content()
    {
        // Arrange
        IRenderedComponent<FastAccordionItem> cut = _testContext.RenderComponent<FastAccordionItem>(
            parameters => parameters.AddChildContent("child content"));

        // Assert
        cut.MarkupMatches("<fast-accordion-item class=\"\">child content</fast-accordion-item>");
    }

    [Theory]
    [InlineData(true)]
    [InlineData(false)]
    public void RenderProperly_WithProvided_IsExtended_Parameter(bool isExtended)
    {
        // Arrange
        IRenderedComponent<FastAccordionItem> cut = _testContext.RenderComponent<FastAccordionItem>(
            parameters => parameters.Add(p => p.IsExpanded, isExtended));

        // Assert
        if (isExtended)
        {
            cut.MarkupMatches("<fast-accordion-item class=\"expanded\"></fast-accordion-item>");
        }
        else
        {
            _outputHelper.WriteLine(cut.Markup);
            cut.MarkupMatches("<fast-accordion-item class=\"\"></fast-accordion-item>");
        }
    }
}
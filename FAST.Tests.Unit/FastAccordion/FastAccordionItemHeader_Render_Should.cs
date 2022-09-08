namespace com.encyclopediagalactica.ui.fast.test.unit.Accordion;

using System.Diagnostics.CodeAnalysis;
using Bunit;
using fast.Accordion;
using Xunit;
using Xunit.Abstractions;

[ExcludeFromCodeCoverage]
[SuppressMessage("ReSharper", "InconsistentNaming")]
public class FastAccordionItemHeader_Render_Should
{
    private readonly ITestOutputHelper _outputHelper;
    private readonly TestContext _testContext;

    public FastAccordionItemHeader_Render_Should(ITestOutputHelper outputHelper)
    {
        ArgumentNullException.ThrowIfNull(outputHelper);
        _outputHelper = outputHelper;
        _testContext = new TestContext();
    }

    [Fact]
    public void RenderProperly_WhenHeaderTextIsProvided()
    {
        // Arrange
        IRenderedComponent<FastAccordionItemHeader> cut = _testContext.RenderComponent<FastAccordionItemHeader>(
            parameters => parameters.AddChildContent("Test header text"));

        // Assert
        cut.MarkupMatches("<div slot=\"heading\">Test header text</div>");
    }

    [Fact]
    public void RenderProperly_WhenHeaderTextIsNotProvided()
    {
        // Arrange
        IRenderedComponent<FastAccordionItemHeader> cut = _testContext.RenderComponent<FastAccordionItemHeader>();

        // Assert
        cut.MarkupMatches("");
    }
}
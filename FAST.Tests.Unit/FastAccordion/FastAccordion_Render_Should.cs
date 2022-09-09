namespace com.encyclopediagalactica.ui.fast.test.unit.FastAccordion;

using System.Diagnostics.CodeAnalysis;
using Bunit;
using fast.FastAccordion;
using Xunit;
using Xunit.Abstractions;

[ExcludeFromCodeCoverage]
[SuppressMessage("ReSharper", "InconsistentNaming")]
public class FastAccordion_Render_Should
{
    private readonly ITestOutputHelper _outputHelper;
    private readonly TestContext _testContext;

    public FastAccordion_Render_Should(ITestOutputHelper outputHelper)
    {
        _outputHelper = outputHelper;
        _testContext = new TestContext();
    }

    [Fact]
    public void RenderProperly_WithoutAnyProvidedContent()
    {
        // Arrange
        IRenderedComponent<FastAccordion> cut = _testContext.RenderComponent<FastAccordion>();

        // Assert
        cut.MarkupMatches("<fast-accordion></fast-accordion>");
    }

    [Fact]
    public void RenderProperly_WithAnyProvidedContent()
    {
        // Arrange
        IRenderedComponent<FastAccordion> cut = _testContext.RenderComponent<FastAccordion>(
            parameters => parameters.AddChildContent("specific child content"));

        // Assert
        cut.MarkupMatches("<fast-accordion>specific child content</fast-accordion>");
    }
}
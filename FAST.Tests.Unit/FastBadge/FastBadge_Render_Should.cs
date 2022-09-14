namespace EncyclopediaGalactica.UI.FAST.Test.Unit.FastBadge;

using System.Diagnostics.CodeAnalysis;
using Bunit;
using FAST.FastBadge;
using Xunit;
using Xunit.Abstractions;

[ExcludeFromCodeCoverage]
[SuppressMessage("ReSharper", "InconsistentNaming")]
public class FastBadge_Render_Should
{
    private readonly ITestOutputHelper _testOutputHelper;
    private readonly TestContext _testContext;

    public FastBadge_Render_Should(ITestOutputHelper testOutputHelper)
    {
        ArgumentNullException.ThrowIfNull(testOutputHelper);
        _testOutputHelper = testOutputHelper;
        _testContext = new TestContext();
    }

    [Fact]
    public void RenderProperly_WhenAllParametersAreSet()
    {
        // Arrange
        IRenderedComponent<FastBadge> cut = _testContext.RenderComponent<FastBadge>(
            parameters => parameters
                .Add(fill => fill.Fill, "fill")
                .Add(color => color.Color, "color")
                .AddChildContent("childcontent")
        );
        
        // Assert
        cut.MarkupMatches("<fast-badge fill=\"fill\" color=\"color\">childcontent</fast-badge>");
    }

    [Fact]
    public void RenderProperly_WhenFill_IsNotProvided()
    {
        // Arrange
        IRenderedComponent<FastBadge> cut = _testContext.RenderComponent<FastBadge>(
            parameters => parameters
                .Add(color => color.Color, "color")
                .AddChildContent("childcontent")
        );
        
        // Assert
        cut.MarkupMatches("<fast-badge color=\"color\">childcontent</fast-badge>");
    }

    [Fact]
    public void RenderProperly_WhenColor_IsNotProvided()
    {
        // Arrange
        IRenderedComponent<FastBadge> cut = _testContext.RenderComponent<FastBadge>(
            parameters => parameters
                .Add(fill => fill.Fill, "fill")
                .AddChildContent("childcontent")
        );
        
        // Assert
        cut.MarkupMatches("<fast-badge fill=\"fill\">childcontent</fast-badge>");
    }
}
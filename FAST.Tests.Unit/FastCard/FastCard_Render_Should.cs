namespace EncyclopediaGalactica.UI.FAST.Test.Unit.FastCard;

using System.Diagnostics.CodeAnalysis;
using Bunit;
using FAST.FastCard;
using Xunit;
using Xunit.Abstractions;

[ExcludeFromCodeCoverage]
[SuppressMessage("ReSharper", "InconsistentNaming")]
public class FastCard_Render_Should
{
    private readonly ITestOutputHelper _testOutputHelper;
    private readonly TestContext _testContext;

    public FastCard_Render_Should(ITestOutputHelper testOutputHelper)
    {
        ArgumentNullException.ThrowIfNull(testOutputHelper);
        _testOutputHelper = testOutputHelper;
        _testContext = new TestContext();
    }

    [Fact]
    public void RenderProperly_WhenAllParametersAreSet()
    {
        // Arrange
        IRenderedComponent<FastCard> cut = _testContext.RenderComponent<FastCard>(
            parameters => parameters.AddChildContent("childcontent"));
        
        // Assert
        cut.MarkupMatches("<fast-card>childcontent</fast-card>");
    }

    [Fact]
    public void RenderProperly_WhenNoChildContent_IsSetUp()
    {
        // Arrange
        IRenderedComponent<FastCard> cut = _testContext.RenderComponent<FastCard>();
        
        // Assert
        cut.MarkupMatches("<fast-card></fast-card>");

    }
}
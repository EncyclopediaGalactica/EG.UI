namespace EncyclopediaGalactica.UI.FAST.Test.Unit.FastBreadcrumb;

using System.Diagnostics.CodeAnalysis;
using Bunit;
using FAST.FastBreadcrumb;
using Xunit;
using Xunit.Abstractions;

[ExcludeFromCodeCoverage]
[SuppressMessage("ReSharper", "InconsistentNaming")]
public class FastBreadcrumb_Render_Should
{
    private readonly ITestOutputHelper _testOutputHelper;
    private readonly TestContext _testContext;

    public FastBreadcrumb_Render_Should(ITestOutputHelper testOutputHelper)
    {
        ArgumentNullException.ThrowIfNull(testOutputHelper);
        _testOutputHelper = testOutputHelper;
        _testContext = new TestContext();
    }

    [Fact]
    public void RenderProperly_WhenNoChildContent()
    {
        // Arrange
        IRenderedComponent<FastBreadcrumb> cut = _testContext.RenderComponent<FastBreadcrumb>();
        
        // Assert
        cut.MarkupMatches("<fast-breadcrumb></fast-breadcrumb>");
    }

    [Fact]
    public void RenderProperly_WhenChildContent_IsSet()
    {
        // Arrange
        IRenderedComponent<FastBreadcrumb> cut = _testContext.RenderComponent<FastBreadcrumb>(
            parameters => parameters.AddChildContent("childcontent"));
        
        // Assert
        cut.MarkupMatches("<fast-breadcrumb>childcontent</fast-breadcrumb>");
    }
}
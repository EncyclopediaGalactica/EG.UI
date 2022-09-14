namespace EncyclopediaGalactica.UI.FAST.Test.Unit.FastBreadcrumb;

using System.Diagnostics.CodeAnalysis;
using Bunit;
using FAST.FastBreadcrumb;
using Xunit;
using Xunit.Abstractions;

[ExcludeFromCodeCoverage]
[SuppressMessage("ReSharper", "InconsistentNaming")]
public class FastBreadcrumbItem_Render_Should
{
    private readonly ITestOutputHelper _testOutputHelper;
    private readonly TestContext _testContext;

    public FastBreadcrumbItem_Render_Should(ITestOutputHelper testOutputHelper)
    {
        ArgumentNullException.ThrowIfNull(testOutputHelper);
        _testOutputHelper = testOutputHelper;
        _testContext = new TestContext();
    }

    [Fact]
    public void RenderProperly_WhenNoHref_IsSetUp()
    {
        // Arrange
        IRenderedComponent<FastBreadcrumbItem> cut = _testContext.RenderComponent<FastBreadcrumbItem>(
            parameters => parameters.AddChildContent("childcontent"));
        
        // Assert
        cut.MarkupMatches("<fast-breadcrumb-item>childcontent</fast-breadcrumb-item>");
    }

    [Fact]
    public void RenderProperly_WhenNoChildContent_IsSetUp()
    {
        // Arrange
        IRenderedComponent<FastBreadcrumbItem> cut = _testContext.RenderComponent<FastBreadcrumbItem>(
            parameters => parameters
                .Add(href => href.Href, "href"));
        
        // Assert
        cut.MarkupMatches("<fast-breadcrumb-item href=\"href\"></fast-breadcrumb-item>");
    }

    [Fact]
    public void RenderProperly_WhenAllParameters_AreSetUp()
    {
        // Arrange
        IRenderedComponent<FastBreadcrumbItem> cut = _testContext.RenderComponent<FastBreadcrumbItem>(
            parameters => parameters
                .Add(href => href.Href, "href")
                .AddChildContent("childcontent"));
        
        // Assert
        cut.MarkupMatches("<fast-breadcrumb-item href=\"href\">childcontent</fast-breadcrumb-item>");
    }
}
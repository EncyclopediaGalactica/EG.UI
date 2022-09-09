namespace com.encyclopediagalactica.ui.fast.test.unit.FastAnchor;

using System.Diagnostics.CodeAnalysis;
using Bunit;
using fast.FastAnchor;
using Xunit;
using Xunit.Abstractions;

[ExcludeFromCodeCoverage]
[SuppressMessage("ReSharper", "InconsistentNaming")]
public class FastAnchor_render_Should
{
    private readonly ITestOutputHelper _outputHelper;
    private readonly TestContext _testContext;

    public FastAnchor_render_Should(ITestOutputHelper outputHelper)
    {
        ArgumentNullException.ThrowIfNull(outputHelper);
        _outputHelper = outputHelper;
        _testContext = new TestContext();
    }

    [Fact]
    public void RenderProperly_WhenAllParameterHasValues()
    {
        // Arrange
        IRenderedComponent<FastAnchor> cut = _testContext.RenderComponent<FastAnchor>(
            parameters => parameters
                .Add(appearance => appearance.Appearance, Configuration.Appearance.Hypertext)
                .Add(href => href.Href, "hrefcontent")
                .AddChildContent("childcontent"));
        
        // Assert
        _outputHelper.WriteLine(cut.Markup);
        cut.MarkupMatches("<fast-anchor href=\"hrefcontent\" appearance=\"hypertext\">childcontent</fast-anchor>");
    }

    [Fact]
    public void RenderProperly_WhenHrefIsNotProvided_FallsBackToDefault()
    {
        // Arrange
        IRenderedComponent<FastAnchor> cut = _testContext.RenderComponent<FastAnchor>(
            parameters => parameters
                .Add(appearance => appearance.Appearance, Configuration.Appearance.Hypertext)
                .AddChildContent("childcontent"));
        
        // Assert
        _outputHelper.WriteLine(cut.Markup);
        cut.MarkupMatches("<fast-anchor href=\"#\" appearance=\"hypertext\">childcontent</fast-anchor>");
    }

    [Fact]
    public void RenderProperly_WhenAppearanceIsNotProvided_FallsBackToDefault()
    {
        // Arrange
        IRenderedComponent<FastAnchor> cut = _testContext.RenderComponent<FastAnchor>(
            parameters => parameters
                .Add(href => href.Href, "hrefcontent")
                .AddChildContent("childcontent"));
        
        // Assert
        _outputHelper.WriteLine(cut.Markup);
        cut.MarkupMatches("<fast-anchor href=\"hrefcontent\" appearance=\"neutral\">childcontent</fast-anchor>");
    }

    [Fact]
    public void RenderProperly_WhenChildContentIsNotProvided()
    {
        // Arrange
        IRenderedComponent<FastAnchor> cut = _testContext.RenderComponent<FastAnchor>(
            parameters => parameters
                .Add(appearance => appearance.Appearance, Configuration.Appearance.Hypertext)
                .Add(href => href.Href, "hrefcontent"));
        
        // Assert
        _outputHelper.WriteLine(cut.Markup);
        cut.MarkupMatches("<fast-anchor href=\"hrefcontent\" appearance=\"hypertext\"></fast-anchor>");
    }

    [Theory]
    [InlineData(Configuration.Appearance.Accent)]
    public void RenderProperly_WithAllAppearances(string appearance)
    {
        // Arrange
        IRenderedComponent<FastAnchor> cut = _testContext.RenderComponent<FastAnchor>(
            parameters => parameters
                .Add(appe => appe.Appearance, appearance)
                .Add(href => href.Href, "hrefcontent")
                .AddChildContent("childcontent"));
        
        // Assert
        _outputHelper.WriteLine(cut.Markup);
        string expectedMarkup =
            $"<fast-anchor href=\"hrefcontent\" appearance=\"{appearance.ToLower()}\">childcontent</fast-anchor>"; 
        cut.MarkupMatches(expectedMarkup);
    }
}
namespace EncyclopediaGalactica.UI.FAST.Test.Unit.FastAvatar;

using System.Diagnostics.CodeAnalysis;
using Bunit;
using FAST.FastAvatar;
using Xunit;
using Xunit.Abstractions;

[ExcludeFromCodeCoverage]
[SuppressMessage("ReSharper", "InconsistentNaming")]
public class FastAvatar_Render_Should
{
    private readonly ITestOutputHelper _outputHelper;
    private readonly TestContext _testContext;

    public FastAvatar_Render_Should(ITestOutputHelper outputHelper)
    {
        ArgumentNullException.ThrowIfNull(outputHelper);
        _outputHelper = outputHelper;
        _testContext = new TestContext();
    }

    [Fact]
    public void RenderProperly_WhenAllPropertiesAreSet()
    {
        // Arrange
        IRenderedComponent<FastAvatar> cut = _testContext.RenderComponent<FastAvatar>(
            parameters => parameters
                .Add(name => name.Name, "Name")
                .Add(fill => fill.Fill, "fill")
                .Add(altTag => altTag.AltTag, "alttag")
                .Add(href => href.Href, "href")
                .Add(shape => shape.Shape, "shape")
                .Add(color => color.Color, "black")
                .AddChildContent("childcontent"));

        // Assert
        cut.MarkupMatches(
            "<fast-avatar " +
            "alt=\"alttag\" " +
            "link=\"href\" " +
            "name=\"Name\" " +
            "shape=\"shape\" " +
            "fill=\"fill\" " +
            "color=\"black\">childcontent</fast-avatar>");
    }

    [Fact]
    public void RenderProperly_WithoutAltTag_WhenAltTagIsNotSetUp()
    {
        // Arrange
        IRenderedComponent<FastAvatar> cut = _testContext.RenderComponent<FastAvatar>(
            parameters => parameters
                .Add(name => name.Name, "Name")
                .Add(fill => fill.Fill, "fill")
                .Add(href => href.Href, "href")
                .Add(shape => shape.Shape, "shape")
                .Add(color => color.Color, "black")
                .AddChildContent("childcontent"));

        // Assert
        cut.MarkupMatches(
            "<fast-avatar " +
            "link=\"href\" " +
            "name=\"Name\" " +
            "shape=\"shape\" " +
            "fill=\"fill\" " +
            "color=\"black\">childcontent</fast-avatar>");
    }

    [Fact]
    public void RenderProperly_WithoutHref_WhenHrefIsNotSetUp()
    {
        // Arrange
        IRenderedComponent<FastAvatar> cut = _testContext.RenderComponent<FastAvatar>(
            parameters => parameters
                .Add(name => name.Name, "Name")
                .Add(fill => fill.Fill, "fill")
                .Add(altTag => altTag.AltTag, "alttag")
                .Add(shape => shape.Shape, "shape")
                .Add(color => color.Color, "black")
                .AddChildContent("childcontent"));

        // Assert
        cut.MarkupMatches(
            "<fast-avatar " +
            "alt=\"alttag\" " +
            "name=\"Name\" " +
            "shape=\"shape\" " +
            "fill=\"fill\" " +
            "color=\"black\">childcontent</fast-avatar>");
    }

    [Fact]
    public void RenderProperly_WithoutName_WhenNameIsNotSetUp()
    {
        // Arrange
        IRenderedComponent<FastAvatar> cut = _testContext.RenderComponent<FastAvatar>(
            parameters => parameters
                .Add(fill => fill.Fill, "fill")
                .Add(altTag => altTag.AltTag, "alttag")
                .Add(href => href.Href, "href")
                .Add(shape => shape.Shape, "shape")
                .Add(color => color.Color, "black")
                .AddChildContent("childcontent"));

        // Assert
        cut.MarkupMatches(
            "<fast-avatar " +
            "alt=\"alttag\" " +
            "link=\"href\" " +
            "shape=\"shape\" " +
            "fill=\"fill\" " +
            "color=\"black\">childcontent</fast-avatar>");
    }

    [Fact]
    public void RenderProperly_WithoutShape_WhenShapeIsNotSetUp()
    {
        // Arrange
        IRenderedComponent<FastAvatar> cut = _testContext.RenderComponent<FastAvatar>(
            parameters => parameters
                .Add(name => name.Name, "Name")
                .Add(fill => fill.Fill, "fill")
                .Add(altTag => altTag.AltTag, "alttag")
                .Add(href => href.Href, "href")
                .Add(color => color.Color, "black")
                .AddChildContent("childcontent"));

        // Assert
        cut.MarkupMatches(
            "<fast-avatar " +
            "alt=\"alttag\" " +
            "link=\"href\" " +
            "name=\"Name\" " +
            "fill=\"fill\" " +
            "color=\"black\">childcontent</fast-avatar>");
    }

    [Fact]
    public void RenderProperly_WithoutFill_WhenFillIsNotSetUp()
    {
        // Arrange
        IRenderedComponent<FastAvatar> cut = _testContext.RenderComponent<FastAvatar>(
            parameters => parameters
                .Add(name => name.Name, "Name")
                .Add(altTag => altTag.AltTag, "alttag")
                .Add(href => href.Href, "href")
                .Add(shape => shape.Shape, "shape")
                .Add(color => color.Color, "black")
                .AddChildContent("childcontent"));

        // Assert
        cut.MarkupMatches(
            "<fast-avatar " +
            "alt=\"alttag\" " +
            "link=\"href\" " +
            "name=\"Name\" " +
            "shape=\"shape\" " +
            "color=\"black\">childcontent</fast-avatar>");
    }
    
    [Fact]
    public void RenderProperly_WithoutColor_WhenColorIsNotSetUp()
    {
        // Arrange
        IRenderedComponent<FastAvatar> cut = _testContext.RenderComponent<FastAvatar>(
            parameters => parameters
                .Add(name => name.Name, "Name")
                .Add(fill => fill.Fill, "fill")
                .Add(altTag => altTag.AltTag, "alttag")
                .Add(href => href.Href, "href")
                .Add(shape => shape.Shape, "shape")
                .AddChildContent("childcontent"));

        // Assert
        cut.MarkupMatches(
            "<fast-avatar " +
            "alt=\"alttag\" " +
            "link=\"href\" " +
            "name=\"Name\" " +
            "shape=\"shape\" " +
            "fill=\"fill\">childcontent</fast-avatar>");
    }
}
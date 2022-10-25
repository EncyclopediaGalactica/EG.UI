namespace EncyclopediaGalactica.UI.FAST.Test.Unit.FastCombobox;

using Bunit;
using FAST.FastCombobox;
using Xunit;
using Xunit.Abstractions;

public class FastCombobox_Render_Should
{
    private readonly TestContext _testContext;
    private readonly ITestOutputHelper _testOutputHelper;

    public FastCombobox_Render_Should(ITestOutputHelper testOutputHelper)
    {
        ArgumentNullException.ThrowIfNull(testOutputHelper);
        _testOutputHelper = testOutputHelper;
        _testContext = new TestContext();
    }

    [Fact]
    public void RenderProperly_WhenNoneOfParameters_AreSet()
    {
        // Arrange & Act
        IRenderedComponent<FastCombobox> cut = _testContext.RenderComponent<FastCombobox>();

        // Act
        cut.MarkupMatches("<fast-combobox></fast-combobox>");
    }

    [Fact]
    public void RenderProperlyWhen_ChildContent_IsSet()
    {
        // Arrange & Act
        IRenderedComponent<FastCombobox> cut = _testContext.RenderComponent<FastCombobox>(
            parameters => parameters.AddChildContent("childcontent"));

        // Act
        cut.MarkupMatches("<fast-combobox>childcontent</fast-combobox>");
    }

    [Fact]
    public void RenderProperlyWhen_ChildContentAnd_IsDisabled_AreSet()
    {
        // Arrange & Act
        IRenderedComponent<FastCombobox> cut = _testContext.RenderComponent<FastCombobox>(
            parameters => parameters.Add(parameter => parameter.IsDisabled, true)
                .AddChildContent("childcontent"));

        // Act
        cut.MarkupMatches("<fast-combobox disabled>childcontent</fast-combobox>");
    }

    [Fact]
    public void RenderProperlyWhen_ChildContentAnd_Name_AreSet()
    {
        // Arrange & Act
        IRenderedComponent<FastCombobox> cut = _testContext.RenderComponent<FastCombobox>(
            parameters => parameters.Add(parameter => parameter.Name, "some name")
                .AddChildContent("childcontent"));

        // Act
        cut.MarkupMatches("<fast-combobox name=\"some name\">childcontent</fast-combobox>");
    }

    [Fact]
    public void RenderProperlyWhen_ChildContentAnd_Autocomplete_AreSet()
    {
        // Arrange & Act
        IRenderedComponent<FastCombobox> cut = _testContext.RenderComponent<FastCombobox>(
            parameters => parameters.Add(parameter => parameter.Autocomplete,
                    Configuration.Combobox.Autocomplete.Both)
                .AddChildContent("childcontent"));

        // Act
        cut.MarkupMatches("<fast-combobox autocomplete=\"both\">childcontent</fast-combobox>");
    }

    [Fact]
    public void RenderProperlyWhen_ChildContentAnd_Position_AreSet()
    {
        // Arrange & Act
        IRenderedComponent<FastCombobox> cut = _testContext.RenderComponent<FastCombobox>(
            parameters => parameters.Add(parameter => parameter.Position,
                    Configuration.Combobox.Position.Above)
                .AddChildContent("childcontent"));

        // Act
        cut.MarkupMatches("<fast-combobox position=\"above\">childcontent</fast-combobox>");
    }

    [Fact]
    public void RenderProperlyWhen_ChildContentAnd_Placeholder_AreSet()
    {
        // Arrange & Act
        IRenderedComponent<FastCombobox> cut = _testContext.RenderComponent<FastCombobox>(
            parameters => parameters.Add(parameter => parameter.Placeholder, "some text")
                .AddChildContent("childcontent"));

        // Act
        cut.MarkupMatches("<fast-combobox placeholder=\"some text\">childcontent</fast-combobox>");
    }

    [Fact]
    public void RenderProperlyWhen_ChildContentAnd_Value_AreSet()
    {
        // Arrange & Act
        IRenderedComponent<FastCombobox> cut = _testContext.RenderComponent<FastCombobox>(
            parameters => parameters.Add(parameter => parameter.Value, "some value")
                .AddChildContent("childcontent"));

        // Act
        cut.MarkupMatches("<fast-combobox value=\"some value\">childcontent</fast-combobox>");
    }

    [Fact]
    public void RenderProperlyWhen_AllParams_AreSet()
    {
        // Arrange & Act
        IRenderedComponent<FastCombobox> cut = _testContext.RenderComponent<FastCombobox>(
            parameters => parameters
                .Add(parameter => parameter.Value, "some value")
                .Add(parameter => parameter.Placeholder, "some placeholder")
                .Add(parameter => parameter.Position, Configuration.Combobox.Position.Above)
                .Add(parameter => parameter.Autocomplete, Configuration.Combobox.Autocomplete.Inline)
                .Add(parameter => parameter.Name, "some name")
                .Add(parameter => parameter.IsDisabled, true)
                .AddChildContent("childcontent"));

        // Act
        cut.MarkupMatches(
            "<fast-combobox position=\"above\" placeholder=\"some placeholder\" value=\"some value\" autocomplete=\"inline\" name=\"some name\" disabled>childcontent</fast-combobox>");
    }
}
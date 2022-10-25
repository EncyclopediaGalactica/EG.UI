namespace EncyclopediaGalactica.UI.FAST.Test.Unit.FastCheckbox;

using System.Diagnostics.CodeAnalysis;
using Bunit;
using FAST.FastCheckbox;
using Xunit;
using Xunit.Abstractions;

[ExcludeFromCodeCoverage]
[SuppressMessage("ReSharper", "InconsistentNaming")]
public class FastCheckbox_Render_Should
{
    private readonly ITestOutputHelper _testOutputHelper;
    private readonly TestContext _testContext;

    public FastCheckbox_Render_Should(ITestOutputHelper testOutputHelper)
    {
        ArgumentNullException.ThrowIfNull(testOutputHelper);
        _testOutputHelper = testOutputHelper;
        _testContext = new TestContext();
    }

    [Fact]
    public void RenderProperly_WhenNoParamsSet()
    {
        // Arrange & Act
        IRenderedComponent<FastCheckbox> cut = _testContext.RenderComponent<FastCheckbox>();
        
        // Assert
        cut.MarkupMatches("<fast-checkbox></fast-checkbox>");
    }

    [Fact]
    public void RenderProperly_WhenChildContent_IsSet()
    {
        // Arrange & Act
        IRenderedComponent<FastCheckbox> cut = _testContext.RenderComponent<FastCheckbox>(
            parameters => parameters.AddChildContent("childcontent"));
        
        // Assert
        cut.MarkupMatches("<fast-checkbox>childcontent</fast-checkbox>");
    }
    
    [Fact]
    public void RenderProperly_CheckedIsSet_And_WhenChildContent_AreSet()
    {
        // Arrange & Act
        IRenderedComponent<FastCheckbox> cut = _testContext.RenderComponent<FastCheckbox>(
            parameters => parameters
                .Add(parameter => parameter.IsChecked, true)
                .AddChildContent("childcontent"));
        
        // Assert
        cut.MarkupMatches("<fast-checkbox checked>childcontent</fast-checkbox>");
    }
    
    [Fact]
    public void RenderProperly_DisabledIsSet_And_WhenChildContent_AreSet()
    {
        // Arrange & Act
        IRenderedComponent<FastCheckbox> cut = _testContext.RenderComponent<FastCheckbox>(
            parameters => parameters
                .Add(parameter => parameter.IsDisabled, true)
                .AddChildContent("childcontent"));
        
        // Assert
        cut.MarkupMatches("<fast-checkbox disabled>childcontent</fast-checkbox>");
    }
    
    [Fact]
    public void RenderProperly_RequiredIsSet_And_WhenChildContent_AreSet()
    {
        // Arrange & Act
        IRenderedComponent<FastCheckbox> cut = _testContext.RenderComponent<FastCheckbox>(
            parameters => parameters
                .Add(parameter => parameter.IsRequired, true)
                .AddChildContent("childcontent"));
        
        // Assert
        cut.MarkupMatches("<fast-checkbox required>childcontent</fast-checkbox>");
    }
    
    [Fact]
    public void RenderProperly_ReadonlyIsSet_And_WhenChildContent_AreSet()
    {
        // Arrange & Act
        IRenderedComponent<FastCheckbox> cut = _testContext.RenderComponent<FastCheckbox>(
            parameters => parameters
                .Add(parameter => parameter.IsReadOnly, true)
                .AddChildContent("childcontent"));
        
        // Assert
        cut.MarkupMatches("<fast-checkbox readonly>childcontent</fast-checkbox>");
    }
    
    [Fact]
    public void RenderProperly_AllParamsAreSet()
    {
        // Arrange & Act
        IRenderedComponent<FastCheckbox> cut = _testContext.RenderComponent<FastCheckbox>(
            parameters => parameters
                .Add(parameter => parameter.IsReadOnly, true)
                .Add(parameter => parameter.IsChecked, true)
                .Add(parameter => parameter.IsDisabled, true)
                .Add(parameter => parameter.IsRequired, true)
                .AddChildContent("childcontent"));
        
        // Assert
        cut.MarkupMatches("<fast-checkbox readonly checked disabled required>childcontent</fast-checkbox>");
    }
}
namespace com.encyclopediagalactica.ui.fast.test.unit.FastAvatar;

using System.Diagnostics.CodeAnalysis;
using Bunit;
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
    public void RenderProperly_WhenAllPropertiesAreSet(){}
    
    [Fact]
    public void RenderProperly_WithoutAltTag_WhenAltTagIsNotSetUp(){}
    
    [Fact]
    public void RenderProperly_WithoutHref_WhenHrefIsNotSetUp(){}
    
    [Fact]
    public void RenderProperly_WithoutName_WhenNameIsNotSetUp(){}
    
    [Fact]
    public void RenderProperly_WithoutShape_WhenShapeIsNotSetUp(){}
    
    [Fact]
    public void RenderProperly_WithoutFill_WhenFillIsNotSetUp(){}
}
namespace EncyclopediaGalactica.UI.FAST.Test.Unit.FastButton;

using System.Diagnostics.CodeAnalysis;
using Bunit;
using FAST.FastButton;
using Xunit;
using Xunit.Abstractions;

/// <summary>
///     Tests checking the following cases:
///     <list type="bullets">
///         <item>all params are set</item>
///         <item>a param is not set and it is not generated or falls back to default</item>
///     </list>
/// </summary>
[ExcludeFromCodeCoverage]
[SuppressMessage("ReSharper", "InconsistentNaming")]
public class FastButton_Render_Should
{
    private readonly TestContext _testContext;

    private readonly ITestOutputHelper _testOutputHelper;

    public FastButton_Render_Should(ITestOutputHelper testOutputHelper)
    {
        ArgumentNullException.ThrowIfNull(testOutputHelper);
        _testOutputHelper = testOutputHelper;
        _testContext = new TestContext();
    }

    [Fact]
    public void RenderProperly_WhenAllParams_AreSet()
    {
        // Arrange
        IRenderedComponent<FastButton> cut = _testContext.RenderComponent<FastButton>(
            parameters => parameters
                .Add(href => href.Href, "href")
                .Add(appearance => appearance.Appearance, "appearance")
                .Add(autofocus => autofocus.Autofocus, true)
                .Add(disabled => disabled.Disabled, true)
                .Add(form => form.FormId, "formId")
                .Add(formAction => formAction.FormAction, "formAction")
                .Add(formEnctype => formEnctype.FormEncType, "formEncType")
                .Add(formMethod => formMethod.FormMethod, "formMethod")
                .Add(formNoValidate => formNoValidate.FormNoValidate, true)
                .Add(formTarget => formTarget.FormTarget, "formTarget")
                .Add(name => name.Name, "name")
                .Add(type => type.ButtonType, "button")
                .Add(val => val.Value, "value")
                .AddChildContent("childContent")
        );

        // Assert
        cut.MarkupMatches("<fast-button href=\"href\" " +
                          "appearance=\"appearance\" " +
                          "autofocus=\"\" " +
                          "disabled=\"\" " +
                          "form=\"formId\" " +
                          "formaction=\"formAction\" " +
                          "formenctype=\"formEncType\" " +
                          "formmethod=\"formMethod\" " +
                          "formnovalidate=\"\" " +
                          "formtarget=\"formTarget\" " +
                          "name=\"name\" " +
                          "type=\"button\" " +
                          "value=\"value\">childContent</fast-button>");
    }

    [Fact]
    public void RenderProperly_AndFallBackToDefaultHRef_WhenHref_IsNotSet()
    {
        // Arrange
        IRenderedComponent<FastButton> cut = _testContext.RenderComponent<FastButton>(
            parameters => parameters
                .Add(appearance => appearance.Appearance, "appearance")
                .Add(autofocus => autofocus.Autofocus, true)
                .Add(disabled => disabled.Disabled, true)
                .Add(form => form.FormId, "formId")
                .Add(formAction => formAction.FormAction, "formAction")
                .Add(formEnctype => formEnctype.FormEncType, "formEncType")
                .Add(formMethod => formMethod.FormMethod, "formMethod")
                .Add(formNoValidate => formNoValidate.FormNoValidate, true)
                .Add(formTarget => formTarget.FormTarget, "formTarget")
                .Add(name => name.Name, "name")
                .Add(type => type.ButtonType, "button")
                .Add(val => val.Value, "value")
                .AddChildContent("childContent")
        );

        // Assert
        cut.MarkupMatches("<fast-button " +
                          "href=\"#\" " +
                          "appearance=\"appearance\" " +
                          "autofocus=\"\" " +
                          "disabled=\"\" " +
                          "form=\"formId\" " +
                          "formaction=\"formAction\" " +
                          "formenctype=\"formEncType\" " +
                          "formmethod=\"formMethod\" " +
                          "formnovalidate=\"\" " +
                          "formtarget=\"formTarget\" " +
                          "name=\"name\" " +
                          "type=\"button\" " +
                          "value=\"value\">childContent</fast-button>");
    }

    [Fact]
    public void RenderProperly_AndFallBackToDefaultAppearance_WhenAppearance_IsNotSet()
    {
        // Arrange
        IRenderedComponent<FastButton> cut = _testContext.RenderComponent<FastButton>(
            parameters => parameters
                .Add(href => href.Href, "href")
                .Add(autofocus => autofocus.Autofocus, true)
                .Add(disabled => disabled.Disabled, true)
                .Add(form => form.FormId, "formId")
                .Add(formAction => formAction.FormAction, "formAction")
                .Add(formEnctype => formEnctype.FormEncType, "formEncType")
                .Add(formMethod => formMethod.FormMethod, "formMethod")
                .Add(formNoValidate => formNoValidate.FormNoValidate, true)
                .Add(formTarget => formTarget.FormTarget, "formTarget")
                .Add(name => name.Name, "name")
                .Add(type => type.ButtonType, "button")
                .Add(val => val.Value, "value")
                .AddChildContent("childContent")
        );

        // Assert
        cut.MarkupMatches("<fast-button " +
                          "href=\"href\" " +
                          "appearance=\"neutral\" " +
                          "autofocus=\"\" " +
                          "disabled=\"\" " +
                          "form=\"formId\" " +
                          "formaction=\"formAction\" " +
                          "formenctype=\"formEncType\" " +
                          "formmethod=\"formMethod\" " +
                          "formnovalidate=\"\" " +
                          "formtarget=\"formTarget\" " +
                          "name=\"name\" " +
                          "type=\"button\" " +
                          "value=\"value\">childContent</fast-button>");
    }

    [Fact]
    public void RenderProperly_AndFallBackToAutofocusDefaultValue_WhenAutofocus_IsNotSet()
    {
        // Arrange
        IRenderedComponent<FastButton> cut = _testContext.RenderComponent<FastButton>(
            parameters => parameters
                .Add(href => href.Href, "href")
                .Add(appearance => appearance.Appearance, "appearance")
                .Add(disabled => disabled.Disabled, true)
                .Add(form => form.FormId, "formId")
                .Add(formAction => formAction.FormAction, "formAction")
                .Add(formEnctype => formEnctype.FormEncType, "formEncType")
                .Add(formMethod => formMethod.FormMethod, "formMethod")
                .Add(formNoValidate => formNoValidate.FormNoValidate, true)
                .Add(formTarget => formTarget.FormTarget, "formTarget")
                .Add(name => name.Name, "name")
                .Add(type => type.ButtonType, "button")
                .Add(val => val.Value, "value")
                .AddChildContent("childContent")
        );

        // Assert
        cut.MarkupMatches("<fast-button " +
                          "href=\"href\" " +
                          "appearance=\"appearance\" " +
                          "disabled=\"\" " +
                          "form=\"formId\" " +
                          "formaction=\"formAction\" " +
                          "formenctype=\"formEncType\" " +
                          "formmethod=\"formMethod\" " +
                          "formnovalidate=\"\" " +
                          "formtarget=\"formTarget\" " +
                          "name=\"name\" " +
                          "type=\"button\" " +
                          "value=\"value\">childContent</fast-button>");
    }

    [Fact]
    public void RenderProperly_AndFallBackToDisabledDefaultValue_WhenDisabled_IsNotSet()
    {
        // Arrange
        IRenderedComponent<FastButton> cut = _testContext.RenderComponent<FastButton>(
            parameters => parameters
                .Add(href => href.Href, "href")
                .Add(appearance => appearance.Appearance, "appearance")
                .Add(autofocus => autofocus.Autofocus, true)
                .Add(form => form.FormId, "formId")
                .Add(formAction => formAction.FormAction, "formAction")
                .Add(formEnctype => formEnctype.FormEncType, "formEncType")
                .Add(formMethod => formMethod.FormMethod, "formMethod")
                .Add(formNoValidate => formNoValidate.FormNoValidate, true)
                .Add(formTarget => formTarget.FormTarget, "formTarget")
                .Add(name => name.Name, "name")
                .Add(type => type.ButtonType, "button")
                .Add(val => val.Value, "value")
                .AddChildContent("childContent")
        );

        // Assert
        cut.MarkupMatches("<fast-button " +
                          "href=\"href\" " +
                          "appearance=\"appearance\" " +
                          "autofocus=\"\" " +
                          "form=\"formId\" " +
                          "formaction=\"formAction\" " +
                          "formenctype=\"formEncType\" " +
                          "formmethod=\"formMethod\" " +
                          "formnovalidate=\"\" " +
                          "formtarget=\"formTarget\" " +
                          "name=\"name\" " +
                          "type=\"button\" " +
                          "value=\"value\">childContent</fast-button>");
    }

    [Fact]
    public void RenderProperly_WhenFormId_IsNotSet()
    {
        // Arrange
        IRenderedComponent<FastButton> cut = _testContext.RenderComponent<FastButton>(
            parameters => parameters
                .Add(href => href.Href, "href")
                .Add(appearance => appearance.Appearance, "appearance")
                .Add(autofocus => autofocus.Autofocus, true)
                .Add(disabled => disabled.Disabled, true)
                .Add(formAction => formAction.FormAction, "formAction")
                .Add(formEnctype => formEnctype.FormEncType, "formEncType")
                .Add(formMethod => formMethod.FormMethod, "formMethod")
                .Add(formNoValidate => formNoValidate.FormNoValidate, true)
                .Add(formTarget => formTarget.FormTarget, "formTarget")
                .Add(name => name.Name, "name")
                .Add(type => type.ButtonType, "button")
                .Add(val => val.Value, "value")
                .AddChildContent("childContent")
        );

        // Assert
        cut.MarkupMatches("<fast-button " +
                          "href=\"href\" " +
                          "appearance=\"appearance\" " +
                          "autofocus=\"\" " +
                          "disabled=\"\" " +
                          "formaction=\"formAction\" " +
                          "formenctype=\"formEncType\" " +
                          "formmethod=\"formMethod\" " +
                          "formnovalidate=\"\" " +
                          "formtarget=\"formTarget\" " +
                          "name=\"name\" " +
                          "type=\"button\" " +
                          "value=\"value\">childContent</fast-button>");
    }

    [Fact]
    public void RenderProperly_WhenFormAction_IsNotSet()
    {
        // Arrange
        IRenderedComponent<FastButton> cut = _testContext.RenderComponent<FastButton>(
            parameters => parameters
                .Add(href => href.Href, "href")
                .Add(appearance => appearance.Appearance, "appearance")
                .Add(autofocus => autofocus.Autofocus, true)
                .Add(disabled => disabled.Disabled, true)
                .Add(form => form.FormId, "formId")
                .Add(formEnctype => formEnctype.FormEncType, "formEncType")
                .Add(formMethod => formMethod.FormMethod, "formMethod")
                .Add(formNoValidate => formNoValidate.FormNoValidate, true)
                .Add(formTarget => formTarget.FormTarget, "formTarget")
                .Add(name => name.Name, "name")
                .Add(type => type.ButtonType, "button")
                .Add(val => val.Value, "value")
                .AddChildContent("childContent")
        );

        // Assert
        cut.MarkupMatches("<fast-button " +
                          "href=\"href\" " +
                          "appearance=\"appearance\" " +
                          "autofocus=\"\" " +
                          "disabled=\"\" " +
                          "form=\"formId\" " +
                          "formenctype=\"formEncType\" " +
                          "formmethod=\"formMethod\" " +
                          "formnovalidate=\"\" " +
                          "formtarget=\"formTarget\" " +
                          "name=\"name\" " +
                          "type=\"button\" " +
                          "value=\"value\">childContent</fast-button>");
    }

    [Fact]
    public void RenderProperly_WhenFormEncType_IsNotSet()
    {
        // Arrange
        IRenderedComponent<FastButton> cut = _testContext.RenderComponent<FastButton>(
            parameters => parameters
                .Add(href => href.Href, "href")
                .Add(appearance => appearance.Appearance, "appearance")
                .Add(autofocus => autofocus.Autofocus, true)
                .Add(disabled => disabled.Disabled, true)
                .Add(form => form.FormId, "formId")
                .Add(formAction => formAction.FormAction, "formAction")
                .Add(formMethod => formMethod.FormMethod, "formMethod")
                .Add(formNoValidate => formNoValidate.FormNoValidate, true)
                .Add(formTarget => formTarget.FormTarget, "formTarget")
                .Add(name => name.Name, "name")
                .Add(type => type.ButtonType, "button")
                .Add(val => val.Value, "value")
                .AddChildContent("childContent")
        );

        // Assert
        cut.MarkupMatches("<fast-button " +
                          "href=\"href\" " +
                          "appearance=\"appearance\" " +
                          "autofocus=\"\" " +
                          "disabled=\"\" " +
                          "form=\"formId\" " +
                          "formaction=\"formAction\" " +
                          "formmethod=\"formMethod\" " +
                          "formnovalidate=\"\" " +
                          "formtarget=\"formTarget\" " +
                          "name=\"name\" " +
                          "type=\"button\" " +
                          "value=\"value\">childContent</fast-button>");
    }

    [Fact]
    public void RenderProperly_WhenFormMethod_IsNotSet()
    {
        // Arrange
        IRenderedComponent<FastButton> cut = _testContext.RenderComponent<FastButton>(
            parameters => parameters
                .Add(href => href.Href, "href")
                .Add(appearance => appearance.Appearance, "appearance")
                .Add(autofocus => autofocus.Autofocus, true)
                .Add(disabled => disabled.Disabled, true)
                .Add(form => form.FormId, "formId")
                .Add(formAction => formAction.FormAction, "formAction")
                .Add(formEnctype => formEnctype.FormEncType, "formEncType")
                .Add(formNoValidate => formNoValidate.FormNoValidate, true)
                .Add(formTarget => formTarget.FormTarget, "formTarget")
                .Add(name => name.Name, "name")
                .Add(type => type.ButtonType, "button")
                .Add(val => val.Value, "value")
                .AddChildContent("childContent")
        );

        // Assert
        cut.MarkupMatches("<fast-button " +
                          "href=\"href\" " +
                          "appearance=\"appearance\" " +
                          "autofocus=\"\" " +
                          "disabled=\"\" " +
                          "form=\"formId\" " +
                          "formaction=\"formAction\" " +
                          "formenctype=\"formEncType\" " +
                          "formnovalidate=\"\" " +
                          "formtarget=\"formTarget\" " +
                          "name=\"name\" " +
                          "type=\"button\" " +
                          "value=\"value\">childContent</fast-button>");
    }

    [Fact]
    public void RenderProperly_WhenFormNoValidate_IsNotSet()
    {
        // Arrange
        IRenderedComponent<FastButton> cut = _testContext.RenderComponent<FastButton>(
            parameters => parameters
                .Add(href => href.Href, "href")
                .Add(appearance => appearance.Appearance, "appearance")
                .Add(autofocus => autofocus.Autofocus, true)
                .Add(disabled => disabled.Disabled, true)
                .Add(form => form.FormId, "formId")
                .Add(formAction => formAction.FormAction, "formAction")
                .Add(formEnctype => formEnctype.FormEncType, "formEncType")
                .Add(formMethod => formMethod.FormMethod, "formMethod")
                .Add(formTarget => formTarget.FormTarget, "formTarget")
                .Add(name => name.Name, "name")
                .Add(type => type.ButtonType, "button")
                .Add(val => val.Value, "value")
                .AddChildContent("childContent")
        );

        // Assert
        cut.MarkupMatches("<fast-button " +
                          "href=\"href\" " +
                          "appearance=\"appearance\" " +
                          "autofocus=\"\" " +
                          "disabled=\"\" " +
                          "form=\"formId\" " +
                          "formaction=\"formAction\" " +
                          "formenctype=\"formEncType\" " +
                          "formmethod=\"formMethod\" " +
                          "formtarget=\"formTarget\" " +
                          "name=\"name\" " +
                          "type=\"button\" " +
                          "value=\"value\">childContent</fast-button>");
    }

    [Fact]
    public void RenderProperly_WhenFormTarget_IsNotSet()
    {
        // Arrange
        IRenderedComponent<FastButton> cut = _testContext.RenderComponent<FastButton>(
            parameters => parameters
                .Add(href => href.Href, "href")
                .Add(appearance => appearance.Appearance, "appearance")
                .Add(autofocus => autofocus.Autofocus, true)
                .Add(disabled => disabled.Disabled, true)
                .Add(form => form.FormId, "formId")
                .Add(formAction => formAction.FormAction, "formAction")
                .Add(formEnctype => formEnctype.FormEncType, "formEncType")
                .Add(formMethod => formMethod.FormMethod, "formMethod")
                .Add(formNoValidate => formNoValidate.FormNoValidate, true)
                .Add(name => name.Name, "name")
                .Add(type => type.ButtonType, "button")
                .Add(val => val.Value, "value")
                .AddChildContent("childContent")
        );

        // Assert
        cut.MarkupMatches("<fast-button " +
                          "href=\"href\" " +
                          "appearance=\"appearance\" " +
                          "autofocus=\"\" " +
                          "disabled=\"\" " +
                          "form=\"formId\" " +
                          "formaction=\"formAction\" " +
                          "formenctype=\"formEncType\" " +
                          "formmethod=\"formMethod\" " +
                          "formnovalidate=\"\" " +
                          "name=\"name\" " +
                          "type=\"button\" " +
                          "value=\"value\">childContent</fast-button>");
    }

    [Fact]
    public void RenderProperly_WhenName_IsNotSet()
    {
        // Arrange
        IRenderedComponent<FastButton> cut = _testContext.RenderComponent<FastButton>(
            parameters => parameters
                .Add(href => href.Href, "href")
                .Add(appearance => appearance.Appearance, "appearance")
                .Add(autofocus => autofocus.Autofocus, true)
                .Add(disabled => disabled.Disabled, true)
                .Add(form => form.FormId, "formId")
                .Add(formAction => formAction.FormAction, "formAction")
                .Add(formEnctype => formEnctype.FormEncType, "formEncType")
                .Add(formMethod => formMethod.FormMethod, "formMethod")
                .Add(formNoValidate => formNoValidate.FormNoValidate, true)
                .Add(formTarget => formTarget.FormTarget, "formTarget")
                .Add(type => type.ButtonType, "button")
                .Add(val => val.Value, "value")
                .AddChildContent("childContent")
        );

        // Assert
        cut.MarkupMatches("<fast-button " +
                          "href=\"href\" " +
                          "appearance=\"appearance\" " +
                          "autofocus=\"\" " +
                          "disabled=\"\" " +
                          "form=\"formId\" " +
                          "formaction=\"formAction\" " +
                          "formenctype=\"formEncType\" " +
                          "formmethod=\"formMethod\" " +
                          "formnovalidate=\"\" " +
                          "formtarget=\"formTarget\" " +
                          "type=\"button\" " +
                          "value=\"value\">childContent</fast-button>");
    }

    [Fact]
    public void RenderProperly_AndFallBackToButtonTypeDefaultValue_WhenType_IsNotSet()
    {
        // Arrange
        IRenderedComponent<FastButton> cut = _testContext.RenderComponent<FastButton>(
            parameters => parameters
                .Add(href => href.Href, "href")
                .Add(appearance => appearance.Appearance, "appearance")
                .Add(autofocus => autofocus.Autofocus, true)
                .Add(disabled => disabled.Disabled, true)
                .Add(form => form.FormId, "formId")
                .Add(formAction => formAction.FormAction, "formAction")
                .Add(formEnctype => formEnctype.FormEncType, "formEncType")
                .Add(formMethod => formMethod.FormMethod, "formMethod")
                .Add(formNoValidate => formNoValidate.FormNoValidate, true)
                .Add(formTarget => formTarget.FormTarget, "formTarget")
                .Add(name => name.Name, "name")
                .Add(val => val.Value, "value")
                .AddChildContent("childContent")
        );

        // Assert
        cut.MarkupMatches("<fast-button " +
                          "href=\"href\" " +
                          "appearance=\"appearance\" " +
                          "autofocus=\"\" " +
                          "disabled=\"\" " +
                          "form=\"formId\" " +
                          "formaction=\"formAction\" " +
                          "formenctype=\"formEncType\" " +
                          "formmethod=\"formMethod\" " +
                          "formnovalidate=\"\" " +
                          "formtarget=\"formTarget\" " +
                          "name=\"name\" " +
                          "type=\"button\" " +
                          "value=\"value\">childContent</fast-button>");
    }

    [Fact]
    public void RenderProperly_WhenValue_IsNotSet()
    {
        // Arrange
        IRenderedComponent<FastButton> cut = _testContext.RenderComponent<FastButton>(
            parameters => parameters
                .Add(href => href.Href, "href")
                .Add(appearance => appearance.Appearance, "appearance")
                .Add(autofocus => autofocus.Autofocus, true)
                .Add(disabled => disabled.Disabled, true)
                .Add(form => form.FormId, "formId")
                .Add(formAction => formAction.FormAction, "formAction")
                .Add(formEnctype => formEnctype.FormEncType, "formEncType")
                .Add(formMethod => formMethod.FormMethod, "formMethod")
                .Add(formNoValidate => formNoValidate.FormNoValidate, true)
                .Add(formTarget => formTarget.FormTarget, "formTarget")
                .Add(name => name.Name, "name")
                .Add(type => type.ButtonType, "button")
                .AddChildContent("childContent")
        );

        // Assert
        cut.MarkupMatches("<fast-button " +
                          "href=\"href\" " +
                          "appearance=\"appearance\" " +
                          "autofocus=\"\" " +
                          "disabled=\"\" " +
                          "form=\"formId\" " +
                          "formaction=\"formAction\" " +
                          "formenctype=\"formEncType\" " +
                          "formmethod=\"formMethod\" " +
                          "formnovalidate=\"\" " +
                          "formtarget=\"formTarget\" " +
                          "name=\"name\" " +
                          "type=\"button\" " +
                          ">childContent</fast-button>");
    }

    [Fact]
    public void RenderProperly_WhenChildContent_IsNotSet()
    {
        // Arrange
        IRenderedComponent<FastButton> cut = _testContext.RenderComponent<FastButton>(
            parameters => parameters
                .Add(href => href.Href, "href")
                .Add(appearance => appearance.Appearance, "appearance")
                .Add(autofocus => autofocus.Autofocus, true)
                .Add(disabled => disabled.Disabled, true)
                .Add(form => form.FormId, "formId")
                .Add(formAction => formAction.FormAction, "formAction")
                .Add(formEnctype => formEnctype.FormEncType, "formEncType")
                .Add(formMethod => formMethod.FormMethod, "formMethod")
                .Add(formNoValidate => formNoValidate.FormNoValidate, true)
                .Add(formTarget => formTarget.FormTarget, "formTarget")
                .Add(name => name.Name, "name")
                .Add(type => type.ButtonType, "button")
                .Add(val => val.Value, "value")
        );

        // Assert
        cut.MarkupMatches("<fast-button " +
                          "href=\"href\" " +
                          "appearance=\"appearance\" " +
                          "autofocus=\"\" " +
                          "disabled=\"\" " +
                          "form=\"formId\" " +
                          "formaction=\"formAction\" " +
                          "formenctype=\"formEncType\" " +
                          "formmethod=\"formMethod\" " +
                          "formnovalidate=\"\" " +
                          "formtarget=\"formTarget\" " +
                          "name=\"name\" " +
                          "type=\"button\" " +
                          "value=\"value\"></fast-button>");
    }
}
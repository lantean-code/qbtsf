using AwesomeAssertions;
using Lantean.QBTSF.Components.UI;
using Lantean.QBTSF.Test.Infrastructure;

namespace Lantean.QBTSF.Test.Components.UI
{
    public sealed class NonRenderingTests : RazorComponentTestBase<NonRendering>
    {
        [Fact]
        public void GIVEN_ChildContent_WHEN_Rendered_THEN_ShouldRenderChildContent()
        {
            var target = TestContext.Render<NonRendering>(parameters =>
            {
                parameters.Add(p => p.ChildContent, builder => builder.AddContent(0, "ChildContent"));
            });

            target.Markup.Should().Be("ChildContent");
        }
    }
}

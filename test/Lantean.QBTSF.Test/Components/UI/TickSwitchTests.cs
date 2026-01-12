using AwesomeAssertions;
using Lantean.QBTSF.Components.UI;
using Lantean.QBTSF.Test.Infrastructure;
using MudBlazor;

namespace Lantean.QBTSF.Test.Components.UI
{
    public sealed class TickSwitchTests : RazorComponentTestBase
    {
        [Fact]
        public void GIVEN_ValueTrue_WHEN_Rendered_THEN_ShouldUseSuccessIcon()
        {
            var target = TestContext.Render<TickSwitch<bool>>(parameters =>
            {
                parameters.Add(p => p.Value, true);
            });

            target.Instance.ThumbIcon.Should().Be(Icons.Material.Filled.Done);
            target.Instance.ThumbIconColor.Should().Be(Color.Success);
        }

        [Fact]
        public void GIVEN_ValueFalse_WHEN_Rendered_THEN_ShouldUseErrorIcon()
        {
            var target = TestContext.Render<TickSwitch<bool>>(parameters =>
            {
                parameters.Add(p => p.Value, false);
            });

            target.Instance.ThumbIcon.Should().Be(Icons.Material.Filled.Close);
            target.Instance.ThumbIconColor.Should().Be(Color.Error);
        }
    }
}

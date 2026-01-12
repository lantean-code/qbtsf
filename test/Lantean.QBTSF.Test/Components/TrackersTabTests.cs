using AwesomeAssertions;
using Bunit;
using Lantean.QBTSF.Components;
using Lantean.QBTSF.Helpers;
using Lantean.QBTSF.Services;
using Lantean.QBTSF.Test.Infrastructure;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using Moq;

namespace Lantean.QBTSF.Test.Components
{
    public sealed class TrackersTabTests : RazorComponentTestBase
    {
        private readonly FakePeriodicTimer _timer;
        private readonly IRenderedComponent<TrackersTab> _target;

        public TrackersTabTests()
        {
            TestContext.UseApiClientMock(MockBehavior.Strict);
            TestContext.AddSingletonMock<IDialogWorkflow>(MockBehavior.Strict);

            _timer = new FakePeriodicTimer();
            TestContext.Services.RemoveAll(typeof(IPeriodicTimerFactory));
            TestContext.Services.AddSingleton<IPeriodicTimerFactory>(new FakePeriodicTimerFactory(_timer));

            _target = TestContext.Render<TrackersTab>(parameters =>
            {
                parameters.Add(p => p.Active, false);
                parameters.Add(p => p.Hash, "Hash");
                parameters.AddCascadingValue("RefreshInterval", 10);
            });
        }

        [Fact]
        public async Task GIVEN_InactiveTab_WHEN_TimerTicks_THEN_DoesNotRender()
        {
            var initialRenderCount = _target.RenderCount;

            await _timer.TriggerTickAsync();
            await _target.InvokeAsync(() => Task.CompletedTask);

            _target.RenderCount.Should().Be(initialRenderCount);
        }
    }
}

using Microsoft.AspNetCore.Components;

namespace Lantean.QBTSF
{
    [EventHandler("onlongpress", typeof(LongPressEventArgs), enableStopPropagation: true, enablePreventDefault: true)]
    public static class EventHandlers
    {
    }
}

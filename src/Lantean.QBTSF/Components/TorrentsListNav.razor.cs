using Lantean.QBTSF.Models;
using Microsoft.AspNetCore.Components;

namespace Lantean.QBTSF.Components
{
    public partial class TorrentsListNav
    {
        [Inject]
        protected NavigationManager NavigationManager { get; set; } = default!;

        [Parameter]
        public IEnumerable<Torrent>? Torrents { get; set; }

        protected void NavigateBack()
        {
            NavigationManager.NavigateToHome();
        }
    }
}

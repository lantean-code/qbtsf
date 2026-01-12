using Lantean.QBTSF.Models;

namespace Lantean.QBTSF.Services
{
    public interface IRssDataManager
    {
        RssList CreateRssList(IReadOnlyDictionary<string, QBitTorrentClient.Models.RssItem> rssItems);
    }
}
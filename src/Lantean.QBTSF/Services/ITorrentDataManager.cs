using Lantean.QBTSF.Models;

namespace Lantean.QBTSF.Services
{
    public interface ITorrentDataManager
    {
        MainData CreateMainData(QBitTorrentClient.Models.MainData mainData);

        Torrent CreateTorrent(string hash, QBitTorrentClient.Models.Torrent torrent);

        bool MergeMainData(QBitTorrentClient.Models.MainData mainData, MainData torrentList, out bool filterChanged);

        Dictionary<string, ContentItem> CreateContentsList(IReadOnlyList<QBitTorrentClient.Models.FileData> files);

        bool MergeContentsList(IReadOnlyList<QBitTorrentClient.Models.FileData> files, Dictionary<string, ContentItem> contents);
    }
}
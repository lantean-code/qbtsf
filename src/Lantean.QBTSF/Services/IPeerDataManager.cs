using Lantean.QBTSF.Models;

namespace Lantean.QBTSF.Services
{
    public interface IPeerDataManager
    {
        PeerList CreatePeerList(QBitTorrentClient.Models.TorrentPeers torrentPeers);

        void MergeTorrentPeers(QBitTorrentClient.Models.TorrentPeers torrentPeers, PeerList peerList);
    }
}
namespace Lantean.QBTSF.Services
{
    public interface IPreferencesDataManager
    {
        QBitTorrentClient.Models.UpdatePreferences MergePreferences(QBitTorrentClient.Models.UpdatePreferences? original, QBitTorrentClient.Models.UpdatePreferences changed);
    }
}
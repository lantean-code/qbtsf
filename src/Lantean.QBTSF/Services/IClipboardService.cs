namespace Lantean.QBTSF.Services
{
    public interface IClipboardService
    {
        Task WriteToClipboard(string text);
    }
}
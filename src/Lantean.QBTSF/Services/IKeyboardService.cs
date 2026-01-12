using Lantean.QBTSF.Models;

namespace Lantean.QBTSF.Services
{
    public interface IKeyboardService
    {
        Task Focus();

        Task UnFocus();

        Task RegisterKeypressEvent(KeyboardEvent criteria, Func<KeyboardEvent, Task> onKeyPress);

        Task UnregisterKeypressEvent(KeyboardEvent criteria);
    }
}
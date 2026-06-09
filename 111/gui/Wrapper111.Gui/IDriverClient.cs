namespace Wrapper111.Gui
{
    public interface IDriverClient
    {
        // Async APIs used by ViewModel
        System.Threading.Tasks.Task<(bool ok, int win32Error, string errorMessage)> TrySetWatermarkAsync(bool enable, System.Threading.CancellationToken cancellationToken = default);
        System.Threading.Tasks.Task<(bool ok, string status, int win32Error, string errorMessage)> TryGetStatusAsync(System.Threading.CancellationToken cancellationToken = default);

        // Synchronous convenience APIs used by legacy UI code
        bool TrySetWatermark(bool enable, out int win32Error, out string errorMessage);
        bool TryGetStatus(out string status, out int win32Error, out string errorMessage);
    }
}

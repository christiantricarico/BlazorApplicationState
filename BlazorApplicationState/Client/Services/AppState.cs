using Microsoft.AspNetCore.Components;

namespace BlazorApplicationState.Client.Services
{
    public class AppState
    {
        public event Action<ComponentBase, string> StateChanged;

        public string Message { get; private set; } = string.Empty;
        public bool Enabled { get; private set; } = false;
        public int Counter { get; private set; } = 0;

        public void UpdateMessage(ComponentBase source, string message)
        {
            Message = message;
            NotifyStateChanged(source, nameof(Message));
        }

        public void UpdateEnabled(ComponentBase source, bool enabled)
        {
            Enabled = enabled;
            NotifyStateChanged(source, nameof(Enabled));
        }

        public void UpdateCounter(ComponentBase source, int counter)
        {
            Counter = counter;
            NotifyStateChanged(source, nameof(Counter));
        }

        private void NotifyStateChanged(ComponentBase source, string property) => StateChanged?.Invoke(source, property);
    }
}

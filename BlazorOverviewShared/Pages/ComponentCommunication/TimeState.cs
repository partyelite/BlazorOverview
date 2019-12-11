using System;

namespace BlazorOverviewShared.Pages.ComponentCommunication
{
    public class TimeState
    {
        public string SelectedTime { get; set; } = DateTime.Now.ToLongTimeString();
        public event Action OnChange;

        public void UpdateTime(string time)
        {
            SelectedTime = time;
            NotifyStateChanged();
        }

        private void NotifyStateChanged() => OnChange?.Invoke();
    }
}

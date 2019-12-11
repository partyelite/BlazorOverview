using Microsoft.AspNetCore.Components;

namespace BlazorOverviewShared.Pages.User
{
    public class ComponentBase<T> : ComponentBase where T : new()
    {
        protected T DataContext = new T();

        [Inject] 
        protected UserMock MockData { get; set; }

        protected override void OnInitialized()
        {
            (DataContext as UserModel).Level = 10;
        }

        protected virtual void UpdateData()
        {
            (DataContext as UserModel).Name = MockData.GetNextName();
            (DataContext as UserModel).LastName = MockData.GetNextLastName();
            (DataContext as UserModel).Level = MockData.GetNextLevel();
        }
    }
}

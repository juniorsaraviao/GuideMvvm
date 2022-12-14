using GuideMvvm.Model;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace GuideMvvm.ViewModel
{
   public class SecondPageViewModel : BaseViewModel
   {
      public List<User> UserList { get; set; }
      public ICommand BackCommand { get; }
      public ICommand AlertCommand { get; }
      public SecondPageViewModel(INavigation navigation)
      {
         Navigation = navigation;
         BackCommand = new Command(async () => await BackNavigation());
         AlertCommand = new Command<User>(async (user) => await AlertMessage(user));
         AddUsers();
      }

      async Task BackNavigation()
      {
         await Navigation.PopAsync();
      }

      async Task AlertMessage(User user)
      {
         if (user == null)
         {
            return;
         }
         await DisplayAlert("Title", $"Message to: {user.Name}", "Ok");
      }

      void AddUsers()
      {
         UserList = new List<User>
         {
            new User
            {
               Name = "User 1",
               Image = "https://i.ibb.co/gvpcDWw/pescado.png"
            },
            new User
            {
               Name = "User 2",
               Image = "https://i.ibb.co/RSrm1rJ/pulpo.png"
            },
            new User
            {
               Name = "User 3",
               Image = "https://i.ibb.co/RSrm1rJ/pulpo.png"
            }
         };
      }
   }
}

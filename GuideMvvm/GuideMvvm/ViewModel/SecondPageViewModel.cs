using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace GuideMvvm.ViewModel
{
   public class SecondPageViewModel : BaseViewModel
   {
      public ICommand BackCommand { get; }
      public SecondPageViewModel(INavigation navigation)
      {
         Navigation = navigation;
         BackCommand = new Command(async () => await BackNavigation());
      }

      async Task BackNavigation()
      {
         await Navigation.PopAsync();
      }
   }
}

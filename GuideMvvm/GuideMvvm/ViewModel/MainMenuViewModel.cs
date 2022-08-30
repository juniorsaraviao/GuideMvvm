using GuideMvvm.Model;
using GuideMvvm.Views;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace GuideMvvm.ViewModel
{
   public class MainMenuViewModel : BaseViewModel
   {
      public List<MainMenuItem> MenuItems { get; set; }
      public ICommand NavigateCommand { get; }
      public MainMenuViewModel(INavigation navigation)
      {
         Navigation = navigation;
         NavigateCommand = new Command<MainMenuItem>(async (user) => await Navigate(user));
         ShowPages();
      }

      async Task Navigate(MainMenuItem menuItem)
      {
         if (menuItem == null)
         {
            return;
         }

         if (menuItem.Page.Contains("Entry, Date Picker"))
         {
            await Navigation.PushAsync(new InitialPage());
         }

         if (menuItem.Page.Contains("CollectionView"))
         {
            await Navigation.PushAsync(new SecondPage());
         }

         if (menuItem.Page.Contains("Pokemon CRUD"))
         {
            await Navigation.PushAsync(new PokemonCrud());
         }
      }

      void ShowPages()
      {
         MenuItems = new List<MainMenuItem>
         {
            new MainMenuItem
            {
               Page = "Entry, Date Picker, Picker, Label, Navigation",
               Icon = "https://i.ibb.co/gvpcDWw/pescado.png"
            },
            new MainMenuItem
            {
               Page = "CollectionView",
               Icon = "https://i.ibb.co/RSrm1rJ/pulpo.png"
            },
            new MainMenuItem
            {
               Page = "Pokemon CRUD",
               Icon = "https://i.ibb.co/frKbb18/snorlax-1.png"
            }
         };
      }
   }
}

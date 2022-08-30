using GuideMvvm.ViewModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace GuideMvvm.Views
{
   [XamlCompilation(XamlCompilationOptions.Compile)]
   public partial class MainMenu : ContentPage
   {
      public MainMenu()
      {
         InitializeComponent();
         BindingContext = new MainMenuViewModel(Navigation);
      }
   }
}
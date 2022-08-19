using GuideMvvm.ViewModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace GuideMvvm.Views
{
   [XamlCompilation(XamlCompilationOptions.Compile)]
   public partial class InitialPage : ContentPage
   {
      public InitialPage()
      {
         InitializeComponent();
         BindingContext = new InitialViewModel(Navigation);
      }
   }
}
using GuideMvvm.ViewModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace GuideMvvm.Views
{
   [XamlCompilation(XamlCompilationOptions.Compile)]
   public partial class SecondPage : ContentPage
   {
      public SecondPage()
      {
         InitializeComponent();
         BindingContext = new SecondPageViewModel(Navigation);
      }
   }
}
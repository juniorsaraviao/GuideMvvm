using GuideMvvm.Views;
using Plugin.SharedTransitions;
using Xamarin.Forms;

namespace GuideMvvm
{
   public partial class App : Application
   {
      public App()
      {
         InitializeComponent();

         MainPage = new SharedTransitionNavigationPage(new InitialPage());
      }

      protected override void OnStart()
      {
      }

      protected override void OnSleep()
      {
      }

      protected override void OnResume()
      {
      }
   }
}

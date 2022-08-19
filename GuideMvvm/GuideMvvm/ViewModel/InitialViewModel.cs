using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace GuideMvvm.ViewModel
{
   public class InitialViewModel : BaseViewModel
   {
      string text;
      string mensaje;
      string numberOne;
      string numberTwo;
      string sum;

      public ICommand ShowAlertCommand { get; }
      public ICommand SimpleProcessCommand { get; }

      public InitialViewModel(INavigation navigation)
      {
         Navigation = navigation;
         ShowAlertCommand = new Command(async () => await ShowAlertAsync());
         SimpleProcessCommand = new Command(SimpleProcess);
      }

      public string Text
      {
         get => text;
         set => SetProperty(ref text, value);
      }

      public string Mensaje
      {
         get => mensaje;
         set => SetProperty(ref mensaje, value);
      }

      public string NumberOne
      {
         get => numberOne;
         set => SetProperty(ref numberOne, value);
      }

      public string NumberTwo
      {
         get => numberTwo;
         set => SetProperty(ref numberTwo, value);
      }

      public string Sum
      {
         get => sum;
         set => SetProperty(ref sum, value);
      }

      public async Task ShowAlertAsync()
      {
         await DisplayAlert("Title", Mensaje, "Ok");
      }

      void SimpleProcess()
      {
         var sum = (int.TryParse(numberOne, out var numOne) ? numOne : 0) + (int.TryParse(numberTwo, out var numTwo) ? numTwo : 0);
         Sum = sum.ToString();
      }
   }
}

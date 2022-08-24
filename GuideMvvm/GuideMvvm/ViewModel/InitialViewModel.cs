using GuideMvvm.Views;
using System;
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
      string userType;
      string resultDate;
      DateTime date;

      public ICommand ShowAlertCommand { get; }
      public ICommand SimpleProcessCommand { get; }
      public ICommand NavigateNextCommand { get; }

      public InitialViewModel(INavigation navigation)
      {
         Navigation = navigation;
         ShowAlertCommand = new Command(async () => await ShowAlertAsync());
         SimpleProcessCommand = new Command(SimpleProcess);
         NavigateNextCommand = new Command(async () => await NavigateNext());
         Date = DateTime.Now;
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

      public string UserType
      {
         get => userType;
         set => SetProperty(ref userType, value);
      }

      public string ResultDate
      {
         get => resultDate;
         set => SetProperty(ref resultDate, value);
      }

      public string SelectedTypeUser
      {
         get => userType;
         set
         {
            if (SetProperty(ref userType, value))
            {
               UserType = userType;
            }
         }
      }

      public DateTime Date
      {
         get => date;
         set
         {
            if (SetProperty(ref date, value))
            {
               ResultDate = date.ToString("dd/MM/yyyy");
            }
         }
      }

      public async Task ShowAlertAsync()
      {
         await DisplayAlert("Title", Mensaje, "Ok");
      }

      public async Task NavigateNext()
      {
         await Navigation.PushAsync(new SecondPage());
      }

      void SimpleProcess()
      {
         var sum = (int.TryParse(numberOne, out var numOne) ? numOne : 0) + (int.TryParse(numberTwo, out var numTwo) ? numTwo : 0);
         Sum = sum.ToString();
      }
   }
}

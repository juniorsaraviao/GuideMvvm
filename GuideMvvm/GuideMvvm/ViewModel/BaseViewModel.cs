using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace GuideMvvm.ViewModel
{
   public class BaseViewModel : INotifyPropertyChanged
   {
      public INavigation Navigation;      
      public event PropertyChangedEventHandler PropertyChanged;

      private ImageSource photo;
      public ImageSource Photo
      {
         get => photo;
         set => SetProperty(ref photo, value);
      }

      private string title;
      public string Title
      {
         get => title;
         set => SetProperty(ref title, value);         
      }

      private bool isBusy;
      public bool IsBusy
      {
         get => isBusy;
         set => SetProperty(ref isBusy, value);
      }      

      public async Task DisplayAlert(string title, string message, string cancel)
      {
         await Application.Current.MainPage.DisplayAlert(title, message, cancel);
      }

      public async Task<bool> DisplayAlert(string title, string message, string accept, string cancel)
      {
         return await Application.Current.MainPage.DisplayAlert(title, message, accept, cancel);
      }

      protected bool SetProperty<T>(ref T field, T value, [CallerMemberName] string propertyName = null)
      {
         if (EqualityComparer<T>.Default.Equals(field, value))
         {
            return false;
         }

         field = value;
         OnPropertyChanged(propertyName);

         return true;
      }

      protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
      {
         PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
      }
   }
}

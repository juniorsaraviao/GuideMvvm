using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace GuideMvvm.ViewModel
{
   public class PatternViewModel : BaseViewModel
   {
      string text;

      public ICommand AsyncProcessCommand { get; }
      public ICommand SimpleProcessCommand { get; }

      public PatternViewModel(INavigation navigation)
      {
         Navigation = navigation;
         AsyncProcessCommand = new Command(async () => await AsyncProcess());
         SimpleProcessCommand = new Command(SimpleProcess);
      }

      public string Text
      {
         get => text;
         set => SetProperty(ref text, value);
      }

      public async Task AsyncProcess()
      {

      }

      void SimpleProcess()
      {

      }
   }
}

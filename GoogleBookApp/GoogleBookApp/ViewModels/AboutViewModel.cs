using System.Windows.Input;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace GoogleBookApp.ViewModels
{
    /// <summary>
    /// About Page, show version information of this Assambly project.
    /// </summary>
    public class AboutViewModel : BaseViewModel
    {
        public AboutViewModel()
        {
            Title = "About";
            OpenWebCommand = new Command(async () => await Browser.OpenAsync("https://xamarin.com"));
        }

        public ICommand OpenWebCommand { get; }
    }
}
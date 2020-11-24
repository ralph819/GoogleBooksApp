using GoogleBookApp.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GoogleBookApp.Pages.BookPages;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace GoogleBookApp.Pages.BookPages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SearchBookPage : ContentPage
    {
        private SearchViewModel viewModel;
        public SearchBookPage()
        {
            InitializeComponent();
            BindingContext = viewModel = new SearchViewModel();
        }

        async void Search_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new NavigationPage(new BooksPage(viewModel.Query)));
        }
    }
}
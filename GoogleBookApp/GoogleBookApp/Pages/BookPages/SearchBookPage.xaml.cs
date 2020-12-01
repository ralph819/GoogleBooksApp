using GoogleBookApp.ViewModels;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using System.ComponentModel;
using Xamarin.Essentials;

namespace GoogleBookApp.Pages.BookPages
{
    /// <summary>
    /// Search Book Page, to type the query you want to use to search books.
    /// </summary>
    [DesignTimeVisible(false)]
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SearchBookPage : ContentPage
    {
        private SearchViewModel viewModel;
        public SearchBookPage()
        {
            InitializeComponent();
            BindingContext = viewModel = new SearchViewModel();
        }

        /// <summary>
        /// Search Button Clicked Event to send the user to Search Books Result Page.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        async void Search_Clicked(object sender, EventArgs e)
        {
            var current = Connectivity.NetworkAccess;
            if (current == NetworkAccess.Internet)
            {
                if (!string.IsNullOrEmpty(viewModel.Query))
                {
                    await Navigation.PushModalAsync(new NavigationPage(new BooksPage(viewModel.Query)));
                    //Clear Query Search Text on Go Back
                    viewModel.Query = string.Empty;
                }
                else
                {
                    await this.DisplayAlert("Required Field", "Write a Work to start serach.", "Ok");
                }
            }
            else
            {
                await this.DisplayAlert("Internet Connection Error", "You required Internet Conectivity to use this Functionality.", "Ok");
            }
        }

        private void Entry_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            this.SearchButton.IsEnabled = !string.IsNullOrEmpty(this.QueryText.Text);
        }
    }
}
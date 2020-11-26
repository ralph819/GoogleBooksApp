using System;
using System.ComponentModel;
using System.Linq;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using GoogleBookApp.Models;
using GoogleBookApp.ViewModels;

namespace GoogleBookApp.Pages.BookPages
{
    /// <summary>
    /// Page to view the Result for books on a List with Infinity Scroll
    /// </summary>
    [DesignTimeVisible(false)]
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class BooksPage : ContentPage
    {
        BooksViewModel viewModel;

        public BooksPage(string query)
        {
            InitializeComponent();

            BindingContext = viewModel = new BooksViewModel(query);
        }

        /// <summary>
        /// Go Back button to Popout the Modal.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        async void GoBack_Clicked(object sender, EventArgs e)
        {
            await this.Navigation.PopModalAsync();
        }

        /// <summary>
        /// On ITem Selected Event to load the book detail page.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        async void OnItemSelected(object sender, EventArgs args)
        {
            var layout = (BindableObject)sender;
            var item = layout.BindingContext as Book;
            await Navigation.PushAsync(new BookDetailPage(item));
            this.ItemsCollectionView.SelectedItem = null;
        }
                
        protected override void OnAppearing()
        {
            base.OnAppearing();

            if (!viewModel.Books.Any())
                viewModel.IsBusy = true;
        }
    }
}
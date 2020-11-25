using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using GoogleBookApp.Models;
using GoogleBookApp.Pages;
using GoogleBookApp.ViewModels;

namespace GoogleBookApp.Pages.BookPages
{
    [DesignTimeVisible(false)]
    public partial class BooksPage : ContentPage
    {
        BooksViewModel viewModel;

        public BooksPage(string query)
        {
            InitializeComponent();

            BindingContext = viewModel = new BooksViewModel(query);
        }

        async void GoBack_Clicked(object sender, EventArgs e)
        {
            await this.Navigation.PopModalAsync();
        }

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

            if (!viewModel.Items.Any())
                viewModel.IsBusy = true;
        }
    }
}
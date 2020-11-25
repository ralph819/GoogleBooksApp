using System;
using System.ComponentModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using GoogleBookApp.Models;
using GoogleBookApp.ViewModels;
using Xamarin.Essentials;

namespace GoogleBookApp.Pages.BookPages
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class BookDetailPage : ContentPage
    {
        BookDetailViewModel viewModel;

        public BookDetailPage(Book book)
        {
            InitializeComponent();

            BindingContext = viewModel = new BookDetailViewModel(book);
        }

        async void GoBack_Clicked(object sender, EventArgs e)
        {
            await this.Navigation.PopToRootAsync();
        }

        async void SelfLink_Clicked(object sender, EventArgs e)
        {
            //WebReaderLink is not working for some books
            await Browser.OpenAsync(new Uri(viewModel.Item.AccessInfo.WebReaderLink), BrowserLaunchMode.SystemPreferred);
        }
    }
}
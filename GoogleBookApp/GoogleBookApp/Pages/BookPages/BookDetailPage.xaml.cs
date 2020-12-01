using System;
using System.ComponentModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using GoogleBookApp.Models;
using GoogleBookApp.ViewModels;
using Xamarin.Essentials;
using GoogleBookApp.Components;

namespace GoogleBookApp.Pages.BookPages
{
    [DesignTimeVisible(false)]
    [XamlCompilation(XamlCompilationOptions.Compile)]
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
            //WebReaderLink is not working for some books.
            //Remove WebViewer Component do to Google Book Url fail to load on WebView.
            await Browser.OpenAsync(new Uri(viewModel.Book.AccessInformation.WebReaderLink), BrowserLaunchMode.SystemPreferred);
            //await Navigation.PushAsync(new WebViewer(viewModel.Item.VolumeInfo.Title, viewModel.Item.AccessInformation.WebReaderLink));
        }
    }
}
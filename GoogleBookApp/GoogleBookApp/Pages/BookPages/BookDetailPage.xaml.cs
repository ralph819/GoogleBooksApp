using System;
using System.ComponentModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using GoogleBookApp.Models;
using GoogleBookApp.ViewModels;

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
    }
}
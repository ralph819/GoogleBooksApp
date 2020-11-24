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
            //viewModel.ExecuteLoadBooks();
        }

        async void OnItemSelected(object sender, EventArgs args)
        {
            var layout = (BindableObject)sender;
            var item = (Book)layout.BindingContext;
            await Navigation.PushAsync(new BookDetailPage(item));
        }

        void OnScrollViewScrolled(object sender, ItemsViewScrolledEventArgs e)
        {
            Console.WriteLine($"HorizontalDelta: {e.HorizontalDelta}");
            Console.WriteLine($"HorizontalDelta: {e.VerticalDelta}");
            Console.WriteLine($"HorizontalDelta: {e.HorizontalOffset}");
            Console.WriteLine($"HorizontalDelta: {e.VerticalOffset}");
            Console.WriteLine($"HorizontalDelta: {e.FirstVisibleItemIndex}");
            Console.WriteLine($"HorizontalDelta: {e.CenterItemIndex}");
            Console.WriteLine($"HorizontalDelta: {e.LastVisibleItemIndex}");
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            //Task.Run(viewModel.RefreshBooks);

            if (viewModel.Items.Count == 0)
                viewModel.IsBusy = true;
        }
    }
}
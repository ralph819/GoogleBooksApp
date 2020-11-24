using System;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Threading.Tasks;

using Xamarin.Forms;

using GoogleBookApp.Models;
using GoogleBookApp.Pages;

namespace GoogleBookApp.ViewModels
{
    public class BooksViewModel : BaseViewModel
    {
        public ObservableCollection<Book> Items { get; set; }
        public Command RefreshBooksCommand { get; set; }
        public Command LazyLoadCommand { get; set; }

        public string Query { get; set; }
        public int PageIndex { get; set; } = 0;
        public int PageSize { get; set; } = 10;

        public BooksViewModel(string query)
        {
            Title = "Books";
            Query = query;
            Items = new ObservableCollection<Book>();
            RefreshBooksCommand = new Command(async () => await RefreshBooks());
            LazyLoadCommand = new Command(async () => await LazyLoadBooks());
        }

        public async Task RefreshBooks()
        {
            IsBusy = true;

            try
            {
                if (PageIndex == 0)
                    Items.Clear();
                var response = await DataStore.GetBooksByNameAsync(Query, PageIndex, PageSize);
                foreach (var item in response.Items)
                {
                    Items.Add(item);
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
            }
            finally
            {
                IsBusy = false;
            }
        }

        private async Task LazyLoadBooks()
        {
            PageIndex++;
            await RefreshBooks();
        }
    }
}
using System;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Threading.Tasks;

using Xamarin.Forms;

using GoogleBookApp.Models;
using GoogleBookApp.Pages;
using Refit;
using GoogleBookApp.Services;
using Xamarin.Essentials;
using System.Linq;

namespace GoogleBookApp.ViewModels
{
    public class BooksViewModel : BaseViewModel
    {
        public IBookService DataStore { get; set; }
        public ObservableCollection<Book> Items { get; set; }
        public Command RefreshBooksCommand { get; set; }
        public Command LazyLoadCommand { get; set; }
        public string Query { get; set; }
        public int PageIndex { get; set; } = 0;
        public int PageSize { get; set; } = 20;
        public int TotalItems { get; set; }

        private bool _isLoadingMore;
        public bool IsLoadingMore
        {
            get { return _isLoadingMore; }
            set { SetProperty(ref _isLoadingMore, value); }
        }

        private int _itemTreshold;
        public int ItemTreshold
        {
            get { return _itemTreshold; }
            set { SetProperty(ref _itemTreshold, value); }
        }

        public BooksViewModel(string query)
        {
            Title = "Book Result For: " + query;
            Query = query;
            ItemTreshold = 1;
            Items = new ObservableCollection<Book>();
            DataStore = RestService.For<IBookService>(Preferences.Get("GoogleUrl", "https://www.googleapis.com"));
            RefreshBooksCommand = new Command(async () => await RefreshBooks());
            LazyLoadCommand = new Command(async () => await LazyLoadBooks());
        }

        private async Task LoadBooks()
        {
            var response = await DataStore.GetBooksByNameAsync(Query, PageIndex, PageSize);
            TotalItems = response.TotalItems;
            //Load all items
            foreach (var item in response.Items)
                Items.Add(item);
            
            //Mark ans no more Items to load.
            if (!response.Items.Any())
                ItemTreshold = -1;
        }

        public async Task RefreshBooks()
        {
            try
            {
                IsBusy = true;
                PageIndex = 0;
                Items.Clear();
                await LoadBooks();
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

        public async Task LazyLoadBooks()
        {
            try
            {
                IsLoadingMore = true;
                PageIndex++;
                //Load 10 items on LazyLoadBooks
                PageSize = 10;
                await LoadBooks();
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
            }
            finally
            {
                IsLoadingMore = false;
            }
        }
    }
}
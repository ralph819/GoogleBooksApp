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
        /// <summary>
        /// BookService to query information to Google Books Service.
        /// </summary>
        public IBookService BookService { get; set; }
        /// <summary>
        /// List of book show on BooksPage.
        /// </summary>
        public ObservableCollection<Book> Items { get; set; }
        /// <summary>
        /// Command used to load the first 20 book result of the Query searched.
        /// </summary>
        public Command RefreshBooksCommand { get; set; }
        /// <summary>
        /// Command used to load 10 more results on page based on Query searched.
        /// </summary>
        public Command LazyLoadCommand { get; set; }
        /// <summary>
        /// Text for Search of Books on Google Books ApI.
        /// </summary>
        public string Query { get; set; }
        /// <summary>
        /// Index of the page to get from Google Books Api.
        /// Default Value 0.
        /// </summary>
        public int PageIndex { get; set; } = 0;
        /// <summary>
        /// Count of Books to get from Google Books Api.
        /// Default and Initial Value 20.
        /// </summary>
        public int PageSize { get; set; } = 20;
        /// <summary>
        /// Total of Book for Query Request from Google Books Api.
        /// </summary>
        public int TotalItems { get; set; }

        private bool _isLoadingMore;
        /// <summary>
        /// Indicate if the page is loading more books.
        /// </summary>
        public bool IsLoadingMore
        {
            get { return _isLoadingMore; }
            set { SetProperty(ref _isLoadingMore, value); }
        }

        private int _itemTreshold;
        /// <summary>
        /// Indicated the scroll index current value. -1 if no more value can be load.
        /// </summary>
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
            BookService = RestService.For<IBookService>(Preferences.Get("GoogleUrl", "https://www.googleapis.com"));
            RefreshBooksCommand = new Command(async () => await RefreshBooks());
            LazyLoadCommand = new Command(async () => await LazyLoadBooks());
        }

        /// <summary>
        /// Load Books from Google Books Api, base on Query, PageIndex and PageSize.
        /// </summary>
        /// <returns></returns>
        private async Task LoadBooks()
        {
            var response = await BookService.GetBooksByNameAsync(Query, PageIndex, PageSize);
            TotalItems = response.TotalItems;
            //Load all items
            foreach (var item in response.Items)
                Items.Add(item);
            
            //Mark ans no more Items to load.
            if (!response.Items.Any())
                ItemTreshold = -1;
        }

        /// <summary>
        /// Load the first 20 result set of Google Books.
        /// </summary>
        /// <returns></returns>
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

        /// <summary>
        /// Load 10 more items from Google Books.
        /// </summary>
        /// <returns></returns>
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
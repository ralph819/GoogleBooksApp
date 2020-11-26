
namespace GoogleBookApp.ViewModels
{
    public class SearchViewModel: BaseViewModel
    {
        private string _query;
        /// <summary>
        /// Query Param to Search on Books
        /// </summary>
        public string Query
        {
            get { return _query; }
            set { SetProperty(ref _query, value); }
        }

        public SearchViewModel()
        {
            Title = "Search Books";
        }
    }
}

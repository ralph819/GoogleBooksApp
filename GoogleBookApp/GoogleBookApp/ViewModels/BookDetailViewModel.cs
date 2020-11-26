using GoogleBookApp.Models;

namespace GoogleBookApp.ViewModels
{
    /// <summary>
    /// Book Detail View Model
    /// </summary>
    public class BookDetailViewModel : BaseViewModel
    {
        /// <summary>
        /// Current Book Item to show on Detail View Page.
        /// </summary>
        public Book Book { get; set; }
        public BookDetailViewModel(Book book = null)
        {
            Title = book?.VolumeInformation?.Title ?? "Unknown Title";
            Book = book;
        }
    }
}

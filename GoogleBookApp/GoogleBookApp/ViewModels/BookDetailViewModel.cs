using System;

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
        public Book Item { get; set; }
        public BookDetailViewModel(Book item = null)
        {
            Title = item?.VolumeInfo.Title;
            Item = item;
        }
    }
}

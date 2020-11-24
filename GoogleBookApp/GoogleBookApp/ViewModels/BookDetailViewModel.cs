using System;

using GoogleBookApp.Models;

namespace GoogleBookApp.ViewModels
{
    public class BookDetailViewModel : BaseViewModel
    {
        public Book Item { get; set; }
        public BookDetailViewModel(Book item = null)
        {
            Title = item?.VolumeInfo.Title;
            Item = item;
        }
    }
}

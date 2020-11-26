using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;

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

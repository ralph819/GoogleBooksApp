using GoogleBookApp.Models;
using Refit;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace GoogleBookApp.Services
{
    public interface IBookService
    {
        [Get("/books/v1/volumes?q={name}")]
        Task<BookResponse> GetBooksByNameAsync(string name);
        
        [Get("/books/v1/volumes?q={name}&startIndex={page}&maxResults={pageCount}")]
        Task<BookResponse> GetBooksByNameAsync(string name, int page = 0, int pageCount = 10);
    }
}

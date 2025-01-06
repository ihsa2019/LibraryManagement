using System;
using LibraryManagement.Dtos.Books;
using LibraryManagement.Interfaces;
using LibraryManagement.Models;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace LibraryManagement.Services;

public class BookAppService : CrudAppService<
    Book,
    BookDto,
    Guid,
    PagedAndSortedResultRequestDto,
    CreateBookDto,
    UpdateBookDto>, IBookAppService
{
    public BookAppService(IRepository<Book, Guid> repository) : base(repository)
    {
        
    }
}
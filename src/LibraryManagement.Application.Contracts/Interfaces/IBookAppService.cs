using System;
using LibraryManagement.Dtos.Books;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace LibraryManagement.Interfaces;

public interface IBookAppService : ICrudAppService<
    BookDto,
    Guid,
    PagedAndSortedResultRequestDto,
    CreateBookDto,
    UpdateBookDto>
{
    
}
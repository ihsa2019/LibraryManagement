using AutoMapper;
using LibraryManagement.Dtos.Books;

namespace LibraryManagement.Web;

public class LibraryManagementWebAutoMapperProfile : Profile
{
    public LibraryManagementWebAutoMapperProfile()
    {
        //Define your AutoMapper configuration here for the Web project.
        CreateMap<BookDto, CreateBookDto>();
        CreateMap<BookDto, UpdateBookDto>();
    }
}

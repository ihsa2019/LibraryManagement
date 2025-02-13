﻿using AutoMapper;
using LibraryManagement.Dtos.Books;
using LibraryManagement.Models;

namespace LibraryManagement;

public class LibraryManagementApplicationAutoMapperProfile : Profile
{
    public LibraryManagementApplicationAutoMapperProfile()
    {
        /* You can configure your AutoMapper mapping configuration here.
         * Alternatively, you can split your mapping configurations
         * into multiple profile classes for a better organization. */
        CreateMap<Book, BookDto>();
        CreateMap<CreateBookDto, Book>();
        CreateMap<UpdateBookDto, Book>();
    }
}

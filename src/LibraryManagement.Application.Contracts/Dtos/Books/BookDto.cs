using System;
using System.Collections.Generic;
using LibraryManagement.Enums;
using Volo.Abp.Application.Dtos;

namespace LibraryManagement.Dtos.Books;

public class BookDto : AuditedEntityDto<Guid>
{
    public string ISBN { get; set; }
    public string Title { get; set; }
    public string Author { get; set; }
    public string Publisher { get; set; }
    public DateTime PublicationDate { get; set; }
    public int PageCount { get; set; }
    public BookGenre Genre { get; set; }
    public BookFormat Format { get; set; }
    public BookStatus Status { get; set; }
    public string Language { get; set; }
    public string Description { get; set; }
    public decimal Price { get; set; }
    public int CopiesAvailable { get; set; }
    public string Location { get; set; }
    public List<string> Tags { get; set; }
    public DateTime DateAdded { get; set; }
    public DateTime? LastBorrowedDate { get; set; }
}
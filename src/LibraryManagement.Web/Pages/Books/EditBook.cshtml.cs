using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using LibraryManagement.Dtos.Books;
using LibraryManagement.Interfaces;

namespace LibraryManagement.Web.Pages.Books;

public class EditBookModalModel : LibraryManagementPageModel
{
    [HiddenInput]
    [BindProperty(SupportsGet = true)]
    public Guid Id { get; set; }
    
    [BindProperty]
    public UpdateBookDto Book { get; set; }
    
    private readonly IBookAppService _bookAppService;

    public EditBookModalModel(IBookAppService bookAppService)
    {
        _bookAppService = bookAppService;
    }
    
    public async Task OnGetAsync()
    {
        var bookDto = await _bookAppService.GetAsync(Id);
        Book = ObjectMapper.Map<BookDto, UpdateBookDto>(bookDto);
    }
}
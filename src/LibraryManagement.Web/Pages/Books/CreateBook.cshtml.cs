using System.Threading.Tasks;
using LibraryManagement.Dtos.Books;
using LibraryManagement.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace LibraryManagement.Web.Pages.Books;

public class CreateBookModalModel : LibraryManagementPageModel
{
    [BindProperty]
    public CreateBookDto Book { get; set; }
    
    private readonly IBookAppService _bookAppService;

    public CreateBookModalModel(IBookAppService bookAppService)
    {
        _bookAppService = bookAppService;
    }
    
    public void OnGet()
    {
        Book = new CreateBookDto();
    }

    public async Task<IActionResult> OnPostAsync()
    {
        await _bookAppService.CreateAsync(Book);
        return NoContent();
    }
}
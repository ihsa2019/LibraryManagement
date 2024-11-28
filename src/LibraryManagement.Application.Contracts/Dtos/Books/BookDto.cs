using LibraryManagement.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;

namespace LibraryManagement.Dtos.Books
{
    public class BookDto : EntityDto<Guid>
    {
        public string Title { get; set; } // Book title
        public string Author { get; set; } // Author name
        public string? Description { get; set; } // Book Description
        public string ISBN { get; set; } // ISBN number
        public int PublishedYear { get; set; } // Year of publication
        public string Publisher { get; set; } // Publisher name
        public BookCategory Category { get; set; } // Enum for book categories
        public BookStatus Status { get; set; } // Enum for book availability
        public DateTime? BorrowedDate { get; set; } // Nullable for borrow date
        public DateTime? DueDate { get; set; } // Nullable for due date
    }
}

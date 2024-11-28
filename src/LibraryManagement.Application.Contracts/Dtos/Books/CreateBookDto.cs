using LibraryManagement.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement.Dtos.Books
{
    public class CreateBookDto
    {
        [Required]
        [StringLength(30)]
        public string Title { get; set; } // Book title

        [Required]
        [StringLength(100)]
        public string Author { get; set; } // Author name

        [StringLength(1000)]
        public string? Description { get; set; } // Book Description

        [Required]
        [StringLength(13)]
        public string ISBN { get; set; } // ISBN number

        [Required]
        public int PublishedYear { get; set; } // Year of publication

        [Required]
        [StringLength(20)]
        public string Publisher { get; set; } // Publisher name

        [Required]
        public BookCategory Category { get; set; } // Enum for book categories

        [Required]
        public BookStatus Status { get; set; } // Enum for book availability

        [DataType(DataType.Date)]
        public DateTime? BorrowedDate { get; set; } // Nullable for borrow date

        [DataType(DataType.Date)]
        public DateTime? DueDate { get; set; } // Nullable for due date
    }
}

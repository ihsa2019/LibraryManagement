using LibraryManagement.Enums;
using LibraryManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Data;
using Volo.Abp.DependencyInjection;
using Volo.Abp.Domain.Repositories;

namespace LibraryManagement
{
    public class LibraryManagementDataSeederContributor : IDataSeedContributor, ITransientDependency
    {
        private readonly IRepository<Book, Guid> _bookRepository;

        public LibraryManagementDataSeederContributor(IRepository<Book, Guid> bookRepository) 
        { 
            _bookRepository = bookRepository; 
        }

        public async Task SeedAsync(DataSeedContext context)
        {
            if (await _bookRepository.CountAsync() <= 0)
            {
                await _bookRepository.InsertAsync(
                    new Book
                    {
                        Title = "Sapiens: A Brief History of Humankind",
                        Author = "Yuval Noah Harari",
                        Description = "What makes us brilliant? What makes us deadly? What makes us Sapiens? One of the world's preeminent historians and thinkers, Yuval Noah Harari challenges everything we know about being human. Earth is 4.5 billion years old. In just a fraction of that time, one species among countless others has conquered it: us. In this bold and provocative book, Yuval Noah Harari explores who we are, how we got here and where we're going.",
                        ISBN = "978-0099590088",
                        PublishedYear = 2011,
                        Publisher = "Vintage",
                        Category = BookCategory.NonFiction,
                        Status = BookStatus.Borrowed,
                        BorrowedDate = DateTime.Now,
                        DueDate = new DateTime(2024, 12, 11)
                    }, autoSave: true);
            }
        }
    }
}

using Volo.Abp.Data;
using Volo.Abp.MongoDB;
using MongoDB.Driver;
using LibraryManagement.Models;

namespace LibraryManagement.MongoDB;

[ConnectionStringName("Default")]
public class LibraryManagementMongoDbContext : AbpMongoDbContext
{
    /* Add mongo collections here. Example:
     * public IMongoCollection<Question> Questions => Collection<Question>();
     */
    public IMongoCollection<Book> Books => Collection<Book>();

    protected override void CreateModel(IMongoModelBuilder modelBuilder)
    {
        base.CreateModel(modelBuilder);

        //modelBuilder.Entity<YourEntity>(b =>
        //{
        //    //...
        //});
    }
}

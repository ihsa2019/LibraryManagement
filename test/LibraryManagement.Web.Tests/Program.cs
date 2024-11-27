using Microsoft.AspNetCore.Builder;
using LibraryManagement;
using Volo.Abp.AspNetCore.TestBase;

var builder = WebApplication.CreateBuilder();

builder.Environment.ContentRootPath = GetWebProjectContentRootPathHelper.Get("LibraryManagement.Web.csproj");
await builder.RunAbpModuleAsync<LibraryManagementWebTestModule>(applicationName: "LibraryManagement.Web" );

public partial class Program
{
}

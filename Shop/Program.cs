using Shop.Models;
using Shop.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddSingleton<IItemService, ItemService>();
builder.Services.AddSingleton<ICustomerRepository,CustomerRepository>();
builder.Services.AddSingleton<IRepositoryService<Admin>>();
builder.Services.AddSingleton<IRepositoryService<Customer>>();
builder.Services.AddSingleton<IRepositoryService<Employee>>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
	app.UseExceptionHandler("/Error");
}
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();

app.Run();



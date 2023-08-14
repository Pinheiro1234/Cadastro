using Cadastro.Data;
using Cadastro.Repositorio;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

var provider = builder.Services.BuildServiceProvider();
var Configuration = provider.GetService<IConfiguration>();
builder.Services.AddDbContext<BancoContex>(item => item.UseSqlServer(Configuration.GetConnectionString("Database")));
builder.Services.AddScoped<IClientesRepositorio, ClientesRepositorio>();
var app = builder.Build();


// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();

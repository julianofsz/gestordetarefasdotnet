using Microsoft.EntityFrameworkCore;
using GestorDeTarefas.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

//Chamando a configura��o do BD
builder.Services.AddDbContext<TarefaContexto>(options =>
    options.UseMySql(
        builder.Configuration.GetConnectionString("MySqlConnection"),
        new MySqlServerVersion(new Version(8, 0, 40)) // ajuste a vers�o para a vers�o do seu MySQL
    ));

var app = builder.Build();

using (var scope = app.Services.CreateScope())
{
    var dbContext = scope.ServiceProvider.GetRequiredService<TarefaContexto>();
    dbContext.Database.EnsureCreated(); // Cria o banco de dados se n�o existir
}

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
    pattern: "{controller=Tarefas}/{action=Index}/{id?}");

app.Run();

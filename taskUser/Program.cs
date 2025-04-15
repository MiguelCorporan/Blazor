/*using Blazored.SessionStorage;
using Microsoft.EntityFrameworkCore;
using taskUser.Components;
using taskUser.DBModels;
using taskUser.PanelServices;*/

using Blazored.SessionStorage;
using Microsoft.EntityFrameworkCore;
using taskUser.Data;        // NUEVO: Aquí está tu DbContext

using taskUser.Components;
using taskUser.PanelServices;
using taskUser.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();

builder.Services.AddDbContext<TareasAppContext>(
    option => option.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

builder.Services.AddScoped<AdminPanelServices>();
builder.Services.AddScoped<TaskService>();

builder.Services.AddBlazoredSessionStorage();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();


app.UseAntiforgery();

app.MapStaticAssets();
app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

app.Run();

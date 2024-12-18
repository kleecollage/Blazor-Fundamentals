using Fundamentals.Components;
using Fundamentals.Repository;
using Fundamentals.Repository.Interfaces;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();

// DEPENDENCY INJECTION
/* Singleton: Requiere que el estado persista y sea único en toda la aplicación.
   Scoped: Útil cuando el servicio es relevante solo dentro del contexto de una solicitud.
   Transient: Adecuado para servicios sin estado o que necesitan siempre una nueva instancia. */
builder.Services.AddSingleton<IMyService, MyService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();
app.UseAntiforgery();

app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

app.Run();
using Microsoft.EntityFrameworkCore;
using Soroush_Sarram_WebServer2_Midtrem.Data;

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddRazorPages();


builder.Services.AddDbContext<ApplicationDbContext>((options => options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"))));

var app = builder.Build();


if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();

app.Run();

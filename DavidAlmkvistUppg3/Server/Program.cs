using DavidAlmkvistUppg3.Server.DataAccess;
using DavidAlmkvistUppg3.Shared;
using Microsoft.AspNetCore.ResponseCompression;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddRazorPages();
builder.Services.AddDbContext<CompanyContext>(options => 
{
	var connectionString = builder.Configuration.GetConnectionString("CompanyDb1");
	options.UseSqlServer(connectionString);
});

builder.Services.AddScoped<CompanyRepository>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
	app.UseWebAssemblyDebugging();
}
else
{
	app.UseExceptionHandler("/Error");
	// The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
	app.UseHsts();
}

app.UseHttpsRedirection();

app.UseBlazorFrameworkFiles();
app.UseStaticFiles();

app.UseRouting();


app.MapRazorPages();
app.MapFallbackToFile("index.html");

app.MapGet("/all", (CompanyRepository repo) =>
{
	return Results.Ok(repo.GetAll());
});

app.MapPost("/add", (CompanyRepository repo, Company company) =>
{
	repo.Add(company);
	return Results.Ok("Company Added.");
});

app.Run();

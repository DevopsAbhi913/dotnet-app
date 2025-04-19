var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

// Enable serving static files 
app.UseDefaultFiles(); // Looks for index.html
app.UseStaticFiles(); // Serves CSS, JS, images, etc.

app.Run();

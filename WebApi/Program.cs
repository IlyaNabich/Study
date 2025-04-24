using DataAccess;
using BusinessLogic;
var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDataAccess();
builder.Services.AddBusinessLogic();
builder.Services.AddControllers();
builder.Services.AddSwaggerGen();
var app = builder.Build();

app.MapGet("/", context =>
{
    context.Response.Redirect("/swagger");
    return Task.CompletedTask;
});
app.MapControllers();
app.UseSwagger();
app.UseSwaggerUI();
app.Run();
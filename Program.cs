using api_learning_project.Service;

var builder = WebApplication.CreateBuilder(args);


// Add services to the container.

builder.Services.AddSingleton<ISongService, SongService>(); //Should be Singleton, instead of Scoped
builder.Services.AddScoped<IUserService, UserService>(); //30 Minutes didnt know why it was not accepting it, untill i saw that in User Service it should be like that: public class UserService : IUserService

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();

app.MapControllers();

app.Run();

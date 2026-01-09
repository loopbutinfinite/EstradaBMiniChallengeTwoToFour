using EstradaBMiniChallenge_2.Controllers;
using EstradaBMiniChallenge_2.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();
builder.Services.AddScoped<TwoNumbersStatementsServices>();
builder.Services.AddScoped<TwoInputQuestionsServices>();
builder.Services.AddScoped<TwoNumberSumServices>();
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();

var app = builder.Build();

app.MapControllers();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseHttpsRedirection();

app.Run();
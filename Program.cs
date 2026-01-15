using EstradaBMiniChallenge_2.Controllers;
using EstradaBMiniChallenge_2.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();
builder.Services.AddScoped<TwoNumbersStatementsServices>();
builder.Services.AddScoped<TwoInputQuestionsServices>();
builder.Services.AddScoped<TwoNumberSumServices>();
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
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

app.UseHttpsRedirection();

app.Run();
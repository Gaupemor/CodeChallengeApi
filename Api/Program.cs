var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Repositories
builder.Services.AddScoped<ChallengeApi.Repositories.ICustomerRepository, ChallengeApi.Repositories.CustomerRepository>();
builder.Services.AddScoped<ChallengeApi.Repositories.IAccountRepository, ChallengeApi.Repositories.AccountRepository>();
// Example data
builder.Services.AddScoped<ChallengeApi.Data.IExampleData, ChallengeApi.Data.ExampleData>(); 

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

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();

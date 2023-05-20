using universidades;
using universidades.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddSqlServer<UniversidadesContext>("Data Source=localhost; Initial Catalog=univeristyDB;user id=sa;password=Programaci0n$;Encrypt=False");
builder.Services.AddScoped<ICountryService, CountryService>();
builder.Services.AddScoped<IRankingCriteriaService, RankingCriteriaService>();
builder.Services.AddScoped<IRankingSystemService, RankingSystemService>();
builder.Services.AddScoped<IUniversityService, UniversityService>();
builder.Services.AddScoped<IUniversityRankingYearService, UniversityRankingYearService>();
builder.Services.AddScoped<IUniversityYearService, UniversityYearService>();

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

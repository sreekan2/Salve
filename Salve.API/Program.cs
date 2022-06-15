using Salve.DataAccess;
using Salve.DataAccess.Interfaces;
using Salve.Services;
using Salve.Services.Interfaces;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddTransient<IClinicService, ClinicService>();
builder.Services.AddTransient<IClinicRepository, ClinicRepository>();

builder.Services.AddTransient<IPatientService, PatientService>();
builder.Services.AddTransient<IPatientRepository, PatientRepository>();

builder.Services.AddCors();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseCors(x => x.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader());
app.UseAuthorization();

app.MapControllers();

app.Run();

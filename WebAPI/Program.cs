using Services;
using System.Text.Json.Serialization;

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddControllers()
    .AddJsonOptions(options =>
    {
        options.JsonSerializerOptions.Converters.Add(new JsonStringEnumConverter());
    });
builder.Services.AddScoped<PacienteService>();
builder.Services.AddScoped<ProfesionalService>();
builder.Services.AddScoped<EspecialidadesService>();
builder.Services.AddScoped<TurnoService>();
builder.Services.AddScoped<ConsultorioService>();
builder.Services.AddScoped<ObraSocialService>();
builder.Services.AddScoped<PlanObraSocialService>();
builder.Services.AddScoped<PracticaService>();


builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.MapControllers();

app.Run();

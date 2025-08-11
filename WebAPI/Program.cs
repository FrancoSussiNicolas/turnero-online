using Services;
using System.Text.Json.Serialization;

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddControllers()
    .AddJsonOptions(options =>
    {
        options.JsonSerializerOptions.Converters.Add(new JsonStringEnumConverter());
    });
builder.Services.AddSingleton<PacienteService>();
builder.Services.AddSingleton<ProfesionalService>();
builder.Services.AddSingleton<EspecialidadesService>();
builder.Services.AddSingleton<TurnoService>();
builder.Services.AddSingleton<ConsultorioService>();
builder.Services.AddSingleton<ObraSocialService>();
builder.Services.AddSingleton<PlanObraSocialService>();


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

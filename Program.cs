using Api.Cep.Integracao;
using Api.Cep.Integracao.Interfaces;
using Api.Cep.Integracao.Refit;
using Refit;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddScoped<IViaCepIntegracao, ViaCepIntegracao>();
builder.Services.AddScoped<IViaEstadosIntegracao, ViaEstadosIntegracao>();


builder.Services.AddRefitClient<IViaCepIntegracaoRefit>().ConfigureHttpClient(c =>
{
    c.BaseAddress = new Uri("https://viacep.com.br");
   
});

builder.Services.AddRefitClient<IViaEstadosIntegracaoRefit>().ConfigureHttpClient(c =>
{
    c.BaseAddress = new Uri("http://servicodados.ibge.gov.br");
});



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

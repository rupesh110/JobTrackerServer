using Serilog;
using JobTrackerServer.Infrastructure;
using JobTrackerServer.Application;
using Azure.Identity;
using Azure.Extensions.AspNetCore.Configuration.Secrets;

var builder = WebApplication.CreateBuilder(args);

// 1️⃣ Load Key Vault first (KeyVaultUrl must come from appsettings/env)
var keyVaultUrl = new Uri(builder.Configuration["KeyVaultUrl"]!);
builder.Configuration.AddAzureKeyVault(keyVaultUrl, new DefaultAzureCredential());

// 2️⃣ Serilog config
builder.Configuration.AddJsonFile("serilog.json", optional: false, reloadOnChange: true);
Log.Logger = new LoggerConfiguration()
    .ReadFrom.Configuration(builder.Configuration)
    .Enrich.FromLogContext()
    .WriteTo.Console()
    .CreateLogger();

builder.Host.UseSerilog();
builder.Services.AddControllers();

// 3️⃣ Read secret "DefaultConnection" from Key Vault and map it into ConnectionStrings
var rawConnection = builder.Configuration["DefaultConnection"];
builder.Configuration["ConnectionStrings:DefaultConnection"] = rawConnection;

// 4️⃣ Use standard GetConnectionString API
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
Console.WriteLine("🚀 USING CONNECTION STRING:");
Console.WriteLine(connectionString);

builder.Services.AddInfrastructureServices(connectionString);
builder.Services.AddApplicationServices();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

app.UseSerilogRequestLogging();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.MapControllers();
app.MapGet("/", () => "Hello World! again");

app.Run();


public partial class Program { }
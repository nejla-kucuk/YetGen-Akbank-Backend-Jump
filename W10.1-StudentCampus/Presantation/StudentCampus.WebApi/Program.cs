using Microsoft.AspNetCore.Localization;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using StudentCampus.Persistence.Contexts; // DbContext'inizin bulunduðu namespace'i ekleyin
using StudentCampus.WebApi.Services;
using System.Globalization;

/*
var builder = WebApplication.CreateBuilder(args);

// DbContext ekleyin
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseNpgsql(builder.Configuration.GetConnectionString("StudentCampusDb-NejlaKucuk")));

// Add services to the container.
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// DbContext'i kullanýlabilir hale getirin
using (var scope = app.Services.CreateScope())
{
    var services = scope.ServiceProvider;
    var context = services.GetRequiredService<ApplicationDbContext>();
    
}

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
*/

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


builder.Services.AddScoped<FakeDataService>();

builder.Services.AddMemoryCache();


var textPath = builder.Configuration.GetSection("TextPath").Value;


builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowAll",
        builder => builder
            .AllowAnyMethod()
            .AllowCredentials()
            .SetIsOriginAllowed((host) => true)
            .AllowAnyHeader());
});

var connectionString = builder.Configuration.GetSection("StudentCampusDb-NejlaKucuk").Value;

builder.Services.AddDbContext<ApplicationDbContext>(options =>
{
    options.UseNpgsql(connectionString);
});

builder.Services.AddLocalization(options =>
{
    options.ResourcesPath = "Resources";
});

builder.Services.Configure<RequestLocalizationOptions>(options =>
{
    var trCulture = new CultureInfo("tr-TR");

    List<CultureInfo> cultureInfos = new()
    {
        trCulture,
        new("en-GB"),
    };

    options.SupportedCultures = cultureInfos;

    options.SupportedUICultures = cultureInfos;

    options.DefaultRequestCulture = new RequestCulture(trCulture);

    options.ApplyCurrentCultureToResponseHeaders = true;
});



var app = builder.Build();

app.UseCors("AllowAll");


var requestLocalizationOptions = app.Services.GetService<IOptions<RequestLocalizationOptions>>();

if (requestLocalizationOptions is not null) app.UseRequestLocalization(requestLocalizationOptions.Value);

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








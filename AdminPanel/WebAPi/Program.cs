using Application;
using Microsoft.Extensions.DependencyInjection;
using WebAPi;
using WebFramework.Configuration;

var builder = WebApplication.CreateBuilder(args);
var siteSetting = SiteConfiguration.GetAppSetting(builder.Configuration);
builder.Services.AddContext(builder.Configuration);
builder.Services.AddJwtAuthentication(siteSetting.JwtSettings);
builder.Services.AddControllers();
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

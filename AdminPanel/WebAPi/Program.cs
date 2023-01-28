using Application;
using Autofac.Core;
using AutoMapper;
using Autofac;
using Autofac.Extensions.DependencyInjection;

using Domain.Entities.User;
using InfraStructure.Contracts;
using InfraStructure.Repositories;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using Services.Interface;
using Services.Services;
using System.Xml.Linq;
using WebAPi;
using WebFramework;
using WebFramework.Configuration;

var builder = WebApplication.CreateBuilder(args);
var siteSetting = SiteConfiguration.GetAppSetting(builder.Configuration);
builder.Services.Configure<AppSetting>(builder.Configuration.GetSection(nameof(AppSetting)));/*for access appSetting in jwtService di*/
builder.Services.AddContext(builder.Configuration);
//builder.Services.AddAutorization();
builder.Services.AddJwtAuthentication(siteSetting.JwtSettings);
builder.Services.AddControllers();
//builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerConfig();
builder.Services.AddCustomIdentity(siteSetting.IdentitySettings);
builder.Services.RegisterAutoMapper();
builder.Host.UseServiceProviderFactory(new AutofacServiceProviderFactory());

//builder.Services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
//builder.Services.AddScoped<ICategoriesRepository, CategoriesRepository>();



builder.Host.ConfigureContainer<ContainerBuilder>(builder =>
{
    builder.RegisterGeneric(typeof(Repository<>)).As(typeof(IRepository<>)).InstancePerLifetimeScope();
    builder.AddApiServices();
});

var app = builder.Build();


// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
    app.UseSwagger();
    app.UseSwaggerUI();
}
app.UseHttpsRedirection();
//app.UseAuthentication();
//app.UseAuthorization();
app.MapControllers();
app.IntializeDatabase();
app.Run();

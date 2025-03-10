using AUA.SSO.DataLayer.Contexts;
using AUA.SSO.Services.Repositories;
using AUA.SSO.Services.Security.Cryptography;
using Duende.IdentityServer.Services;
using Duende.IdentityServer.Stores;
using System.IdentityModel.Tokens.Jwt;
using Duende.IdentityServer.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Net.Http.Headers;

var builder = WebApplication.CreateBuilder(args);

// https://localhost:7274/.well-known/openid-configuration


JwtSecurityTokenHandler.DefaultInboundClaimTypeMap.Clear();
JwtSecurityTokenHandler.DefaultOutboundClaimTypeMap.Clear();

builder.Services.AddScoped<IUserRepository, UserRepository>();
builder.Services.AddScoped<IUserConsentStore, UserRepository>();
builder.Services.AddScoped<IProfileService, CustomUserProfileService>();
builder.Services.AddScoped<IPasswordHasher, BcryptPasswordHasher>();


builder.Services.AddDbContext<ApplicationDbContext>(dbContextBuilder =>
{
    //builder.Configuration.GetConnectionString("SqlConnection")
    dbContextBuilder.UseSqlServer("Initial Catalog=IDPDb;Data Source=.;Integrated Security=True;TrustServerCertificate=True;Trusted_Connection=True;");
});

builder.Services.AddIdentityServer()
    .AddDeveloperSigningCredential()
    .AddClientStore<ClinetRipository>()
    .AddProfileService<CustomUserProfileService>()
    .AddInMemoryIdentityResources(new List<IdentityResource>
    {
        new IdentityResources.OpenId(),
        new IdentityResources.Address(),
        new IdentityResources.Email(),
        new IdentityResources.Profile(),
        new IdentityResources.Phone()

    });


// Add services to the container.
builder.Services.AddRazorPages();


builder.Services.AddCors(config =>
{
    config.AddPolicy("AllowOrigin", policyBuilder =>
    {
        policyBuilder
            .AllowAnyHeader()
            .AllowAnyOrigin()
            .AllowAnyMethod()
            .WithExposedHeaders(HeaderNames.ContentDisposition);
    });
});




var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseCors("AllowOrigin");

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();


app.UseIdentityServer();
app.UseAuthentication();
app.UseAuthorization();

app.MapRazorPages();

app.Run();

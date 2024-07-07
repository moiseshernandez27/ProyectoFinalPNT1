using Microsoft.EntityFrameworkCore;
using ProyectoFinalToDo.Data;
using ProyectoFinalToDo.Models;
using System;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using Microsoft.IdentityModel.Tokens;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

var builder = WebApplication.CreateBuilder(args);
string accessToken = "ghuDX7VAwQ9E0l1jnC6ms5kaqUiBvrMx"; // [WEP 256-bit Key] [https://keygen.io/]

// Add jwt authentication
builder.Services.AddAuthorization();
builder.Services.AddAuthentication("Bearer").AddJwtBearer(option =>
    {
        var singingKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(accessToken));
        var singingCredentials = new SigningCredentials(singingKey, SecurityAlgorithms.HmacSha256Signature);

        option.RequireHttpsMetadata = false; // only for development

        option.TokenValidationParameters = new TokenValidationParameters
        {
            ValidateAudience = false,
            ValidateIssuer = false,
            IssuerSigningKey = singingKey
        };
    }
);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<ToDoAppDbContext>(options => 
    options.UseSqlServer(builder.Configuration.GetConnectionString("ToDoConnectionString")));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthentication();
app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

//test jwt
app.MapGet("/", () => "Hello World!");
app.MapGet("/protected", () => "Hello World!").RequireAuthorization();
app.MapGet("/protectedData", (ClaimsPrincipal user) => user.Identity?.Name).RequireAuthorization();

app.MapGet("/auth/login/{user}/{pass}", (string user, string pass) =>
{
    if(user == "admin" && pass == "admin123")
    {
        var tokenHandler = new JwtSecurityTokenHandler();
        var byteKey = Encoding.UTF8.GetBytes(accessToken);
        var tokenDes = new SecurityTokenDescriptor
        {
            Subject = new ClaimsIdentity(new Claim[]
            {
                new Claim(ClaimTypes.Name, user)
            }),
            Expires = DateTime.UtcNow.AddMonths(1), // token expires in 1 month
            SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(byteKey), SecurityAlgorithms.HmacSha256Signature)
        };
        var token = tokenHandler.CreateToken(tokenDes);
        return tokenHandler.WriteToken(token);
    }
    else
    {
        return "Invalid user or password";
    }
});
//test
app.Run();

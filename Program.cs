using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;
using Microsoft.Extensions.Options;
using PlanejamentoWeb.models;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<TripDbContext>(Options =>
{
    var sql = Environment.GetEnvironmentVariable("SQL_CONNECTION");
    Options.UseSqlServer(sql);
});
var app = builder.Build();


// $env:SQL_CONNECTION = "Data Source=localhost;Initial Catalog=TripWeb;Trust Server Certificate=true;Integrated Security=true"


app.Run();

using Microsoft.EntityFrameworkCore;
using TuorBrasil_API.Context;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

/*CONEXAO COM O BANCO DE DADOS*/
/*SOMEE.COM*/
string SqlConnection = builder.Configuration.GetConnectionString("SQL_Somee_Database");

builder.Services.AddDbContext<DataContext>(options =>
options.UseSqlServer(SqlConnection));


/* MYSQL
           * string mySqlConnection = builder.Configuration.GetConnectionString("DefaultConnection");

                      builder.Services.AddDbContext<DataContext>(options =>
                                          options.UseMySql(mySqlConnection,
                                          ServerVersion.AutoDetect(mySqlConnection)));*/

/* SQL SERVER 
            * builder.Services.AddEntityFrameworkSqlServer()
               .AddDbContext<DataContext>(
                       options => options.UseSqlServer(builder.Configuration.GetConnectionString("SQL_DataBase"))
                   );*/

//cors
var MyAllowSpecificOrigins = "_nyAllowSpecificOrigins";

builder.Services.AddCors(options =>
{
    options.AddPolicy(name: MyAllowSpecificOrigins,
        Policy =>
        {
            Policy.WithOrigins("*")
            .AllowAnyMethod()
            .AllowAnyHeader();

        });
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseCors(MyAllowSpecificOrigins);

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
